using System;
using System.Collections.Generic;
using System.ComponentModel;

class IteratorWorkflow
{
    static readonly string Padding = new string(' ', 30);

    static IEnumerable<int> GetEnumerable()
    {
        Console.WriteLine(Padding);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0}About to yield {1}", Padding, i);
            yield return i;
            Console.WriteLine("{0}After yield", Padding);
        }
        Console.WriteLine(Padding);
        yield return -1;
    }
    static void Main()
    {
        IEnumerable<int> iterable = GetEnumerable();
        IEnumerator<int> iterator = iterable.GetEnumerator();
        while (true)
        {
            bool result = iterator.MoveNext();
            Console.WriteLine(result);
            if (!result)
            {
                break;
            }
            Console.WriteLine(iterator.Current);
        }
    }
}
