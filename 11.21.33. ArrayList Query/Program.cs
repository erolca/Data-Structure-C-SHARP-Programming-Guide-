using System;
using System.Collections;
using System.ComponentModel;

public class Product
{
    string name;
    public string Name
    {
        get { return name; }
    }

    decimal price;
    public decimal Price
    {
        get { return price; }
    }

    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public static ArrayList GetSampleProducts()
    {
        ArrayList list = new ArrayList();
        list.Add(new Product("C", 9.99m));
        list.Add(new Product("A", 1.99m));
        list.Add(new Product("F", 2.99m));
        list.Add(new Product("S", 3.99m));
        return list;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }
}
class ArrayListSort
{
    class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }
    }

    static void Main()
    {
        ArrayList products = Product.GetSampleProducts();
        products.Sort(new ProductNameComparer());
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}