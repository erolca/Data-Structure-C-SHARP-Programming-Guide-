using System;

//11.16.4.	Use the Reverse() method to reverse the elements in intArray
class MainClass
{

    public static void Main()
    {
        int[] intArray = { 5, 2, 3, 1, 6, 9, 7, 14, 25 };
        Array.Sort(intArray);

        Array.Reverse(intArray);
        Console.WriteLine("Reversed intArray:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine("intArray[" + i + "] = " +
              intArray[i]);
        }

    }

}

//Reversed intArray:
//intArray[0] = 25
//intArray[1] = 14
//intArray[2] = 9
//intArray[3] = 7
//intArray[4] = 6
//intArray[5] = 5
//intArray[6] = 3
//intArray[7] = 2
//intArray[8] = 1