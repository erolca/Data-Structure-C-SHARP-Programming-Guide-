using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


//11.34.4.	Converting a list: user defined converting function


public class MainClass
{
    private static int ConvertStringToInt(string input)
    {
        int result;
        if (!int.TryParse(input, out result)) //public static bool TryParse( string s, 	out int result)
            result = -1;
        return result;
    }
    public static void Main()
    {
        List<string> stringList2 = new List<string>(new string[] { "99", "182", "invalid", "15" });
        List<int> intList2 = stringList2.ConvertAll<int>(ConvertStringToInt);
    }
}