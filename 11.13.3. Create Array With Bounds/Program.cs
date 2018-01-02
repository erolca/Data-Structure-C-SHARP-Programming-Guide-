using System;

//Public Shared Function CreateInstance (elementType As Type,length As Integer) As Array

public class MainClass
{
    static void Main()
    {
        // Creates and initializes a one-dimensional Array of type Int32.
        Array my1DArray = Array.CreateInstance(typeof(Int32), 5);



        int[] lengthsArray = new int[2] { 3, 5 };
        int[] boundsArray = new int[2] { 2, 3 };
        Array multiDimensionalArray = Array.CreateInstance(typeof(String), lengthsArray, boundsArray);
        for (int i = 0; i < multiDimensionalArray.Rank; i++)
            Console.WriteLine("{0}:\t{1}\t{2}", i, multiDimensionalArray.GetLowerBound(i), multiDimensionalArray.GetUpperBound(i));
    }
}