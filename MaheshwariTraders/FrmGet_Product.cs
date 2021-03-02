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
namespace MaheshwariTraders
{
    public partial class FrmGet_Product : MetroForm
    {
        public FrmGet_Product()
        {
            InitializeComponent();
        }
        public static string pname1, plotno1, prate1, vt1;

        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);


        private void FrmGet_Product_Load(object sender, EventArgs e)
        {
            con.Open();
            plant.Items.Clear();
            SqlCommand cmd = new SqlCommand("select Plant_Name from Stock GROUP BY Plant_Name", con);
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    plant.Items.Add(sdr["Plant_Name"]);
                }


                sdr.Close();
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void plant_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Stock where Plant_Name='" + plant.Text + "'", con);
            DataSet viewproducts = new DataSet();
            sda1.Fill(viewproducts);
            metroGrid1.DataSource = viewproducts.Tables[0];

            con.Close();
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in metroGrid1.SelectedRows)
            {
                pname1 = row.Cells[0].Value.ToString();
                plotno1 = row.Cells[2].Value.ToString();
                vt1 = row.Cells[1].Value.ToString();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Rate from Stock where Plant_Name='" + pname1 + "' and Lot_No='" + plotno1 + "'and  Variety='" + vt1 + "'", con);
                    SqlDataReader sdr3 = cmd.ExecuteReader();


                    while (sdr3.Read())
                    {
                        prate1 = sdr3["Rate"].ToString();
                    }
                    sdr3.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdd_Product a = new FrmAdd_Product();
            a.ShowDialog();

            plant.Items.Clear();

            con.Open();
            
            SqlCommand cmd = new SqlCommand("select Plant_Name from Stock GROUP BY Plant_Name", con);
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    plant.Items.Add(sdr["Plant_Name"]);
                }


                sdr.Close();
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Stock where Plant_Name='" + plant.Text + "'", con);
            DataSet viewproducts = new DataSet();
            sda1.Fill(viewproducts);
            metroGrid1.DataSource = viewproducts.Tables[0];

            con.Close();

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
