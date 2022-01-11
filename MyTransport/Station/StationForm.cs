using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTransport.Connections;

namespace MyTransport.Station
{
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
            connectionProvider = new ConnectionProvider();
        }

        private ConnectionProvider connectionProvider;

        private void comboBoxStations_TextChanged(object sender, EventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }
            ComboBoxAutoComplete.AutoComplete(userInput, (ComboBox)sender);
        }


        private List<Tuple<string, string>> stationsNameIDList;


        private void buttonLoadStationTable_Click(object sender, EventArgs e)
        {
            connectionProvider.GetId(comboBoxStations.Text);
            labelHeader.Text = comboBoxStations.Text;

            var table = connectionProvider.GetStationBoard(comboBoxStations.Text, connectionProvider.GetId(comboBoxStations.Text));
            foreach (var boardEntry in table.Entries)
            {
                var connection = connectionProvider.GetConnections(comboBoxStations.Text, boardEntry.To);
                dataGridViewStationTable.Rows.Add(boardEntry.Category+ boardEntry.Number, ((DateTime)boardEntry.Stop.Departure).ToShortTimeString(), boardEntry.To);
            }

        }
    }
}
