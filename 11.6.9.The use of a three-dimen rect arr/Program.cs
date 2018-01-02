using System;
//11.6.9.	The use of a three-dimensional rectangular array

class MainClass
{

    public static void Main()
    {
        int[,,] intArray = new int[10, 5, 3];

        intArray[1, 3, 2] = 3;
        intArray[4, 1, 2] = 9;

        Console.WriteLine("intArray.Rank (number of dimensions) = " + intArray.Rank);
        Console.WriteLine("intArray.Length (number of elements) = " + intArray.Length);

        for (int x = 0; x < intArray.GetLength(0); x++)
        {
            for (int y = 0; y < intArray.GetLength(1); y++)
            {
                for (int z = 0; z < intArray.GetLength(2); z++)
                {
                    if (intArray[x, y, z] != 0)
                    {
                        Console.WriteLine("intArray[" + x + ", " + y + ", " + z + "] = " + intArray[x, y, z]);
                    }
                }
            }
        }

    }

}
//intArray.Rank(number of dimensions) = 3
//intArray.Length(number of elements) = 150
//intArray[1, 3, 2] = 3
//intArray[4, 1, 2] = 9