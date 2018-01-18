using System;
using System.Collections;


//11.21.1.	Demonstrates the 3 constructors of ArrayList

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        ArrayList al1 = new ArrayList();
        ArrayList al2 = new ArrayList(10);


        int[] intArr = new int[10];// veya  { 1,2, 3, 4, 5, 6, 7, 8, 9,0 };
                                   // int[] intArr = new int[10]  { 1,2, 3, 4, 5, 6, 7, 8, 9,0 };

        ArrayList al3 = new ArrayList(intArr);

        ArrayList myArrayList = new ArrayList();
        myArrayList.Capacity = 10;

        intArr = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        myArrayList.Add(1);
        myArrayList.AddRange(intArr); //Adds the elements of an ICollection to the end of the ArrayList
        Console.WriteLine(myArrayList.Capacity);

        myArrayList.Remove(1);
        myArrayList.RemoveRange(1, 2);

        myArrayList.Insert(1, 3); //İçine bir öğe ekler ArrayList belirtilen dizindeki.
        /*public virtual void Insert(int index,object value)*/

        myArrayList.InsertRange(0, intArr); //Inserts the elements of a collection into the ArrayList at the specified index.

        //public virtual void InsertRange(int index, ICollection c)

        foreach (object elem in myArrayList)
        {
            Console.WriteLine(elem);
        }





        //http://www.tutorialsteacher.com/csharp/csharp-arraylist

        //C# ArrayList:
        //ArrayList is a non-generic type of collection in C#. It can contain elements of any data types. It is similar to an array, except that it 
        //grows automatically as you add items in it. Unlike an array, you don't need to specify the size of ArrayList.
        //Example: Initialize ArrayList
        ArrayList ArryLists = new ArrayList();




        //Add elements into ArrayList:
        //Use the Add()method to add a single element or the AddRange() method to add multiple 
        //elements from the other collections into an ArrayList. Here, the element means the literal 
        //value of a primitive or non-primitive type.
        //Add() signature: int Add(Object value)
        //AddRange() signature: void AddRange(ICollection c)


        ArrayList arryList1 = new ArrayList();
        arryList1.Add(1);
        arryList1.Add("Two");
        arryList1.Add(3);
        arryList1.Add(4.5);

        ArrayList arryList2 = new ArrayList();
        arryList2.Add(100);
        arryList2.Add(200);

        //adding entire arryList2 into arryList1
        arryList1.AddRange(arryList2);


        //Access ArrayList Elements:
        //ArrayList elements can be accessed using indexer, in the same way as an array.
        //However, you need to cast it to the appropriate type or use the implicit type var keyword while accessing it.
        //Access individual item using indexer
       int firstElement = (int)arryList1[0]; //returns 1
        string secondElement = (string)arryList1[1]; //returns "Two"
        int thirdElement = (int)arryList1[2]; //returns 3
        float fourthElement = (float)arryList1[3]; //returns 4.5

        //use var keyword
        var _firstElement = arryList1[0]; //returns 1

        //Iterate ArrayList

        foreach (var val in arryList1)
            Console.WriteLine(val);
        //Or
        for (int i = 0; i < arryList1.Count; i++)
            Console.WriteLine(arryList1[i]);




        //Insert elements into ArrayList:
        //Use the Insert() method to insert a single item at the specified index.       
        //Insert() signature: void Insert(int index, Object value)

        ArrayList myArryList_ = new ArrayList();
        myArryList_.Add(1);
        myArryList_.Add("Two");
        myArryList_.Add(3);
        myArryList_.Add(4.5);

        myArryList_.Insert(1, "Second Item");
        myArryList_.Insert(2, 100);

        foreach (var val in myArryList_)
            Console.WriteLine(val);


       
        //Use the InsertRange() method to insert all the values from another collection into ArrayList at the specfied index.
        //InsertRange() method signature: Void InsertRange(int index, ICollection c)
        ArrayList arryList3 = new ArrayList();
        arryList3.Add(100);
        arryList3.Add(200);

        ArrayList arryList4 = new ArrayList();
        arryList4.Add(10);
        arryList4.Add(20);
        arryList4.Add(30);

        arryList4.InsertRange(2, arryList3);

        foreach (var item in arryList4)
            Console.WriteLine(item);

        //Remove elements from an ArrayList:
        //Use the Remove() method to remove a specified element from an ArrayList.
        //Remove() signature: void Remove(Object obj)
        ArrayList arryList5 = new ArrayList();
        arryList5.Add(100);
        arryList5.Add(200);
        arryList5.Add(300);

        arryList5.Remove(100); //Removes 1 from ArrayList

        foreach (var item in arryList5)
            Console.WriteLine(item);

        // Use the RemoveAt() method to remove an element from the specified index location.
        //RemoveAt() method signature: void RemoveAt(int index)

        //Example: RemoveAt()

        ArrayList arryList6 = new ArrayList();
        arryList6.Add(100);
        arryList6.Add(200);
        arryList6.Add(300);

        arryList6.RemoveAt(1); //Removes the first element from an ArrayList

        foreach (var item in arryList6)
            Console.WriteLine(item);

        //Use the RemoveRange() method to remove multiple elements from the specified index till the specified number of elements in the ArrayList.
        //RemoveRange() signature: void RemoveRange(int index, int count)
        //Example: RemoveRange()

        ArrayList arryList7 = new ArrayList();
        arryList7.Add(100);
        arryList7.Add(200);
        arryList7.Add(300);

        arryList7.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

        foreach (var item in arryList7)
            Console.WriteLine(item);


        //Sort ArrayList:
        // ArrayList includes Sort() and Reverse() method.Sort() method arranges elements in ascending order. 
        //However, all the elements should have same data type so that it can compare with default comparer otherwise it will throw runtime exception.
        //Reverse() method arranges elements in reverse order. Last element at zero index and so on.
        //Example: Sort(), Reverse()

         ArrayList arryList8 = new ArrayList();
        arryList8.Add(300);
        arryList8.Add(200);
        arryList8.Add(100);
        arryList8.Add(500);
        arryList8.Add(400);

        Console.WriteLine("Original Order:");

        foreach (var item in arryList8)
            Console.WriteLine(item);

        arryList8.Reverse();
        Console.WriteLine("Reverse Order:");

        foreach (var item in arryList8)
            Console.WriteLine(item);

        arryList8.Sort();
        Console.WriteLine("Ascending Order:");

        foreach (var item in arryList8)
            Console.WriteLine(item);

        //Check existing elements:
        //ArrayList.Contains() method checks whether specified element exists in the ArrayList or not. Returns true if exists otherwise false.
        //Example: Contains()

        ArrayList myArryList = new ArrayList();
        myArryList.Add(100);
        myArryList.Add("Hello World");
        myArryList.Add(300);

        Console.WriteLine(myArryList.Contains(100));

    }
}