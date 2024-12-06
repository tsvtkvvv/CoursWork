using System;

namespace ConsoleApp4;


public class MemoryManager
{
    private Memory memory;

    public void Save(Memory memory)
    {
        memory = memory ?? throw new ArgumentNullException(nameof(memory));
    }
    public Memory Allocate(Process process)
    {
        if (process == null) throw new ArgumentNullException(nameof(process));
        var requiredSize = process.AddrSpace;
        if (memory.Size >= requiredSize)
        {
            memory.Size -= requiredSize;
            memory.OcuppiedSize += requiredSize;
            return memory;
        }
        return null;
    }
    public void Free(Process process)
    {
        if (process != null) throw new ArgumentNullException(nameof(process));
        var sizetoFree_ = process.AddrSpace;
        var ocNewSize = memory.OcuppiedSize - sizetoFree_;
        if (ocNewSize > 0)
        {
            memory.OcuppiedSize = ocNewSize;
            memory.Size += sizetoFree_;
        }
    }
}