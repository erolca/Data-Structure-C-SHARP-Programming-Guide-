using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Animals : DictionaryBase
{
    public void Add(string newID, Animal newAnimal)
    {
        Dictionary.Add(newID, newAnimal);
    }

    public void Remove(string animalID)
    {
        Dictionary.Remove(animalID);
    }

    public Animals()
    {
    }

    public Animal this[string animalID]
    {
        get
        {
            return (Animal)Dictionary[animalID];
        }
        set
        {
            Dictionary[animalID] = value;
        }
    }

    public new IEnumerator GetEnumerator()
    {
        foreach (object animal in Dictionary.Values)
            yield return (Animal)animal;
    }
}

public abstract class Animal
{
    protected string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public Animal()
    {
        name = "no name";
    }

    public Animal(string newName)
    {
        name = newName;
    }

    public void Feed()
    {
        Console.WriteLine("feed:" + name);
    }
}

public class Chicken : Animal
{
    public void LayEgg()
    {
        Console.WriteLine("egg:" + name);
    }

    public Chicken(string newName)
        : base(newName)
    {
    }
}
public class Cow : Animal
{
    public void Milk()
    {
        Console.WriteLine("Milk:" + name);
    }

    public Cow(string newName) : base(newName)
    {
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animals animalCollection = new Animals();
        animalCollection.Add("A", new Cow("A"));
        animalCollection.Add("B", new Chicken("B"));
        foreach (Animal myAnimal in animalCollection)
        {
            Console.WriteLine(myAnimal.ToString());
            Console.WriteLine(myAnimal.Name);
        }
    }
}