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

namespace Lab2_2
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "C:\\Users\\Asus\\developement\\ii\\Lab2\\Lab2_4\\list.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
        }

       

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
