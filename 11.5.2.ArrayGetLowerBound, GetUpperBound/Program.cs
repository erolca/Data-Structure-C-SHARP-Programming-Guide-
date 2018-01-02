using System;

public class ArrayTest
{

    public static void Main()
    {
        int[,] a = new int[3, 4] {
                                   {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
                                   {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
                                   {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
                                                      };



        int[] array_1 = new int[5];

        for (int i = array_1.GetLowerBound(0); i <= array_1.GetUpperBound(0); i++)
            array_1[i] = i + 1;

        for (int j = array_1.GetLowerBound(0); j <= array_1.GetUpperBound(0); j++)
            Console.WriteLine("array_1[{0}] = {1}", j, array_1[j]);

    }
}
//array_1[0] = 1
//array_1[1] = 2
//array_1[2] = 3
//array_1[3] = 4
//array_1[4] = 5