using System;

namespace CoursWork
{
    public class MemoryManager
    {
        public Memory memory { get; private set; }

        public void Save(Memory memory) => this.memory = memory;

        public Memory Allocate(Process process)
        {
            if (memory.FreeSize >= process.AddrSpace)
            {
                memory.OccupiedSize += process.AddrSpace;
                memory.FreeSize -= process.AddrSpace;
                return memory;
            }

            return null;
        }

        public void Free(Process process)
        {
            memory.OccupiedSize -= process.AddrSpace;
            memory.FreeSize += process.AddrSpace;
        }
    }
}