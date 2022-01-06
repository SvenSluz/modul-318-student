using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransport.Verbindungen
{
    public partial class VerbindungenForm : Form
    {
        private readonly ConnectionProvider connectionProvider;
        public VerbindungenForm()
        {
            InitializeComponent();
            connectionProvider = new ConnectionProvider();
        }
        public BindingList<string> AutoCompleteStrings { get; set; } = new BindingList<string>();
        private void ComboBoxWithAutoComplete_TextChanged(object sender, EventArgs e)
        {
            var userInput = ((ComboBox)sender).Text;
            AutoComplete(userInput, (ComboBox)sender);
        }

        private void AutoComplete(string userInput, ComboBox comboBox)
        {
            var items = new BindingList<string>(connectionProvider.GetSimilarStationsAsync(userInput));
            if (items.Count != 0)
            {
                comboBox.Items.AddRange(items.ToArray());
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var connections = connectionProvider.GetConnections(comboBoxAbfahrtsStation.Text, comboBoxZielStation.Text);
        }
    }
}