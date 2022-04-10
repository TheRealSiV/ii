using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_1
{

    public partial class Form1 : Form
    {
        private loginPrompt lp = new loginPrompt();
        private string user;
        private string pw;
        public Form1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "C:\\Users\\Asus\\developement\\ii\\Lab2\\Lab2_1\\parola.txt");
            user = streamReader.ReadLine();
            pw = streamReader.ReadLine();
            pw_textBox.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pw_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Equals(user_textBox.Text) && pw.Equals(pw_textBox.Text))
            { 
                lp.label_setUser(user);
                lp.ShowDialog();
            }
            else
            {
                MessageBoxButtons butt = MessageBoxButtons.OK;
                DialogResult res = MessageBox.Show("Please check the input again", "NOT ALLOWED", butt, MessageBoxIcon.Error);
                
            }
        }
    }
}
