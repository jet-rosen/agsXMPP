using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Management;
using System.Windows.Forms;



namespace Form02.Helpers
{
    class DeviceHelper
    {

        static public string getDeviceToken()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("Win32_Processor instance");
                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("Architecture: {0}", queryObj["Architecture"]);
                    //Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                    //Console.WriteLine("Family: {0}", queryObj["Family"]);
                    Console.WriteLine("ProcessorId: {0}", queryObj["ProcessorId"]);

                    if (queryObj["ProcessorId"].ToString() != "")
                    {
                        return queryObj["ProcessorId"].ToString();
                    }
                }
                
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
            return "";
        }

        static public string getDeviceName()
        {
            try
            {
                return Environment.MachineName;
            }
            catch
            {
                return "Unnamed PC";
            }
        }

        static public string getDeviceInfo()
        {
            return "";
        }

    }
}
