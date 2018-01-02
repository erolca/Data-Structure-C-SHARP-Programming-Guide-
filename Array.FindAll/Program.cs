using System;

//Exists
//Find
//FindAll
//FindIndex
//FindLastIndex

public class Example
{
    public static void Main()
    {
        string[] dinosaurs = { "Compsognathus",
            "Amargasaurus",   "Oviraptor",      "Velociraptor",
            "Deinonychus",    "Dilophosaurus",  "Gallimimus",
            "Triceratops" };

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine(
            "\nArray.Exists(dinosaurs, EndsWithSaurus): {0}",
            Array.Exists(dinosaurs, EndsWithSaurus));

        Console.WriteLine(
            "\nArray.TrueForAll(dinosaurs, EndsWithSaurus): {0}",
            Array.TrueForAll(dinosaurs, EndsWithSaurus));

        Console.WriteLine(
            "\nArray.Find(dinosaurs, EndsWithSaurus): {0}",
            Array.Find(dinosaurs, EndsWithSaurus));

        Console.WriteLine(
            "\nArray.FindLast(dinosaurs, EndsWithSaurus): {0}",
            Array.FindLast(dinosaurs, EndsWithSaurus));

        Console.WriteLine(
            "\nArray.FindAll(dinosaurs, EndsWithSaurus):");
        string[] subArray =
            Array.FindAll(dinosaurs, EndsWithSaurus);

        foreach (string dinosaur in subArray)
        {
            Console.WriteLine(dinosaur);
        }
    }

    // Search predicate returns true if a string ends in "saurus".
    private static bool EndsWithSaurus(String s)
    {
        if ((s.Length > 5) &&
            (s.Substring(s.Length - 6).ToLower() == "saurus"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

/* This code example produces the following output:

Compsognathus
Amargasaurus
Oviraptor
Velociraptor
Deinonychus
Dilophosaurus
Gallimimus
Triceratops

Array.Exists(dinosaurs, EndsWithSaurus): True

Array.TrueForAll(dinosaurs, EndsWithSaurus): False

Array.Find(dinosaurs, EndsWithSaurus): Amargasaurus

Array.FindLast(dinosaurs, EndsWithSaurus): Dilophosaurus

Array.FindAll(dinosaurs, EndsWithSaurus):
Amargasaurus
Dilophosaurus
 */
