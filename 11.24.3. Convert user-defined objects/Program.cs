using System;
using System.Collections;
using System.Collections.Specialized;

//	11.24.3.	Convert user-defined objects in an ArrayList to an array

class MyClass
{
    public string MyName = "";
  
     public MyClass(string Name)
    {
       
        MyName = Name;

    }
}

class MainClass
{
    static void Main(string[] args)
    {
        ArrayList classList = new ArrayList();
        classList.AddRange(new MyClass[] { new MyClass("John"),
                                           new MyClass("Can"),
                                           new MyClass("Raul")});
        Console.WriteLine("Items in List: {0}", classList.Count);

        // Get object array from ArrayList & print again.
        object[] arrayOfMyClasss = classList.ToArray();

       // ((MyClass)arrayOfMyClasss[0]).MyName;

        for (int i = 0; i < arrayOfMyClasss.Length; i++)
        {
            Console.WriteLine("MyClass name: {0}",
              ((MyClass)arrayOfMyClasss[i]).MyName);
        }

    }
}
//Items in List: 3
//MyClass name:
//MyClass name:
//MyClass name: