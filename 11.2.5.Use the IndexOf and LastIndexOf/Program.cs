using System;

class MainClass
{

    public static void Main()
    {
        string[] stringArray = { "Hello", "to", "everyone", "Hello", "all" };
        Console.WriteLine("stringArray:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine("stringArray[" + i + "] = " + stringArray[i]);
        }


        int index = Array.IndexOf(stringArray, "Hello");
        Console.WriteLine("Array.IndexOf(stringArray, \"Hello\") = " + index);
        index = Array.LastIndexOf(stringArray, "Hello");
        Console.WriteLine("Array.LastIndexOf(stringArray, \"Hello\") = " + index);

    }

}
//stringArray:
//stringArray[0] = Hello
//stringArray[1] = to
//stringArray[2] = everyone
//stringArray[3] = Hello
//stringArray[4] = all
//Array.IndexOf(stringArray, "Hello") = 0
//Array.LastIndexOf(stringArray, "Hello") = 3