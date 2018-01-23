using System;
using System.Collections.Generic;


//11.42.4.	Implement IComparer to do the customized sorting


public class MyComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (x == null)
        {
            return -1;
        }
        else
        {
            if (y == null)
            {
                return 1;
            }
            else
            {
                int retval = x.Length.CompareTo(y.Length);
                if (retval != 0)
                {
                    return retval;
                }
                else
                {
                    return x.CompareTo(y);
                }
            }
        }
    }
}

public class Example
{
    public static void Main()
    {
        List<string> letters = new List<string>();
        letters.Add("this");
        letters.Add("is");
        letters.Add("a");
        letters.Add("test");
        Display(letters);

        MyComparer dc = new MyComparer();

        letters.Sort(dc);
        Display(letters);

        SearchAndInsert(letters, "E", dc);
        Display(letters);

        SearchAndInsert(letters, "A", dc);
        Display(letters);

        SearchAndInsert(letters, "T", dc);
        Display(letters);

        SearchAndInsert(letters, null, dc);
        Display(letters);
    }

    private static void SearchAndInsert(List<string> list, string insert, MyComparer dc)
    {
        int index = list.BinarySearch(insert, dc);
        if (index < 0)
        {
            list.Insert(~index, insert);
        }
    }

    private static void Display(List<string> list)
    {
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
    }
}