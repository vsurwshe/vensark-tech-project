using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Net.NetworkInformation;
using System.Data;
using System.Management;
namespace gst
{
    static class Program
    {
        
        
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           //  SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
           //  SqlCeCommand cmd = new SqlCeCommand("SELECT lic FROM login where key =7",conn);
           //String tl="";
           // conn.Open();
           //     //using (SqlCeDataReader read = cmd.ExecuteReader())
           //     //{
                   
           //     //    while (read.Read())
           //     //    {
           //     //        tl = (read["lic"].ToString());
                      
                       
           //     //    }
           //     //}
           // DataSet ds;
           // using (SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT lic FROM login where key =7", conn))
           // {
           //   ds = new DataSet();
           //   adapter.Fill(ds);
           // }

           // MessageBox.Show( ds.Tables[0].Rows[0].Field<String>("lic"));
           //String macAddresses = "";
           // if (Properties.Settings.Default.mac == "mac")
           // {
           //foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
           //{
           //    if (nic.OperationalStatus == OperationalStatus.Up)
           //    {
           //        macAddresses += nic.GetPhysicalAddress().ToString();
           //        break;
           //    }
           //}
           ////     Properties.Settings.Default.mac =  macAddresses);
           //     Properties.Settings.Default.Save();
           // }
           //if (mac == "")
           //{
           //    mac = macAddresses;
           //}
           ////else
           ////{
            ManagementObjectSearcher objMOS = new ManagementObjectSearcher("Select * FROM Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMOS.Get();
            string macAddress = String.Empty;
            foreach (ManagementObject objMO in objMOC)
            {
                object tempMacAddrObj = objMO["MacAddress"];

                if (tempMacAddrObj == null) //Skip objects without a MACAddress
                {
                    continue;
                }
                if (macAddress == String.Empty) //54E1AD490C38  F80F4104AB1B F0921C5C74B6 000C292EA1E5  only return MAC Address from first card that has a MAC Address
                {
                    macAddress = tempMacAddrObj.ToString();
                }
                objMO.Dispose();
            }
            macAddress = macAddress.Replace(":", "");
            if (macAddress != "54E1AD490C38")
               {
                   MessageBox.Show("For more information visit// http://vensarktechnologies.com", "Buy a license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   Application.Exit();
               }
               else
               {
                   Application.EnableVisualStyles();
                   Application.SetCompatibleTextRenderingDefault(false);
                   Application.Run(new Main());

               }
           }
        }
    }

