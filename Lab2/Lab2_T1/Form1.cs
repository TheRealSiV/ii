using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace Lab2_T1
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();

            String[] Judete = { "Cluj", "Arad", "Salaj", "Timis", "Bihor", "Altul" };
            comboBox_Judete.Items.AddRange(Judete);

            String[] Orase = { "Cluj-Napoca", "Arad", "Timisoara", "Dej", "Oradea", "Zalau", "Salonta", "Ineu", "Santana" };
            comboBox_Orase.Items.AddRange(Orase);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rp = new ResponseCertificate();
            var sex = "";
            if (radioButton1.Checked)
            {
                sex = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                sex = radioButton2.Text;
            }
            var newBorn = new NewBornsData(textBox_NumeCopil.Text,
                                           textBox_PrenC.Text,
                                           dateTimePicker1.Value,
                                           comboBox_Judete.Text,
                                           comboBox_Orase.Text,
                                           sex,
                                           textBox_NumeT.Text,
                                           textBox_PrenT.Text,
                                           textBox_NumeM.Text,
                                           textBox_PrenM.Text);
            rp.setData(newBorn);
            rp.ShowDialog();
        }
    }
}
