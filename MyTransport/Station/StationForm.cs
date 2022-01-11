namespace MyTransport.Station
{
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
            _connectionProvider = new ConnectionProvider();
        }

        private readonly ConnectionProvider _connectionProvider;

        private void comboBoxStations_TextChanged(object sender, EventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }
            ComboBoxAutoComplete.AutoComplete(userInput, (ComboBox)sender);
        }
        
        private void buttonLoadStationTable_Click(object sender, EventArgs e)
        {
            _connectionProvider.GetId(comboBoxStations.Text);
            labelHeader.Text = comboBoxStations.Text;

            var table = _connectionProvider.GetStationBoard(comboBoxStations.Text, _connectionProvider.GetId(comboBoxStations.Text));
            foreach (var boardEntry in table.Entries)
            {
                var connection = _connectionProvider.GetConnections(comboBoxStations.Text, boardEntry.To);
                dataGridViewStationTable.Rows.Add(boardEntry.Category+ boardEntry.Number, ((DateTime)boardEntry.Stop.Departure).ToShortTimeString(), boardEntry.To);
            }

        }
    }
}
