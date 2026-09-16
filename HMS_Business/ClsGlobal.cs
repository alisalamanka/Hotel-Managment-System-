using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class CLSglobal
    {
        public static Clsuser LoggedInUser;

        public static bool RememberUserNameAndPassword(string userName, string password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\Software\HMS";
            string ValueName = "UserCredintials";
            string LineTosave = userName + "#//#" + password;

            bool Setted = false;

            try
            {
                // Read the value from the Registry
                Registry.SetValue(keyPath, ValueName, LineTosave);

                Setted = true;
            }
            catch (Exception ex)
            {
                Setted = false;
                throw new Exception(ex.Message);

            }
            return Setted;
        }

        public static bool GetCurrentCredential(ref string UserName, ref string Password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\Software\HMS";
            string ValueName = "UserCredintials";


            try
            {
                // Read the value from the Registry
                string LineOfData = Registry.GetValue(keyPath, ValueName, null) as string;
                if (LineOfData != null)
                {
                    string[] Credentials = LineOfData.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    if (Credentials.Length == 2)
                    {
                        UserName = Credentials[0];
                        Password = Credentials[1];
                    }
                    return true;
                }
                else
                {
                    UserName = "";
                    Password = "";
                    return false;
                }
            }
            catch (Exception)
            {
                UserName = "";
                Password = "";
                return false;
                //throw new Exception(ex.Message);
            }

        }
    }
}
