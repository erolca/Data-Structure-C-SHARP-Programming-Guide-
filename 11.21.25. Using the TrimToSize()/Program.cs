using System;
using System.Collections;

//11.21.25.	Using the TrimToSize() method to reduce the capacity of ArrayList


class MainClass
{
    public static void Main()
    {
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");
        myArrayList.Add("A");


        string[] anotherStringArray = { "Here's", "some", "more", "text" };
        myArrayList.SetRange(0, anotherStringArray);

        myArrayList.TrimToSize();
        Console.WriteLine("myArrayList.Capacity = " + myArrayList.Capacity);


        //https://msdn.microsoft.com/en-us/library/system.collections.arraylist.trimtosize(v=vs.110).aspx

        // Creates and initializes a new ArrayList.
        ArrayList myAL = new ArrayList();
        myAL.Add("The");
        myAL.Add("quick");
        myAL.Add("brown");
        myAL.Add("fox");
        myAL.Add("jumped");

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("Initially,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

        // Trim the ArrayList.
        myAL.TrimToSize();

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("After TrimToSize,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

        // Clear the ArrayList.
        myAL.Clear();

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("After Clear,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

        // Trim the ArrayList again.
        myAL.TrimToSize();

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("After the second TrimToSize,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

    }

    public static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList)
            Console.Write("   {0}", obj);
        Console.WriteLine();
    }
}

//myArrayList.Capacity = 10

/**/

/* 
This code produces the following output.

Initially,
Count    : 5
Capacity : 16
Values:    The    quick    brown    fox    jumped
After TrimToSize,
Count    : 5
Capacity : 5
Values:    The    quick    brown    fox    jumped
After Clear,
Count    : 0
Capacity : 5
Values:
After the second TrimToSize,
Count    : 0
Capacity : 16
Values:
*/
