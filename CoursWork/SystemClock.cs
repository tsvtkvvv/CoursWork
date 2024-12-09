namespace CoursWork
{
    public class SystemClock
    {
        public long Clock { get; set; }
        public long clock
        {
            get => clock;
            private set => clock = value;
        }

        public void WorkingCycle() => Clock++;

        void Clear() => Clock = 0;
    }
}