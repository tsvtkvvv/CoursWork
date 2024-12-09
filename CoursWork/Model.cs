


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
        }
        public PriorityQueue<Process, long> ReadyQueue
        {
            get
            {
                return readyQueue;
            }
            set => readyQueue = value;

        }
        public Queue<Process> DeviceQueue => deviceQueue;
        public Resource Cpu => cpu;
        public Resource Device => device;
        public Memory Ram => ram;
        public SystemClock Clock => clock;

        public void SaveSettings()
        {
            ram.Save(Settings.ValueOfRAMSize);
            memorymanager.Save(ram);
        }

        public void WorkingCycle()
        {
            clock.WorkingCycle();

            cpu.WorkingCycle();
            
            

            if (processRand.NextDouble() < Settings.Intensity)
            {
                CreateProcess();
                cpuscheduler.Execute();
            }

            devicescheduler.Session();
            cpuscheduler.Session();
            
        }

        void CreateProcess()
        {
            var proc = new Process(
                IdGen.Id,
                processRand.Next(Settings.MinValueOfAddrSpace, Settings.MaxValueOfAddrSpace + 1),
                processRand.Next(Settings.MinValueOfBurst, Settings.MaxValueOfBurst + 1));

            if (memorymanager.Allocate(proc) != null)
            {
                ReadyQueue.Enqueue(proc, proc.UpdateEstimatedTime(Settings.ValueOfAlpha));     
            }

            Subscribe(proc);
        }

        public void Clear()
        {
            cpu.Clear();
            device.Clear();
            ram.Clear();
            ReadyQueue.Clear();
            deviceQueue.Clear();
        }

        void freeingResourceEventHandler(object obj, EventArgs e)
        {
            var proc = obj as Process;

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
                    
                    ReadyQueue.Enqueue(proc, proc.UpdateEstimatedTime(Settings.ValueOfAlpha));
                    

                    Subscribe(proc);
                    break;

                case ProcessStatus.Waiting:
                    if (cpu.ActiveProcess == proc)
                    {
                        memorymanager.Free(proc);
                        cpu.Clear();
                        proc.ResetWorkTime();
                        proc.Status = ProcessStatus.Ready;
                        DeviceQueue.Enqueue(proc);
                        Subscribe(proc);
                    }
                    if(device.ActiveProcess == proc)
                    {
                        device.Clear();
                    }
                    
                    break;

                case ProcessStatus.Terminated:
                    if (cpu.ActiveProcess == proc)
                    {
                        memorymanager.Free(proc);
                        cpu.Clear();
                    }
                      

                    if(device.ActiveProcess == proc)
                    {
                        device.Clear();
                    }
                    break;


            }
        }

        void Subscribe(Process proc) => proc.resourceFreeing += freeingResourceEventHandler;

        void Unsubscribe(Process proc) => proc.resourceFreeing -= freeingResourceEventHandler;

        public void initSettings(double intensity, int burstMin, int burstMax, int addrSpaceMin, int addrSpaceMax, int ramSize)
        {
            Settings.Intensity = intensity;
            Settings.MinValueOfBurst = burstMin;
            Settings.MaxValueOfBurst = burstMax;
            Settings.MinValueOfAddrSpace = addrSpaceMin;
            Settings.MaxValueOfAddrSpace = addrSpaceMax;
            Settings.ValueOfRAMSize = ramSize;
            Settings.ValueOfAlpha = 0.9;

            ram.Save(ramSize);
        }
    }
}