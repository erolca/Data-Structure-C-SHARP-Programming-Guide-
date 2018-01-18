using System;
using System.Collections;


	//11.27.5.	Use the Not() method to reverse the elements in BitArray

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


        myBitArray.Not();
        DisplayBitArray("myBitArray", myBitArray);

    }

}
//myBitArray[0] = False
//myBitArray[1] = True
//myBitArray[2] = True
//myBitArray[3] = False

//myBitArray[0] = True
//myBitArray[1] = False
//myBitArray[2] = False
//myBitArray[3] = True