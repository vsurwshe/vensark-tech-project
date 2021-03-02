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
    public partial class Sales_Bill : Form
    {
        public Sales_Bill()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void Sales_Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hirkaniDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.hirkaniDataSet.Products);
            //=============
            metroLabel6.Visible = false;
            bfp.Visible = false;
            SqlCommand cmdf = new SqlCommand("SELECT Customer_Name FROM Customer", con);
            con.Open();
            SqlDataReader reader = cmdf.ExecuteReader();
          //  SqlCommand cm = new SqlCommand("select Product_Name from Products", con);
           // con.Open();
           // SqlDataReader sdr = cm.ExecuteReader();

            while (reader.Read())
            {
                customername.Items.Add(reader["Customer_Name"]);
            }

            con.Close();
            /////
            SqlCommand cmdf1 = new SqlCommand("SELECT Advance_Bill_No FROM Advance_Sowing where Status='" + "Done" + "' GROUP BY Advance_Bill_No", con);
            con.Open();
            comboBox1.Items.Clear();
            SqlDataReader reader1 = cmdf1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox1.Items.Add(reader1["Advance_Bill_No"]);
            }

            con.Close();
            
            
            //AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //while (reader.Read())
            //{
            //    MyCollection.Add(reader.GetString(0));
            //}
            //customername.AutoCompleteCustomSource = MyCollection;
            //con.Close();
            ////=============

            con.Open();
            SqlCommand cmd4 = new SqlCommand("delete Billing", con);
            cmd4.ExecuteNonQuery();
            con.Close();
              
            createid();

            metroButton1.UseSelectable = false;
            submit.UseSelectable = false;
            metroButton3.UseSelectable = false;

            //distributorname.SelectedIndex = distributorname.FindStringExact("");

         
            //products.Items.Clear();
            /*con.Open();
            
            SqlCommand cmd = new SqlCommand("select Product_Name from Products where Brand='" + metroComboBox1.Text + "'", con);
            SqlCommand cmd1 = new SqlCommand("select Brand_VAT from Brands where Brand_Name='" + metroComboBox1.Text + "'", con);
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    products.Items.Add(sdr["Product_Name"]);
                }


                sdr.Close();

                SqlDataReader sdr1 = cmd1.ExecuteReader();

                while (sdr1.Read())
                {
                    //vat.Text = sdr1["Brand_VAT"].ToString();
                }


                sdr1.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            metroGrid1.AutoGenerateColumns = true;
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Product_Name,Variety,Lot_No,Rate,Quantity,Total from Billing", con);
            DataSet viewproducts = new DataSet();
            sda1.Fill(viewproducts);
            metroGrid1.DataSource = viewproducts.Tables[0];
           

            ////metroGrid1.Columns[0].HeaderText = "SN";
            ////metroGrid1.Columns[0].Width = 40;
            metroGrid1.Columns[2].HeaderText = "Lot No";
            metroGrid1.Columns[2].Width = 150;
            metroGrid1.Columns[0].HeaderText = "Product Name";
            metroGrid1.Columns[0].Width = 100;
            metroGrid1.Columns[1].Width = 150;
            metroGrid1.Columns[3].Width = 100;
            metroGrid1.Columns[4].Width = 100;
            metroGrid1.Columns[5].HeaderText = "Total";
            metroGrid1.Columns[5].Width = 100;

            con.Close();


            //To view rate first time


            //con.Open();
            //rate.Text = "0";
            //SqlCommand cmd1 = new SqlCommand("select Rate from Stock where Plant_Name='" + products.Text + "' and Lot_No='"+lotno.Text+"'", con);
            //SqlDataReader sdr13 = cmd1.ExecuteReader();
            //sdr13.Read();
            //if (sdr13.Read())
            //{
            //    textBox1.Text = sdr13["Rate"].ToString();
            //    Console.WriteLine("Rate=" + rate.Text);
            //}


            //////while (sdr13.Read())
            ////{
            ////    rate.Text = sdr13["Rate"].ToString();
            ////    Console.WriteLine("Rate="+rate.Text);
            ////}
            //sdr13.Close();
            //con.Close();

            //try
            //{

            //    con.Open();
            //    string str2 = "select Rate from Stock where Plant_Name='" + products.Text + "' and Lot_No='" + lotno.Text + "'";
            //    SqlCommand cmd2 = new SqlCommand(str2, con);
            //    SqlDataReader sdar2 = cmd2.ExecuteReader();
            //    sdar2.Read();
            //    rate.Text = sdar2["Rate"].ToString();
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}




        }

        private void createid()
        {
            metroLabel6.Visible = false;
            bfp.Visible = false;
            string dt = DateTime.Now.ToString("yy") + "-" + DateTime.Now.AddYears(1).ToString("yy")+"/";
            string soid = dt;
            con.Open();
            SqlCommand inq = new SqlCommand("SELECT COUNT(*) AS count FROM Sales WHERE SUBSTRING(Sales_OrderID,1,6)='" + soid + "'", con);
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

            salesorderid.Text = soid;
           

        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            if (customername.Text != "")
            {
                //dname.Text = distributorname.Text;
                //customername.Visible = false;
                //dname.Visible = true;
                //try
                //{
                    if (products.Text != "")
                    {

                        if (quantity.Text != "")
                        {

                            //==========
                            //bool IsDuplicate = false;
                            //for (int i = 0; i < metroGrid1.Rows.Count; i++) 
                            //{
                            //    if (products.Text == metroGrid1.Rows[i].Cells[0].Value.ToString() && variety.Text == metroGrid1.Rows[i].Cells[1].Value.ToString() && lotno.Text == metroGrid1.Rows[i].Cells[2].Value.ToString())
                            //    {
                            //        IsDuplicate = true;
                            //        MessageBox.Show("The Product is Already Added...");
                            //        break;
                            //    }
                            //}
                            //if (!IsDuplicate)
                            //{
                                con.Open();
                                int cnt = metroGrid1.RowCount + 1;
                                SqlCommand cmd = new SqlCommand("insert into Billing(Sales_OrderID, Customer_Name,Product_Name,Variety, Lot_No,Rate,Quantity) values ('" + salesorderid.Text + "', '" + customername.Text + "' ,'" + products.Text + "','"+variety.Text+"','" + lotno.Text + "', '" + rate.Text + "' , '" + quantity.Text + "')", con);
                                cmd.ExecuteNonQuery();

                                con.Close();

                                
                                

                           // }
                            //==========

                            con.Open();
                            SqlDataAdapter sda1 = new SqlDataAdapter("select Product_Name,Variety,Lot_No,Rate,Quantity,Total from Billing", con);
                            DataSet viewproducts = new DataSet();
                            sda1.Fill(viewproducts);
                            metroGrid1.DataSource = viewproducts.Tables[0];

                            //ProductName.SelectedIndex = -1;
                            //Quantity.ResetText();


                            //======



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
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

                quantity.Text = "";
            }
            else 
            {
                MessageBox.Show("Please Select Customer Name...");
            }
            products.Text = "";
            lotno.Text = "";
            variety.Text = "";
            rate.Text = "";

        }

        

        private void metroGrid1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //for (int n = 0; n < (metroGrid1.Rows.Count); n++)
            //{

            //    int quantity = Convert.ToInt32(metroGrid1.Rows[n].Cells[2].Value);
            //    double amount = Convert.ToDouble(metroGrid1.Rows[n].Cells[3].Value);
            //    double vat = Convert.ToDouble(metroGrid1.Rows[n].Cells[4].Value);
            //    double ttotal = (quantity * quantity) + (quantity * quantity) * vat / 100;
            //    metroGrid1.Rows[n].Cells[5].Value = ttotal;

            //}

            //double products = 0,gtotal=0;
            //for (int i = 0; i < metroGrid1.Rows.Count; i++)
            //{
            //    products += Convert.ToInt32(metroGrid1.Rows[i].Cells[2].Value);
            //    gtotal += Convert.ToInt32(metroGrid1.Rows[i].Cells[5].Value);
            //}
            //totalproducts.Text = products.ToString();
            //total.Text = gtotal.ToString();

            //SqlCommand cmd1 = new SqlCommand("insert into Sales(Sales_OrderID,Total_Products,Total) values ('" + salesorderid.Text + "', '" + totalproducts.Text + "' , '" + total.Text + "')", con);
            //cmd1.ExecuteNonQuery();
      

        }

        //private void products_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select Rate from Products where Product_Name='" + products.Text + "'", con);
        //        SqlDataReader sdr3 = cmd.ExecuteReader();


        //        while (sdr3.Read())
        //        {
        //            rate.Text = sdr3["Rate"].ToString();
        //        }
        //        sdr3.Close();
        //    con.Close();
        //}

        private void paid_TextChanged(object sender, EventArgs e)
        {
            if (paid.Text != "")
            {
                if (Double.Parse(paid.Text) <= Double.Parse(total.Text))
                {
                    if (adv.Checked == true)
                    {
                        double paidamount = 0, remainingamount = 0;
                        paidamount = Double.Parse(paid.Text);
                        remainingamount =  Double.Parse(bfp.Text) - paidamount;
                        remaining.Text = Convert.ToString(remainingamount);
                    }
                    else
                    {
                        double paidamount = 0, remainingamount = 0;
                        paidamount = Double.Parse(paid.Text);
                        remainingamount = Double.Parse(total.Text) - paidamount;
                        remaining.Text = Convert.ToString(remainingamount);
                    }
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

        private void metroButton2_Click(object sender, EventArgs e)
        {       if (paid.Text != "")
                {

                    con.Open();

                    for (int n = 0; n < (metroGrid1.Rows.Count); n++)
                    {
                        SqlCommand cmd3 = new SqlCommand("insert into Sales_Products(Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity,Total) values ('" + salesorderid.Text + "', '" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "' , '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "', '" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "' , '" + metroGrid1.Rows[n].Cells[3].Value.ToString() + "', '" + metroGrid1.Rows[n].Cells[4].Value.ToString() + "', '" + metroGrid1.Rows[n].Cells[5].Value.ToString() + "')", con);
                        cmd3.ExecuteNonQuery();

                        SqlCommand cmd1 = new SqlCommand("update Billing set Total = '" + metroGrid1.Rows[n].Cells[5].Value.ToString() + "' where Product_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "' and Variety= '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                        cmd1.ExecuteNonQuery();

                        //SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) AS count FROM Sales WHERE SUBSTRING(Sales_OrderID,1,8)='" + soid + "'", con);
                        //qty = cmd5.ExecuteScalar().ToString();

                        SqlCommand cmd4 = new SqlCommand("Select Available from Stock Where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "'and Variety= '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                        SqlCommand cmd5 = new SqlCommand("Select Total_Stock from Stock Where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "'and Variety= '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                        SqlCommand cmd6 = new SqlCommand("Select Reserved from Stock Where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "'and Variety= '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);

                        int aval = (int)cmd4.ExecuteScalar();
                        int tplant = (int)cmd5.ExecuteScalar();


                        //int freeqty = (int)cmd5.ExecuteScalar();
                        int given = 0, left = 0, tqty = 0, resv = 0;
                        given = Int32.Parse(metroGrid1.Rows[n].Cells[4].Value.ToString());
                        //fgiven = Int32.Parse(metroGrid1.Rows[n].Cells[4].Value.ToString());
                        left = aval - given;
                        tqty = tplant - given;

                        //fleft = freeqty - fgiven;
                        //tqty = left + fleft;

                        if (adv.Checked == false)
                        {
                            SqlCommand upd = new SqlCommand("update Stock set Total_Stock='" + tqty + "', Available='" + left + "' where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "'and Variety= '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                            upd.ExecuteNonQuery();
                           
                        }
                        else
                        {
                            int res = (int)cmd6.ExecuteScalar();
                            resv = res - given;
                            SqlCommand upd = new SqlCommand("update Stock set Total_Stock='" + tqty + "',Reserved='" + resv + "' where Plant_Name='" + metroGrid1.Rows[n].Cells[0].Value.ToString() + "'and Variety= '" + metroGrid1.Rows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.Rows[n].Cells[2].Value.ToString() + "'", con);
                            upd.ExecuteNonQuery();
                            upd.CommandText = "insert into Billing (Sales_OrderID,Product_Name,Variety, Lot_No,Rate,Quantity) select Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity from Sales_Products";
                            upd.ExecuteNonQuery();
                            SqlCommand upd1 = new SqlCommand("update Advance_Sowing set Status='" + "Delivered" + "' where Advance_Bill_No='" + comboBox1.Text + "'", con);
                            upd1.ExecuteNonQuery();
                            upd.CommandText = "update Booking set Advance='" + remaining.Text + "' where BillNo='" + comboBox1.Text + "'";
                            upd.ExecuteNonQuery();

                        }
                        //con.Close();


                    }
                    SqlCommand cmd2 = new SqlCommand("insert into Sales(Sales_OrderID,Distributor_Name,MobNo,Sales_Date,Total_Products,Total_Quantity,Total,Paid,Remaining) values ('" + salesorderid.Text + "', '" + customername.Text + "','" + mobilenumber.Text + "',convert(date,'" + date.Text + "',105), '" + totalproducts.Text + "' ,'" + totalquantity.Text + "', '" + total.Text + "','" + paid.Text + "' , '" + remaining.Text + "')", con);
                    cmd2.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Inventory Updated...");
                    submit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please Enter Payment Amount");
                }

          
            
            
            
           
        }
        public static string sn = null;
        private void metroButton3_Click(object sender, EventArgs e)
        {
                sn = salesorderid.Text;
                Bill_Print b = new Bill_Print();
                b.Show();
            
           
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            if(quantity.Text!="")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Available from Stock Where Plant_Name='"+products.Text+"' and Lot_No='"+lotno.Text+"' and Variety='"+variety.Text+"'", con);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if(count<Convert.ToInt32(quantity.Text))
                {
                    MessageBox.Show("Remaining Products = "+count);
                    quantity.Text = "0";
                }
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroGrid1.RowCount > 0)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("delete from Billing where Product_Name = '" + metroGrid1.SelectedRows[0].Cells[0].Value.ToString() + "' and Variety= '" + metroGrid1.SelectedRows[0].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.SelectedRows[0].Cells[2].Value.ToString() + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                //-------------
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("select Product_Name,Variety,Lot_No,Rate,Quantity,Total from Billing", con);
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

        private void metroButton5_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Add_Customer ac = new Add_Customer();
            ac.ShowDialog();
            customername.Items.Clear();
            SqlCommand cmdf = new SqlCommand("SELECT Customer_Name FROM Customer", con);
            con.Open();
            SqlDataReader reader = cmdf.ExecuteReader();
            //  SqlCommand cm = new SqlCommand("select Product_Name from Products", con);
            // con.Open();
            // SqlDataReader sdr = cm.ExecuteReader();

            while (reader.Read())
            {
                customername.Items.Add(reader["Customer_Name"]);
            }

            con.Close();

            //SqlCommand cmdf = new SqlCommand("SELECT Customer_Name FROM Customer", con);
            //con.Open();
            //SqlDataReader reader = cmdf.ExecuteReader();
            //AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //while (reader.Read())
            //{
            //    MyCollection.Add(reader.GetString(0));
            //}
            //customername.AutoCompleteCustomSource = MyCollection;
            //con.Close();
        }

        private void customername_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Mobile_Number,Address from Customer where Customer_Name='" + customername.Text + "'", con);
            SqlDataReader sdr3 = cmd.ExecuteReader();

            while (sdr3.Read())
            {
                mobilenumber.Text = sdr3["Mobile_Number"].ToString();
                add.Text = sdr3["Address"].ToString();
            }
            sdr3.Close();
            con.Close();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Get_Product gp = new Get_Product();
            gp.ShowDialog();
            products.Text = Get_Product.pname;
            lotno.Text = Get_Product.plotno;
            rate.Text = Get_Product.prate;
            variety.Text = Get_Product.vt;
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

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void adv_CheckedChanged(object sender, EventArgs e)
        {
            if (adv.Checked == true)
            {
                SqlCommand cm = new SqlCommand("select BillNo from Booking", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                comboBox1.Items.Clear();
                while (sdr.Read())
                {
                    comboBox1.Items.Add(sdr["BillNo"]);
                }

                con.Close();
               
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //---------------------------------------------------------------------------------------------------------
            // VISHVANATH CODE
            String s = comboBox1.Text;
            con.Open();
            SqlCommand cmd33 = new SqlCommand("select * from Booking where BillNo='" + s + "'", con);
            cmd33.ExecuteNonQuery();
            SqlDataAdapter dr = new SqlDataAdapter();
            dr.SelectCommand = cmd33;
            DataSet ds = new DataSet();
            dr.Fill(ds, "Booking");
            con.Close();
            metroLabel6.Visible = true;
            bfp.Visible = true;
            customername.Text = ds.Tables[0].Rows[0][1].ToString();
            bfp.Text = ds.Tables[0].Rows[0][6].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Mobile_Number,Address from Customer where Customer_Name='" + customername.Text + "'", con);
            SqlDataReader sdr3 = cmd.ExecuteReader();

            while (sdr3.Read())
            {
                mobilenumber.Text = sdr3["Mobile_Number"].ToString();
                add.Text = sdr3["Address"].ToString();
            }
            sdr3.Close();
            con.Close();
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Product_Name,Variety,Lot_No,Rate,Quantity,Total from Hirkani.dbo.Advance_Billing where Advance_Bill_No='" + s + "'", con);
            DataSet viewproducts = new DataSet();
            sda1.Fill(viewproducts);
            metroGrid1.DataSource = viewproducts.Tables[0];


            for (int n = 0; n < (metroGrid1.Rows.Count); n++)
            {
                double rate_var = Convert.ToDouble(metroGrid1.Rows[n].Cells[3].Value);
                int quantity_var = Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value);
                double total_var = rate_var * quantity_var;
                metroGrid1.Rows[n].Cells[5].Value = Math.Truncate(total_var * 100) / 100;
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

            con.Close();



            //-----------------------------------------------------------------------------------------------------//
            // CHETAN SIR CODE
            
            //con.Open();
            //SqlCommand cmd33 = new SqlCommand("select FarmersName from Booking where BillNo='" + comboBox1.Text + "'", con);
            //cmd33.ExecuteNonQuery();
            //SqlDataAdapter dr = new SqlDataAdapter();
            //dr.SelectCommand = cmd33;
            //DataSet ds = new DataSet();
            //dr.Fill(ds,"FarmersName");
            //con.Close();
            //customername.Text = ds.Tables[0].Rows[0][0].ToString();

            ////customername.DataSource=ds;
            ////customername.ValueMember="FarmersName";
            ////customername.DisplayMember="FarmersName";


            ////SqlDataReader sdr33 = cmd33.ExecuteReader();
            ////string aaa = cmd3.ExecuteNonQuery().ToString();
            ////MessageBox.Show(aaa);

            ////while (sdr33.Read())
            ////{

            ////    customername.Text = sdr33["FarmersName"].ToString();
            ////}
            ////sdr33.Close();
            
            
            //customername.DropDownStyle.Equals("DropDownList");

            //con.Open();
            //SqlCommand cmd1 = new SqlCommand("delete from Billing", con);
            //cmd1.ExecuteNonQuery();
            //con.Close();

            
            //con.Open();
            ////SqlCommand cmd = new SqlCommand("insert into Billing(Product_Name,Variety, Lot_No,Rate,Quantity) select Product_Name,Variety,Lot_No,Rate,Quantity from Advance_Products where Advance_Bill_No='"+comboBox1.Text+"'", con);


            //SqlCommand cmd = new SqlCommand("insert into Billing(Product_Name,Variety, Lot_No,Rate,Quantity) SELECT Advance_Products.Product_Name, Advance_Products.Variety, Advance_Products.Lot_No, Advance_Products.Rate, Advance_Products.Quantity FROM Advance_Products INNER JOIN Advance_Sowing ON Advance_Products.Advance_Bill_No = Advance_Sowing.Advance_Bill_No AND Advance_Products.Product_Name = Advance_Sowing.Plant_Name AND Advance_Products.Variety = Advance_Sowing.Variety AND Advance_Products.Lot_No = Advance_Sowing.Lot_No AND Advance_Products.Quantity = Advance_Sowing.Quantity WHERE Advance_Sowing.Advance_Bill_No = '"+comboBox1.Text+"' AND Advance_Sowing.Status = 'Done'", con);
                        
            //cmd.ExecuteNonQuery();

            //con.Close();

            //con.Open();
            //SqlDataAdapter sda1 = new SqlDataAdapter("select Product_Name,Variety,Lot_No,Rate,Quantity,Total from Billing", con);
            //DataSet viewproducts1 = new DataSet();
            //sda1.Fill(viewproducts1);
            //metroGrid1.DataSource = viewproducts1.Tables[0];
            //con.Close();

            //con.Open();
            //            for (int n = 0; n < (metroGrid1.Rows.Count); n++)
            //                {
            //                    double rate_var = Convert.ToDouble(metroGrid1.Rows[n].Cells[3].Value);
            //                    int quantity_var = Convert.ToInt32(metroGrid1.Rows[n].Cells[4].Value);
            //                    double total_var = rate_var * quantity_var;
                                
            //                    metroGrid1.Rows[n].Cells[5].Value = Math.Truncate(total_var * 100) / 100;

                                
            //                    //SqlCommand cmd4 = new SqlCommand("insert into Billing(Sales_OrderID,Customer_Name) values('" + salesorderid.Text + "','" + customername.Text + "') where Product_Name = '" + metroGrid1.SelectedRows[n].Cells[0].Value.ToString() + "' and Variety= '" + metroGrid1.SelectedRows[n].Cells[1].Value.ToString() + "' and Lot_No='" + metroGrid1.SelectedRows[n].Cells[2].Value.ToString() + "'", con);
            //                    //cmd4.ExecuteNonQuery();

                                
            //                }

            //                double producttotal = 0, gtotal = 0;
            //                for (int i = 0; i < metroGrid1.Rows.Count; i++)
            //                {
            //                    producttotal += Convert.ToInt32(metroGrid1.Rows[i].Cells[4].Value);
            //                    gtotal += Convert.ToDouble(metroGrid1.Rows[i].Cells[5].Value);
            //                }
            //                totalquantity.Text = producttotal.ToString();
            //                total.Text = gtotal.ToString();
            //                totalproducts.Text = metroGrid1.Rows.Count.ToString();
                        
            //            con.Close();


            //            con.Open();
            //            SqlCommand cmd4 = new SqlCommand("update Billing set Sales_OrderID='" + salesorderid.Text + "' , Customer_Name='" + customername.Text + "'", con);
            //            cmd4.ExecuteNonQuery();
            //            con.Close();
                        

        }

       
     

    }
}
