using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          private void label2_Click(object sender, EventArgs e)
                {
                }
        private void button1_Click(object sender, EventArgs e)
        {
            
                int cont = 4;
            for (int i = 0; i < 3; i++)
            {
                int a = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite un numero", "Adivinar contraseña"));
                if (a == cont)
                {
                    MessageBox.Show("Acceso permitido");
                   
                    i = 3;
                }
                else
                {
                    if (i == 2)
                    {
                        MessageBox.Show("Clave bloqueada");
                       
                    }
                    else
                    {
                        MessageBox.Show("Acceso denegado");
                    }
                }
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
