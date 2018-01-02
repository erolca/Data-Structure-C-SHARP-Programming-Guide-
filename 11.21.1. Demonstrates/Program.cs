using System;
using System.Collections;


//11.21.1.	Demonstrates the 3 constructors of ArrayList

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        ArrayList al1 = new ArrayList();
        ArrayList al2 = new ArrayList(10);


        int[] intArr = new int[10];// veya  { 1,2, 3, 4, 5, 6, 7, 8, 9,0 };
       // int[] intArr = new int[10]  { 1,2, 3, 4, 5, 6, 7, 8, 9,0 };

        ArrayList al3 = new ArrayList(intArr);

        ArrayList myArrayList = new ArrayList();
        myArrayList.Capacity = 10;

        intArr = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10};

        myArrayList.Add(1);
        myArrayList.AddRange(intArr); //Adds the elements of an ICollection to the end of the ArrayList
        Console.WriteLine(myArrayList.Capacity);

        myArrayList.Remove(1);
        myArrayList.RemoveRange(1, 2);

        myArrayList.Insert(1, 3); //İçine bir öğe ekler ArrayList belirtilen dizindeki.
        /*public virtual void Insert(int index,object value)*/

        myArrayList.InsertRange(0, intArr); //Inserts the elements of a collection into the ArrayList at the specified index.

        //public virtual void InsertRange(int index, ICollection c)

        foreach (object elem in myArrayList)
        {
            Console.WriteLine(elem);
        }
    }
}