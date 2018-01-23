// Code revised from 
//A Programmer's Introduction to C# 2.0, Third Edition

using System;
using System.Collections;

//11.44.6.	Define custom enumerators and use foreach to loop through

// Note: This class is not thread-safe
public class IntList : IEnumerable
{
    int[] values = new int[10];
    int allocated = 10;
    int count = 0;
    int revision = 0;

    public void Add(int value)
    {
        // reallocate if necessary
        if (count + 1 == allocated)
        {
            int[] newValues = new int[allocated * 2];
            for (int index = 0; index < count; index++)
            {
                newValues[index] = values[index];
            }
            allocated *= 2;
        }
        values[count] = value;
        count++;
        revision++;
    }

    public int Count
    {
        get
        {
            return (count);
        }
    }

    void CheckIndex(int index)
    {
        if (index >= count)
            throw new ArgumentOutOfRangeException("Index value out of range");
    }

    public int this[int index]
    {
        get
        {
            CheckIndex(index);
            return (values[index]);
        }
        set
        {
            CheckIndex(index);
            values[index] = value;
            revision++;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return (new IntListEnumerator(this));
    }

    internal int Revision
    {
        get
        {
            return (revision);
        }
    }
}

class IntListEnumerator : IEnumerator
{
    IntList intList;
    int revision;
    int index;

    internal IntListEnumerator(IntList intList)
    {
        this.intList = intList;
        Reset();
    }

    public bool MoveNext()
    {
        index++;
        if (index >= intList.Count)
            return (false);
        else
            return (true);
    }

    public object Current
    {
        get
        {
            if (revision != intList.Revision)
                throw new InvalidOperationException("Collection modified while enumerating.");
            return (intList[index]);
        }
    }

    public void Reset()
    {
        index = -1;
        revision = intList.Revision;
    }
}

class MainClass
{
    public static void Main()
    {
        IntList list = new IntList();

        list.Add(1);
        list.Add(55);
        list.Add(43);

        foreach (int value in list)
        {
            Console.WriteLine("Value = {0}", value);
        }

        foreach (int value in list)
        {
            Console.WriteLine("Value = {0}", value);
            list.Add(124);
        }
    }
}
//Value = 1
//Value = 55
//Value = 43
//Value = 1

//Unhandled Exception: System.InvalidOperationException: Collection modified while enumerating.
//   at IntListEnumerator.get_Current()
//   at MainClass.Main()