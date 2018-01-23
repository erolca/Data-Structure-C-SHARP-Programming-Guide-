using System;
using System.Collections.Generic;

public class MainClass
{
    static public IEnumerable<int> Powers(int from,int to)
    {
        for (int i = from; i <= to; ++i)
        {
            yield return (int)Math.Pow(2, i);
        }
    }

    static void Main()
    {
        IEnumerable<int> powers = Powers(0, 16);
        foreach (int result in powers)
        {
            Console.WriteLine(result);
        }
    }
}
//1
//2
//4
//8
//16
//32
//64
//128
//256
//512
//1024
//2048
//4096
//8192
//16384
//32768
//65536