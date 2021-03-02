using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
namespace MaheshwariTraders
{
    public partial class FrmAdvance : Form
    {
        public FrmAdvance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        public String n1, nam1 = "";
        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Booking values('" + fName.Text + "','" + city.Text + "','" + id.Text + "','" + mobileNo.Text + "','" + tapshi.Text + "','" + remaining.Text + "',convert(date,'" + metroDateTime1.Text + "',105),convert(date,'" + metroDateTime2.Text + "',105),'" + cashNo.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "truncate table Temp_Adv";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Saved Success");
            n1 = id.Text;
            nam1 = fName.Text;
            fName.Text = "";
            city.Text = "";
            billNo.Text = "";
            mobileNo.Text = "";
            tapshi.Text = "";
            advance.Text = "";
            cashNo.Text = "";

            if (paid.Text != "")
            {
                con.Open();
                for (int n = 0; n < (metroGrid1.Rows.Count); n++)
                {
                    SqlCommand cmd3 = new SqlCommand("insert into Advance_Products(Advance_Bill_No,Product_Name,Variety,Lot_No,Rate,Quantity,Total) values ('" + id.Text + "', '" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "' , '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "', '" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "' , '" + metroGrid1.Rows[n].Cells[3].Value.ToString() + "', '" + metroGrid1.Rows[n].Cells[4].Value.ToString() + "', '" + metroGrid1.Rows[n].Cells[5].Value.ToString() + "')", con);
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("update Advance_Billing set Total = '" + metroGrid1.Rows[n].Cells[5].Value.ToString() + "' where Product_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "' and Variety= '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                    cmd1.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Advance Booking Done Successfully");


            }
            else
            {
                MessageBox.Show("Please insert Advance Payment.");
            }
            //this.Close();
            for (int n = 0; n < (metroGrid1.Rows.Count); n++)
            {
            
                SqlCommand cmd4 = new SqlCommand("select Available from Stock where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "' and Variety='" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                con.Open();
                Int32 ava =Convert.ToInt32(cmd4.ExecuteScalar());
                con.Close();

                SqlCommand cmd5 = new SqlCommand("select Reserved from Stock where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "' and Variety='" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                con.Open();
                Int32 res =Convert.ToInt32(cmd5.ExecuteScalar());
                con.Close();
                if (ava > Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value) && ava!=0)
                {
                    res = res + Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value);
                    ava = ava - Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value);

                    SqlCommand cmd6 = new SqlCommand("update Stock set Available='" + ava.ToString() + "',Reserved='" + Convert.ToString(res) + "' where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "' and Variety='" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                    con.Open();
                    cmd6.ExecuteNonQuery();
                    con.Close();
                    
                }
                else if (ava == 0 || ava < Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value))
                {
                    SqlCommand cmd6 = new SqlCommand("insert into Advance_Sowing(Advance_Bill_No,Plant_Name,Variety,Lot_No,Quantity) values('" + id.Text + "','" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "','" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "','" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "','" + metroGrid1.Rows[n].Cells[4].Value.ToString() + "') ", con);
                    con.Open();
                    cmd6.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("update Stock");
            save.Enabled = false;
            print.Enabled = true;

        }

        private void FrmAdvance_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select * from Booking", con);
            //con.Open();
            //SqlDataAdapter adp = new SqlDataAdapter();
            //adp.SelectCommand = cmd;
            //DataSet ds = new DataSet();
            //adp.Fill(ds, "Booking");
            //metroGrid1.DataSource = ds.Tables[0];
            //con.Close();
            

            

        }
        private void createid()
        {
            string dt = DateTime.Now.ToString("yy") + "-" + DateTime.Now.AddYears(1).ToString("yy") + "/";
            string soid = dt;
            con.Open();
            SqlCommand inq = new SqlCommand("SELECT COUNT(BillNo) FROM Booking", con);
            string count1 = inq.ExecuteScalar().ToString();
            int cnt = 0;
            cnt = int.Parse(count1) + 1;

            if (cnt < 10)
                soid = soid + "0000" + cnt.ToString();
            else if (cnt < 100)
                soid = soid + "000" + cnt.ToString();
            else if (cnt < 1000)
                soid = soid + "00" + cnt.ToString();
            else if (cnt < 10000)
                soid = soid + "0" + cnt.ToString();
            else
                soid = soid + cnt.ToString();


            Console.WriteLine(count1);
            con.Close();
            id.Text = "ADV-"+soid;
            //MessageBox.Show("ADV-" + soid);


        }

        private void FrmAdvance_Load_1(object sender, EventArgs e)
        {
            createid();
            fName.Items.Clear();
            SqlCommand cmdf = new SqlCommand("SELECT Customer_Name FROM Customer", con);
            con.Open();
            SqlDataReader reader = cmdf.ExecuteReader();
            //  SqlCommand cm = new SqlCommand("select Product_Name from Products", con);
            // con.Open();
            // SqlDataReader sdr = cm.ExecuteReader();

            while (reader.Read())
            {
                fName.Items.Add(reader["Customer_Name"]);
            }

            con.Close();
            //con.Open();
            //SqlCommand cmd4 = new SqlCommand("delete Advance_Billing", con);
            //cmd4.ExecuteNonQuery();
            //con.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            FrmGet_Product f = new FrmGet_Product();
            f.ShowDialog();
            products.Text = FrmGet_Product.pname1;
            lotno.Text = FrmGet_Product.plotno1;
            rate.Text = FrmGet_Product.prate1;
            variety.Text = FrmGet_Product.vt1;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
             //try
             //   {
                    if (products.Text != "")
                    {
                          if (quantity.Text != "")
                        {

                            //==========
                            bool IsDuplicate = false;
                            for (int i = 0; i < metroGrid1.Rows.Count; i++) 
                            {
                                if (products.Text == metroGrid1.Rows[i].Cells[0].Value.ToString() && variety.Text == metroGrid1.Rows[i].Cells[1].Value.ToString() && lotno.Text == metroGrid1.Rows[i].Cells[2].Value.ToString())
                                {
                                    IsDuplicate = true;
                                    MessageBox.Show("The Product is Already Added...");
                                    break;
                                }
                            }
                            if (!IsDuplicate)
                            {
                                con.Open();
                                int cnt = metroGrid1.RowCount + 1;
                                SqlCommand cmd = new SqlCommand("insert into Advance_Billing(Advance_Bill_No, Customer_Name,Product_Name,Variety, Lot_No,Rate,Quantity,Delivery_Date) values ('" + id.Text + "', '" + fName.Text + "' ,'" + products.Text + "','" + variety.Text + "','" + lotno.Text + "', '" + rate.Text + "' , '" + quantity.Text + "',convert(date,'" + metroDateTime2.Value.ToShortDateString() + "',105))", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            //==========

                            con.Open();
                            SqlCommand cmd1 = new SqlCommand("insert into Temp_Adv(Advance_Bill_No, Customer_Name,Product_Name,Variety, Lot_No,Rate,Quantity,Delivery_Date) values ('" + id.Text + "', '" + fName.Text + "' ,'" + products.Text + "','" + variety.Text + "','" + lotno.Text + "', '" + rate.Text + "' , '" + quantity.Text + "',convert(date,'" + metroDateTime2.Value.ToShortDateString() + "',105))", con);
                            cmd1.ExecuteNonQuery();
                            SqlDataAdapter sda1 = new SqlDataAdapter("select Product_Name,Variety,Lot_No,Rate,Quantity,Total,Delivery_Date from Temp_Adv", con);
                            DataSet viewproducts = new DataSet();
                            sda1.Fill(viewproducts);
                            metroGrid1.DataSource = viewproducts.Tables[0];
                            metroGrid1.Columns[0].HeaderText = "Plant";
                            metroGrid1.Columns[0].Width = 100;

                            for (int n = 0; n < (metroGrid1.Rows.Count); n++)
                            {
                                double rate_var = Convert.ToDouble(metroGrid1.Rows[n].Cells[3].Value);
                                int quantity_var = Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value);
                                double total_var = rate_var * quantity_var;
                                //double vat_var = Convert.ToDouble(metroGrid1.Rows[n].Cells[6].Value);

                                //SqlCommand cc1 = new SqlCommand("SELECT Scheme_Quantity FROM Products WHERE Product_Name='" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "'", con);
                                //string sqty = cc1.ExecuteScalar().ToString();
                                //SqlCommand cc2 = new SqlCommand("SELECT Scheme_Free FROM Products WHERE Product_Name='" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "'", con);
                                //string sfree = cc2.ExecuteScalar().ToString();
                                //int free = (quantity_var / Convert.ToInt32(sqty)) * Convert.ToInt32(sfree);

                                //double vat_amount = (quantity_var) * (rate_var * (vat_var / 100));
                                //double ttotal = amount_var + vat_amount;

                                metroGrid1.Rows[n].Cells[5].Value = Math.Truncate(total_var * 100) / 100;

                                //metroGrid1.Rows[n].Cells[5].Value = Math.Truncate(amount_var * 100) / 100;
                                //metroGrid1.Rows[n].Cells[7].Value = Math.Truncate(vat_amount * 100) / 100;
                                //metroGrid1.Rows[n].Cells[8].Value = Math.Truncate(ttotal * 100) / 100;

                                //SqlCommand cmd1 = new SqlCommand("insert into Sales_Products(Sales_OrderID,Product_Name,Rate,Quantity,Amount,VAT,VAT_Amount,Total) values ('" + salesorderid.Text + "', '" + products.Text + "', '" + rate.Text + "' , '" + quantity.Text + "', '" + amount_var + "' ,'" + vat.Text + "' ,'" + vat_amount + "', '" + ttotal + "')", con);
                                //cmd1.ExecuteNonQuery();
                                //SqlCommand cmd2 = new SqlCommand("insert into Sales_Products(Sales_OrderID,Product_Name,Rate,Quantity,VAT,VAT_Amount,Total) values ('" + salesorderid.Text + "', '" + products.Text + "', '" + rate.Text + "' , '" + quantity.Text + "','" + vat.Text + "' ,'" + vat_amount + "', '" + ttotal + "')", con);
                                //cmd2.ExecuteNonQuery();
                            }

                            double producttotal = 0, gtotal = 0;
                            for (int i = 0; i < metroGrid1.Rows.Count; i++)
                            {
                                producttotal += Convert.ToInt32(metroGrid1.Rows[i].Cells[4].Value);
                                gtotal += Convert.ToDouble(metroGrid1.Rows[i].Cells[5].Value);
                            }
                            totalquantity.Text = producttotal.ToString();
                            total.Text = gtotal.ToString();
                            totalproducts.Text = metroGrid1.Rows.Count.ToString();
                        }
                        con.Close();


                    }
                    products.Text = "";
                    lotno.Text = "";
                    variety.Text = "";
                    quantity.Text = "";
                    rate.Text = "";

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

                quantity.Text = "";
                        
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroGrid1.RowCount > 0)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("delete from Advance_Billing where Product_Name = '" + metroGrid1.SelectedRows[0].Cells[0].Value.ToString() + "' and Variety= '" + metroGrid1.SelectedRows[0].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.SelectedRows[0].Cells[2].Value.ToString() + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                //-------------
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("select Product_Name,Variety,Lot_No,Rate,Quantity,Total,Delivery_Date from Advance_Billing", con);
                DataSet viewproducts1 = new DataSet();
                sda1.Fill(viewproducts1);
                metroGrid1.DataSource = viewproducts1.Tables[0];
                con.Close();

                //============Upgrading Total Quantity after deletion===========
                for (int n = 0; n < (metroGrid1.Rows.Count); n++)
                {
                    double rate_var = Convert.ToDouble(metroGrid1.Rows[n].Cells[3].Value);
                    int quantity_var = Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value);
                    double total_var = rate_var * quantity_var;
                    //double vat_var = Convert.ToDouble(metroGrid1.Rows[n].Cells[6].Value);

                    //SqlCommand cc1 = new SqlCommand("SELECT Scheme_Quantity FROM Products WHERE Product_Name='" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "'", con);
                    //string sqty = cc1.ExecuteScalar().ToString();
                    //SqlCommand cc2 = new SqlCommand("SELECT Scheme_Free FROM Products WHERE Product_Name='" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "'", con);
                    //string sfree = cc2.ExecuteScalar().ToString();
                    //int free = (quantity_var / Convert.ToInt32(sqty)) * Convert.ToInt32(sfree);

                    //double vat_amount = (quantity_var) * (rate_var * (vat_var / 100));
                    //double ttotal = amount_var + vat_amount;

                    metroGrid1.Rows[n].Cells[5].Value = Math.Truncate(total_var * 100) / 100;

                    //metroGrid1.Rows[n].Cells[5].Value = Math.Truncate(amount_var * 100) / 100;
                    //metroGrid1.Rows[n].Cells[7].Value = Math.Truncate(vat_amount * 100) / 100;
                    //metroGrid1.Rows[n].Cells[8].Value = Math.Truncate(ttotal * 100) / 100;

                    //SqlCommand cmd1 = new SqlCommand("insert into Sales_Products(Sales_OrderID,Product_Name,Rate,Quantity,Amount,VAT,VAT_Amount,Total) values ('" + salesorderid.Text + "', '" + products.Text + "', '" + rate.Text + "' , '" + quantity.Text + "', '" + amount_var + "' ,'" + vat.Text + "' ,'" + vat_amount + "', '" + ttotal + "')", con);
                    //cmd1.ExecuteNonQuery();
                    //SqlCommand cmd2 = new SqlCommand("insert into Sales_Products(Sales_OrderID,Product_Name,Rate,Quantity,VAT,VAT_Amount,Total) values ('" + salesorderid.Text + "', '" + products.Text + "', '" + rate.Text + "' , '" + quantity.Text + "','" + vat.Text + "' ,'" + vat_amount + "', '" + ttotal + "')", con);
                    //cmd2.ExecuteNonQuery();
                }

                double producttotal = 0, gtotal = 0;
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    producttotal += Convert.ToInt32(metroGrid1.Rows[i].Cells[4].Value);
                    gtotal += Convert.ToDouble(metroGrid1.Rows[i].Cells[5].Value);
                }
                totalquantity.Text = producttotal.ToString();
                total.Text = gtotal.ToString();
                totalproducts.Text = metroGrid1.Rows.Count.ToString();

            }
        }

        private void paid_Click(object sender, EventArgs e)
        {

        }

        private void paid_TextChanged(object sender, EventArgs e)
        {
            if (paid.Text != "")
            {
                if (Double.Parse(paid.Text) <= Double.Parse(total.Text))
                {
                    double paidamount = 0, remainingamount = 0;
                    paidamount = Double.Parse(paid.Text);
                    remainingamount = Double.Parse(total.Text) - paidamount;
                    remaining.Text = Convert.ToString(remainingamount);
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Amount....");
                    paid.Text = "0";
                }
            }
            else
            {
                double remainingamount = 0;
                remainingamount = Double.Parse(total.Text);
            }
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            if (paid.Text != "")
            {
                if (Double.Parse(paid.Text) <= Double.Parse(total.Text))
                {
                    double paidamount = 0, remainingamount = 0;
                    paidamount = Double.Parse(paid.Text);
                    remainingamount = Double.Parse(total.Text) - paidamount;
                    remaining.Text = Convert.ToString(remainingamount);
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Amount....");
                    paid.Text = "0";
                }
            }
            else
            {
                double remainingamount = 0;
                remainingamount = Double.Parse(total.Text);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            FrmRptAdvBill fab = new FrmRptAdvBill();
            FrmAdvance1.name = nam1;
            FrmAdvance1.no = n1;
            fab.ShowDialog();
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmdf = new SqlCommand("SELECT Customer_Name FROM Customer", con);
            con.Open();
            SqlDataReader reader = cmdf.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            fName.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void fName_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Mobile_Number,Address from Customer where Customer_Name='" + fName.Text + "'", con);
            SqlDataReader sdr3 = cmd.ExecuteReader();

            while (sdr3.Read())
            {
                mobileNo.Text = sdr3["Mobile_Number"].ToString();
                city.Text = sdr3["Address"].ToString();
            }
            sdr3.Close();
            con.Close();
        }

      






    }
}
