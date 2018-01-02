using System;

//11.16.6.	Use the Reverse() method to reverse the elements in charArray

class MainClass
{

    public static void Main()
    {
        char[] charArray = { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
        Array.Sort(charArray);  // sort the elements      

        Array.Reverse(charArray);
        Console.WriteLine("Reversed charArray:");
        for (int i = 0; i < charArray.Length; i++)
        {
            Console.WriteLine("charArray[" + i + "] = " + charArray[i]);
        }
    }

}
//Reversed charArray:
//charArray[0] = w
//charArray[1] = o
//charArray[2] = m
//charArray[3] = l
//charArray[4] = e
//charArray[5] = e
//charArray[6] = c