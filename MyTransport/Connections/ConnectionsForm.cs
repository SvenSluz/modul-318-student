using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MyTransport.Station;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MyTransport.Connections
{
    public partial class ConnectionsForm : Form 
    {
        private readonly ConnectionProvider _connectionProvider;
        public ConnectionsForm()
        {
            InitializeComponent();
            _connectionProvider = new ConnectionProvider();
            DateTimePickerDeparture.Text = DateTime.Now.ToShortDateString();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";


        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var connections = _connectionProvider.GetConnectionsWithTimeAndDate(DateTimePickerDeparture.Text,timePicker.Text, comboBoxDepartureStation.Text, comboBoxArrivalStation.Text);
            dataGridViewConnectionTable.Rows.Clear();
            foreach (var con in connections.ConnectionList)
            {
                var delay = con.From.Delay.ToString();
                dataGridViewConnectionTable.Rows.Add(con.From.Station.Name, con.From.Platform, con.To.Station.Name, $"{((DateTime)con.From.Departure).ToShortTimeString()} +{delay}'" ,((DateTime)con.To.Arrival).ToShortTimeString());
            }
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }
            ComboBoxAutoComplete.AutoComplete(userInput, (ComboBox)sender);
        }
    }
}