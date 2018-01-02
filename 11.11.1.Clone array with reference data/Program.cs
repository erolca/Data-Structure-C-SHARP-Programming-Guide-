using System;

class MyClass
{
    public int Value = 5;
}

class MainClass
{
    static void Main()
    {

        //Clone array with reference data inside
        MyClass[] orignalArray = new MyClass[3] { new MyClass(), new MyClass(), new MyClass() };

        MyClass[] cloneArray = (MyClass[])orignalArray.Clone();

        cloneArray[0].Value = 1;
        cloneArray[1].Value = 2;
        cloneArray[2].Value = 3;

        // klon ile aynı referansı gostermektedir..
        foreach (MyClass a in orignalArray)
            Console.WriteLine(a.Value);

        foreach (MyClass a in cloneArray)
            Console.WriteLine(a.Value);
    }
}
//1
//2
//3
//1
//2
//3








