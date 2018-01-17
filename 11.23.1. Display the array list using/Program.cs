using System;
using System.Collections;

//	11.23.1.	Display the array list using array indexing


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

        Console.Write("Current contents: ");
        for (int i = 0; i < al.Count; i++)
            Console.Write(al[i] + " ");
        Console.WriteLine("\n");
    }

}
//Adding 6 elements
//Current contents: C A E B D F