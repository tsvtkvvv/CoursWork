
namespace CoursWork
{


    public class Resource
    {
        private Process _activeProcess;

        public Process ActiveProcess
        {
            get { return _activeProcess; }
            set { _activeProcess = value; }
        }

        public DeviceScheduler DeviceScheduler
        {
            get => default;
            set
            {
            }
        }

        public CPUScheduler CPUScheduler
        {
            get => default;
            set
            {
            }
        }

        public void WorkingCycle()
        {
            if (_activeProcess != null)
            {
                _activeProcess.IncreaseWorkTime();
            }
        }
        public bool IsFree() => _activeProcess == null || _activeProcess.Status == ProcessStatus.Terminated;

        public void SetActiveProcess(Process process)
        {
            _activeProcess = process ?? throw new ArgumentNullException(nameof(process));
        }
        public void Clear()
        {
            _activeProcess = null;
        }
    }
}