using System;
using System.Collections.Generic;
using System.Text;

class MyClass : IEnumerable<string>
{
    IEnumerator<string> Letter
    {
        get
        {
            string[] s = { "A", "B", "C" };
            for (int i = 0; i < s.Length; i++)
                yield return s[i];
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