using System;
using System.Collections;

//11.21.12.	Create a string array and use the ICollection.CopyTo method to copy the contents of the ArrayList
//Copies the entire ArrayList to a compatible one-dimensional Array, starting at the beginning of the target array.

class MainClass
{
    public static void Main(string[] args)
    {
        // Create a new ArrayList and populate it.
        ArrayList list = new ArrayList(5);
        list.Add("B");
        list.Add("G");
        list.Add("J");
        list.Add("S");
        list.Add("M");


        string[] array1 = new string[list.Count];
        list.CopyTo(array1, 0);

        Console.WriteLine("Array 1:");
        foreach (string s in array1)
        {
            Console.WriteLine("\t{0}", s);
        }


        // https://msdn.microsoft.com/en-us/library/y1xf28a9(v=vs.110).aspx

        // Creates and initializes the source ArrayList.
        ArrayList mySourceList = new ArrayList();
        mySourceList.Add("three");
        mySourceList.Add("napping");
        mySourceList.Add("cats");
        mySourceList.Add("in");
        mySourceList.Add("the");
        mySourceList.Add("barn");
        // Creates and initializes the one-dimensional target Array.
        String[] myTargetArray = new String[15];
        myTargetArray[0] = "The";
        myTargetArray[1] = "quick";
        myTargetArray[2] = "brown";
        myTargetArray[3] = "fox";
        myTargetArray[4] = "jumped";
        myTargetArray[5] = "over";
        myTargetArray[6] = "the";
        myTargetArray[7] = "lazy";
        myTargetArray[8] = "dog";

        // Displays the values of the target Array.
        Console.WriteLine("The target Array contains the following (before and after copying):");
        PrintValues(myTargetArray, ' ');

        // Copies the second element from the source ArrayList to the target Array starting at index 7.
        mySourceList.CopyTo(1, myTargetArray, 7, 1);

        // Displays the values of the target Array.
        PrintValues(myTargetArray, ' ');

        // Copies the entire source ArrayList to the target Array starting at index 6.
        mySourceList.CopyTo(myTargetArray, 6);

        // Displays the values of the target Array.
        PrintValues(myTargetArray, ' ');

        // Copies the entire source ArrayList to the target Array starting at index 0.
        mySourceList.CopyTo(myTargetArray);

        // Displays the values of the target Array.
        PrintValues(myTargetArray, ' ');

    }

    public static void PrintValues(String[] myArr, char mySeparator)
    {
        for (int i = 0; i < myArr.Length; i++)
            Console.Write("{0}{1}", mySeparator, myArr[i]);
        Console.WriteLine();
    }

}
//Array 1:
//        B
//        G
//        J
//        S
//        M

/* 
This code produces the following output.

The target Array contains the following (before and after copying):
The quick brown fox jumped over the lazy dog
The quick brown fox jumped over the napping dog
The quick brown fox jumped over three napping cats in the barn
three napping cats in the barn three napping cats in the barn
*/
