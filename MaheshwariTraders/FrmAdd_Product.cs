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
    public partial class FrmAdd_Product : Form
    {
        public FrmAdd_Product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void FrmAdd_Product_Load(object sender, EventArgs e)
        {
            con.Open();
            plant.Items.Clear();
            SqlCommand cmd = new SqlCommand("select Product_Name from Products", con);
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    plant.Items.Add(sdr["Product_Name"]);
                }


                sdr.Close();
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into stock (Plant_Name,Variety,Lot_No,Total_Stock,Available,Reserved,Rate,Limit) values('"+plant.Text+"','"+variety.Text+"','"+lotno.Text+"','"+0+"','"+0+"','"+0+"','"+rate.Text+"','"+limit.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved data into stock");
            this.Close();
        }

        private void plant_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Variety,Lot_No,Rate from Stock where Plant_Name='"+plant.Text+"'",con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
