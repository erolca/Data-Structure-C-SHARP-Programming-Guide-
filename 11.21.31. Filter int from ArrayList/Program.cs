using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.Collections;

//11.21.31.	Filter int from ArrayList

class Car
{
    public string PetName;
    public string Color;
    public int Speed;
    public string Make;
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList myStuff = new ArrayList();
        myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
        IEnumerable<int> myInts = myStuff.OfType<int>();

        foreach (int i in myInts)
        {
            Console.WriteLine("Int value: {0}", i);
        }
    }
}
