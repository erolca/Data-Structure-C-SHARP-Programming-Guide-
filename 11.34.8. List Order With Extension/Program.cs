using System.Text;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
class ListOrderWithExtensionMethod
{
    static void Main()
    {
        List<Product> products = Product.GetSampleProducts();

        foreach (Product product in products.OrderBy(d => d.Name))
        {
            Console.WriteLine(product);
        }
    }
}