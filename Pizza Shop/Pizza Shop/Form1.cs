using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Shop
{
    public partial class Form1 : Form
    {
        public static int price = 0;
        public static int total = 0;
        public static string size;
        public static string crust;
        public static string flavour;
        public static string vegTopping;
        public static string Nonveg;
        public static string Type;
        public static int count = 0;

        public static int sizeprice = 0;
        public static int flavourcost = 0;
        public static int crustcost = 0;
        public static int vegcost = 0;
        public static int Nonvegcost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                size = radioButton5.Text;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Enabled = true;
                Type = "Veg";
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox2.Enabled = true;
                Type = "Non-Veg";
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = -1;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (comboBox1.Enabled)
            {

                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                numericUpDown1.Enabled = true;
            }
            else
            {
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;

            }
            if (comboBox1.Text == "4 Cheese Pizza")
            {
                flavour = comboBox1.Text;
                flavourcost = 350;
            }
            else if (comboBox1.Text == "Farmhouse")
            {
                flavour = comboBox1.Text;
                flavourcost = 450;
            }
            else if (comboBox1.Text == "Peppy Paneer")
            {
                flavour = comboBox1.Text;
                flavourcost = 550;
            }
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Enabled)
            {
                numericUpDown2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
            }
            if (comboBox2.Text == "Chicken Dominator")
            {
                flavour = comboBox2.Text;
                flavourcost = 650;
            }
            else if (comboBox2.Text == "Chicken Keema")
            {
                flavour = comboBox2.Text;
                flavourcost = 750;
            }
            else if (comboBox2.Text == "Non-Veg Supreme")
            {
                flavour = comboBox2.Text;
                flavourcost = 850;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                size = radioButton3.Text;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.CanSelect)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            if (comboBox1.Text == "4 Cheese Pizza")
            {
                price = 350;
                int temp = price * (int)numericUpDown1.Value;
                listBox1.Items.Add(" You Flavour is : " + comboBox1.Text);
                listBox1.Items.Add(" No.of.Pizza's : " + numericUpDown1.Value);
                total += temp;
            }
            else if (comboBox1.Text == "Farmhouse")
            {
                price = 450;
                int temp = price * (int)numericUpDown1.Value;
                listBox1.Items.Add(" Your Flavour is : " + comboBox1.Text);
                listBox1.Items.Add(" No.of.Pizza's : " + numericUpDown1.Value);
                total += temp;
            }
            else if (comboBox1.Text == "Peppy Paneer")
            {
                price = 550;
                int temp = price * (int)numericUpDown1.Value;
                listBox1.Items.Add(" Your Flavour is : " + comboBox1.Text);
                listBox1.Items.Add(" No.of.Pizza's : " + numericUpDown1.Value);
                total += temp;
            }


            if (comboBox2.Text == "Chicken Dominator")
            {
                price = 650;
                int temp = price * (int)numericUpDown2.Value;
                listBox1.Items.Add(" You Flavour is : " + comboBox2.Text);
                listBox1.Items.Add(" No.of.Pizza's : " + numericUpDown2.Value);
                total += price;
                
            }
            else if (comboBox2.Text == "Chicken keema")
            {
                price = 750;
                int temp = price * (int)numericUpDown2.Value;
                listBox1.Items.Add(" Your Flavour is : " + comboBox2.Text);
                listBox1.Items.Add(" No.of.Pizza's : " + numericUpDown2.Value);
                total += price;
            }
            else if (comboBox2.Text == "Non-Veg Supreme")
            {
                price = 850;
                int temp = price * (int)numericUpDown2.Value;
                listBox1.Items.Add(" Your Flavour is : " + comboBox2.Text);
                listBox1.Items.Add(" No.of.Pizza's : " + numericUpDown2.Value);
                total += price;
            }


            if (radioButton3.Checked)
            {
                listBox1.Items.Add("Pizza Size is : " + radioButton3.Text);
                sizeprice = 100;
                total += sizeprice;
            }
            else if (radioButton4.Checked)
            {
                listBox1.Items.Add("Pizza size is : " + radioButton4.Text);
                sizeprice = 150;
                total += sizeprice;
            }
            else if (radioButton5.Checked)
            {
                listBox1.Items.Add("Pizza Size is : " + radioButton5.Text);
                sizeprice = 250;
                total += sizeprice;
            }


            if (radioButton6.Checked)
            {
                listBox1.Items.Add("Crust Type is : " + radioButton6.Text);
                price = 50;
                total += price;
            }
            else if (radioButton7.Checked)
            {
                listBox1.Items.Add("Crust Type is : " + radioButton7.Text);
                price = 100;
                total += price;
            }
            else if (radioButton8.Checked)
            {
                listBox1.Items.Add("Crust Type is : " + radioButton8.Text);
                price = 150;
                total += price;
            }
             if (checkBox1.Checked && checkBox2.Checked)
            {
                listBox1.Items.Add(" Veg Toppings : " + checkBox1.Text + " and " + checkBox2.Text);
                price = 100;
                total += price;
            }
            else if (checkBox1.Checked)
            {
                listBox1.Items.Add("Veg Toppings : " + checkBox1.Text);
                price = 50;
                total += price;
            }
            else if (checkBox2.Checked)
            {
                listBox1.Items.Add("Veg Toppings : " + checkBox2.Text);
                price = 50;
                total += price;
            }
           
            if (checkBox3.Checked && checkBox4.Checked)
            {
                listBox1.Items.Add("Non- Veg Toppings : " + checkBox3.Text + " and " + checkBox4.Text);
                price = 200;
                total += price;
            }
            else if (checkBox3.Checked)
            {
                listBox1.Items.Add("Non-Veg Toppings : " + checkBox3.Text);
                price = 100;
                total += price;
            }
            else if (checkBox4.Checked)
            {
                listBox1.Items.Add("Non-Veg Toppings : " + checkBox4.Text);
                price = 100;
                total += price;
            }


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                crustcost = 50;
                crust = radioButton6.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billing Bill = new Billing();
            Bill.ShowDialog();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                size = radioButton4.Text;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                count =(int) numericUpDown1.Value;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0)
            {
                count = (int)numericUpDown2.Value;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                crust = radioButton7.Text;
                crustcost = 100;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                crust = radioButton8.Text;
                crustcost = 150;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                vegTopping = checkBox1.Text;
                vegcost = 50;
            }
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                vegTopping = checkBox2.Text;
                vegcost = 50;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Nonveg = checkBox3.Text;
                Nonvegcost = 100;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Nonveg = checkBox4.Text;
                Nonvegcost = 100;
            }
        }
    }
}
