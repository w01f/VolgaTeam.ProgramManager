using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager
{
    class AppManager
    {
        private static AppManager _instance = new AppManager();

        private AppManager()
        {
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

        public bool RunPowerPoint()
        {
            return InteropClasses.PowerPointHelper.Instance.Connect();
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

        public void ActivatePowerPoint()
        {
            if (InteropClasses.PowerPointHelper.Instance.PowerPointObject != null)
            {
                IntPtr powerPointHandle = new IntPtr(InteropClasses.PowerPointHelper.Instance.PowerPointObject.HWND);
                InteropClasses.WinAPIHelper.ShowWindow(powerPointHandle, InteropClasses.WindowShowStyle.ShowMaximized);
                uint lpdwProcessId = 0;
                InteropClasses.WinAPIHelper.AttachThreadInput(InteropClasses.WinAPIHelper.GetCurrentThreadId(), InteropClasses.WinAPIHelper.GetWindowThreadProcessId(InteropClasses.WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), true);
                InteropClasses.WinAPIHelper.SetForegroundWindow(powerPointHandle);
                InteropClasses.WinAPIHelper.AttachThreadInput(InteropClasses.WinAPIHelper.GetCurrentThreadId(), InteropClasses.WinAPIHelper.GetWindowThreadProcessId(InteropClasses.WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), false);
            }
        }

        public void ActivateMiniBar()
        {
            IntPtr minibarHandle = ConfigurationClasses.RegistryHelper.MinibarHandle;
            if (minibarHandle.ToInt32() == 0)
            {
                Process[] processList = Process.GetProcesses();
                foreach (Process process in processList.Where(x => x.ProcessName.Contains("MiniBar")))
                {
                    if (process.MainWindowHandle.ToInt32() != 0)
                    {
                        minibarHandle = process.MainWindowHandle;
                        break;
                    }
                }
            }
            if (minibarHandle.ToInt32() != 0)
            {
                uint lpdwProcessId = 0;
                InteropClasses.WinAPIHelper.MakeTopMost(minibarHandle);
                InteropClasses.WinAPIHelper.AttachThreadInput(InteropClasses.WinAPIHelper.GetCurrentThreadId(), InteropClasses.WinAPIHelper.GetWindowThreadProcessId(InteropClasses.WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), true);
                InteropClasses.WinAPIHelper.SetForegroundWindow(minibarHandle);
                InteropClasses.WinAPIHelper.AttachThreadInput(InteropClasses.WinAPIHelper.GetCurrentThreadId(), InteropClasses.WinAPIHelper.GetWindowThreadProcessId(InteropClasses.WinAPIHelper.GetForegroundWindow(), out lpdwProcessId), false);
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
            MessageBox.Show(text, "Program Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public DialogResult ShowWarningQuestion(string text)
        {
            return MessageBox.Show(text, "Program Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        public void ShowInformation(string text)
        {
            MessageBox.Show(text, "Program Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
