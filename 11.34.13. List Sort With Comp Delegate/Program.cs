using System;
using System.Collections;
using System.Collections.Generic;

//11.34.13.	List Sort With Comparison Delegate

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

    public static List<Product> GetSampleProducts()
    {
        List<Product> list = new List<Product>();
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

class ListSortWithComparisonDelegate
{
    static void Main()
    {
        List<Product> products = Product.GetSampleProducts();
        products.Sort(delegate (Product first, Product second)
        { return first.Name.CompareTo(second.Name); }
        );
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}