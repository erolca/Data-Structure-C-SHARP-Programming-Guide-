using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainClass
{
    static void Main()
    {
        string[] names = new string[4];
        object[] objects = names;

        string[] originalNames = (string[])objects;
    }
}