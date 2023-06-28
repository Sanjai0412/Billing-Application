using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milk_Price_calculator
{
    public partial class Form2 : Form
    {
        public static int price = 0;
        public static string ML;
        public static string way;
        
        public static int MLprice;
        public static string brand;
        public static string type;
        public static int total = 0;
        public static int temp = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 time = new Form3();
            time.ShowDialog();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
             
                comboBox1.Enabled = true;
                way = " / "+radioButton1.Text;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                brand = comboBox2.Text;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                brand = comboBox2.Text;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                brand = comboBox2.Text;
            }

            if (comboBox2.Enabled)
            {
                comboBox3.Enabled = true;
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Enabled)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                type = comboBox1.Text;
                price = 10;
                total += price;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                type = comboBox1.Text;
                price = 15;
                total += price;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                type = comboBox1.Text;
                price = 20;
                total += price;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                ML = comboBox3.Text;
                MLprice = 10;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                ML = comboBox3.Text;
                MLprice = 20;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex == 2)
            {
                ML = comboBox3.Text;
                MLprice = 30;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex == 3)
            {
                ML = comboBox3.Text;
                MLprice = 40;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex == 4)
            {
                ML = comboBox3.Text;
                MLprice = 50;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex == 5)
            {
                ML = comboBox3.Text;
                MLprice = 60;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex == 6)
            {
                ML = comboBox3.Text;
                MLprice = 70;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex == 7)
            {
                ML = comboBox3.Text;
                MLprice = 80;
                total += MLprice;
            }
            if (comboBox3.SelectedIndex>-1)
            {
                button1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
               
                way = " / "+radioButton2.Text;
                comboBox3.Enabled = true;
            }
            else
            {
                way = "-";
            }
        }
    }
}
