using System;
namespace ConsoleApp4;


public class CPUScheduler
{
    public Resource __resource;
    public PriorityQueue<Process, long> __queue;

    public CPUScheduler(Resource resource, PriorityQueue<Process, long> queue)
    {
        __resource = resource ?? throw new ArgumentNullException(nameof(resource));
        __queue = queue ?? throw new ArgumentNullException(nameof(queue));
    }
    public void Session_()
    {
        if (__queue.TryDequeue(out var process, out var priority))
        {
            process.Status = ProcessStatus.Running;
            __resource.ActiveProcess = process;
        }
    }
}
