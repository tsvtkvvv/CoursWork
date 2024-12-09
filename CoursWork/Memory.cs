public class Memory
{
    public long OccupiedSize { get; set; }
    public long FreeSize { get; set; }

    public void Save(long size)
    {
        FreeSize = size;
        OccupiedSize = 0;
    }

    public void Clear() => OccupiedSize = 0;
}
