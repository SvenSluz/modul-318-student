using SwissTransport.Models;
using System.Globalization;

namespace MyTransport.Station
{
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
            _dataProvider = new DataProvider();
        }

        private readonly DataProvider _dataProvider;
        private StationBoardRoot _boardTable = new StationBoardRoot();
        private List<string> _durationTimes = new List<string>();

        private async void buttonLoadStationTable_Click(object sender, EventArgs e)
        {
            buttonLoadStationTable.Enabled = false;
            var stationName = comboBoxStations.Text;
            var progress = new Progress<string>(s => loadingLabel.Text = s);
            await Task.Factory.StartNew(() => LongWork(progress, stationName), TaskCreationOptions.LongRunning);

            labelHeader.Text = stationName;
            dataGridViewStationTable.BeginInvoke(ApplyDataToDataGrid);
            buttonLoadStationTable.Enabled = false;
            loadingLabel.Text = "fertig";
        }

        private void LongWork(IProgress<string> progress, string stationName)
        {
            progress.Report("laden...");
            GetStationData(stationName);

        }

        private Task GetStationData(string stationName)
        {
            LoadStations(stationName).GetAwaiter();
            _durationTimes = GetDurationTimes(stationName) as List<string>;
            return Task.CompletedTask;
        }

        private Task ApplyDataToDataGrid()
        {
            AddEntriesToDataGrid(_boardTable);
            AddDurationTimes(_boardTable.Entries, dataGridViewStationTable.Rows).ConfigureAwait(false);
            return Task.CompletedTask;
        }

        private List<string?> GetDurationTimes(string stationName)
        {
            return _boardTable.Entries
                .Select(boardEntry => _dataProvider.GetSingleConnection(boardEntry.Stop.Departure.ToString(CultureInfo.CurrentCulture),
                    boardEntry.Stop.Departure.ToString("HH:mm"),
                    stationName, boardEntry.To)?.Duration).ToList();
        }

        private void comboBoxStations_KeyPress(object sender, KeyPressEventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }

            var callThread = new Thread(new ThreadStart(() => LoadSuggestedStations(userInput)));
            callThread.Start();
            if (SuggestedStationsList != null && !SuggestedStationsList.Any())
            {
                return;
            }

            BeginInvoke(() => ComboBoxAutoComplete.HandleAutoComplete(((ComboBox)sender), SuggestedStationsList));
        }

        public List<string>? SuggestedStationsList = new List<string>();


        private void LoadSuggestedStations(string userInput)
        {
            SuggestedStationsList = _dataProvider.GetSimilarStations(userInput)?.Result;
        }

        private Task LoadStations(string stationName)
        {
            _dataProvider.GetId(stationName);
            _boardTable = _dataProvider.GetStationBoard(stationName, _dataProvider.GetId(stationName));
            return Task.CompletedTask;
        }

        private Task AddEntriesToDataGrid(StationBoardRoot boardTable)
        {
            dataGridViewStationTable.Rows.Clear();
            foreach (var boardEntry in boardTable.Entries)
            {
                dataGridViewStationTable.Rows.Add(boardEntry.Category + boardEntry.Number,
                    ((DateTime)boardEntry.Stop.Departure).ToShortTimeString(), "", boardEntry.To);
            }
            return Task.CompletedTask;
        }

        private Task AddDurationTimes(List<StationBoard> boardTable, DataGridViewRowCollection rows)
        {
            var rowIndex = 0;
            foreach (var boardEntry in boardTable)
            {
                rows[rowIndex].Cells[2].Value = _durationTimes[rowIndex];
                rowIndex++;
            }
            return Task.CompletedTask;
        }
    }
}
