using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
//using MetroFramework.Forms;
namespace MaheshwariTraders
{
    public partial class Add_Customer : MetroForm
    {
        public Add_Customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Customer values('" + customername.Text + "','" + mobilenumber.Text + "','" + address.Text + "','" + taluka.Text + "','" + city.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save Success");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            customername.Text = "";
            mobilenumber.Text = "";
            address.Text = "";
            taluka.Text = "";
            city.Text = "";


        }
    }
}
