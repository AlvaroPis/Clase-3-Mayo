using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase352
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                float saldo = 1000;
                textBox1.Text = "300";
                textBox2.Text = "4";

            if ((int.Parse(textBox1.Text) * int.Parse(textBox2.Text)) > saldo)
            {
                textBox3.Text = "No alcanza el saldo";
            }
            else { 
            }
                
            
                
        }
    }
}
