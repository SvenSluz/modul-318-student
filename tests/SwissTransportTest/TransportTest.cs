﻿namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using System.Threading.Tasks;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public async Task LocationsAsync()
        {
            Stations stations = await this.testee.GetStationsAsync("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public async Task StationBoardAsync()
        {
            StationBoardRoot stationBoard = await this.testee.GetStationBoardAsync("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public async Task ConnectionsAsync()
        {
            Connections connections = await this.testee.GetConnectionsAsync("Sursee", "Luzern");

            connections.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern");

            connections.Should().NotBeNull();
        }

        [Fact]
        public async Task ConnectionsWithTimeAndDate()
        {
            Connections connections = await this.testee.GetConnectionWithTime("2022-01-01", "15:00", "Sursee", "Luzern");

            connections.Should().NotBeNull();
        }

        [Fact]
        public async Task GetSingleConnectionWithDateTimeTest()
        {
            Connections connections = await this.testee.GetSingleConnectionWithDateTimeAsync("2022-01-01", "15:00", "Sursee", "Luzern");

            connections.ConnectionList.Should().HaveCount(1);
        }
    }
}