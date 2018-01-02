using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        ArrayList list = new ArrayList(1);

        for (int i = 0; i < 10; i++)
            list.Add(i*2);

        IEnumerator etr = list.GetEnumerator();
        while (etr.MoveNext())
            Console.Write(etr.Current + " ");

        Console.WriteLine();

    }
}
//0 1 2 3 4 5 6 7 8 9