using System;
//11.6.4.	Use Foreach statement to loop through Rectangular Array

class MainClass
{
    static void Main()
    {
        int[,] arr1 = { { 0, 1, 1 }, { 2, 3, 3 } };

        foreach (int element in arr1)
        {
            Console.WriteLine("Element: {0}", element);
        }
    }
}
//Element: 0
//Element: 1
//Element: 2
//Element: 3