using System;

class MainClass
{
    public static void Main()
    {
        int[][] matrix = { new int[5], new int[4], new int[2] };
        matrix[0][3] = 4;
        matrix[1][1] = 8;
        matrix[2][0] = 5;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.WriteLine("matrix[{0}, {1}] = {2}", i, j, matrix[i][j]);
            }
        }
    }
}
//matrix[0, 0] = 0
//matrix[0, 1] = 0
//matrix[0, 2] = 0
//matrix[0, 3] = 4
//matrix[0, 4] = 0
//matrix[1, 0] = 0
//matrix[1, 1] = 8
//matrix[1, 2] = 0
//matrix[1, 3] = 0
//matrix[2, 0] = 5
//matrix[2, 1] = 0