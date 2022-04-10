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

namespace Lab2_4
{
    public partial class Form1 : Form
    {
        Dictionary<string, Image> dic = new Dictionary<string, Image>();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            StreamReader streamReader = new StreamReader(path: "C:\\Users\\Asus\\developement\\ii\\Lab2\\Lab2_4\\list.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            string url = "C:\\Users\\Asus\\developement\\ii\\Lab2\\Lab2_4\\";
            dic.Add("car", Image.FromFile(url + "mercedes.jpg"));
            dic.Add("elon", Image.FromFile(url + "elon.jpg"));
            dic.Add("starship", Image.FromFile(url + "starship.jpg"));
            dic.Add("utcn", Image.FromFile(url + "utcn.png"));

            radioButton1.CheckedChanged += new EventHandler(radioButtons1_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons1_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButtons1_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(radioButtons2_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(radioButtons2_CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(radioButtons2_CheckedChanged);
        }

        private void radioButtons1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            textBox1.Text = radioButton.Text;
        }

        private void radioButtons2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            textBox2.Text = radioButton.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var item in dic)
            {
                if (item.Key.Equals(listBox1.SelectedItem))
                {
                    pictureBox1.Image = item.Value;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
