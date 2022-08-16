using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(textBox1.Text);


            if (a == 1 || a == 0)
            {
                listBox1.Items.Add("el numero " + a + " no es primo");
            }
            if (a == 2)
            {
                listBox1.Items.Add("el numero " + a + " es primo");
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        listBox1.Items.Add("el numero " + a + " no es primo");
                        break;
                    }
                    else
                    {
                        listBox1.Items.Add("el numero " + a + " es primo");
                        break;
                    }
                }
            }
            textBox1.Text = " ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
