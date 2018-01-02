using System;
using System.Drawing;
using System.Reflection;


//11.14.3.	Use Array.Find to find array elements end with s

public class Example
{
    public static void Main()
    {
        string[] letters = { "E", "B", "A", "Z", "D", "X", "Y", "Q" };

        Console.WriteLine();
        foreach (string letter in letters)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("\nArray.Find(letters, EndsWithS): {0}", Array.Find(letters, EndsWithS));



        //Console-2
        // Create an array of five Point structures.
        Point[] points = { new Point(100, 200),
            new Point(150, 250), new Point(250, 375),
            new Point(275, 395), new Point(295, 450) };

        // Find the first Point structure for which X times Y 
        // is greater than 100000. 
        Point first = Array.Find(points, p => p.X * p.Y > 100000);
        
        // Display the first structure found.
        Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);

    }


    private static bool EndsWithS(String s)
    {
        if ((s.Length > 5) &&
            (s.Substring(s.Length - 6).ToLower() == "s"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    // for consol-2
    private class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }


}

// The example displays the following output:
// Found: X = 275, Y = 395  