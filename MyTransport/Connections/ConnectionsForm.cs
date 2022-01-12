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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxArrivalStation.Text) || string.IsNullOrWhiteSpace(comboBoxArrivalStation.Text))
            {
                return;
            }
            dataGridViewConnectionTable.Rows.Clear();
            var date = DateTimePickerDeparture.Text;
            var time = timePicker.Text;
            var fromStation = comboBoxDepartureStation.Text;
            var toStation = comboBoxArrivalStation.Text;
            var callThread = new Thread(new ThreadStart(() => LoadConnections(date, time, fromStation, toStation)));
            callThread.Start();

            BeginInvoke(new Action(AddConnectionsToDataGrid));
        }

        private void AddConnectionsToDataGrid()
        {
            foreach (var con in _connections)
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


    }
}