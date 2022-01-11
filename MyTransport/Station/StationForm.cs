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

        private void buttonLoadStationTable_Click(object sender, EventArgs e)
        {
            _dataProvider.GetId(comboBoxStations.Text);
            labelHeader.Text = comboBoxStations.Text;

            var boardTable = _dataProvider.GetStationBoard(comboBoxStations.Text, _dataProvider.GetId(comboBoxStations.Text));
            foreach (var boardEntry in boardTable.Entries)
            {
                var connection = _dataProvider.GetConnections(comboBoxStations.Text, boardEntry.To);
                dataGridViewStationTable.Rows.Add(boardEntry.Category+ boardEntry.Number, ((DateTime)boardEntry.Stop.Departure).ToShortTimeString(), boardEntry.To);
            }

        }

        private void comboBoxStations_KeyPress(object sender, KeyPressEventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }
            ComboBoxAutoComplete.AutoComplete(userInput, (ComboBox)sender);
        }

        private void comboBoxStations_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
