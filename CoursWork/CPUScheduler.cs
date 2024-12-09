using System;

namespace CoursWork
{
    public class CPUScheduler
    {
        public Resource __resource;
        public PriorityQueue<Process, long> __queue;

        public CPUScheduler(Resource resource, PriorityQueue<Process, long> queue)
        {
            __resource = resource ?? throw new ArgumentNullException(nameof(resource));
            __queue = queue ?? throw new ArgumentNullException(nameof(queue));
        }

        public void Session()
        {
            if (__resource.IsFree() && __queue.Count > 0)
            {
                var process = __queue.Dequeue();
                process.Status = ProcessStatus.Running;
                __resource.ActiveProcess = process;
            }
        }

        public void Execute()
        {
            if (!__resource.IsFree())
            {
                var proc = __resource.ActiveProcess;
                proc.Status = ProcessStatus.Ready;
                __resource.Clear();
                __queue.Enqueue(proc, proc.UpdateEstimatedTime(Settings.ValueOfAlpha));
               
            }
        }
    }
}