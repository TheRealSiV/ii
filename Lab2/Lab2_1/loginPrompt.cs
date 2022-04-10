using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_1
{
    public partial class loginPrompt : Form
    {
        public loginPrompt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void label_setUser(string user)
        {
            label1.Text = "Hello there, " + user + " you are great!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
