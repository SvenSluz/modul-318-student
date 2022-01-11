using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MyTransport.Connections
{
    public partial class ConnectionsForm : Form 
    {
        private readonly ConnectionProvider connectionProvider;
        private ITransport _transport;
        public ConnectionsForm()
        {
            InitializeComponent();
            _transport = new Transport();
            connectionProvider = new ConnectionProvider();
        }

        private string DepartingStation;
        private string ArrivalStation;
        private void ComboBoxWithAutoComplete_TextChanged(object sender, EventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            if (string.IsNullOrEmpty(userInput))
            {
                return;
            }
            AutoComplete(userInput, (ComboBox)sender);
        }

        /* private void AutoComplete(string userInput, ComboBox comboBox)
         {
             if (string.IsNullOrEmpty(userInput)) return;
             var suggestionStations = new List<string>();
             try
             {
                 suggestionStations = connectionProvider.GetSimilarStationsAsync(userInput).Result.Select(s => s.Item1).ToList();
             }
             catch (Exception e)
             {
                 return;
             } 
             comboBox.Items.AddRange(suggestionStations.ToArray());

             //var items = Task.Run(()=>connectionProvider.GetSimilarStationsAsync(userInput).GetAwaiter().GetResult()).Result.Select(s => s.Item1).ToArray();
             if (suggestionStations == null || suggestionStations.Count == 0)
             {
                 return;
             }

              f  (comboBox==comboBoxDepartureStation)
              {
                  DepartingStation = suggestionStations.StationList.First().Name;
              }
              else
              {
                  ArrivalStation = suggestionStations.StationList.First().Name;
              }

         }
        */

        private void AutoComplete(string userInput, ComboBox comboBox)
        {
            var i = connectionProvider.GetSimilarStationsAsync(userInput).Result;
            if (i == null || i.Count == 0) return;
            var items = new BindingList<string>(i.Select(s => s.Item1).ToList());
            comboBox.Items.AddRange(items.ToArray());
            
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var connections = connectionProvider.GetConnections(comboBoxDepartureStation.Text, comboBoxDepartureStation.Text);
            dataGridViewConnectionTable.Rows.Clear();
            foreach (var con in connections.ConnectionList)
            {
                var delay = con.From.Delay.ToString();
                dataGridViewConnectionTable.Rows.Add(con.From.Station.Name, con.From.Platform, con.To.Station.Name, $"{((DateTime)con.From.Departure).ToShortTimeString()} '{delay}" ,((DateTime)con.To.Arrival).ToShortTimeString());
            }
        }

        private void comboBoxDepartureStation_Leave(object sender, EventArgs e)
        {
            ((ComboBox) sender).Text = (string)((ComboBox) sender).GetList().Where(s => s.Contains(((ComboBox)sender).Text)).FirstOrDefault();
        }
    }

    internal static class ComboboxExtension
    {   
        internal static IEnumerable<string> GetList(this ComboBox comboBox)
        {
            return comboBox.Items.Cast<string>();
        }
    }
}