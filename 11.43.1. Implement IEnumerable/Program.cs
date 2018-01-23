using System;
using System.Collections.Generic;
using System.Text;

class MyClass : IEnumerable<string>
{
    IEnumerator<string> Letter
    {
        get
        {
            yield return "A";
            yield return "B";
            yield return "C";
        }
    }

    public IEnumerator<string> GetEnumerator()
    {
        return Letter;
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return Letter;
    }
}

class MainClass
{
    static void Main()
    {
        MyClass mc1 = new MyClass();
        foreach (string s in mc1)
            Console.Write("{0} ", s);
    }
}
//A B C