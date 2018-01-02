using System;

public class StringSearcher
{
    Char firstChar;

    public StringSearcher(Char firstChar)
    {
        this.firstChar = Char.ToUpper(firstChar);
    }

    public bool StartsWith(String s)
    {
        if (String.IsNullOrEmpty(s)) return false;

        if (s.Substring(0, 1).ToUpper() == firstChar.ToString())
            return true;
        else
            return false;
    }

}




class MainClass
{

    static bool isCriteria(int v)
    {
        if (v > 1)
            return true;
        return false;
    }

    public static void Main()
    {

        //-------Console-1--------------------------------------
        int[] nums = { 1, 4, -1, 5, -9 };

        Console.Write("Contents of nums: ");
        foreach (int i in nums)
            Console.Write(i + " ");
        Console.WriteLine();

        if (Array.Exists(nums, isCriteria))
        {
            Console.WriteLine("nums contains a negative value.");

            // Now, find first negative value. 
            int x = Array.Find(nums, isCriteria);
            Console.WriteLine("First negative value is : " + x);
        }
        //----------------------------------------------------------------------------------------------------------//



        //-------Console-2------------------------------------------------------------------------------------------
        String[] names = { "Adam", "Adel", "Bridgette", "Carla",
                         "Charles", "Daniel", "Elaine", "Frances",
                         "George", "Gillian", "Henry", "Irving",
                         "James", "Janae", "Lawrence", "Miguel",
                         "Nicole", "Oliver", "Paula", "Robert",
                         "Stephen", "Thomas", "Vanessa",
                         "Veronica", "Wilberforce" };

        Char[] charsToFind = { 'A', 'K', 'W', 'Z' };

        foreach (var charToFind in charsToFind)
            Console.WriteLine("One or more names begin with '{0}': {1}",
                              charToFind,
                              Array.Exists(names, (new StringSearcher(charToFind)).StartsWith));


        foreach (var charToFind in charsToFind)
            Console.WriteLine("One or more names begin with '{0}': {1}",
                              charToFind,
                              Array.Exists(names,
                                           s => {
                                               if (String.IsNullOrEmpty(s))
                                                   return false;

                                               if (s.Substring(0, 1).ToUpper() == charToFind.ToString())
                                            
                                                   return true;
                                               else
                                                   return false;
                                           }));
        //----------------------------------------------------------------------------------------------------------//

        //Console-3
        string[] array = { "cat", "dot", "perls" };

        // Use Array.Exists in different ways.
        bool a = Array.Exists(array, element => element == "perls");
        bool b = Array.Exists(array, element => element == "python");
        bool c = Array.Exists(array, element => element.StartsWith("d"));
        bool d = Array.Exists(array, element => element.StartsWith("x"));

        // Display bools.
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);






    }
}
//Contents of nums: 1 4 -1 5 -9
//nums contains a negative value.
//First negative value is : 4

// The example displays the following output:
//       One or more names begin with 'A': True
//       One or more names begin with 'K': False
//       One or more names begin with 'W': True
//       One or more names begin with 'Z': False