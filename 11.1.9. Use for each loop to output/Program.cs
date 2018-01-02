using System;


//11.1.9.	Use for each loop to output elements in an array
class MainClass
{
    public static void Main()
    {
        string s = "A B C D E";
        char[] separators = { ' ' };
        string[] words = s.Split(separators);

        foreach (object obj in words)
            Console.WriteLine("Word: {0}", obj);
    }
}
//Word: A
//Word: B
//Word: C
//Word: D
//Word: E