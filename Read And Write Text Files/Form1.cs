using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO.Compression;
using System.Collections.Generic;

// Developed By Gehan Fernando.
// This Application Target For The Basic .net Developers.

namespace Read_And_Write_Text_Files
{

    public partial class Form1 : Form
    {
        BinaryWriter bwriter = null;
        BinaryReader breader = null;

        FileStream flstream = null;
        MemoryStream mem = null;

        StreamWriter stwriter = null;
        StreamReader streader = null;

        TextWriter txtwriter = null;
        TextReader txtreader = null;

        StringWriter strwriter = null;
        StringReader strreader = null;

        GZipStream gzip = null;

        byte[] buff;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonBinaryWriter_Click(object sender, EventArgs e)
        {
            bwriter = new BinaryWriter(File.Open(@"C:\TEST\Sample.dat", FileMode.Create, FileAccess.Write));

            byte[] bytes = new byte[] { 5,3,4 };
            string strings = "Gehan";

            flstream = new FileStream(@"C:\WINDOWS\Web\Wallpaper\Bliss.bmp", FileMode.Open, FileAccess.Read);
            byte[] bytex = new byte[flstream.Length];
            flstream.Read(bytex, 0, (int)flstream.Length);
            flstream.Flush();
            flstream.Close();
            flstream.Dispose();

            bwriter.Write(true);    // Write True False Values
            bwriter.Write(bytes);   // Write Simple Byte Values
            bwriter.Write(strings); // Write String Values
            bwriter.Write(bytex.Length); // Write Image Length Values
            buff = bytex;
            bwriter.Write(bytex);   // Write Image Values Into Dat File

            bwriter.Flush();

            bwriter.Close();
            bwriter = null;

            MessageBox.Show("Done");
        }
        private void buttonBinaryReader_Click(object sender, EventArgs e)
        {
            breader = new BinaryReader(File.Open(@"C:\TEST\Sample.dat", FileMode.Open, FileAccess.Read));

            object obj = breader.ReadByte();
            byte[] bytes = breader.ReadBytes(3);
            string strings = breader.ReadString();
            Int32 lnth = breader.ReadInt32();
            byte[] bytex = breader.ReadBytes(lnth);
            buff = bytex;

            breader.Close();
            breader = null;

            mem = new MemoryStream(bytex, true);
            mem.Write(bytex, 0, bytex.Length);
            Bitmap img = new Bitmap(mem);

            Graphics g = this.CreateGraphics();
            Rectangle rect=new Rectangle(new Point(8, 128),new Size(216, 224));
            g.CompositingMode= System.Drawing.Drawing2D.CompositingMode.SourceOver;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.DrawRectangle(new Pen(Color.Black, 2), rect);
            g.DrawImage(img, rect);

            MessageBox.Show("Done");
        }
        private void buttonMemoryStream_Click(object sender, EventArgs e)
        {
            //buttonBinaryWriter_Click First

            MemoryStream mem = new MemoryStream(buff, true);
            mem.Write(buff, 0, buff.Length);
            Bitmap img = new Bitmap(mem);

            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(new Point(8, 128), new Size(216, 224));
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.DrawRectangle(new Pen(Color.Black, 2), rect);
            g.DrawImage(img, rect);

            MessageBox.Show("Done");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stwriter = new StreamWriter(File.Open(@"C:\TEST\StreamWriter.txt", FileMode.Create, FileAccess.Write));
            for (int i = 1; i <= 100; i++)
            {
                stwriter.WriteLine(i.ToString("00"));
            }
            stwriter.Flush();
            stwriter.Close();
            stwriter.Dispose();
            MessageBox.Show("Done");
        }
        private void buttonStreamReader_Click(object sender, EventArgs e)
        {
            streader = new StreamReader(File.Open(@"C:\TEST\StreamWriter.txt", FileMode.Open, FileAccess.Read));
            StringBuilder bld = new StringBuilder();
            
            while (streader.Peek() != -1)
            {
                bld.Append(streader.ReadLine() + ",");
            }

            Console.WriteLine(bld.Remove((bld.Length - 1), 1));

            streader.Close();
            streader.Dispose();
            MessageBox.Show("Done");
        }
        private void buttonTextWriter_Click(object sender, EventArgs e)
        {
            TextWriter txtwriter = new StreamWriter(File.Open(@"C:\TEST\TextWriter.txt", FileMode.Create, FileAccess.Write));
            
            for (int i = 1; i <= 100; i++)
            {
                txtwriter.WriteLine(i.ToString("00"));
            }
            txtwriter.Flush();
            txtwriter.Close();
            txtwriter.Dispose();
            MessageBox.Show("Done");
        }
        private void buttonTextReader_Click(object sender, EventArgs e)
        {
            txtreader = new StreamReader(File.Open(@"C:\TEST\TextWriter.txt", FileMode.Open, FileAccess.Read));
            StringBuilder bld = new StringBuilder();

            while (txtreader.Peek() != -1)
            {
                bld.Append(txtreader.ReadLine() + ",");
            }

            Console.WriteLine(bld.Remove((bld.Length - 1), 1));

            txtreader.Close();
            txtwriter.Dispose();
            MessageBox.Show("Done");
        }
        private void buttonStringWriter_Click(object sender, EventArgs e)
        {
            strwriter = new StringWriter();
            strwriter.Write("Name: {0}, Age: {1}", "Henry", 32);
            Console.WriteLine(strwriter.ToString());
            MessageBox.Show("Done");
        }
        private void buttonStringReader_Click(object sender, EventArgs e)
        {
            String MyString = "Hello World";
            char[] MyChar = new char[12];
            strreader = new StringReader(MyString);
            strreader.Read(MyChar, 0, 5);
            Console.WriteLine(MyChar);
            strreader.Close();
            MessageBox.Show("Done");
        }
        private void buttonUnmanagedMemoryStream_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.koders.com/csharp/fidC7ED820C095BC4DBCDCA566D1CD2614F432EB9D1.aspx?s=DateTime");
            MessageBox.Show("Done");
        }
        private void buttonCompress_Click(object sender, EventArgs e)
        {
            FileStream sourceFile = File.OpenRead(@"C:\TEST\MCTS(rgb)_512.jpg");
            FileStream destFile = File.Create(@"C:\TEST\MCTS(rgb)_512.gz");
            gzip = new GZipStream(destFile, CompressionMode.Compress);

            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                gzip.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }

            gzip.Flush();
            gzip.Close();
            gzip.Dispose();

            destFile.Close();
            destFile.Dispose();

            sourceFile.Close();
            sourceFile.Dispose();
            MessageBox.Show("Done");
        }
        private void buttonDecompress_Click(object sender, EventArgs e)
        {
            FileStream sourceFile = File.OpenRead(@"C:\TEST\MCTS(rgb)_512.gz");
            FileStream destFile = File.Create(@"C:\TEST\New\MCTS(rgb)_512.jpg");
            gzip = new GZipStream(sourceFile, CompressionMode.Decompress, true);

            int theByte = gzip.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = gzip.ReadByte();
            }

            gzip.Flush();
            gzip.Close();
            gzip.Dispose();

            destFile.Close();
            destFile.Dispose();

            sourceFile.Close();
            sourceFile.Dispose();
            MessageBox.Show("Done");

        }

        private void buttonIsolatedStorage_Click(object sender, EventArgs e)
        {
            string str = "Check The Following URLS ...... " + Environment.NewLine +
                        ""  + Environment.NewLine +
                        "http://www.experts-exchange.com/Programming/Languages/C_Sharp/Q_23239924.html" + Environment.NewLine +
                        "http://blog.madskristensen.dk/" + Environment.NewLine +
                        "http://www.developerfusion.co.uk/show/4636/" + Environment.NewLine +
                        "http://www.codeguru.com/csharp/csharp/cs_data/article.php/c4225/" + Environment.NewLine +
                        "http://fookeansoftware.wordpress.com/2007/11/11/isolatedstorage-in-c/";

            MessageBox.Show(str);
        }
        private void buttonPorts_Click(object sender, EventArgs e)
        {
            //http://msdn.microsoft.com/en-us/library/system.io.ports.serialport.getportnames.aspx


            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            Console.ReadLine();
        }
    }
}