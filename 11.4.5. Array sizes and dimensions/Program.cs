using System;

class MainClass
{

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; ++i)
            Console.WriteLine("OneDArray Row {0} = {1}", i, arr[i]);
    }

    public static void PrintArrayRank(int[,] arr)
    {
        Console.WriteLine("PrintArrayRank: {0} dimensions", arr.Rank);
    }


    public static void Main()
    {
        int[] x = new int[10];
        for (int i = 0; i < 10; ++i)
            x[i] = i;
        PrintArray(x);

        int[,] y = new int[10, 20];
        for (int k = 0; k < 10; ++k)
            for (int i = 0; i < 20; ++i)
                y[k, i] = i * k;
        PrintArrayRank(y);

        int[] d = new int[10];
        int[] e = d;
    }
}

//OneDArray Row 0 = 0
//OneDArray Row 1 = 1
//OneDArray Row 2 = 2
//OneDArray Row 3 = 3
//OneDArray Row 4 = 4
//OneDArray Row 5 = 5
//OneDArray Row 6 = 6
//OneDArray Row 7 = 7
//OneDArray Row 8 = 8
//OneDArray Row 9 = 9
//PrintArrayRank: 2 dimensions