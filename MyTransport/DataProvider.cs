using SwissTransport.Core;
using SwissTransport.Models;

namespace MyTransport
{
    public class DataProvider
    {
        private readonly Transport _transport;
        public DataProvider()
        {
            _transport = new Transport();
        }

        public Task<List<string>>? GetSimilarStations(string input)
        {
            var stations = _transport.GetStationsAsync(input).GetAwaiter().GetResult();
            return (stations == null ? null : Task.FromResult(stations.StationList.Select(s => s.Name).ToList()));
        }

        public SwissTransport.Models.Connections GetConnections(string departureStation, string targetDestination)
        {
            return Task.Run(() => _transport.GetConnectionsAsync(departureStation, targetDestination)).GetAwaiter().GetResult();
        }


        public StationBoardRoot GetStationBoard(string name, string id)
        {
            return Task.Run(() => _transport.GetStationBoardAsync(name, id)).GetAwaiter().GetResult();
        }

        public string GetId(string text)
        {
            var stations = _transport.GetStationsAsync(text).GetAwaiter().GetResult();
            return stations.StationList[0].Id;
        }

        public SwissTransport.Models.Connections GetConnectionsWithTimeAndDate(string date, string time, string fromStation, string toStation)
        {
            var formattedDate = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
            var formattedTime = Convert.ToDateTime(time).ToString("HH:mm");

            var connections = Task.Run(() => _transport.GetConnectionWithTime(formattedDate, formattedTime, fromStation, toStation)).GetAwaiter().GetResult();
            return connections;
        }

        public Connection? GetSingleConnection(string date, string time, string fromStation, string toStation)
        {
            var formattedDate = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
            var formattedTime = Convert.ToDateTime(time).ToString("HH:mm");

            var connection = Task.Run(() => _transport.GetSingleConnectionWithDateTimeAsync(formattedDate, formattedTime, fromStation, toStation)).GetAwaiter().GetResult();
            return connection.ConnectionList.FirstOrDefault();

        }
    }
}
