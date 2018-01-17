using System;
using System.Collections;


//	11.22.3.	Add object with IComparable interface implementation to an ArrayList
// Implement the non-generic IComparable interface. 
class Product : IComparable
{
    string name;
    double cost;
    int onhand;

    public Product(string n, double c, int h)
    {
        name = n;
        cost = c;
        onhand = h;
    }

    public override string ToString()
    {
        return
          String.Format("{0,-10}Cost: {1,6:C}  On hand: {2}",
                        name, cost, onhand);
    }

    // Implement the IComparable interface. 
    public int CompareTo(object obj)
    {
        Product b;
        b = (Product)obj;
        return name.CompareTo(b.name);
    }
}

class MainClass
{
    public static void Main()
    {
        ArrayList inv = new ArrayList();

        // Add elements to the list 
        inv.Add(new Product("A", 5.5, 3));
        inv.Add(new Product("B", 8.9, 2));
        inv.Add(new Product("D", 1.8, 8));
        inv.Add(new Product("C", 3.0, 4));

        Console.WriteLine("Product list before sorting:");
        foreach (Product i in inv)
        {
            Console.WriteLine("   " + i);
        }
        Console.WriteLine();

        // Sort the list. 
        inv.Sort();

        Console.WriteLine("Product list after sorting:");
        foreach (Product i in inv)
        {
            Console.WriteLine("   " + i);
        }
    }
}
//Product list before sorting:
//   A Cost:  $5.50  On hand: 3
//   B Cost:  $8.90  On hand: 2
//   D Cost:  $1.80  On hand: 8
//   C Cost:  $3.00  On hand: 4


//Product list after sorting:
//   A Cost:  $5.50  On hand: 3
//   B Cost:  $8.90  On hand: 2
//   C Cost:  $3.00  On hand: 4
//   D Cost:  $1.80  On hand: 8