using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

//11.26.6.	Collections interoperability: cast Array to IList, IList to ICollection,
//ICollection to IEnumerable, non-generic to generic

public class MainClass
{
    public static void Main()
    {
        //string[] languages = new string[6] { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal" };
        //Array language = languages;
        

        int[] arrayOfInts = new int[] { 10, 99, 50 };
        Array a = (Array)arrayOfInts;
        IList list = (IList)arrayOfInts;
        ICollection collection = (ICollection)arrayOfInts;
        IEnumerable enumerable = (IEnumerable)arrayOfInts;
        ICollection<int> collectionGeneric = (ICollection<int>)arrayOfInts;
        IEnumerable<int> enumerableGeneric = (IEnumerable<int>)arrayOfInts;

    }
}