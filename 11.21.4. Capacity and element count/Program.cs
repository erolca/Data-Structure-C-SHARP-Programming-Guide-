using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        ArrayList al = new ArrayList();

        Console.WriteLine("Adding 6 elements");
        al.Add('C');
        al.Add('A');
        al.Add('E');
        al.Add('B');
        al.Add('D');
        al.Add('F');

        Console.WriteLine("Add enough elements to force ArrayList to grow. Adding 20 more elements");

        for (int i = 0; i < 20; i++)
            al.Add((char)('a' + i));
        Console.WriteLine("Current capacity: " +
                           al.Capacity);
        Console.WriteLine("Number of elements after adding 20: " +
                           al.Count);
        Console.Write("Contents: ");
        foreach (char c in al)
            Console.Write(c + " ");


        Console.WriteLine("\n");
    }
}
//Adding 6 elements
//Add enough elements to force ArrayList to grow.Adding 20 more elements
//Current capacity: 32
//Number of elements after adding 20: 26
//Contents: C A E B D F a b c d e f g h i j k l m n o p q r s t