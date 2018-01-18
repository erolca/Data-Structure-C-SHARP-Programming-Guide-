using System;
using System.Collections;


//11.27.4.	Use copy constructor in BitArray


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