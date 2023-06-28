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
    public partial class Form4 : Form
    {
        public static string path;
        public static int TOTAL = 0;
        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form5 Bill = new Form5();
            Bill.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            path = "D:\\PayOut";
            CreateDirectory(path);
            Form3.date++;
            if (Form3.date >-1)
            {
                button1.Enabled = true;
            }
            if (Form3.demodate ==0)
            {
                Form3.demodate = -1;
                button2.Enabled = false;
            }
            else if (Form3.demodate ==0)
            {
                Form3.demodate = -1;
                button2.Enabled = false;
            }
            TOTAL += Form2.total;
            listBox1.Items.Add("Day : " + Form3.date);
            listBox1.Items.Add("Milk Type : " + Form2.type + Form2.way);
            listBox1.Items.Add("Brand Name : " + Form2.brand);
            listBox1.Items.Add("Quantity of Milk : " + Form2.ML + " ml");
            listBox1.Items.Add("Extra Milk Quantity : " + Form3.ml + " ml");
            listBox1.Items.Add("Total : " + Form2.total.ToString("c"));

            //string[] billarray = new string[listBox1.Items.Count];
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    billarray[i] = listBox1.Items[i].ToString();
            //}

            StreamWriter Bill = new StreamWriter("D:\\PayOut\\" + Form1.name + ".txt", true);
            
            Bill.WriteLine("Day : " + Form3.date);
            Bill.WriteLine("Milk Type : " + Form2.type + Form2.way);
            Bill.WriteLine("Brand Name : " + Form2.brand);
            Bill.WriteLine("Quantity : " + Form2.ML + " ml");
            Bill.WriteLine("Extra Milk Quantity : " + Form3.ml + " ml");
            Bill.WriteLine("Total : " + Form2.total.ToString("c"));
            Bill.Close();
        }
        private static void CreateDirectory(DirectoryInfo dir)
        {
            dir.CreateSubdirectory(path);
        }
        private static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (Form3.demodate > 6)
            {
                Form3.demodate = -1;
                button2.Enabled = false;
            }
            else if (Form3.demodate > 27)
            {
                Form3.demodate = -1;
                button2.Enabled = false;
            }
        }
    }
}
