using CoursWork;
using Process.cs;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CoursWork
{
    public class Model

    {
        public SystemClock clock;
        public IdGenerator IdGen;
        public Resource cpu;
        public Resource device;
        
        public PriorityQueue<Process, long> readyQueue;
        public Queue<Process> deviceQueue;
        public Memory ram;
        public CPUScheduler cpuscheduler;
        public DeviceScheduler devicescheduler;
        public MemoryManager memorymanager;
        public Random processRand;
        public Settings modelSettings;
        

        public Model()
        {
            clock = new SystemClock();
            IdGen = new IdGenerator();
            cpu = new Resource();
            device = new Resource();
            readyQueue = new PriorityQueue<Process, long>();
            deviceQueue = new Queue<Process>();
            ram = new Memory();
            cpuscheduler = new CPUScheduler(cpu, readyQueue);
            devicescheduler = new DeviceScheduler(device, deviceQueue);
            memorymanager = new MemoryManager();
            processRand = new Random();
            modelSettings = new Settings();
           

        }
        public PriorityQueue<Process, long> ReadyQueue
        {
            get
            {
                return readyQueue;
            }
            set => readyQueue = value;

        }
        public Queue<Process> DeviceQueue
        {
            get
            {
                return deviceQueue;
            }
        }
        public Resource Cpu
        {
            get { return cpu; }
        }
        public Resource Device
        {
            get { return device; }
        }
        public Memory Ram
        {
            get { return ram; }
        }
        public SystemClock Clock
        {
            get { return clock; }
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        public void SaveSettings()
        {
            ram.Save(modelSettings.ValueOfRAMSize);
            memorymanager.Save(ram);
        }

 
        public void WorkingCycle()
        {
            clock.WorkingCycle();
            cpuscheduler.Execute();
            cpuscheduler.Session();
            cpu.WorkingCycle();

            cpuscheduler.Session();
            devicescheduler.Session();
            if (processRand.NextDouble() < modelSettings.Intensity)
            {
                Process proc = new Process(IdGen.Id, processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1))
                {
                    BurstTime = processRand.Next(modelSettings.MinValueOfBurst, modelSettings.MaxValueOfBurst + 1),
                };

                if (memorymanager.Allocate(proc) != null)
                {
                    ReadyQueue.Enqueue(proc, proc.RemainingWorkTime()); // Добавляем процесс в очередь                    
                }
                
                Subscribe(proc);
                
            }
            
        }


        public void Clear()
        {
            cpu.Clear();
            device.Clear();
            ram.Clear();
            ReadyQueue.Clear();
            deviceQueue.Clear();
        }

       
        private void freeingResourceEventHandler(object obj, EventArgs e)
        {
            Process proc = obj as Process;
            if (proc == null)
                return;

            proc.ResetWorkTime();
            Unsubscribe(proc);

            switch (proc.Status)
            {
                case ProcessStatus.Ready:
                    if (device.ActiveProcess == proc)
                        device.Clear();
                    memorymanager.Free(proc);
                    if (cpu.ActiveProcess == proc)
                        memorymanager.Free(proc);


                    if (!ReadyQueue.UnorderedItems.Any(p => p.Element == proc))
                    {
                        ReadyQueue.Enqueue(proc, proc.RemainingWorkTime());
                    }


                    Subscribe(proc);
                    break;

                case ProcessStatus.Waiting:
                    if (cpu.ActiveProcess == proc)
                        memorymanager.Free(proc);
                    cpu.Clear();

                    if (!DeviceQueue.Contains(proc))
                    {
                        DeviceQueue.Enqueue(proc);
                    }
                    Subscribe(proc);
                    break;

                case ProcessStatus.Terminated:
                    if (cpu.ActiveProcess == proc)
                        memorymanager.Free(proc);
                    cpu.Clear();
                    break;


            }
        }


        private void Subscribe(Process proc)
        {
            proc.resourceFreeing += freeingResourceEventHandler;
        }
        private void Unsubscribe(Process proc)
        {
            proc.resourceFreeing -= freeingResourceEventHandler;
        }
        public void initSettings(double intensity, int burstMin, int burstMax, int addrSpaceMin, int addrSpaceMax, int ramSize)
        {
            modelSettings.Intensity = intensity;
            modelSettings.MinValueOfBurst = burstMin;
            modelSettings.MaxValueOfBurst = burstMax;
            modelSettings.MinValueOfAddrSpace = addrSpaceMin;
            modelSettings.MaxValueOfAddrSpace = addrSpaceMax;
            modelSettings.ValueOfRAMSize = ramSize;

            // Инициализация оперативной памяти
            ram.Save(ramSize);

          

        }

    }
}
