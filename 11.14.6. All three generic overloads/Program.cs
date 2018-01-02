using System;

public class Example
{
    public static void Main()
    {
        string[] dinosaurs = { "A", "B", "C", "F", "D", "A", "E" };

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nArray.IndexOf(dinosaurs, \"A\"): {0}", Array.IndexOf(dinosaurs, "A"));

        Console.WriteLine("\nArray.IndexOf(dinosaurs, \"A\", 3): {0}", Array.IndexOf(dinosaurs, "A", 3));

        Console.WriteLine("\nArray.IndexOf(dinosaurs, \"A\", 2, 2): {0}", Array.IndexOf(dinosaurs, "A", 2, 2));
       // Console.WriteLine("\nArray.IndexOf(dinosaurs, \"A\", 2, 2): {0}", Array.IndexOf(dinosaurs, "A", 0, 2));
    }
}