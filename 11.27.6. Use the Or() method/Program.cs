using System;
using System.Collections;

class MainClass
{
    public static void DisplayBitArray(string arrayListName, BitArray myBitArray)
    {
        for (int i = 0; i < myBitArray.Count; i++)
        {
            Console.WriteLine(arrayListName + "[" + i + "] = " + myBitArray[i]);
        }
    }

    public static void Main()
    {
        BitArray myBitArray = new BitArray(4);
        myBitArray[0] = false;
        myBitArray[1] = true;
        myBitArray[2] = true;
        myBitArray[3] = false;
        DisplayBitArray("myBitArray", myBitArray);


        BitArray anotherBitArray = new BitArray(myBitArray);
        DisplayBitArray("anotherBitArray", myBitArray);

        myBitArray.Not();
        DisplayBitArray("myBitArray", myBitArray);


        myBitArray.Or(anotherBitArray);
        DisplayBitArray("myBitArray", myBitArray);


    }

}
//myBitArray[0] = False
//myBitArray[1] = True
//myBitArray[2] = True
//myBitArray[3] = False

//anotherBitArray[0] = False
//anotherBitArray[1] = True
//anotherBitArray[2] = True
//anotherBitArray[3] = False

//myBitArray[0] = True
//myBitArray[1] = False
//myBitArray[2] = False
//myBitArray[3] = True
//myBitArray[0] = True
//myBitArray[1] = True
//myBitArray[2] = True
//myBitArray[3] = True