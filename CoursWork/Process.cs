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
        public long estimatedTime { get; set; }

        public Process(long pId, long addrSpace, long burstTime)
        {
            id = pId;
            AddrSpace = addrSpace;

            Status = ProcessStatus.Ready;
            BurstTime = burstTime;
            estimatedTime = BurstTime;
        }


        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
                UpdateEstimatedTime(Settings.ValueOfAlpha);
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

        public long UpdateEstimatedTime(double alpha)
        {
            var remainingTime = BurstTime - workTime;
            estimatedTime = (long)Math.Round(alpha * remainingTime + (1 - alpha) * estimatedTime);
            return estimatedTime;
        }

        public void ResetWorkTime() => workTime = 0;

        public event EventHandler resourceFreeing;
        public void OnResourceFreeing()
        {
            if (resourceFreeing != null)
                resourceFreeing(this, null);
        }

        public override string ToString()
        {
            
            return "Id: " + id + " " +
                  "[" + Status + "]" +
                  " Priority [" + estimatedTime + "]" +
                  " AddrsSpace" + " [" + AddrSpace + "]" +
                  " Work time " + "[" + workTime +
                  "/" + BurstTime + "]";
        }

        public ProcessStatus randStatus()
        {
            return procRand.Next(2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting;
        }
    }
}