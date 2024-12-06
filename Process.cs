namespace ConsoleApp4;

public enum ProcessStatus { Ready, Running, Waiting, Terminated }

public class Process
{
    public long id { get; private set; }
    public string name { get; private set; }
    public long BurstTime { get; private set; }
    public ProcessStatus Status { get; set; }
    public long workTime { get; private set; }
    public long AddrSpace { get; private set; }
    private Random procRand;

    public Process(long pId, long addrSpace, string procName)
    {
        id = pId;
        AddrSpace = addrSpace;
        name = procName;
        Status = ProcessStatus.Ready;
        procRand = new Random();
    }

    public  void IncreaseWorkTime()
    {
        if (workTime < BurstTime)
        {
            workTime++;
        }
        else
        {
            if (Status == ProcessStatus.Running)
            {
                
                Status = procRand.Next(2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting;
            }
            else
            {
               
                Status = ProcessStatus.Ready;
            }
        }
    }

    public void ResetWorkTime()
    {
        workTime = 0;
    }
    public event EventHandler resourceFreeing;
    private void OnResourceFreeing()
    {
        if (resourceFreeing != null)
            resourceFreeing(this, null);
    }
    public override string ToString()
    {
        return $"Process {name} [ID: {id}, Status: {Status}, WorkTime: {workTime}/{BurstTime}]";
    }
}
