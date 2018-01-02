using System;

//The general form of a multidimensional array declaration:
//type[, ...,] name = new type[size1, size2, ..., sizeN];

class MainClass
{
    static void Main()
    {
        int[,] arr = new int[2, 3] { { 0, 1, 2 }, { 10, 11, 12 } };

        int[,] integers2d = { {2, 4}, {3, 9}, {4, 16}, {5, 25},
                           {6, 36}, {7, 49}, {8, 64}, {9, 81} };

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(arr[i, j]);
            }
        }
    }
}