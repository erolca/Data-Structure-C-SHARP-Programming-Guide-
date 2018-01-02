using System;
using System.Collections;
using System.Collections.Specialized;

class MyClass
{
    public string MyName = "";
}

class MainClass
{
    static void Main(string[] args)
    {
        ArrayList classList = new ArrayList();
        classList.AddRange(new MyClass[] { new MyClass(),
                                           new MyClass(),
                                           new MyClass()});
        Console.WriteLine("Items in List: {0}", classList.Count);

        classList.Insert(2, new MyClass());//ekleme
        Console.WriteLine("Items in classList: {0}", classList.Count);

        // Print out current values. 
        foreach (MyClass c in classList)
        {
            Console.WriteLine("MyClass name: {0}", c.MyName);
        }
    }
}
//Items in List: 3
//Items in classList: 4
//MyClass name:
//MyClass name:
//MyClass name:
//MyClass name: