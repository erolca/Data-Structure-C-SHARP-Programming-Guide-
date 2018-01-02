using System;

class MainClass
{
   // public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)

    public static void Main()
    {
        int[] source = { 21, 22, 23, 24, 25 };
        int[] target = { 11, 12, 13, 14, 15 };
        int[] source2 = { -1, -2, -3, -4, -5 };

        Array.Copy(source, target, source.Length);


        Console.Write("target after copy:  ");
        foreach (int i in target)
            Console.Write(i + " ");
        Console.WriteLine();

    }
}
//target after copy:  21 22 23 24 25