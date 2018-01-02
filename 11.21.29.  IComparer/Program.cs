using System;
using System.Collections;

//11.21.29.	Sort arraylist using custom IComparer


class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        string input;
        ArrayList alPeople = new ArrayList();
        input = Console.ReadLine();

        alPeople.Add(new Person("a", "b"));
        alPeople.Add(new Person("x", "x"));
        alPeople.Add(new Person("y", "y"));
        alPeople.Add(new Person("z", "z"));

        Console.WriteLine("\nArray before sort");
        foreach (Person p in alPeople)
        {
            Console.WriteLine("   {0} {1}", p.firstName, p.lastName);
        }
        // sort arraylist using custom IComparer
        alPeople.Sort(new Person());

        // output sorted array
        Console.WriteLine("\nArray after sort");
        foreach (Person p in alPeople)
        {
            Console.WriteLine("   {0} {1}", p.firstName, p.lastName);
        }
    }
}

struct Person : IComparer
{
    public string firstName;
    public string lastName;

    public Person(string first, string last)
    {
        firstName = first;
        lastName = last;
    }

    public int Compare(object a, object b)
    {
        int lNameCmp;
        int fNameCmp;

        Person pa = (Person)a;
        Person pb = (Person)b;

        lNameCmp = String.Compare(pa.lastName, pb.lastName);
        if (lNameCmp != 0) return lNameCmp;

        fNameCmp = String.Compare(pa.firstName, pb.firstName);

        return fNameCmp;
    }
}