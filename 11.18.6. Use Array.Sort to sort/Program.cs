using System;
using System.Collections.Generic;
using System.Text;

class MyClass : IComparable
{
    public int TheValue;

    public int CompareTo(object obj)
    {
        MyClass mc = (MyClass)obj;

        if (this.TheValue < mc.TheValue)
            return -1;

        if (this.TheValue > mc.TheValue)
            return 1;

        return 0;
    }
}

class MainClass
{
    static void Main()
    {
        MyClass[] objectArray = new MyClass[5];
        for (int i = 0; i < 5; i++)
        {
            objectArray[i] = new MyClass();
            objectArray[i].TheValue = 100 - i;
        }

        foreach (MyClass i in objectArray)
            Console.Write("{0} ", i.TheValue);

        Array.Sort(objectArray);

        foreach (MyClass i in objectArray)
            Console.Write("{0} ", i.TheValue);
    }
}
//100 99 98 97 96 96 97 98 99 100