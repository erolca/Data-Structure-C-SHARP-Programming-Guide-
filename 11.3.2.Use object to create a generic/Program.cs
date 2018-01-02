using System;
//11.3.2.	Use object to create a generic array.


class MainClass
{
    public static void Main()
    {
        object[] ga = new object[10];

        // store ints 
        for (int i = 0; i < 3; i++)
            ga[i] = i;

        // store doubles 
        for (int i = 3; i < 6; i++)
            ga[i] = (double)i / 2;


        // store two strings, a bool, and a char 
        ga[6] = "String";
        ga[7] = true;
        ga[8] = 'X';
        ga[9] = "asdf";

        for (int i = 0; i < ga.Length; i++)
            Console.WriteLine("ga[" + i + "]: " + ga[i] + " ");

    }
}
//ga[0]: 0
//ga[1]: 1
//ga[2]: 2
//ga[3]: 1.5
//ga[4]: 2
//ga[5]: 2.5
//ga[6]: String
//ga[7]: True
//ga[8]: X
//ga[9]: asdf