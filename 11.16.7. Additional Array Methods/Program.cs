using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;




class ProgrammingLanguages
{
    public static void Main(string[] args)
    {
        string[] languages = new string[] { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };

        System.Array.Sort(languages);

        String searchString = "COBOL";
        int index = System.Array.BinarySearch(languages, searchString);
        System.Console.WriteLine("The wave of the future, {0}, is at index {1}.", searchString, index);

        System.Console.WriteLine("{0,-20}\t{1,-20}", languages[0], languages[languages.Length - 1]);

        System.Array.Reverse(languages);
        System.Console.WriteLine("{0,-20}\t{1,-20}", languages[0], languages[languages.Length - 1]);

        System.Array.Clear(languages, 0, languages.Length);
        System.Console.WriteLine("{0,-20}\t{1,-20}", languages[0], languages[languages.Length - 1]);
        System.Console.WriteLine("After clearing, the array size is: {0}", languages.Length);




        // new...
      

            // run as windows app
            Application.EnableVisualStyles();
            Application.Run(new newform());
      



    }
}



public class newform : System.Windows.Forms.Form
{
    public newform()
    {
        MessageBox.Show("Hello");

    }
}