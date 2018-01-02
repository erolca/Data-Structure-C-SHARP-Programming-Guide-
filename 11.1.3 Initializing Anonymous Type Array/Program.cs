using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] d = new[] { 1, 2, 3 }; // kullanımı şekillerinden biri
        int[] f = new int[3];
        f[0] = 1;
        //--//

        var worldCup2006Finalists = new[]{new
          {
              TeamName = "France",
              Players = new string[]
              {
                  "A", "B","C", "D",
              }
          },
          new
          {
              TeamName = "Italy",
              Players = new string[]
              {
                  "Q", "W","E", "R",
              }
          }
      };
        Print(worldCup2006Finalists);
    }

    private static void Print<T>(IEnumerable<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}