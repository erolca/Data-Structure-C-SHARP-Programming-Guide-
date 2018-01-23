using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        Queue<string> q = new Queue<string>();
        List<string> stringList = new List<string>(q);
    }
}