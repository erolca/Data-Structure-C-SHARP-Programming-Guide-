using System;

class Stack
{
    char[] stck; // holds the stack  
    int tos;     // index of the top of the stack  

    public Stack(int size)
    {
        stck = new char[size]; // allocate memory for stack   
        tos = 0;
    }

    public void push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine(" -- Stack is full.");
            return;
        }

        stck[tos] = ch;
        tos++;
    }

    public char pop()
    {
        if (tos == 0)
        {
            Console.WriteLine(" -- Stack is empty.");
            return (char)0;
        }

        tos--;
        return stck[tos];
    }

    public bool full()
    {
        return tos == stck.Length;
    }

    public bool empty()
    {
        return tos == 0;
    }

    public int capacity()
    {
        return stck.Length;
    }

    public int getNum()
    {
        return tos;
    }
}

class MainClass
{
    public static void Main()
    {
        Stack stk1 = new Stack(10);
        Stack stk2 = new Stack(10);
        Stack stk3 = new Stack(10);
        char ch;
        int i;

        Console.WriteLine("Push A through J onto stk1.");
        for (i = 0; !stk1.full(); i++)
            stk1.push((char)('A' + i));

        if (stk1.full())
            Console.WriteLine("stk1 is full.");

        Console.Write("Contents of stk1: ");
        while (!stk1.empty())
        {
            ch = stk1.pop();
            Console.Write(ch);
        }

        Console.WriteLine();

        if (stk1.empty())
            Console.WriteLine("stk1 is empty.\n");

        Console.WriteLine("Again push A through J onto stk1.");
        for (i = 0; !stk1.full(); i++)
            stk1.push((char)('A' + i));

        Console.WriteLine("Now, pop chars from stk1 and push " +
                          "them onto stk2.");
        while (!stk1.empty())
        {
            ch = stk1.pop();
            stk2.push(ch);
        }

        Console.Write("Contents of stk2: ");
        while (!stk2.empty())
        {
            ch = stk2.pop();
            Console.Write(ch);
        }


        Console.WriteLine("Capacity of stk2: " + stk2.capacity());
        Console.WriteLine("Number of objects in stk2: " +
                          stk2.getNum());

    }
}
//Push A through J onto stk1.
//stk1 is full.
//Contents of stk1: JIHGFEDCBA
//stk1 is empty.

//Again push A through J onto stk1.
//Now, pop chars from stk1 and push them onto stk2.
//Contents of stk2: ABCDEFGHIJCapacity of stk2: 10
//Number of objects in stk2: 0