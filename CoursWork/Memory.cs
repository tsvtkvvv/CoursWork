public class Memory
{
    public long OccupiedSize { get; set; }
    public long FreeSize { get; set; }

    public CoursWork.MemoryManager MemoryManager
    {
        get => default;
        set
        {
        }
    }

    public void Save(long size)
    {
        FreeSize = size;
        OccupiedSize = 0;
    }

    public void Clear()
    {
        OccupiedSize = 0;
    }
}
