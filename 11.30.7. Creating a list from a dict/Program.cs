using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        IDictionary<string, DateTime> dictionary = new Dictionary<string, DateTime>();
        List<KeyValuePair<string, DateTime>> keyValueList = new List<KeyValuePair<string, DateTime>>(dictionary);
    }
}