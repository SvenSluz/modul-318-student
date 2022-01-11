using SwissTransport.Core;

namespace MyTransport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenConnectionForm_click(object sender, EventArgs e)
        {
            var connectionForm = new Connections.ConnectionsForm();
            connectionForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(connectionForm);
            connectionForm.Show();
            
        }

        private void OpenStationForm_Click(object sender, EventArgs e)
        {

        }
    }
}