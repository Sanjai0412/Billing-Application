using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milk_Price_calculator
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Your Name : " + Form1.name);
            listBox1.Items.Add("Your Door No : " + Form1.Region);
            listBox1.Items.Add("Your Address : " + Form1.Address);
            listBox1.Items.Add("");
            string[] arr = File.ReadAllLines("D:\\PayOut\\"+ Form1.name + ".txt");
            for (int i = 0; i < arr.Length; i++)
            {
                listBox1.Items.Add(arr[i]+"\n");
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Total Amount For a " + Form3.Duration + " : " + Form4.TOTAL.ToString("c"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
