using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class MainClass
{
    static void Main()
    {
        Customers customers = new Customers();
        foreach (Customer c in customers)
        {
            System.Console.WriteLine(c.Name + ", " + c.Phone);
        }
    }
}

public class Customers : ReadOnlyCollectionBase
{
    public Customers()
    {
        ReadCustomers();
    }

    public Customer this[int index]
    {
        get
        {
            return (Customer)InnerList[index];
        }
    }


    public Customer this[string name]
    {
        get
        {
            return (Customer)this[Find(name)];
        }
    }

    private int Find(string name)
    {
        for (int i = 0; i < Count - 1; i++)
        {
            if (this[i].Name.Equals(name)) return i;
        }
        return -1;
    }

    private void ReadCustomers()
    {
        InnerList.Add(new Customer("A", "(666) 555-1212"));
        InnerList.Add(new Customer("M", "(503) 555-1212"));
    }
}

public class Customer
{

    public Customer(string name, string phone)
    {
        this.Name = name;
        this.Phone = phone;
    }

    public string Name;

    public string Phone;
}