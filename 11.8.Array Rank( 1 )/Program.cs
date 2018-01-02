using System;

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


        Console.WriteLine("names.Rank (number of dimensions) = " + names.Rank);
        Console.WriteLine("names.Length (number of elements) = " + names.Length);

    }
}
//names.Rank(number of dimensions) = 2
//names.Length(number of elements) = 12






    

