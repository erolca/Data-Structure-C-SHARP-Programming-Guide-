using System;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {

        string[,,] arr1 = new string[3, 2, 3];

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                for (int z = 0; z < 3; z++)
                    arr1[row, col, z] = row + "," + col + "," + z;
            }
        }

        foreach (string elem in arr1)
        {
            Console.WriteLine(elem);
        }
    }
}