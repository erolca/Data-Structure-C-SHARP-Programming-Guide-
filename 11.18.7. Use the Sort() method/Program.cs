using System;

class MainClass
{

    public static void Main()
    {
        int[] intArray = { 5, 2, 3, 1, 6, 9, 7, 14, 25 };
        Array.Sort(intArray);
        Console.WriteLine("Sorted intArray:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine("intArray[" + i + "] = " +
              intArray[i]);
        }

    }

}
//Sorted intArray:
//intArray[0] = 1
//intArray[1] = 2
//intArray[2] = 3
//intArray[3] = 5
//intArray[4] = 6
//intArray[5] = 7
//intArray[6] = 9
//intArray[7] = 14
//intArray[8] = 25