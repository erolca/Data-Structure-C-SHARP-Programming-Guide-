using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        ArrayList al = new ArrayList();

        Console.WriteLine("Initial number of elements: " + al.Count);

        Console.WriteLine("Adding 6 elements");
        // Add elements to the array list 
        al.Add('C');
        al.Add('A');
        al.Add('E');
        al.Add('B');
        al.Add('D');
        al.Add('F');

        Console.WriteLine("Number of elements: " + al.Count);
    }
}
//Initial number of elements: 0
//Adding 6 elements
//Number of elements: 6