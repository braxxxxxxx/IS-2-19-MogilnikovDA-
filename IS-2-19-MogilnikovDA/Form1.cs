using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_MogilnikovDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class kompl
        {
            public int price;
            public int year;

            public kompl(int cena, int god)
            {
                price = cena;
                year = god;
            }

            abstract public void Display(ListBox listBox1);


        }



        class CP : kompl
        {
            public int freq;
            public int core;
            public int stream;

            public CP(int cena, int god, int chastota, int yadra, int potoki) : base(cena, god)
            {
                freq = chastota;
                core = yadra;
                stream = potoki;
            }

            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Год выпуска: {year}");
                listBox1.Items.Add($"Цена: {price}");
                listBox1.Items.Add($"Частота: {freq}");
                listBox1.Items.Add($"Ядра: {core}");
                listBox1.Items.Add($"Потоки: {stream}");
            }


        }

        class VID : CP
        {
            public int freqGPU;
            public int perf;
            public int memory;

            public VID(int cena, int god, int chastotaGPU, int proizvod, int pamyat, int chastota, int yadra, int potoki) : base(cena, god, chastota, yadra, potoki)
            {
                freqGPU = chastotaGPU;
                perf = proizvod;
                memory = pamyat;
            }

            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Год выпуска: {year}");
                listBox1.Items.Add($"Цена: {price}");
                listBox1.Items.Add($"Частота ГПУ: {freqGPU}");
                listBox1.Items.Add($"Производительность: {perf}");
                listBox1.Items.Add($"Память: {memory}");
            }
        }

        public void vivodCP()
        {
            listBox1.Items.Clear();
            textBox6.Text = "1";
            textBox7.Text = "2";
            textBox8.Text = "3";
            if (textBox1.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else
            {
                CP KMPL = new CP(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                KMPL.Display(listBox1);
                label9.Text = "ЦП:";
            }
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
        public void vidodVID()
        {
            listBox1.Items.Clear();
            textBox3.Text = "1";
            textBox4.Text = "2";
            textBox5.Text = "3";
            if (textBox6.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Выберите значение");
            }
            else
            {
                VID vid = new VID(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                vid.Display(listBox1);
                label9.Text = "Видеокарта:";
            }
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vivodCP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vidodVID();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyDown(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
