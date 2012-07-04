using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgramManager.Client.Controllers
{
    public class OutputManager
    {
        private static OutputManager _instance = null;

        public string ReportWeekScheduleTemplatePath
        {
            get
            {
                return Path.Combine(ConfigurationClasses.SettingsManager.Instance.OutputRootPath, "WeekSchedule{0}.xls");
            }
        }

        public string ReporActivityListTemplatePath
        {
            get
            {
                return Path.Combine(ConfigurationClasses.SettingsManager.Instance.OutputRootPath, "ActivityList.xls");
            }
        }

        public static OutputManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OutputManager();
                return _instance;
            }
        }

        private OutputManager()
        {
        }
    }
}
