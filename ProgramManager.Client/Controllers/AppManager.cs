using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager.Client.Controllers
{
    class AppManager
    {
        private static AppManager _instance = new AppManager();

        public CoreObjects.ApplicationLog Log { get; private set; }

        private AppManager()
        {
            this.Log = new CoreObjects.ApplicationLog(ConfigurationClasses.SettingsManager.Instance.LogFilePath);
        }

        public static AppManager Instance
        {
            get
            {
                return _instance;
            }
        }

        public void RunForm()
        {
            Application.Run(FormMain.Instance);
        }

        public void ActivateForm(IntPtr handle, bool maximized, bool topMost)
        {
            InteropClasses.WinAPIHelper.ShowWindow(handle, maximized ? InteropClasses.WindowShowStyle.ShowMaximized : InteropClasses.WindowShowStyle.ShowNormal);
            uint lpdwProcessId = 0;
            InteropClasses.WinAPIHelper.AttachThreadInput(InteropClasses.WinAPIHelper.GetCurrentThreadId(), InteropClasses.WinAPIHelper.GetWindowThreadProcessId(InteropClasses.WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), true);
            InteropClasses.WinAPIHelper.SetForegroundWindow(handle);
            InteropClasses.WinAPIHelper.AttachThreadInput(InteropClasses.WinAPIHelper.GetCurrentThreadId(), InteropClasses.WinAPIHelper.GetWindowThreadProcessId(InteropClasses.WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), false);
            if (topMost)
                InteropClasses.WinAPIHelper.MakeTopMost(handle);
            else
                InteropClasses.WinAPIHelper.MakeNormal(handle);
        }

        public void ActivateMainForm()
        {
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList.Where(x => x.ProcessName.ToLower().Contains("ProgramManager")))
            {
                if (process.MainWindowHandle.ToInt32() != 0)
                {
                    ActivateForm(process.MainWindowHandle, true, false);
                    break;
                }
            }
        }

        public void ReleaseComObject(object o)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(o);
            }
            catch
            {
            }
            finally
            {
                o = null;
            }
        }

        public void ShowWarning(string text)
        {
            MessageBox.Show(text, ConfigurationClasses.SettingsManager.Instance.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public DialogResult ShowWarningQuestion(string text)
        {
            return MessageBox.Show(text, ConfigurationClasses.SettingsManager.Instance.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public void ShowInformation(string text)
        {
            MessageBox.Show(text, ConfigurationClasses.SettingsManager.Instance.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Folders Stuff
        private void MakeFolderAvailable(DirectoryInfo folder)
        {
            try
            {
                foreach (DirectoryInfo subFolder in folder.GetDirectories())
                    MakeFolderAvailable(subFolder);
                foreach (FileInfo file in folder.GetFiles())
                    if (File.Exists(file.FullName))
                        File.SetAttributes(file.FullName, FileAttributes.Normal);
            }
            catch(Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
            }
        }

        public void DeleteFolder(DirectoryInfo folder, string filter = "")
        {
            try
            {
                MakeFolderAvailable(folder);
                foreach (DirectoryInfo subFolder in folder.GetDirectories())
                    DeleteFolder(subFolder, filter);
                foreach (FileInfo file in folder.GetFiles())
                {
                    try
                    {
                        if (File.Exists(file.FullName) && (folder.Name.Contains(filter) || string.IsNullOrEmpty(filter)))
                            File.Delete(file.FullName);
                    }
                    catch
                    {
                        try
                        {
                            System.Threading.Thread.Sleep(100);
                            if (File.Exists(file.FullName) && (folder.Name.Contains(filter) || string.IsNullOrEmpty(filter)))
                                File.Delete(file.FullName);
                        }
                        catch (Exception ex)
                        {
                            AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                            AppManager.Instance.Log.Save();
                        }
                    }
                }
                try
                {
                    if (Directory.Exists(folder.FullName) && (folder.Name.Contains(filter) || string.IsNullOrEmpty(filter)))
                        Directory.Delete(folder.FullName, false);
                }
                catch
                {
                    try
                    {
                        System.Threading.Thread.Sleep(100);
                        if (Directory.Exists(folder.FullName) && (folder.Name.Contains(filter) || string.IsNullOrEmpty(filter)))
                            Directory.Delete(folder.FullName, false);
                    }
                    catch (Exception ex)
                    {
                        AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                        AppManager.Instance.Log.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
            }
        }
        #endregion
    }
}
