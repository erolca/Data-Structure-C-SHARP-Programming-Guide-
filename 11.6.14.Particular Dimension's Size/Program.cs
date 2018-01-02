class MainClass
{
    static void Main()
    {
        bool[,,] cells;
        cells = new bool[2, 3, 3];
        System.Console.WriteLine(cells.GetLength(0));   // Displays 2

    }
}