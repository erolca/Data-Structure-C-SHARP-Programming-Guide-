using System;

class MyClass
{
    public int i;

    public MyClass(int x)
    {
        i = x;
    }
}

class MainClass
{

    static void neg(MyClass o)
    {
        o.i = -o.i;
    }

    public static void Main()
    {
        MyClass[] nums = new MyClass[5];

        nums[0] = new MyClass(5);
        nums[1] = new MyClass(2);
        nums[2] = new MyClass(3);
        nums[3] = new MyClass(4);
        nums[4] = new MyClass(1);

        // Use action to negate the values. 
        Array.ForEach(nums, MainClass.neg);

    }
}