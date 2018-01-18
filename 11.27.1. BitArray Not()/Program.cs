using System;
using System.Collections;

//11.27.1.	BitArray: Not()


class MainClass
{
    public static void Main()
    {
        BitArray ba = new BitArray(8);
        byte[] b = { 67 };
        BitArray ba2 = new BitArray(b);

        Console.WriteLine("Original contents of ba:");

        for (int i = 0; i < ba.Count; i++)
            Console.Write("{0, -6} ", ba[i]);

        ba = ba.Not();

        Console.WriteLine("Contents of ba after Not:");
        for (int i = 0; i < ba.Count; i++)
            Console.Write("{0, -6} ", ba[i]);


        Console.WriteLine("");
        Console.WriteLine("67-0x43->>Contents of ba2 of binary");
        for (int i = 0; i < ba2.Length; i++)
        {
            Console.Write("{0, -6} ", ba2[i]);
        }


    }
}
//Original contents of ba:
//False False  False False  False False  False False  Contents of ba after Not:
//True True   True True   True True   True True