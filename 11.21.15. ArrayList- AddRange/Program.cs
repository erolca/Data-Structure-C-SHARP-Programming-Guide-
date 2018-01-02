using System;
using System.Collections;

class MyClass
{
    public string MyName = "";
}

class MainClass
{
    static void Main(string[] args)
    {
        //MyClass[] myclass = new MyClass[] { new MyClass(),
        //                                   new MyClass(),
        //                                   new MyClass()};


        ArrayList classList = new ArrayList();
        classList.AddRange(new MyClass[] { new MyClass(),
                                           new MyClass(),
                                           new MyClass()});
        Console.WriteLine("Items in List: {0}", classList.Count);

        // Print out current values. 
        foreach (MyClass c in classList)
        {
            Console.WriteLine("MyClass name: {0}", c.MyName);
        }
    }
}
//Items in List: 3
//MyClass name:
//MyClass name:
//MyClass name: