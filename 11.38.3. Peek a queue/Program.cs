using System;
using System.Collections;
using System.Collections.Specialized;

class MyClass
{
    public string MyName = "A";
}

class MainClass
{
    static void Main(string[] args)
    {
        Queue classQueue = new Queue();
        classQueue.Enqueue(new MyClass());
        classQueue.Enqueue(new MyClass());
        classQueue.Enqueue(new MyClass());

        // Peek at first car in Q.
        Console.WriteLine("First in Q is {0}",
          ((MyClass)classQueue.Peek()).MyName);
    }
}
//First in Q is A