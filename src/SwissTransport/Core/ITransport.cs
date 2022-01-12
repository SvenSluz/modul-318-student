namespace SwissTransport.Core
{
    using SwissTransport.Models;
    using System.Threading.Tasks;


    public interface ITransport
    {
        Task<Stations> GetStationsAsync(string query);

        Stations GetStations(string query);

        Task<StationBoardRoot> GetStationBoardAsync(string station, string id);

        StationBoardRoot GetStationBoard(string station, string id);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation);

        Connections GetConnections(string fromStation, string toStation);

        Task<Connections> GetConnectionWithTime(string date, string time, string fromStation, string toStation);

        Task<Connections> GetSingleConnectionWithDateTimeAsync(string date, string time, string fromStation, string toStation);
    }
}