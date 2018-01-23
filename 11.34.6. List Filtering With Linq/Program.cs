using System.Text;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Collections;


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


    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }
}
class ListFilteringWithLinq
{

    public static List<Product> GetSampleProducts()
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("C", 9.99m));
        list.Add(new Product("A", 1.99m));
        list.Add(new Product("F", 2.99m));
        list.Add(new Product("S", 3.99m));
        return list;
    }
    static void Main()
    {
        List<Product> products = GetSampleProducts();
        var filtered = from Product p in products

                       where p.Price > 10
                       select p;
        foreach (Product product in filtered)
        {
            Console.WriteLine(product);
        }
    }
}