using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



//http://www.ismailgursoy.com.tr/hashtable/

namespace Windows_Hashtable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable ht = new Hashtable();

        public void Yenile()
        {
            listBox1.Items.Clear();

            ICollection anahtarlar = ht.Keys;

            foreach (object anahtar in anahtarlar)
            {
                listBox1.Items.Add(anahtar+":"+ht[anahtar]);

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            ht.Add("Computer", "Bilgisayar");
            ht.Add("Mouse",     "Fare");
            ht.Add("Keyboard",  "Klavye");
            ht.Add("MainBoard", "Anakart");
            ht.Add("Desktop",   "Masaüstü");

            ICollection anahtarlar = ht.Keys;

            foreach (object anahtar in anahtarlar)
            {
                listBox1.Items.Add(anahtar + ":" + ht[anahtar]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ht.Add(textBox1.Text,textBox2.Text);
            Yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ht.Remove(textBox1.Text);
            Yenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizideki eleman sayısı :"+ht.Count.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ht.IsFixedSize==true)
            {
                MessageBox.Show("Dizi sabit  boyutlu"); 
            }
            else
            {
                MessageBox.Show("Dizi sabit  boyutlu değil");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ht.IsReadOnly == true)
            {
                MessageBox.Show("Dizi sadece okunabilir");
            }
            else
            {
                MessageBox.Show("Dizi sadece okunabilir değil");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ht.Clear();
            Yenile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ht.ContainsKey(textBox1.Text)==true)
            {
                MessageBox.Show("Aradığınız "+textBox1.Text+" ifadesi dizi içinde bulunmuştur");
            }
            else
            {
                MessageBox.Show("Aradığınız " + textBox1.Text + " ifadesi dizi içinde bulunamadı");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ht.ContainsValue(textBox2.Text) == true)
            {
                MessageBox.Show("Aradığınız " + textBox2.Text + " ifadesi dizi içinde bulunmuştur");
            }
            else
            {
                MessageBox.Show("Aradığınız " + textBox2.Text + " ifadesi dizi içinde bulunamadı");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ht.Contains(textBox1.Text) == true)
            {
                MessageBox.Show("Aradığınız " + textBox1.Text + " ifadesi dizi içinde bulunmuştur");
            }
            else
            {
                MessageBox.Show("Aradığınız " + textBox1.Text + " ifadesi dizi içinde bulunamadı");
            }
        }
    }
}
