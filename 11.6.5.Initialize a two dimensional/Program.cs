using System;

//11.6.5.	Initialize a two-dimensional array

class MainClass
{
    public static void Main()
    {
        int i, j;
        //10x2
        int[,] sqrs = {
      { 1, 1 },
      { 2, 4 },
      { 3, 9 },
      { 4, 16 },
      { 5, 25 },
      { 6, 36 },
      { 7, 49 },
      { 8, 64 },
      { 9, 81 },
      { 10, 100 }
    };
        int numberOfRows = sqrs.GetLength(0);
        int numberOfColumns = sqrs.GetLength(1);
        Console.WriteLine("Number of rows = " + numberOfRows);
        Console.WriteLine("Number of columns = " + numberOfColumns);

        
        Console.WriteLine("");
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 2; j++)
                Console.Write(sqrs[i, j] + " ");
            Console.WriteLine();
        }
    }
}

//Number of rows = 10
//Number of columns = 2

//1 1
//2 4
//3 9
//4 16
//5 25
//6 36
//7 49
//8 64
//9 81
//10 100