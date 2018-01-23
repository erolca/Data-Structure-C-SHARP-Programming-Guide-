using System.Text;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

//11.34.7.	List Joining Ordering And Filtering With Linq


class ProductWithSupplierID
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int SupplierID { get; private set; }

    public ProductWithSupplierID(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    ProductWithSupplierID()
    {
    }

    public static List<ProductWithSupplierID> GetSampleProducts()
    {
        return new List<ProductWithSupplierID>
            {
                new ProductWithSupplierID { Name="C", Price = 9.99m, SupplierID=1 },
                new ProductWithSupplierID { Name="A", Price=14.99m, SupplierID=2 },
                new ProductWithSupplierID { Name="F", Price=13.99m, SupplierID=1 },
                new ProductWithSupplierID { Name="S", Price=10.99m, SupplierID=3}
            };
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", Name, Price);
    }
}
class Supplier
{
    public string Name { get; private set; }
    public int SupplierID { get; private set; }

    Supplier()
    {
    }

    public static List<Supplier> GetSampleSuppliers()
    {
        return new List<Supplier>
            {
                new Supplier { Name="S", SupplierID=1 },
                new Supplier { Name="C", SupplierID=2 },
                new Supplier { Name="B", SupplierID=3 }
            };
    }
}
class ListJoiningOrderingAndFilteringWithLinq
{
    static void Main()
    {
        List<ProductWithSupplierID> products = ProductWithSupplierID.GetSampleProducts();
        List<Supplier> suppliers = Supplier.GetSampleSuppliers();
        var filtered = from p in products
                       join s in suppliers
                       on p.SupplierID equals s.SupplierID
                       where p.Price > 10
                       orderby s.Name, p.Name
                       select new
                       {
                           SupplierName = s.Name,
                           ProductName = p.Name
                       };
        foreach (var v in filtered)
        {
            Console.WriteLine("Supplier={0}; Product={1}",
                              v.SupplierName, v.ProductName);
        }
    }
}