using System;
using System.Collections;

class StackDemo
{


    public static void Main()
    {
        Stack st = new Stack();

        st.Push(1);
        st.Push(2);

        foreach (int i in st)
            Console.Write(i + " ");

        st.Push(1);

        Console.Write("stack: ");
        foreach (int i in st)
            Console.Write(i + " ");

        Console.WriteLine();


        Console.Write("Pop -> ");
        int a = (int)st.Pop();
        Console.WriteLine(a);

        Console.Write("stack: ");
        foreach (int i in st)
            Console.Write(i + " ");

        Console.WriteLine();

    }
}
//2 1 stack: 1 2 1
//Pop -> 1
//stack: 2 1