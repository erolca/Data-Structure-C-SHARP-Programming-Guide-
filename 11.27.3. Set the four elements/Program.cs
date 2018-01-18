using System;
using System.Collections;


//11.27.3.	Set the four elements of the BitArray and display the elements of the BitArray


class MainClass
{
    public static void Main()
    {
        BitArray myBitArray = new BitArray(4);

        Console.WriteLine("myBitArray.Length = " + myBitArray.Length);
        myBitArray[0] = false;
        myBitArray[1] = true;
        myBitArray[2] = true;
        myBitArray[3] = false;


        for (int i = 0; i < myBitArray.Count; i++)
        {
            Console.WriteLine("myBitArray[" + i + "] = " + myBitArray[i]);
        }
    }
}
//myBitArray.Length = 4
//myBitArray[0] = False
//myBitArray[1] = True
//myBitArray[2] = True
//myBitArray[3] = False