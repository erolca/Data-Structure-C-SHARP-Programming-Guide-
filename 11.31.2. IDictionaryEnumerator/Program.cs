using System;
using System.Collections;


//11.31.2.	IDictionaryEnumerator for HashTable

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        Hashtable dir = new Hashtable();
        dir.Add('N', "North");
        dir.Add('S', "South.");
        dir.Add('W', "West");
        dir.Add('E', "East");
        dir.Add('Q', "Goodbye");

        char input;

        do
        {
            Console.Write("Enter a direction (N,S,E,W) or Q to quit: ");
            input = Char.ToUpper(Console.ReadLine()[0]);
            Console.WriteLine(dir[Char.ToUpper(input)]);

        } while (input != 'Q');

        PrintHashtable(dir);
        dir.Remove('Q');
        dir.Clear();
    }

    static void PrintHashtable(Hashtable ht)
    {
        IDictionaryEnumerator htEnum = ht.GetEnumerator();
        while (htEnum.MoveNext())
        {
            Console.WriteLine("Key: {0}\tValue: {1}", htEnum.Key, htEnum.Value);
        }

        foreach (char key in ht.Keys)
        {
            Console.WriteLine(key);
        }
    }
}