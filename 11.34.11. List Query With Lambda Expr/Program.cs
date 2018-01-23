using System.Text;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

//11.34.11.	List Query With Lambda Expression


class Product
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    Product()
    {
    }

    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
            {
                new Product { Name="C", Price=9.99m },
                new Product { Name="A", Price=14.99m },
                new Product { Name="F", Price=13.99m },
                new Product { Name="S", Price=10.99m}
            };
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", Name, Price);
    }
}
class ListQueryWithLambdaExpression
{
    static void Main()
    {
        List<Product> products = Product.GetSampleProducts();
        foreach (Product product in products.Where(p => p.Price > 10))
        {
            Console.WriteLine(product);
        }
    }
}