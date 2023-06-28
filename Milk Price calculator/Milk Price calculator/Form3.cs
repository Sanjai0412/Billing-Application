using System;
using System.IO;
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
    public partial class Form3 : Form
    {
        public static string Duration;
        public static int demodate = 0;
        public static int date= 0;
        public static int Price = 0;
        public static string day;
        public static string ml;
       
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (demodate > 7)
                {
                    demodate = -1;
                    button2.Enabled = false;
                }
            }
            else if (radioButton2.Checked)
            {
                if (demodate > 28)
                {
                    demodate = -1;
                    button2.Enabled = false;
                }
            }
            Form4 Bill = new Form4();
            if (comboBox2.SelectedIndex == 0)
            {
                ml = comboBox2.Text;
                Price = 10;
                Form2.total += Price;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                ml = comboBox2.Text;
                Price = 15;
                Form2.total += Price;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                ml = comboBox2.Text;
                Price = 20;
                Form2.total += Price;
            }
            if (comboBox2.SelectedIndex == 3)
            {
                ml = comboBox2.Text;
                Price = 25;
                Form2.total += Price;
            }
            if (comboBox2.SelectedIndex == 4)
            {
                ml = comboBox2.Text;
                Price = 30;
                Form2.total += Price;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                ml = comboBox2.Text;
                Price = 35;
                Form2.total += Price;
            }
            if (comboBox2.SelectedIndex == 6)
            {
                ml = comboBox2.Text;
                Price = 40;
                Form2.total += Price;
            }
            comboBox2.SelectedIndex = -1;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            comboBox2.SelectedIndex = -1;
            comboBox2.Enabled = false;
            demodate++;
            label7.Text = demodate.ToString();
            label6.Text = date.ToString();
           
            Bill.ShowDialog();



            //if(radioButton1.Checked)
            //{
               
            //for (int i = 1; i <= 7; i++)
            //{
            //    string var = i.ToString();
            //    label8.Text = var;
            //    break;
            //}
            //}
            //else if (radioButton2.Checked)
            //{
            //    int limit = 29;
            //    for (int i = 1; i < limit; i++)
            //    {
            //        label8.Text = i.ToString();
            //    }
            //}
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         

            if (radioButton1.Checked)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                radioButton2.Enabled = false;
                Duration = "Week";
            }
            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton2.Checked)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                radioButton1.Enabled = false;
                Duration = "Month";   
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox2.Enabled = true;
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                comboBox2.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter skip = new StreamWriter("D:\\PayOut\\" + Form1.name + ".txt",true);
            skip.WriteLine("Day " + demodate.ToString() + " was Skipped");
            skip.Close();
            date++;
            demodate++;
            label7.Text = demodate.ToString();
            label6.Text = date.ToString();
            if (radioButton1.Checked)
            {     
                if (demodate > 7)
                {
                    demodate=-1;
                    button2.Enabled = false;
                }
            }
            else if (radioButton2.Checked)
            {              
                if (demodate > 28)
                {
                    demodate = -1 ;
                    button2.Enabled = false;
                }
            }
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            demodate = demodate + 1;
            label7.Text = demodate.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
