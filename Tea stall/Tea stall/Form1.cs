using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tea_stall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int price = 0;
        int total = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
               
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox2.Enabled = true;
                button1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = -1;
                button1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox3.Enabled = true;
                button1.Enabled = true;
                numericUpDown3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                button1.Enabled = false;
                comboBox3.SelectedIndex = -1;
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 0;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                comboBox4.Enabled = true;
                button1.Enabled = true;
                numericUpDown4.Enabled = true;
            }
            else
            {
                comboBox4.Enabled = false;
                comboBox4.SelectedIndex = -1;
                button1.Enabled = false;
                numericUpDown4.Value = 0;
                numericUpDown4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" ");
            listBox1.Items.Add("__________ WELCOME TO JAM JAM CAFE __________");
            listBox1.Items.Add("");
            if (comboBox1.Text == "Tea")
            {
                price = 12;
                int temp = price * (int)numericUpDown1.Value;
                listBox1.Items.Add("Cost for " +numericUpDown1.Value+ " Tea is : " + temp.ToString("c"));
                total += temp;
            }
            else if (comboBox1.Text == "Coffee"||comboBox1.Text=="Milk"||comboBox1.Text=="Lite Tea")
            {
                price = 15;
                int temp = price * (int)numericUpDown1.Value;
                listBox1.Items.Add("Cost for " +numericUpDown1.Value+" " +comboBox1.Text+"  is : " + temp.ToString("c"));
                total += temp;
            }
            else if (comboBox1.Text == "Lemon Tea")
            {
                price = 17;
                int temp = price * (int)numericUpDown1.Value;
                listBox1.Items.Add("Cost for  "+numericUpDown1.Value+" Lemon Tea is : " + temp.ToString("c"));
                total += temp;
            }
            if (comboBox2.Text == "7 UP")
            {
                price = 25;
                int temp = price * (int)numericUpDown2.Value;
                listBox1.Items.Add("Cost for " +numericUpDown2.Value+" 7 UP is : " + temp.ToString("c"));
                total += temp;
            }
            else if (comboBox2.Text == "Pepsi")
            {
                price = 30;
                int temp = price * (int)numericUpDown2.Value;
                listBox1.Items.Add("Cost for " +numericUpDown2.Value+" Pepsi is : " + temp.ToString("c"));
                total += temp;
            }
            else if (comboBox2.Text == "Mazza")
            {
                price = 20;
                int temp = price * (int)numericUpDown2.Value;
                listBox1.Items.Add("Cost for"+numericUpDown2.Value+" Mazza is : " + temp.ToString("c"));
                total += temp;
            }
            if (comboBox3.Text == "Vada"||comboBox3.Text=="Bajji")
            {
                price = 5;
                int temp = price * (int)numericUpDown3.Value;
                listBox1.Items.Add("Cost for" + numericUpDown3.Value +" "+comboBox3.Text+ " is : " + temp.ToString("c"));
                total += temp;
            }
            if (comboBox4.Text == "Choco Bar")
            {
                price = 20;
                int temp = price * (int)numericUpDown3.Value;
                listBox1.Items.Add("Cost for" + numericUpDown4.Value + " " + comboBox4.Text + " is : " + temp.ToString("c"));
                total += temp;
            }
            else if (comboBox4.Text == "Cone")
            {
                price = 30;
                int temp = price * (int)numericUpDown3.Value;
                listBox1.Items.Add("Cost for" + numericUpDown4.Value + " " + comboBox4.Text + " is : " + temp.ToString("c"));
                total += temp;
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Total Cost is : " + total.ToString("c"));
            listBox1.Items.Add("__________ THANKYOU VISIT AGAIN __________");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            checkBox1.Checked= false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            
        }
    }
}
