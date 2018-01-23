using System;
using System.Collections;
using System.ComponentModel;

class IteratorBlockIterationSample : IEnumerable
{
    object[] values;
    int startingPoint;

    public IteratorBlockIterationSample(object[] values, int startingPoint)
    {
        this.values = values;
        this.startingPoint = startingPoint;
    }

    public IEnumerator GetEnumerator()
    {
        for (int index = 0; index < values.Length; index++)
        {
            yield return values[(index + startingPoint) % values.Length];
        }
    }

    static void Main()
    {
        object[] values = { "a", "b", "c", "d", "e" };
        IteratorBlockIterationSample collection = new IteratorBlockIterationSample(values, 3);
        foreach (object x in collection)
        {
            Console.WriteLine(x);
        }
    }
}