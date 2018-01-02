using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


public class MainClass
{

    public static void Main()
    {
        int[] srcArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] destArray = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,21 ,22, 23 };

        Array.Copy(srcArray, destArray, srcArray.Length);
        srcArray.CopyTo(destArray, 0);
        srcArray.CopyTo(destArray, 3);
        Array.Copy(srcArray, 0, destArray, 3, srcArray.Length);

    }
}