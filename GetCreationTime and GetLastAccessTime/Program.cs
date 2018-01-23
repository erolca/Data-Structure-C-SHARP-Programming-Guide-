using System;
using System.Windows.Forms;
using System.IO;

class MainClass
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
     static void Main()
    {
        OpenFileDialog dlgOpen = new OpenFileDialog();
        if (dlgOpen.ShowDialog() == DialogResult.OK)
        {
            string s = dlgOpen.FileName;
            Console.WriteLine("Filename " + s);
            Console.WriteLine(" Created at " + File.GetCreationTime(s));
            Console.WriteLine(" Accessed at " + File.GetLastAccessTime(s));
        }

    }

}

//Filename C:\TEST\test.txt
// Created at 27.11.2017 13:31:35
// Accessed at 27.11.2017 13:31:35
