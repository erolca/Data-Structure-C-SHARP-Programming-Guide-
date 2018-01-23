using System;
using System.Collections;


//	11.44.5.	Implement IEnumerable and IEnumerator


class MyClass : IEnumerator, IEnumerable
{
    char[] chrs = { 'A', 'B', 'C', 'D' };
    int index = -1;

    // Implement IEnumerable. 
    public IEnumerator GetEnumerator()
    {
        return this;
    }

    // The following methods implement IEnumerator. 

    // Return the current object. 
    public object Current
    {
        get
        {
            return chrs[index];
        }
    }

    // Advance to the next object.  
    public bool MoveNext()
    {
        if (index == chrs.Length - 1)
        {
            Reset(); // reset enumerator at the end. 
            return false;
        }

        index++;
        return true;
    }

    // Reset the enumerator to the start. 
    public void Reset()
    {
        index = -1;
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        // Display the contents of mc. 
        foreach (char ch in mc)
            Console.Write(ch + " ");

        Console.WriteLine();

        // Display the contents of mc, again. 
        foreach (char ch in mc)
            Console.Write(ch + " ");

        Console.WriteLine();
    }
}
//A B C D
//A B C D