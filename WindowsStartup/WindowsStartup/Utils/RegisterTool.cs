using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsStartup.Utils
{
    public class RegisterTool
    {
        public static bool Write(string key, string name, string value)
        {
            try
            {
                RegistryKey RKey = Registry.LocalMachine.OpenSubKey(key, true);
                if (RKey == null)
                    RKey = Registry.LocalMachine.CreateSubKey(key);
                RKey.SetValue(name, value);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static string Read(string key, string name)
        {
            try
            {
                RegistryKey RKey = Registry.LocalMachine.OpenSubKey(key, true);
                if (RKey != null)
                {
                    return RKey.GetValue(name) != null ? RKey.GetValue(name).ToString() : "";
                }
            }
            catch (Exception e) { }
            return null;
        }
        public static bool Delete(string key, string name)
        {
            try
            {
                RegistryKey RKey = Registry.LocalMachine.OpenSubKey(key, true);
                if (RKey != null)
                    RKey.DeleteValue(name);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
