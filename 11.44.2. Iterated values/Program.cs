using System;
using System.Collections;
//11.44.2.	Iterated values can be dynamically constructed.
class MyClass
{
    char ch = 'A';

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < 26; i++)
            yield return (char)(ch + i);
    }
}

class MainClass
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        foreach (char ch in mc)
            Console.Write(ch + " ");

        Console.WriteLine();
    }
}
//A B C D E F G H I J K L M N O P Q R S T U V W X Y Z