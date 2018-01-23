using System;
using System.Collections;


//11.42.6.	Sort an Array using the default comparer and a custom comparer that reverses the sort order


class myReverserClass : IComparer
{
    int IComparer.Compare(Object x, Object y)
    {
        return ((new CaseInsensitiveComparer()).Compare(y, x));
    }
}

public class SamplesArray
{
    public static void Main()
    {
        String[] myArr = { "this", "is", "a", "test", "this", "is", "another", "test", "z" };
        IComparer myComparer = new myReverserClass();

        PrintIndexAndValues(myArr);

        Array.Sort(myArr, 1, 3);
        PrintIndexAndValues(myArr);

        // Sorts a section of the Array using the reverse case-insensitive comparer.
        Array.Sort(myArr, 1, 3, myComparer);
        PrintIndexAndValues(myArr);

        // Sorts the entire Array using the default comparer.
        Array.Sort(myArr);
        PrintIndexAndValues(myArr);

        // Sorts the entire Array using the reverse case-insensitive comparer.
        Array.Sort(myArr, myComparer);
        PrintIndexAndValues(myArr);

    }

    public static void PrintIndexAndValues(String[] myArr)
    {
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("   [{0}] : {1}", i, myArr[i]);
        }
    }
}