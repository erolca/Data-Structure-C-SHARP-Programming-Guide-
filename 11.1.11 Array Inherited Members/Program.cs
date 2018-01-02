using System;


//11.1.11.	Array Inherited Members: Rank and Length
class MainClass
{
    static void Main()
    {
        int[] arr = new int[] { 15, 20, 5, 25, 10 };

        Console.WriteLine("Rank = {0}, Length = {1}", arr.Rank, arr.Length);
    }
}
//Rank = 1, Length = 5