using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


public class MainClass
{
    


    public static void Main()
    {
        int[] array = new int[] { 8, 2, 3, 5, 1, 3 };
        //Sözdizmi : -> public static void ForEach<T>( T[] array,Action<T> action)
        Array.ForEach<int>(array, delegate (int x)
        {
            Console.Write(x + " ");
        });
        Console.WriteLine();

        









        // New Examp
        // create a three element array of integers
        int[] intArray = new int[] { 2, 3, 4 };

        // set a delegate for the ShowSquares method
       Action<int> action = new Action<int>(ShowSquares);
       Array.ForEach(intArray,action);

     
        // Generic Methods(C# Programming Guide)
        int a = 1;
        int b = 2;

        Swap<int>(ref a, ref b);
        System.Console.WriteLine(a + " " + b);

        string aa = "aa";
        string bb = "bb";
        Swap<string>(ref aa, ref bb);
        System.Console.WriteLine(aa + " " + bb);

    }

    private static void ShowSquares(int val)
    {
        Console.WriteLine("{0:d} squared = {1:d}", val, val * val);
    }

    static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    static void GetEnvironmentVariables()
    {  
        string cumle = "Sistem ana dizininiz %SystemRoot% ve bilgisayar adınız %COMPUTERNAME%.";
        Console.WriteLine(Environment.ExpandEnvironmentVariables(cumle));

        //Exenin çalıştığı o anki yolu verir.
        Console.WriteLine(Environment.CurrentDirectory);

        //Bilgisayarın 64bit işletim sistemi olup olmadığını dönderir.
        Console.WriteLine(Environment.Is64BitOperatingSystem);

        //64bit işlemcinin olup olmadığı sorgulanır.
        Console.WriteLine(Environment.Is64BitProcess);

        //Bilgisayar adı geri dönderilir.
        Console.WriteLine(Environment.MachineName);

        //İşletim sistemi versiyonunu dönderir.
        Console.WriteLine(Environment.OSVersion);

        //İşlemci sayısını dönderir.
        Console.WriteLine(Environment.ProcessorCount);

        //System klasörünün yolunu verir.
        Console.WriteLine(Environment.SystemDirectory);

        //Bilgisayarın ram boyutunu verir.
        Console.WriteLine(Environment.SystemPageSize);

        //Sistemin ne kadar milisaniye önce başladığını dönderir.
        Console.WriteLine(Environment.TickCount);

        //Kullanıcı domain adı dönderilir.
        Console.WriteLine(Environment.UserDomainName);

        //?
        Console.WriteLine(Environment.UserInteractive);

        //Bilgisayarda o anki kullanıcının kullanıcı adını dönderir.
        Console.WriteLine(Environment.UserName);

        //Bilgisayarda yüklü olan son .net framework versiyonu dönderilmektedir.
        Console.WriteLine(Environment.Version);

        //Fiziksel hafıza boyutu dönderilmektedir.
        Console.WriteLine(Environment.WorkingSet);

        //Windows dizinini yolunu döndürür
        Console.WriteLine(Environment.GetEnvironmentVariable("windir"));





    }




}

//8 2 3 5 1 3

/*
This code produces the following output:

2 squared = 4
3 squared = 9
4 squared = 16
*/
