using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

class GoodMonthType
{
    private static readonly string[] monthConstants = new string[] {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    };

    public string[] Months
    {
        get { return (string[])monthConstants.Clone(); }
    }

   /* public IEnumerable<string> MonthsEnumerable
    {
        get { return Array.AsReadOnly<string>(monthConstants); }
    }*/
}




class GoodDayType
{
    private static readonly string[] dayCostants = new string[]
    {
    "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"

    };

    public string[] Days
    {
        get { return (string[])dayCostants.Clone(); }
    }


}


public class MainClass
{

    public static void Main()
    {
        GoodMonthType mt2 = new GoodMonthType();

        foreach (string m in mt2.Months)
        {
            Console.WriteLine(m);
        }

        Console.WriteLine("\n");

        string[] months2 = mt2.Months;
        months2[3] = "Not-April";

        foreach (string m in mt2.Months)
        {
            Console.WriteLine(m);
        }

        Console.WriteLine("\n");


        //
        GoodDayType dt2 = new GoodDayType();
        foreach (string item in dt2.Days)
        {
            Console.WriteLine(item);

        }



    }
}
//January
//February
//March
//April
//May
//June
//July
//August
//September
//October
//November
//December
//January
//February
//March
//April
//May
//June
//July
//August
//September
//October
//November
//December