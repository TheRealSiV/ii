using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_T1
{
    public partial class ResponseCertificate : Form
    {
        public ResponseCertificate()
        {
            InitializeComponent();
        }

        public void setData(NewBornsData data)
        {
            FamName.Text = data.numeC;
            Prenume.Text = data.prenC;
            Sex.Text = data.sex;
            DataNAn.Text = data.dataN.Year.ToString();
            DataNLuna.Text = data.dataN.Month.ToString();
            DataNZiua.Text = data.dataN.Day.ToString();

            Localitate.Text = data.local;
            Judet.Text = data.judet;

            TataNume.Text = data.numeT;
            TataPren.Text = data.prenT;
            MamaNume.Text = data.numeM;
            MamaPren.Text = data.prenM;
            ActNr.Text = new Random().Next(10000, 999999).ToString();
            ActData.Text = DateTime.Now.ToLongTimeString();
            ActLoc.Text = data.local;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
