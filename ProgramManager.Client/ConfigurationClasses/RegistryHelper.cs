using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ProgramManager.Client.ConfigurationClasses
{
    public static class RegistryHelper
    {
        public static IntPtr MainFormHandle
        {
            get
            {
                int result = 0;
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\NewBizWiz", RegistryKeyPermissionCheck.ReadSubTree);
                if (key != null)
                {
                    object value = key.GetValue("MainFormHandle", false);
                    if (value != null)
                        int.TryParse(value.ToString(), out result);
                }
                return new IntPtr(result);
            }
            set
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software", RegistryKeyPermissionCheck.ReadWriteSubTree).CreateSubKey("NewBizWiz", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (key != null)
                    key.SetValue("MainFormHandle", value.ToInt32(), RegistryValueKind.DWord);
            }
        }

        public static IntPtr MinibarHandle
        {
            get
            {
                int result = 0;
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\NewBizWiz", RegistryKeyPermissionCheck.ReadSubTree);
                if (key != null)
                {
                    object value = key.GetValue("MinibarHandle", false);
                    if (value != null)
                        int.TryParse(value.ToString(), out result);
                }
                return new IntPtr(result);
            }
            set
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software", RegistryKeyPermissionCheck.ReadWriteSubTree).CreateSubKey("NewBizWiz", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (key != null)
                    key.SetValue("MinibarHandle", value.ToInt32(), RegistryValueKind.DWord);
            }
        }
    }
}
