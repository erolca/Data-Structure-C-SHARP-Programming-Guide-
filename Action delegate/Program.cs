using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass
{
    static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
    }

    static void Main(string[] args)
    {
        Action<int> printActionDel = ConsolePrint;
        printActionDel(10);
    }

}