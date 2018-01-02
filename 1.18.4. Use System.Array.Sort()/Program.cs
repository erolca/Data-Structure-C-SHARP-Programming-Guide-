using System;

class MainClass
{
    public static void Main()
    {
        int[] arr = { 5, 1, 10, 33, 100, 4 };
        Array.Sort(arr);
        foreach (int v in arr)
            Console.WriteLine("Element: {0}", v);
    }
}
//Element: 1
//Element: 4
//Element: 5
//Element: 10
//Element: 33
//Element: 100