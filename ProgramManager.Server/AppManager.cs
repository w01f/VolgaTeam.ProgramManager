using System;
using System.Windows.Forms;
using System.ServiceModel;

namespace ProgramManager.Server
{
    class AppManager
    {
        private static AppManager instance = new AppManager();

        private AppManager()
        {
        }

        public static AppManager Instance
        {
            get
            {
                return instance;
            }
        }

        public void RunForm()
        {
            ServiceHost host = new ServiceHost(typeof(Service.StationService));
            host.Open();
            Application.Run(new FormHidden());
            host.Close();
        }
    }
}
