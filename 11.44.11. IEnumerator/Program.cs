using System;
using System.Collections;


//	11.44.11.	IEnumerator and ArrayList, BitArray, Hashtable and array

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        int[] intArr = { 1, 2, 3, 4, 5 };

        ArrayList al = new ArrayList(intArr);

        bool[] baVals = { true, true, false, false, true };
        BitArray ba = new BitArray(baVals);

        Hashtable ht = new Hashtable();
        ht.Add(1, "one");
        ht.Add(2, "two");
        ht.Add(3, "three");
        ht.Add(4, "four");
        ht.Add(5, "five");

        PrintCollection("Integer Array", intArr.GetEnumerator());
        PrintCollection("ArrayList", al.GetEnumerator());
        PrintCollection("BitArray", ba.GetEnumerator());
        PrintCollection("Hashtable", ht.GetEnumerator());
    }

    static void PrintCollection(string name, IEnumerator collEnum)
    {
        Console.WriteLine(collEnum.GetType().ToString());
        Console.WriteLine(name);
        while (collEnum.MoveNext())
        {
            if (collEnum.Current.GetType() == Type.GetType("System.Collections.DictionaryEntry"))
            {
                Console.Write(((DictionaryEntry)collEnum.Current).Value.ToString() + " ");
            }
            else
            {
                Console.Write(collEnum.Current.ToString() + " ");
            }
        }
    }
}