namespace CoursWork
{
    public class Settings
    {
        public double Intensity { get; set; }
        public int MaxValueOfBurst { get; set; }
        public int MinValueOfBurst { get; set; }
        public int MaxValueOfAddrSpace { get; set; }
        public int MinValueOfAddrSpace { get; set; }
        public int ValueOfRAMSize { get; set; }

        public Model Model
        {
            get => default;
            set
            {
            }
        }
    }
}
