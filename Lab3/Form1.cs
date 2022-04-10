using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        public Form1()
        {
            InitializeComponent();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            sqlConnection.Open();
            dsFac = new DataSet();
            dsUniv = new DataSet();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", sqlConnection);
            daUniv.Fill(dsUniv, "Universitati");

            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", sqlConnection);
            daFac.Fill(dsFac, "Facultati");

            foreach(DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }
            sqlConnection.Close();

        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Facs.Items.Clear();
            textBox_City.Clear();
            int code = 0;
            String selectedUniv = listBox_Univ.SelectedItem.ToString();

            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (selectedUniv == dr.ItemArray.GetValue(1).ToString())
                {
                    textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_Code.Text = code.ToString();
                }
            }

            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox_Facs.Items.Add(nameFac);
                }
            }


        }


    }
}
