using System;
using System.Collections;
using System.Collections.Generic;


//	11.29.1.	Add elements to the table and Use the keys to obtain the values


class HashtableDemo
{
    public static void Main()
    {
        Hashtable ht = new Hashtable();


        ht.Add("a", "A");
        ht.Add("b", "B");
        ht.Add("c", "C");
        ht.Add("e", "E");

        // Get a collection of the keys. 
        ICollection c = ht.Keys;

        foreach (string str in c)
            Console.WriteLine(str + ": " + ht[str]);





        //http://www.tutorialsteacher.com/csharp/csharp-hashtable

        //Add key-value into Hashtable:
        //The Add() method adds an item with a key and value into the Hashtable. Key and value can be of any data type.
        //Key cannot be null whereas value can be null.

        //Add() Signature: void Add(object key, object value);
        Hashtable htx = new Hashtable();

        htx.Add(1, "One");
        htx.Add(2, "Two");
        htx.Add(3, "Three");
        htx.Add(4, "Four");
        htx.Add(5, null);
        htx.Add("Fv", "Five");
        htx.Add(8.5F, 8.5);

        //You can also assign key and value at the time of initialization using object initializer syntax:
        Hashtable hty = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", "Five" },
                    { 8.5F, 8.5 }
                };

        //Hashtable can include all the elements of Dictionary as shown below.
        //Example: Add()

        Dictionary<int, string> dictz = new Dictionary<int, string>();
  

        dictz.Add(1, "one");
        dictz.Add(2, "two");
        dictz.Add(3, "three");

        Hashtable htz = new Hashtable(dictz);
        Console.WriteLine("Total elements: {0}", dictz.Count);

        //Access Hashtable:
        //You can retrive the value of an existing key from the Hashtable using indexer.
        //Please note that the hashtable indexer requires a key.

        Hashtable htt = new Hashtable();

        htt.Add(1, "One");
        htt.Add(2, "Two");
        htt.Add(3, "Three");
        htt.Add(4, "Four");
        htt.Add("Fv", "Five");
        htt.Add(8.5F, 8.5F);

        string strValue1 = (string)htt[2];
        string strValue2 = (string)htt["Fv"];
        float fValue = (float)htt[8.5F];

        Console.WriteLine(strValue1);
        Console.WriteLine(strValue2);
        Console.WriteLine(fValue);

        //Hashtable elements are key-value pairs stored in DictionaryEntry. So you cast each element in Hashtable to DictionaryEntry. 
        //Use the foreach statement to iterate the Hashtable, as shown below:
        Hashtable htEntry = new Hashtable();

        htEntry.Add(1, "One");
        htEntry.Add(2, "Two");
        htEntry.Add(3, "Three");
        htEntry.Add(4, "Four");
        htEntry.Add("Fv", "Five");
        htEntry.Add(8.5F, 8.5);

        foreach (DictionaryEntry item in htEntry)
            Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);


        //Access Hashtable using Keys & Values
        Hashtable htd = new Hashtable();
        htd.Add(1, "One");
        htd.Add(2, "Two");
        htd.Add(3, "Three");
        htd.Add(4, "Four");
        htd.Add("Fv", "Five");
        htd.Add(8.5F, 8.5);

        foreach (var key in htd.Keys)
            Console.WriteLine("Key:{0}, Value:{1}", key, htd[key]);

        Console.WriteLine("***All Values***");

        foreach (var value in htd.Values)
            Console.WriteLine("Value:{0}", value);

        //Remove elements in Hashtable:
        //The Remove() method removes the item with the specified key from the hashtable.

        //Remove() Method Signature: void Remove(object key)

        Hashtable htRemove = new Hashtable();
        htRemove.Add(1, "One");
        htRemove.Add(2, "Two");
        htRemove.Add(3, "Three");
        htRemove.Add(4, "Four");
        htRemove.Add("Fv", "Five");
        htRemove.Add(8.5F, 8.5);

        htRemove.Remove("Fv"); // removes {"Fv", "Five"}

        //Check for existing elements:
        //Contains() and ContainsKey() check whether the specified key exists in the Hashtable collection.
        //ContainsValue() checks whether the specified value exists in the Hashtable.
        //Contains(), ContainsKey() and ContainsValue() Signatures:
        //bool Contains(object key)
        //bool ContainsKey(object key)
        //bool ContainsValue(object value)
        //Example: Contains

        Hashtable htCheck = new Hashtable();
        htCheck.Add(1, "One");
        htCheck.Add(2, "Two");
        htCheck.Add(3, "Three");
        htCheck.Add(4, "Four");

        htCheck.Contains(2);// returns true
        htCheck.ContainsKey(2);// returns true
        htCheck.Contains(5); //returns false
        htCheck.ContainsValue("One"); // returns true

        //Clear():
        //Clear() method removes all the key - value pairs in the Hashtable.
        //Clear() Method Signature: void Clear()
        //Example: Clear()

        Hashtable htClear = new Hashtable();
        htClear.Add(1, "One");
        htClear.Add(2, "Two");
        htClear.Add(3, "Three");
        htClear.Add(4, "Four");
        htClear.Add("Fv", "Five");
        htClear.Add(8.5F, 8.5);

        htClear.Clear(); // removes all elements
        Console.WriteLine("Total Elements: {0}", htClear.Count);
    }
}
//a: A
//b: B
//c: C
//e: E