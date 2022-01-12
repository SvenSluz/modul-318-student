using FluentAssertions;
using MyTransport;
using NUnit.Framework;
using Xunit;

namespace MyTransportTest
{
    internal class DataProviderTest
    {
        public DataProviderTest()
        {
            _dataProvider = new DataProvider();
        }

        private readonly MyTransport.DataProvider _dataProvider;

        [Test]
        public void ConnectionsWithTimeAndDateTest()
        {
            var connections =  _dataProvider.GetConnectionsWithTimeAndDate("2015-01-01", "15:30", "Sursee", "Luzern");

            connections.Should().NotBeNull();
        }
        [Test]
        public void GetIdTest()
        {
            var id = _dataProvider.GetId("Luzern");
            id.Should().Be("8505000");
        }
        [Test]
        public void GetStationBoardTest()
        {
            var stationBoard = _dataProvider.GetStationBoard("Luzern", "8505000");
            stationBoard.Should().NotBeNull();
        }
        [Test]
        public void GetConnectionsTest()
        {
            var connections = _dataProvider.GetConnections("Luzern", "Sursee");
            connections.Should().NotBeNull();
        }
        [Test]
        public void GetSimilarStationsWithReturnTest()
        {
            var stations = _dataProvider.GetSimilarStations("Sa")?.Result;
            stations.Should().NotBeNull();
        }
        [Test]
        public void GetSimilarStationsWithNullReturnTest()
        {
            var stations = _dataProvider.GetSimilarStations("Safjdkl")?.Result;
            stations.Should().HaveCount(0);
        }
        [Test]
        public void GetConnectionWithDateAndTimeTest()
        {
            var stations = _dataProvider.GetConnectionsWithTimeAndDate("2022-01-01", "15:00", "Sursee", "Luzern");
            stations.Should().NotBeNull();
        }
        [Test]
        public void GetSingleConnectionTest()
        {
            var stations = _dataProvider.GetSingleConnection("2022-01-01", "15:00", "Sursee", "Luzern");
            stations.Should().NotBeNull();
        }



    }
}
