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
    {   [STAThread]
        static void Main()
         {
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
                 if (macAddress == String.Empty) //sHRI- 54E1AD490C38 F0921C5C74B6  000C292EA1E5  IAD-F80F4104AB1B     only return MAC Address from first card that has a MAC Address
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

