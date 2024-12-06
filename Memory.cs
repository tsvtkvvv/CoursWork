using System;
namespace ConsoleApp4;
public class Memory
{
 
    public long Size { get; set; }
    public long OcuppiedSize { get; set; }

    public void Save(long size)
    {
        OcuppiedSize = size;
        OcuppiedSize = 0;
       
    }
   
    public void Clear()
    {
        Size = 0;
        OcuppiedSize = 0;
    }
}
