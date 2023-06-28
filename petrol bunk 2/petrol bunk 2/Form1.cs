using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petrol_bunk_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBox1.Checked)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            else
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;            
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox1.Enabled = true;
                
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Enabled)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value= 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            int wheel = 0;
            int total = 0;
            listBox1.Items.Add("_________ WELCOME TO BHARAT PETROLEUM__________");
            listBox1.Items.Add("");
            listBox1.Items.Add("Your Reg.No is : " + textBox1.Text);
            if (radioButton1.Checked)
            {
                wheel = 2;
                listBox1.Items.Add("Your Vehicle Type is : " + radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                wheel = 4;
                listBox1.Items.Add("Your Vehicle Type is : " + radioButton2.Text);
            }
            if (comboBox1.Text == "Petrol")
            {
                price = 100;
                listBox1.Items.Add("Your Fuel Type is : " + comboBox1.Text);
            }
            else if (comboBox1.Text == "Diesel")
            {
                price = 90;
                listBox1.Items.Add("Your Fuel Type is : " + comboBox1.Text);
            }
            if (checkBox1.Checked)
            {
                int priceair = 10;
                int temp = priceair * wheel;
                listBox1.Items.Add("Cost for Air filling : " + temp.ToString("c"));
                total += temp;

            }
            if (checkBox2.Checked)
            {
                int temp = price * (int)numericUpDown1.Value;
                listBox1.Items.Add("Cost for Fuel Filling : " + temp.ToString("c"));
                total += temp;
            }
            if (checkBox3.Checked)
            {
                int oilprice = 2;
                int temp = oilprice * (int)numericUpDown2.Value;
                listBox1.Items.Add("Cost for Oil : " + temp.ToString("c"));
                total += temp;       
            }
            listBox1.Items.Add("Total Amount is : " + total.ToString("c"));
            listBox1.Items.Add(" ");
            listBox1.Items.Add("______________  THANKYOU :) VISIT AGAIN  _____________");
        }                    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                checkBox1.Enabled = true;
                button1.Enabled = true;

            }
            else
                checkBox1.Enabled = false;
                button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Clear();
        }

        private void hfhfh(object sender, KeyPressEventArgs e)
        {
            
        }
    } 
}
