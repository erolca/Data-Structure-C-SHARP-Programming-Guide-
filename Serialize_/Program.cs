using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DemoCustomer
{
    // These fields hold the values for the public properties.
    private Guid idValue = Guid.NewGuid();
    private string customerNameValue = String.Empty;
    private string phoneNumberValue = String.Empty;


    // The constructor is private to enforce the factory pattern.
    public DemoCustomer()
    {
        customerNameValue = "Customer";
        phoneNumberValue = "(312)555-0100";
    }

    // This is the public factory method.
    public static DemoCustomer CreateNewCustomer()
    {
        return new DemoCustomer();
    }

    // This property represents an ID, suitable
    // for use as a primary key in a database.
    public Guid ID
    {
        get
        {
            return this.idValue;
        }
    }

    public string CustomerName
    {
        get
        {
            return this.customerNameValue;
        }

        set
        {
            if (value != this.customerNameValue)
            {
                this.customerNameValue = value;

            }
        }
    }

    public string PhoneNumber
    {
        get
        {
            return this.phoneNumberValue;
        }

        set
        {
            if (value != this.phoneNumberValue)
            {
                this.phoneNumberValue = value;

            }
        }
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        ArrayList customerList = new ArrayList();
        customerList.AddRange(new DemoCustomer[] { new DemoCustomer(),
                                           new DemoCustomer(),
                                           new DemoCustomer()});

        customerList.Add(DemoCustomer.CreateNewCustomer());


        Console.WriteLine("Items in List: {0}", customerList.Count);


        BinarySerialize(customerList);

        ArrayList binaryPeople = BinaryDeserialize();

        Console.WriteLine("Binary people:");
        foreach (string s in binaryPeople)
        {
            Console.WriteLine("\t" + s);
        }





    }



    private static void BinarySerialize(ArrayList list)
    {
        using (FileStream str = File.Create("people.bin"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(str, list);
        }
    }

    // Deserialize an ArrayList object from a binary file.
    private static ArrayList BinaryDeserialize()
    {
        ArrayList people = null;

        using (FileStream str = File.OpenRead("people.bin"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            people = (ArrayList)bf.Deserialize(str);
        }
        return people;
    }



}
//Items in List: 4
//ID: 83337ab7-22b1-4e51-9b07-af3a7eacf33c
//CustomerName: Customer
//PhoneNumber: (312)555-0100

//ID: 67bd9280-f6fc-405b-ab6d-65fc866ad344
//CustomerName: Customer
//PhoneNumber: (312)555-0100

//ID: c6cd00cc-a947-4671-a301-caa99577814d
//CustomerName: Customer
//PhoneNumber: (312)555-0100

//ID: d9a9dd00-ea9c-4708-b134-9ab3a0c829d2
//CustomerName: Customer
//PhoneNumber: (312)555-0100