using System.ServiceModel;

namespace ProgramManager.Service
{
    [ServiceContract]
    public interface IStationsService
    {
        [OperationContract]
        string[] GetStationList();
        [OperationContract]
        string[] GetFCCList();
        [OperationContract]
        string[] GetTypeList();

        [OperationContract]
        CoreObjects.StationInformation GetStationInfo(string stationName);
        [OperationContract]
        void UploadStation(CoreObjects.Station station);
        [OperationContract]
        CoreObjects.Station DownloadStation(string stationName);
    }
}
