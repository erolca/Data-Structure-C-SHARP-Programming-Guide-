using System;
using System.Collections;
using System.Globalization;


//11.33.1.	Create a SortedList using the default comparer


public class SamplesSortedList
{
    public static void Main()
    {

        SortedList mySL1 = new SortedList(3);
        Console.WriteLine("mySL1 (default):");
        mySL1.Add("FIRST", "Hello");
        mySL1.Add("SECOND", "World");
        mySL1.Add("THIRD", "!");
        try
        {
            mySL1.Add("first", "Ola!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
        }
        PrintKeysAndValues(mySL1);



        //C# SortedList:
        //The SortedList collection stores key - value pairs in the ascending order of key by default.
        //SortedList class implements IDictionary & ICollection interfaces, so elements can be accessed both by key and index.

        // C# includes two types of SortedList, generic SortedList and non-generic SortedList.
        //Here, we will learn about non-generic SortedList


        //Add elements in SortedList:
        //Use the Add() method to add key-value pairs into a SortedList.
        //Add() method signature: void Add(object key, object value)
        //Key cannot be null but value can be null.Also, datatype of all keys must be same, 
        //so that it can compare otherwise it will throw runtime exception.
        //Example: Add key-value pairs in SortedList

        SortedList sortedList1 = new SortedList();
        sortedList1.Add(3, "Three");
        sortedList1.Add(4, "Four");
        sortedList1.Add(1, "One");
        sortedList1.Add(5, "Five");
        sortedList1.Add(2, "Two");

        SortedList sortedList2 = new SortedList();
        sortedList2.Add("one", 1);
        sortedList2.Add("two", 2);
        sortedList2.Add("three", 3);
        sortedList2.Add("four", 4);

        SortedList sortedList3 = new SortedList();
        sortedList3.Add(1.5, 100);
        sortedList3.Add(3.5, 200);
        sortedList3.Add(2.4, 300);
        sortedList3.Add(2.3, null);
        sortedList3.Add(1.1, null);


        //Note
        //Internally, SortedList maintains two object[] array, one for keys and another for values.So when you add key - value pair,
        //it runs a binary search using the key to find an appropriate index to store a key and value in respective arrays. 
        //It re-arranges the elements when you remove the elements from it.





        //Access SortedList:
        //SortedList can be accessed by index or key. Unlike other collection, 
        //SortedList requires key instead of index to access a value for that key.

        //Example: Access SortedList

        SortedList sortedList = new SortedList();
        sortedList.Add("one", 1);
        sortedList.Add("two", 2);
        sortedList.Add("three", 3);
        sortedList.Add("four", "Four");

        int i = (int)sortedList["one"];
        int j = (int)sortedList["two"];
        string str = (string)sortedList["four"];

        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(str);


       // Example: Access values using for loop

        SortedList sortedList_2 = new SortedList();
        sortedList_2.Add("one", 1);
        sortedList_2.Add("two", 2);
        sortedList_2.Add("three", 3);
        sortedList_2.Add("four", 4);
        //Console.WriteLine("key: {0}, value: {1}",
        //                        sortedList_2.GetKey(0), sortedList_2.GetByIndex(0));

        for (int d = 0; d < sortedList_2.Count; d++)
        {
            Console.WriteLine("key: {0}, value: {1}",
                                sortedList_2.GetKey(d), sortedList_2.GetByIndex(d));
        }

        //Access SortedList using foreach loop:
        //The foreach statement in C# can be use to access the SortedList collection. 
        //SortedList element includes both key and value. 
        //so, type of element would be DictionaryEntry rather than type of key or value.

        //Example: Access values using foreach

        SortedList sortedList_3 = new SortedList();
        sortedList_3.Add("one", 1);
        sortedList_3.Add("two", 2);
        sortedList_3.Add("three", 3);
        sortedList_3.Add("four", 4);

        foreach (DictionaryEntry kvp in sortedList_3)
            Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);




        //Remove elements from SortedList:
        //Use the Remove() or RemoveAt() method to remove elements from a SortedList.
        //Remove() signature: void Remove(object key)
        //RemoveAt() signature: void RemoveAt(int index)
        //Example: Remove elements in SortedList

        SortedList sortedList_4 = new SortedList();
        sortedList_4.Add("one", 1);
        sortedList_4.Add("two", 2);
        sortedList_4.Add("three", 3);
        sortedList_4.Add("four", 4);

        sortedList_4.Remove("one");//removes element whose key is 'one'
        sortedList_4.RemoveAt(0);//removes element at zero index i.e first element: four

        foreach (DictionaryEntry kvp in sortedList_4)
            Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

        //Check for existing key in SortedList:
        //The Contains() & ContainsKey() methods determine whether the specified key exists in the SortedList collection or not.
        //Contains() signature: bool Contains(object key)
        //ContainsKey() signature: bool ContainsKey(object key)
        //The ContainsValue() method determines whether the specified value exists in the SortedList or not.
        //ContainValue() signature: bool ContainValue(object value)
        //Example: Contains

        SortedList sortedList_5 = new SortedList();
        sortedList_5.Add(3, "Three");
        sortedList_5.Add(2, "Two");
        sortedList_5.Add(4, "Four");
        sortedList_5.Add(1, "One");
        sortedList_5.Add(8, "Five");

        sortedList_5.Contains(2); // returns true
        sortedList_5.Contains(4); // returns true
        sortedList_5.Contains(6); // returns false

        sortedList_5.ContainsKey(2); // returns true
        sortedList_5.ContainsKey(6); // returns false

        sortedList_5.ContainsValue("One"); // returns true
        sortedList_5.ContainsValue("Ten"); // returns false


        //Points to Remember:
        //C# has generic and non-generic SortedList.
        //SortedList stores the key - value pairs in ascending order of the key.
        //Key must be unique and cannot be null whereas value can be null or duplicate.
        //Non - generic SortedList stores keys and values of any data types.So values needs to be cast to appropriate data type.
        //Key - value pair can be cast to DictionaryEntry.
        //Access individual value using indexer.SortedList indexer accepts key to return value associated with it.
    }

    public static void PrintKeysAndValues(SortedList myList)
    {
        Console.WriteLine("        -KEY-   -VALUE-");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("{0,-6}: {1}", myList.GetKey(i), myList.GetByIndex(i));
        }
    }
}