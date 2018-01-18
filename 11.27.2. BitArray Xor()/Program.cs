using System;
using System.Collections;

//11.27.2.	BitArray: Xor()

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

        BitArray ba3 = ba.Xor(ba2);

        Console.WriteLine("\ncontents of ba2 :");
        for (int i = 0; i < ba2.Count; i++)
            Console.Write("{0, -6} ", ba2[i]);

        Console.WriteLine("\nResult of ba XOR ba3:");
        for (int i = 0; i < ba3.Count; i++)
            Console.Write("{0, -6} ", ba3[i]);


    }
}
//Original contents of ba:
//False False  False False  False False  False False
//contents of ba2 :
//True True   False False  False False  True False
//Result of ba XOR ba3:
//False False  True True   True True   False True