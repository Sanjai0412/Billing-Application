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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
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
            listBox1.Items.Add("     ");
            listBox1.Items.Add("     ");
            listBox1.Items.Add(" Pizza Type : " + Form1.Type);
            listBox1.Items.Add(" Flavour is : " + Form1.flavour);
            listBox1.Items.Add(" No.of.Pizza : " + Form1.count);
            listBox1.Items.Add(" Pizza Size : " + Form1.size);
            
            listBox1.Items.Add(" Crust Type : " + Form1.crust);
            listBox1.Items.Add(" Veg Toppings : " + Form1.vegTopping);
            listBox1.Items.Add(" Non-Veg Toppings : " + Form1.Nonveg);
            listBox1.Items.Add("     ");
            listBox1.Items.Add(" Total : " );
            listBox2.Items.Add("     ");
            listBox2.Items.Add("     ");
            listBox2.Items.Add("     ");
            listBox2.Items.Add(Form1.flavourcost.ToString("c"));
            listBox2.Items.Add("x" + Form1.count);
            listBox2.Items.Add(Form1.sizeprice.ToString("c"));
            
            listBox2.Items.Add(Form1.crustcost.ToString("c"));
            listBox2.Items.Add(Form1.vegcost.ToString("c"));
            listBox2.Items.Add(Form1.Nonvegcost.ToString("c"));
            listBox2.Items.Add("     ");
            listBox2.Items.Add(Form1.total.ToString("c"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
