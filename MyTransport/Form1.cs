using SwissTransport.Core;

namespace MyTransport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = new Verbindungen.VerbindungenForm();
            test.Show();
        }
    }
}