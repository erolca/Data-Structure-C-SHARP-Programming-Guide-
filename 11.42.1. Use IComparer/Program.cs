using System;
using System.Collections;

// Create an IComparer for Product objects. 
class ProductComparer : IComparer
{
    // Implement the IComparable interface. 
    public int Compare(object obj1, object obj2)
    {
        Product a, b;
        a = (Product)obj1;
        b = (Product)obj2;
        return a.name.CompareTo(b.name);
    }
}

class Product
{
    public string name;
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
}

class IComparerDemo
{
    public static void Main()
    {
        ProductComparer comp = new ProductComparer();
        ArrayList inv = new ArrayList();

        // Add elements to the list 
        inv.Add(new Product("A", 5.5, 3));
        inv.Add(new Product("B", 8.9, 2));
        inv.Add(new Product("C", 3.0, 4));
        inv.Add(new Product("D", 1.8, 8));

        Console.WriteLine("Product list before sorting:");
        foreach (Product i in inv)
        {
            Console.WriteLine("   " + i);
        }
        Console.WriteLine();

        // Sort the list using an IComparer. 
        inv.Sort(comp);

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
//   C Cost:  $3.00  On hand: 4
//   D Cost:  $1.80  On hand: 8

//Product list after sorting:
//   A Cost:  $5.50  On hand: 3
//   B Cost:  $8.90  On hand: 2
//   C Cost:  $3.00  On hand: 4
//   D Cost:  $1.80  On hand: 8