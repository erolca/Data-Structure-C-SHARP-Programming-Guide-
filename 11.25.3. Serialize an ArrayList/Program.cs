using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;

class MainClass
{
    public static void Main()
    {
        ArrayList people = new ArrayList();
        people.Add("G");
        people.Add("L");
        people.Add("A");

        SoapSerialize(people);
        ArrayList soapPeople = SoapDeserialize();


        Console.WriteLine("\nSOAP people:");
        foreach (string s in soapPeople)
        {
            Console.WriteLine("\t" + s);
        }

    }

    private static void SoapSerialize(ArrayList list)
    {
        using (FileStream str = File.Create("people.soap"))
        {
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(str, list);
        }
    }

    private static ArrayList SoapDeserialize()
    {
        ArrayList people = null;

        using (FileStream str = File.OpenRead("people.soap"))
        {
            SoapFormatter sf = new SoapFormatter();
            people = (ArrayList)sf.Deserialize(str);
        }
        return people;
    }

}
//SOAP people:
//        G
//        L
//        A