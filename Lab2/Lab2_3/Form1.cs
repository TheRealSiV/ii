using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuPlus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            textBox3.Text = (a | b).ToString();
        }

        private void toolStripMenuMinus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            textBox3.Text = (a & b).ToString();
        }

        private void toolStripMenuMul_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            textBox3.Text = (a ^ b).ToString();
        }


        private void oPERATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
