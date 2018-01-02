using System;

class MainClass
{

    public static void Main()
    {

        try
        {
            int[] intArray = new int[5];
            for (int i = 0; i <= intArray.Length; i++)
            {
                intArray[i] = i;
                Console.WriteLine("intArray[" + i + "] = " + intArray[i]);
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException occurred");
            Console.WriteLine("Message = " + e.Message);
            Console.WriteLine("Stack trace = " + e.StackTrace);
        }
    }
}
//intArray[0] = 0
//intArray[1] = 1
//intArray[2] = 2
//intArray[3] = 3
//intArray[4] = 4
//IndexOutOfRangeException occurred
//Message = Index was outside the bounds of the array.
//Stack trace = at MainClass.Main()