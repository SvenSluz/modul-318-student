using MyTransport.Station;
using SwissTransport.Core;

namespace MyTransport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form ConnectionForm;
        private Form StationForm;

        private void OpenConnectionForm_click(object sender, EventArgs e)
        {
            ConnectionForm = new Connections.ConnectionsForm();
            ConnectionForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(ConnectionForm);
            ConnectionForm.Show();
            
        }

        private void OpenStationForm_Click(object sender, EventArgs e)
        {
            StationForm = new StationForm();
            StationForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(StationForm);
            StationForm.Show();
        }
    }
}