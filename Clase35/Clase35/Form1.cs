using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "1000";
                textBox2.Text = "0";
                textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();

            }
            catch (DivideByZeroException) when (int.Parse(textBox2.Text) == 0) { textBox3.Text = "Text Box 2 = 0"; }
            catch (DivideByZeroException) when (int.Parse(textBox1.Text) == 0) { textBox3.Text = "Text Box 1 = 0"; }
            finally { textBox4.Text = "Funciona"; }
            
        } 
    }
}
