using System;

class MainClass
{
    public static void Main()
    {
        int[][] jaggedArray = new int[4][];
        jaggedArray[0] = new int[3];
        jaggedArray[1] = new int[7];
        jaggedArray[2] = new int[2];
        jaggedArray[3] = new int[5];

        int i, j;

        for (i = 0; i < jaggedArray.Length; i++)
        {
            for (j = 0; j < jaggedArray[i].Length; j++)
            {
                jaggedArray[i][j] = i * j + 70;
            }
        }

        Console.WriteLine("Total number of network nodes: " +
                          jaggedArray.Length + "\n");

        for (i = 0; i < jaggedArray.Length; i++)
        {
            for (j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(i + " " + j + ": ");
                Console.Write(jaggedArray[i][j] + "% ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
//Total number of network nodes: 4

//0 0: 70%
//0 1: 70%
//0 2: 70%

//1 0: 70%
//1 1: 71%
//1 2: 72%
//1 3: 73%
//1 4: 74%
//1 5: 75%
//1 6: 76%

//2 0: 70%
//2 1: 72%

//3 0: 70%
//3 1: 73%
//3 2: 76%
//3 3: 79%
//3 4: 82%