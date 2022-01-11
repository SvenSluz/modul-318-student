using FluentAssertions;
using MyTransport;
using NUnit.Framework;
using Xunit;

namespace MyTransportTest
{
    internal class ConnectionProviderTest
    {
        public ConnectionProviderTest()
        {
            _connectionProvider = new ConnectionProvider();
        }

        private readonly MyTransport.ConnectionProvider _connectionProvider;

        [Test]
        public void ConnectionsWithTimeAndDateTest()
        {
            var connections =  _connectionProvider.GetConnectionsWithTimeAndDate("2015-01-01", "15:30", "Sursee", "Luzern");

            connections.Should().NotBeNull();
        }
        [Test]
        public void GetIdTest()
        {
            var id = _connectionProvider.GetId("Luzern");
            id.Should().Be("8505000");
        }
        [Test]
        public void GetStationBoardTest()
        {
            var stationBoard = _connectionProvider.GetStationBoard("Luzern", "8505000");
            stationBoard.Should().NotBeNull();
        }
        [Test]
        public void GetConnectionsTest()
        {
            var connections = _connectionProvider.GetConnections("Luzern", "Sursee");
            connections.Should().NotBeNull();
        }
        [Test]
        public void GetSimilarStationsTest()
        {
            var stations = _connectionProvider.GetSimilarStations("Sa").Result;
            stations.Should().NotBeNull();
        }
    }
}
