using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ProgramManager.Client.Controllers
{
    public class ServiceManager
    {
        private static Service.StationsServiceClient GetClient()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxBufferPoolSize = int.MaxValue;
            binding.MaxBufferSize = int.MaxValue;
            binding.MaxReceivedMessageSize = int.MaxValue;
            binding.ReaderQuotas.MaxArrayLength = int.MaxValue;
            EndpointAddress address = new EndpointAddress(string.Format("http://{0}:8080/program_manager", ConfigurationClasses.SettingsManager.Instance.ServerName));
            Service.StationsServiceClient client = new Service.StationsServiceClient(binding, address);
            foreach (OperationDescription op in client.Endpoint.Contract.Operations)
            {
                var dataContractBehavior = op.Behaviors.Find<DataContractSerializerOperationBehavior>();
                if (dataContractBehavior != null)
                    dataContractBehavior.MaxItemsInObjectGraph = int.MaxValue;
            }
            return client;
        }

        public static string[] GetStationsList()
        {
            try
            {
                return GetClient().GetStationList();
            }
            catch(Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
                return new string[] { };
            }
        }

        public static string[] GetFCCList()
        {
            try
            {
                return GetClient().GetFCCList();
            }
            catch(Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
                return new string[] { };
            }
        }

        public static string[] GetTypeList()
        {
            try
            {
                return GetClient().GetTypeList();
            }
            catch(Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
                return new string[] { };
            }
        }

        public static CoreObjects.StationInformation GetStationInfo(string stationName)
        {
            try
            {
                return GetClient().GetStationInfo(stationName);
            }
            catch(Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
                return null;
            }
        }

        public static CoreObjects.Station DownloadStation(string stationName)
        {
            try
            {
                return GetClient().DownloadStation(stationName); ;
            }
            catch(Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
                return null;
            }
        }

        public static bool UploadStation(CoreObjects.Station station)
        {
            try
            {
                GetClient().UploadStation(station);
                station.LastLoaded = DateTime.Now;
                station.SaveStationMetaData();
                return true;
            }
            catch(Exception ex)
            {
                AppManager.Instance.Log.Records.Add(new CoreObjects.LogRecord(ex));
                AppManager.Instance.Log.Save();
                return false;
            }
        }
    }
}
