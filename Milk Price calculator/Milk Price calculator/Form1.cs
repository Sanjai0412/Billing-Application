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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public static string name;
        public static string Region;
        public static string Address;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 type=new Form2();
            type.ShowDialog();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (textBox1.TextLength > 0)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Region = textBox2.Text;
            if (textBox2.TextLength > 0)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Address = textBox3.Text;
            if (textBox3.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
