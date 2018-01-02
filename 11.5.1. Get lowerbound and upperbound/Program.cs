using System;

public class MainClass
{
    static void Main()
    {
        int[,] twoDim = { {1, 2, 3, 4},
                          {5, 6, 7, 8},
                          {9, 10, 11, 12} };

        for (int i = twoDim.GetLowerBound(0);  i <= twoDim.GetUpperBound(0); ++i)
        {
            for (int j = twoDim.GetLowerBound(1);j <= twoDim.GetUpperBound(1);++j)
            {
                Console.WriteLine(twoDim[i, j]);
            }
        }


        //https://msdn.microsoft.com/tr-tr/library/system.array.getlowerbound(v=vs.110).aspx

        // Create a one-dimensional integer array.
        int[] integers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        // Get the upper and lower bound of the array.
        int upper = integers.GetUpperBound(0);
        int lower = integers.GetLowerBound(0);
        Console.WriteLine("Elements from index {0} to {1}:", lower, upper);
        // Iterate the array.
        for (int ctr = lower; ctr <= upper; ctr++)
            Console.Write("{0}{1}{2}", ctr == lower ? "   " : "",
                                      integers[ctr],
                                      ctr < upper ? ", " : Environment.NewLine);

        Console.WriteLine();


        // Two-dimensional array.
        // Create a two-dimensional integer array.
        int[,] integers2d = { {2, 4}, {3, 9}, {4, 16}, {5, 25},
                           {6, 36}, {7, 49}, {8, 64}, {9, 81} };
        // Get the number of dimensions.                               
        int rank = integers2d.Rank;
        Console.WriteLine("Number of dimensions: {0}", rank);

        for (int ctr = 0; ctr < integers2d.Rank - 1; ctr++)
            Console.WriteLine("   Dimension {0}: from {1} to {2}", ctr,integers2d.GetLowerBound(ctr),integers2d.GetUpperBound(ctr));

        // Iterate the 2-dimensional array and display its values.
        Console.WriteLine("   Values of array elements:");
        for (int outer = integers2d.GetLowerBound(0); outer <= integers2d.GetUpperBound(0); outer++)
            for (int inner = integers2d.GetLowerBound(1); inner <= integers2d.GetUpperBound(1); inner++)
                Console.WriteLine("      {3}{0}, {1}{4} = {2}", outer, inner,  integers2d.GetValue(outer, inner), "{", "}");


        Console.WriteLine("      {4}{0}, {1}, {2}{5} = {3}", 0, 1, 2, 3, "{", "}");


        // Three-dimensional array.

        int[, ,] integer3d = {
                                { { 1, 2, 3 }, 
                                  { 4, 5, 6 },
                                  { 7, 8, 9 }},
                                { { 10, 11, 12}, 
                                  { 13, 14, 15},
                                  { 16 ,17,18}},
                                { { 19, 20, 21 }, 
                                  { 22, 23, 24 },
                                  { 25 , 26 , 27 }}
                                                    };

        // Get the number of dimensions
        rank = integer3d.Rank;
        Console.WriteLine("Number of dimensions: {0}", rank);
        for (int ctr = 0; ctr < integer3d.Rank - 1; ctr++)
            Console.WriteLine("   Dimension {0}: from {1} to {2}", ctr, integer3d.GetLowerBound(ctr), integer3d.GetUpperBound(ctr));

        for (int outer = integer3d.GetLowerBound(0); outer <= integer3d.GetUpperBound(0); outer++)
            for (int inner = integer3d.GetLowerBound(1); inner <= integer3d.GetUpperBound(1); inner++)
                for (int innerr = integer3d.GetLowerBound(2); innerr <= integer3d.GetUpperBound(2); innerr++)
                    Console.WriteLine("      {4}{0}, {1}, {2}{5} = {3}", outer, inner,innerr, integer3d.GetValue(outer, inner, innerr), "{", "}");

        Console.ReadLine();



    }
}
//1
//2
//3
//4
//5
//6
//7
//8
//9