    using Process.cs;

    namespace ConsoleApp4;


public class DeviceScheduler
{
        public Resource _resource;
        public Queue<Process> _queue;

        public void CPUScheduler(Resource resource, Queue<Process> queue)
        {
            _resource = resource ?? throw new ArgumentNullException(nameof(resource));
            _queue = queue ?? throw new ArgumentNullException(nameof(_queue));
        }
        public void Session()
        {
            if (_queue.TryDequeue(out var process))
            {
      
             _resource.SetActiveProcess(process);
          
            }
        }
    }
