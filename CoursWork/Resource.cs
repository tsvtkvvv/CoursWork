namespace CoursWork
{
    public class Resource
    {
        Process _activeProcess;

        public Process ActiveProcess
        {
            get { return _activeProcess; }
            set { _activeProcess = value; }
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

        public void Clear() => _activeProcess = null;
    }
}