using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Плотность
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            textBox3.Text = Program.CalcDispense(textBox1.Text, textBox2.Text);
            label3.Text = "Плотность при " + textBox4.Text + " Гр.С.";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = "Плотность при " + textBox2.Text + " Гр.С.";
        }
    }
}
