using System;

class MainClass
{
    static void Main()
    {

        //---------------example----------------------------------
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[4];
        jaggedArray[2] = new int[2];
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        jaggedArray[1] = new int[] { 0, 2, 4, 6 };
        jaggedArray[2] = new int[] { 11, 22 };
        //---------------------------------------------------------


        int[][,] Arr;
        Arr = new int[2][,];

        Arr[0] = new int[,] { { 1, 2 }, { 10, 20 } };
        Arr[1] = new int[,] { { 3, 4, 5 }, { 30, 40, 50 } };

        for (int i = 0; i < Arr.GetLength(0); i++)
        {
            for (int j = 0; j < Arr[i].GetLength(0); j++)
            {
                for (int k = 0; k < Arr[i].GetLength(1); k++)
                {
                    Console.WriteLine("[{0}][{1},{2}] = {3}", i, j, k, Arr[i][j, k]);
                }
            }
        }
    }
}

//[0] [0,0] = 1
//[0] [0,1] = 2
//[0] [1,0] = 10
//[0] [1,1] = 20
//[1] [0,0] = 3
//[1] [0,1] = 4
//[1] [0,2] = 5
//[1] [1,0] = 30
//[1] [1,1] = 40
//[1] [1,2] = 50