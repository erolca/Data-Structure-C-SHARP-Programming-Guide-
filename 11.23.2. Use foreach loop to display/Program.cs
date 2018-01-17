using System;
using System.Collections;


//11.23.2.	Use foreach loop to display the ArrayList


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

        // Use foreach loop to display the list. 
        Console.Write("Contents: ");
        foreach (char c in al)
            Console.Write(c + " ");
        Console.WriteLine("\n");

    }
}
//Adding 6 elements
//Contents: C A E B D F