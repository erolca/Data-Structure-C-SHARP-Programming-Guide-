using System;

	//11.6.10.	Initialize multidimensional arrays in declaration

class MainClass
{
    public static void Main()
    {

        //5x2
        int[,] matrix = { { 1, 1 }, { 2, 2 }, { 3, 5 }, { 4, 5 }, { 134, 44 } };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine("matrix[{0}, {1}] = {2}", i, j, matrix[i, j]);
            }
        }
    }
}
//matrix[0, 0] = 1
//matrix[0, 1] = 1
//matrix[1, 0] = 2
//matrix[1, 1] = 2
//matrix[2, 0] = 3
//matrix[2, 1] = 5
//matrix[3, 0] = 4
//matrix[3, 1] = 5
//matrix[4, 0] = 134
//matrix[4, 1] = 44