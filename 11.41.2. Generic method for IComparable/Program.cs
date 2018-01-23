using System;

class MyClass : IComparable
{
    public int val;

    public MyClass(int x) { val = x; }

    // Implement IComparable. 
    public int CompareTo(object obj)
    {
        return val - ((MyClass)obj).val;
    }
}

class MainClass
{
    public static bool isIn<T>(T what, T[] obs) where T : IComparable
    {
        foreach (T v in obs)
            if (v.CompareTo(what) == 0) // now OK, uses CompareTo() 
                return true;

        return false;
    }

    public static void Main()
    {
        // Use isIn() with int. 
        int[] nums = { 1, 2, 3, 4, 5 };

        if (isIn(2, nums))
            Console.WriteLine("2 is found.");

        // Use isIn() with string. 
        string[] strs = { "one", "two", "Three" };

        if (isIn("two", strs))
            Console.WriteLine("two is found.");

        // Use isIn with MyClass. 
        MyClass[] mcs = { new MyClass(1), new MyClass(2),
                      new MyClass(3), new MyClass(4) };

        if (isIn(new MyClass(3), mcs))
            Console.WriteLine("MyClass(3) is found.");

        if (isIn(new MyClass(99), mcs))
            Console.WriteLine("This won't display.");
    }
}
//2 is found.
//two is found.
//MyClass(3) is found.