using System;
//using System.Buffers;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Queues;
using Structures;


    public class Model
{
    public Model()
    {
        public clock = new SystemClock();
        public cpu = new Resource();
        public device = new Resource();
        public ram = new Memory();
        public idGen = new IdGenerator();
        public readyQueue = new PriorityQueue<Process, long>();
        public deviceQueue = new Queue<Process>();
        public cpuScheduler = new CPUScheduler(cpu, readyQueue);
        public memoryManager = new MemoryManager();
        public deviceScheduler = new DeviceScheduler(device, deviceQueue);
        public processRand = new Random();
        public modelSettings = new Settings();
    }
    public void WorkingCycle()
    {
        clock.WorkingCycle();

        if (processRand.NextDouble() < modelSettings.Intensity)
        {
            Process proc = new Process(idGen.Id, processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));
            if (memoryManager.Allocate(proc) != null)
            {
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                readyQueue.Put(proc);
                if (cpu.IsFree())
                {
                    cpuScheduler.Session();
                    Subscribe(cpu.ActiveProcess);
                }
            }
        }
        cpu.WorkingCycle();
        device.WorkingCycle();
    }
    public void SaveSettings()
    {
        ram.Save(modelSettings.ValueOfRAMSize);
        memoryManager.Save(ram);
    }
    public void Clear()
    {
        clock.Clear();
        cpu.Clear();
        device.Clear();
        ram.Clear();
        readyQueue.Clear();
        deviceQueue.Clear();
    }

    public PriorityQueue<Process, long> ReadyQueue
    {
        get
        {
            return readyQueue;
        }
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

    
    private void freeingResourceEventHandler(object obj, EventArgs e)
    {
        Process proc = obj as Process;
        if (proc == null) // не обов'язково
            return;
        proc.ResetWorkTime();
        Unsubscribe(proc);
        switch (proc.Status)
        {
            case ProcessStatus.ready:      // звільнення зовнішнього пристрою
                device.ActiveProcess = null;
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                readyQueue.Enqueue(proc);
                if (cpu.IsFree())
                {
                    cpuScheduler.Session();
                    Subscribe(proc);
                }
                if (deviceQueue.Count != 0)
                {
                    deviceScheduler.Session();
                    Subscribe(device.ActiveProcess);
                }
                return;
            case ProcessStatus.waiting: // звільнення процесору
                cpu.ActiveProcess = null;
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                deviceQueue.Enqueue(proc);
                if (device.IsFree())
                {
                    deviceScheduler.Session();
                    Subscribe(proc);
                }
                if (readyQueue.Count != 0)
                {
                    cpuScheduler.Session();
                    Subscribe(cpu.ActiveProcess);
                }
                return;
            case ProcessStatus.terminated: // звільнення процесору
                cpu.ActiveProcess = null;
                memoryManager.Free(proc);
                if (readyQueue.Count != 0)
                {
                    cpuScheduler.Session();
                    Subscribe(cpu.ActiveProcess);
                }
                return;
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

    private SystemClock clock;
    private Resource cpu;
    private Resource device;
    private Memory ram;
    private IdGenerator idGen;
    private PriorityQueue<Process, long> readyQueue;
    private Queue<Process> deviceQueue;
    private CPUScheduler cpuScheduler;
    private MemoryManager memoryManager;
    private DeviceScheduler deviceScheduler;
    private Random processRand;
    private Settings modelSettings;

    // temporary
    public void initSettings()
    {
        modelSettings.Intensity = 0.5;
        modelSettings.ValueOfRAMSize = 4096;
        modelSettings.MinValueOfAddrSpace = 300;
        modelSettings.MaxValueOfAddrSpace = 700;
        modelSettings.MinValueOfBurstTime = 2;
        modelSettings.MaxValueOfBurstTime = 6;
    }
}