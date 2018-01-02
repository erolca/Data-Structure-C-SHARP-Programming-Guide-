using System;

//11.4.4.	Use the GetLength() method to get number of elements in each dimension of the two dimensional array
class MainClass
{

    public static void Main()
    {
        string[,] names = {
      {"J", "M", "P"},
      {"S", "E", "S"},
      {"C", "A", "W"},
      {"G", "P", "J"},
    };

        int numberOfRows = names.GetLength(0);
        int numberOfColumns = names.GetLength(1);
        Console.WriteLine("Number of rows = " + numberOfRows);
        Console.WriteLine("Number of columns = " + numberOfColumns);

        int[,] id = new int[4, 5];
        numberOfRows = id.GetLength(0);
        numberOfColumns = id.GetLength(1);



    }
}
//Number of rows = 4
//Number of columns = 3