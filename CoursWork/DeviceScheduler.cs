namespace CoursWork
{
    public class DeviceScheduler
    {
        Resource resource;
        public Queue<Process> queue { get; private set; }

        public DeviceScheduler(Resource resource, Queue<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public void Session()
        {
            if (!resource.IsFree())
            {
                var activeProcess = resource.ActiveProcess;
                activeProcess.IncreaseWorkTime();

                if (activeProcess.workTime > activeProcess.BurstTime)
                {
                    activeProcess.Status = ProcessStatus.Terminated;
                    activeProcess.OnResourceFreeing();
                }
            }

            if (resource.IsFree() && queue.Count > 0)
            {
                var process = queue.Dequeue();

                if (resource.ActiveProcess != process)
                {
                    process.Status = ProcessStatus.Running;
                    process.ResetWorkTime();
                    resource.ActiveProcess = process;
                    Console.WriteLine($"Process {process.id} started on the device.");
                }
            }

        }
    }
}