using System;
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
            textBoxDisp.Text = Convert.ToString(Program.CalcDispenseVar(    Program.ToDouble(textBoxt1.Text),
                                                                            Program.ToDouble(textBoxt2.Text),
                                                                            Program.ToDouble(textBoxDisp1.Text)));
            label3.Text = "Плотность при " + textBoxt2.Text + " Гр.С.";
            label1.Text = "Плотность при " + textBoxt1.Text + " Гр.С.";
        }
    }
}
