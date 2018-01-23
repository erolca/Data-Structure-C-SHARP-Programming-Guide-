using System;
using System.Collections.Generic;

public class Tester
{
    static void Main()
    {
        Stack<Int32> intStack = new Stack<Int32>();
        for (int i = 0; i < 8; i++)
        {
            intStack.Push(i * 5);
        }
        PrintValues(intStack);
        Console.WriteLine("\n(Pop)\t{0}", intStack.Pop());
        PrintValues(intStack);
        Console.WriteLine("\n(Pop)\t{0}", intStack.Pop());
        PrintValues(intStack);
        Console.WriteLine("\n(Peek) \t{0}", intStack.Peek());
        PrintValues(intStack);
        int[] targetArray = new int[12];
        for (int i = 0; i < targetArray.Length; i++)
        {
            targetArray[i] = i * 100 + 100;
        }
        PrintValues(targetArray);
        intStack.CopyTo(targetArray, 6);
        PrintValues(targetArray);
    }

    public static void PrintValues(IEnumerable<Int32> myCollection)
    {
        IEnumerator<Int32> enumerator = myCollection.GetEnumerator();
        while (enumerator.MoveNext())
            Console.Write("{0} ", enumerator.Current);
    }
}