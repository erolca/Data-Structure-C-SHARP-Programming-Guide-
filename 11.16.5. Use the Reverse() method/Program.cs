using System;
//	11.16.5.	Use the Reverse() method to reverse the elements in stringArray


class MainClass
{

    public static void Main()
    {
        string[] stringArray = { "t", "i", "a", "test", "abc123", "abc345" };
        Array.Sort(stringArray);

        Array.Reverse(stringArray);
        Console.WriteLine("Reversed stringArray:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine("stringArray[" + i + "] = " + stringArray[i]);
        }
    }

}
//Reversed stringArray:
//stringArray[0] = test
//stringArray[1] = t
//stringArray[2] = i
//stringArray[3] = abc345
//stringArray[4] = abc123
//stringArray[5] = a








