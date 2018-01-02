using System;
//11.6.11.	Use a single for loop to assign a two-dimensional array


class MainClass
{
    static void Main(string[] args)
    {
        //multidimensional array
        int[,] MyIntArray = new int[5, 5];

        for (int x = 0, y = 0; x < 5; x++, y++)
        {
            MyIntArray[x, y] = 1;
        }
    }
}