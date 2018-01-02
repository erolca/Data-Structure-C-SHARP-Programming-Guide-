using System;
using System.Collections;


//	11.21.5.	Change contents using array indexing

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

        // 
        Console.WriteLine("Change first three elements");
        al[0] = 'X';
        al[1] = 'Y';
        al[2] = 'Z';
        Console.Write("Contents: ");
        foreach (char c in al)
            Console.Write(c + " ");
        Console.WriteLine();
    }
}
//Adding 6 elements
//Change first three elements
//Contents: X Y Z B D F