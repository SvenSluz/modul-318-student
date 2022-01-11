using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MyTransport.Connections
{
    internal class ConnectionProvider
    {
        private readonly Transport _transport;
        public ConnectionProvider()
        {
            _transport = new Transport();
        }

        internal Task<List<Tuple<string, string>>> GetSimilarStations(string input)
        {
            try
            {
                SwissTransport.Models.Stations? stations = _transport.GetStationsAsync(input).GetAwaiter().GetResult();
                return Task.FromResult(stations.StationList.Select(s => new Tuple<string, string>(s.Name, s.Id)).ToList());
                
            }
            catch (Exception)
            {
                return Task.FromResult<List<Tuple<string, string>>>(null);
            }

        }

        internal SwissTransport.Models.Connections GetConnections(string departureStation, string targetDestination)
        {
            return Task.Run(()=>_transport.GetConnectionsAsync(departureStation, targetDestination)).GetAwaiter().GetResult();
        }


        public StationBoardRoot GetStationBoard(string name, string id)
        {
            return Task.Run(() => _transport.GetStationBoardAsync(name, id)).GetAwaiter().GetResult();
        }

        public string GetId(string text)
        {
            return GetSimilarStations(text).Result.First().Item2;
        }

        public SwissTransport.Models.Connections GetConnectionsWithTimeAndDate(string date, string time, string fromStation, string toStation)
        {
            var formattedDate = Convert.ToDateTime(date).ToString("yyyy-MM-dd");
            var formattedTime = Convert.ToDateTime(time).ToString("HH:mm");
            

            var connections = Task.Run(()=>_transport.GetConnectionWithTime(formattedDate, formattedTime, fromStation, toStation)).GetAwaiter().GetResult();
            return connections;
        }
    } 
}
