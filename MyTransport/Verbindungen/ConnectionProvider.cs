using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTransport.Verbindungen
{
    internal class ConnectionProvider
    {
        private readonly Transport _transport;
        public ConnectionProvider()
        {
            _transport = new Transport();
        }

        internal List<string> GetSimilarStationsAsync(string input)
        {
            try
            {
                SwissTransport.Models.Stations? s = Task.Run(() => _transport.GetStationsAsync(input)).GetAwaiter().GetResult();
                return s.StationList.Select(s => s.Name).ToList();

            }
            catch (Exception)
            {
                return null;
            }

        }

        internal object GetConnections(string departureStation, string targetDestination)
        {
            return null;
        }
    } 
}
