using System;
//Array. Sort: Belirtilen dizinin küçükten büyüğe sıralanmasını sağlar.

//11.3.3.	Use the Sort() method to sort the elements in a char array
class MainClass
{
    public static int i = 0;
    public static void Main()
    {
        char[] charArray = { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
        Array.Sort(charArray);  // sort the elements
        Console.WriteLine("Sorted charArray:");
        for (int i = 0; i < charArray.Length; i++)
        {
            Console.WriteLine("charArray[" + i + "] = " +
              charArray[i]);
        }

        
        while (true)
        {
     
            if (i>5)
                {
                break;

            }

            Console.WriteLine("Merhaba");
            i++;

        }

        Console.ReadLine();
    }

}
//Sorted charArray:
//charArray[0] = c
//charArray[1] = e
//charArray[2] = e
//charArray[3] = l
//charArray[4] = m
//charArray[5] = o
//charArray[6] = w  