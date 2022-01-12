using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using SwissTransport.Models;

namespace MyTransport.Connections
{
    public partial class ConnectionsForm : Form
    {
        private readonly DataProvider _dataProvider;
        private List<Connection?> _connections = new List<Connection?>();
        private List<string>? _suggestedStationsList = new List<string>();
        public ConnectionsForm()
        {
            InitializeComponent();
            _dataProvider = new DataProvider();
            DateTimePickerDeparture.Text = DateTime.Now.ToShortDateString();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxDepartureStation.Text) || string.IsNullOrWhiteSpace(comboBoxArrivalStation.Text))
            {
                return;
            }
            var date = DateTimePickerDeparture.Text;
            var time = timePicker.Text;
            var fromStation = comboBoxDepartureStation.Text;
            var toStation = comboBoxArrivalStation.Text;
            await Task.Factory.StartNew(() => LongWork(date, time, fromStation, toStation), TaskCreationOptions.LongRunning);

            dataGridViewConnectionTable.Rows.Clear();
            AddConnectionsToDataGrid(_connections);
        }

        private void LongWork(string date, string time, string fromStation, string toStation)
        {
            LoadConnections(date, time, fromStation, toStation);
        }

        private void AddConnectionsToDataGrid(List<Connection?> connections)
        {
            foreach (var con in connections)
            {
                var delay = con.From.Delay.ToString();
                dataGridViewConnectionTable.Rows.Add(
                    con.From.Station.Name,
                    con.From.Platform, con.To.Station.Name,
                    $"{((DateTime)con.From.Departure).ToShortTimeString()} +{(string.IsNullOrEmpty(delay) ? 0 : delay)}'",
                    ((DateTime)con.To.Arrival).ToShortTimeString());
            }
        }

        private void LoadConnections(string date, string time, string fromStation, string toStation)
        {
            _connections = _dataProvider.GetConnectionsWithTimeAndDate(date, time, fromStation, toStation).ConnectionList;
        }


        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }

            var callThread = new Thread(new ThreadStart(() => LoadSuggestedStations(userInput)));
            callThread.Start();
            if (_suggestedStationsList != null && !_suggestedStationsList.Any())
            {
                return;
            }

            BeginInvoke(() => ComboBoxAutoComplete.HandleAutoComplete(((ComboBox)sender), _suggestedStationsList));
        }

        private void LoadSuggestedStations(string userInput)
        {
            _suggestedStationsList = new DataProvider().GetSimilarStations(userInput)?.Result;
        }

        private void buttonMoreConnections_Click(object sender, EventArgs e)
        {
            if (dataGridViewConnectionTable.Rows.Count==0)
            {
                return;
            }

            var date = DateTimePickerDeparture.Text;
            var stationFrom = _connections.First().From.Station.Name;
            var stationTo = _connections.First().To.Station.Name;
            DateTime? depart = GetLastDepartureTimeInConnections();

            var additionalConnections = _dataProvider.GetConnectionsWithTimeAndDate(date,((DateTime)depart).ToString("HH:mm"),stationFrom,stationTo).ConnectionList;
            AddConnectionsToDataGrid(additionalConnections);
            _connections.AddRange(additionalConnections);
        }

        private DateTime? GetLastDepartureTimeInConnections()
        {
            DateTime? depart = DateTime.Now;
            foreach (var con in _connections)
            {
                depart = ((DateTime) con.From.Departure).AddMinutes(1);
            }

            return depart;
        }
    }
}