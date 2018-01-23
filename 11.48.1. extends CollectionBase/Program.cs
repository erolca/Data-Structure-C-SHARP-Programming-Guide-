using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//11.48.1.	extends CollectionBase to create your own collection


class Program
{
    static void Main(string[] args)
    {
        Animals animalCollection = new Animals();
        animalCollection.Add(new Cow("A"));
        animalCollection.Add(new Chicken("B"));
        foreach (Animal myAnimal in animalCollection)
        {
            myAnimal.Feed();
        }
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
        name = "The animal with no name";
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
        Console.WriteLine("chicken:" + name);
    }

    public Chicken(string newName) : base(newName)
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

public class Animals : CollectionBase
{
    public void Add(Animal newAnimal)
    {
        List.Add(newAnimal);
    }

    public void Remove(Animal newAnimal)
    {
        List.Remove(newAnimal);
    }

    public Animals()
    {
    }

    public Animal this[int animalIndex]
    {
        get
        {
            return (Animal)List[animalIndex];
        }
        set
        {
            List[animalIndex] = value;
        }
    }
}