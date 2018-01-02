using System;

class MainClass
{

    public static void Main()
    {

        string[] stringArray = new string[2];
        Console.WriteLine("stringArray[0] = " + stringArray[0]);
        stringArray[0] = "Hello";
        stringArray[1] = "World";
        foreach (string myString in stringArray)
        {
            Console.WriteLine("myString = " + myString);
        }

    }

}
//stringArray[0] =
//myString = Hello
//myString = World