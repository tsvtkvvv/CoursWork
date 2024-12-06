namespace CoursWork
{


    public enum ProcessStatus { Ready, Running, Waiting, Terminated }

    public class Process
    {
        public long id { get; private set; }
        public string name { get; private set; }
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        public long workTime { get; private set; }
        public long AddrSpace { get; private set; }
        static Random procRand = new Random();
        private long RemainingTime;

        public Process(long pId, long addrSpace)
        {
            id = pId;
            AddrSpace = addrSpace;

            Status = ProcessStatus.Ready;
        }



        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
            }
            else
            {
                if (Status == ProcessStatus.Running)
                {

                    Status = randStatus();
                }
                else
                {

                    Status = ProcessStatus.Ready;
                }
                OnResourceFreeing();
            }
        }

        public void ResetWorkTime()
        {
            workTime = 0;
        }
        public long RemainingWorkTime()
        {
            return RemainingTime =  BurstTime - workTime;
        }

        public event EventHandler resourceFreeing;
        public void OnResourceFreeing()
        {
            if (resourceFreeing != null)
                resourceFreeing(this, null);
        }
        public override string ToString()
        {
            return $"Process {name} [ID: {id}, Status: {Status}, WorkTime: {workTime}/{BurstTime}]";
        }

        public ProcessStatus randStatus()
        {
            return procRand.Next(2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting;
        }

        public Resource Resource
        {
            get => default;
            set
            {
            }
        }
    }
}
