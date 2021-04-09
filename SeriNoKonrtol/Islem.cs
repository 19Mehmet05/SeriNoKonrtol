using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace SeriNoKonrtol
{
    
   public static class Islem
    {

        private static string fingerPrint = string.Empty;
        public static string Value()
        {
            if (string.IsNullOrEmpty(fingerPrint))
            {
                string plainText = "NAME >> " + Deger();
                   

                fingerPrint = Deger();
            }
            return fingerPrint;
        }
       
       
            public static String CPUSeriNoCek()
        {
            String processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
        }
        public static String EkranSeriNoCek()
        {

            string displaycard = null;
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (var o in managementObjectSearcher.Get())
            {
                var managementObject = (ManagementObject)o;
                foreach (PropertyData properties in managementObject.Properties)
                {
                    if (properties.Name == "SerialNumber")
                    {
                        displaycard = properties.Value.ToString();
                    }
                }
            }
            return displaycard;
        }
        public static String AnakartSeriNoCek()
        {
            string motherBoardSerialNumber = null;
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (var o in managementObjectSearcher.Get())
            {
                var managementObject = (ManagementObject)o;
                foreach (PropertyData properties in managementObject.Properties)
                {
                    if (properties.Name == "SerialNumber")
                    {
                        motherBoardSerialNumber = properties.Value.ToString();
                        if (motherBoardSerialNumber!=null)
                        {
                            break;
                        }
                    }
                }
            }
            return motherBoardSerialNumber;
        }
        public static string Deger()
        {
            string deger = null;
            deger = Islem.AnakartSeriNoCek()  + Islem.EkranSeriNoCek() +  Islem.CPUSeriNoCek();
            return deger;
        }

    }
}
