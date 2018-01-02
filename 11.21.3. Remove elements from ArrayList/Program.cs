using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        ArrayList al = new ArrayList();

        Console.WriteLine("Adding 6 elements");
        // Add elements to the array list 
        al.Add('C');
        al.Add('A');
        al.Add('E');
        al.Add('B');
        al.Add('D');
        al.Add('F');

        Console.WriteLine("Removing 2 elements");
        // Remove elements from the array list. 
        al.Remove('F');
        al.Remove('A');

        Console.WriteLine("Number of elements: " +  al.Count);
    }

}
//Adding 6 elements
//Removing 2 elements
//Number of elements: 4