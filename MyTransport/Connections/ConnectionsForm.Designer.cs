namespace MyTransport.Connections
{
    partial class ConnectionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDepartureStation = new System.Windows.Forms.ComboBox();
            this.dataGridViewConnectionTable = new System.Windows.Forms.DataGridView();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeparturePlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxArrivalStation = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelVerbindungen = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionTable)).BeginInit();
            this.tableLayoutPanelVerbindungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitel.Location = new System.Drawing.Point(102, 43);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(407, 81);
            this.labelTitel.TabIndex = 3;
            this.labelTitel.Text = "Verbindungen";
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(701, 189);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(500, 47);
            this.timePicker.TabIndex = 7;
            // 
            // DateTimePickerDeparture
            // 
            this.DateTimePickerDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTimePickerDeparture.Location = new System.Drawing.Point(69, 189);
            this.DateTimePickerDeparture.Name = "DateTimePickerDeparture";
            this.DateTimePickerDeparture.ShowUpDown = true;
            this.DateTimePickerDeparture.Size = new System.Drawing.Size(495, 47);
            this.DateTimePickerDeparture.TabIndex = 4;
            // 
            // comboBoxDepartureStation
            // 
            this.comboBoxDepartureStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDepartureStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxDepartureStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDepartureStation.FormattingEnabled = true;
            this.comboBoxDepartureStation.Location = new System.Drawing.Point(90, 68);
            this.comboBoxDepartureStation.Name = "comboBoxDepartureStation";
            this.comboBoxDepartureStation.Size = new System.Drawing.Size(454, 49);
            this.comboBoxDepartureStation.TabIndex = 0;
            this.comboBoxDepartureStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // dataGridViewConnectionTable
            // 
            this.dataGridViewConnectionTable.AllowUserToAddRows = false;
            this.dataGridViewConnectionTable.AllowUserToDeleteRows = false;
            this.dataGridViewConnectionTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewConnectionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConnectionTable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewConnectionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnectionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.from,
            this.DeparturePlatform,
            this.To,
            this.Departure,
            this.Ankunft});
            this.tableLayoutPanelVerbindungen.SetColumnSpan(this.dataGridViewConnectionTable, 3);
            this.dataGridViewConnectionTable.Location = new System.Drawing.Point(191, 430);
            this.dataGridViewConnectionTable.Name = "dataGridViewConnectionTable";
            this.dataGridViewConnectionTable.RowHeadersWidth = 102;
            this.tableLayoutPanelVerbindungen.SetRowSpan(this.dataGridViewConnectionTable, 2);
            this.dataGridViewConnectionTable.RowTemplate.Height = 49;
            this.dataGridViewConnectionTable.Size = new System.Drawing.Size(1520, 504);
            this.dataGridViewConnectionTable.TabIndex = 6;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Arrival";
            this.Ankunft.MinimumWidth = 12;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Abfahrt";
            this.Departure.MinimumWidth = 12;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "Bis";
            this.To.MinimumWidth = 12;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // DeparturePlatform
            // 
            this.DeparturePlatform.FillWeight = 25F;
            this.DeparturePlatform.HeaderText = "Pl.";
            this.DeparturePlatform.MinimumWidth = 12;
            this.DeparturePlatform.Name = "DeparturePlatform";
            this.DeparturePlatform.ReadOnly = true;
            // 
            // from
            // 
            this.from.HeaderText = "Von";
            this.from.MinimumWidth = 12;
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.Location = new System.Drawing.Point(1474, 64);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(223, 58);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Suche";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            this.buttonSearch.Enter += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // comboBoxArrivalStation
            // 
            this.comboBoxArrivalStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxArrivalStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxArrivalStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxArrivalStation.FormattingEnabled = true;
            this.comboBoxArrivalStation.Location = new System.Drawing.Point(723, 68);
            this.comboBoxArrivalStation.Name = "comboBoxArrivalStation";
            this.comboBoxArrivalStation.Size = new System.Drawing.Size(455, 49);
            this.comboBoxArrivalStation.TabIndex = 1;
            this.comboBoxArrivalStation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // tableLayoutPanelVerbindungen
            // 
            this.tableLayoutPanelVerbindungen.AutoSize = true;
            this.tableLayoutPanelVerbindungen.ColumnCount = 3;
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelVerbindungen.Controls.Add(this.comboBoxArrivalStation, 1, 0);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.buttonSearch, 2, 0);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.dataGridViewConnectionTable, 0, 2);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.comboBoxDepartureStation, 0, 0);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.DateTimePickerDeparture, 0, 1);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.timePicker, 1, 1);
            this.tableLayoutPanelVerbindungen.Location = new System.Drawing.Point(12, 140);
            this.tableLayoutPanelVerbindungen.Name = "tableLayoutPanelVerbindungen";
            this.tableLayoutPanelVerbindungen.RowCount = 4;
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVerbindungen.Size = new System.Drawing.Size(1903, 992);
            this.tableLayoutPanelVerbindungen.TabIndex = 2;
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1174);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.tableLayoutPanelVerbindungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionsForm";
            this.ShowIcon = false;
            this.Text = "Verbindungen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionTable)).EndInit();
            this.tableLayoutPanelVerbindungen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelTitel;
        private DateTimePicker timePicker;
        private DateTimePicker DateTimePickerDeparture;
        private ComboBox comboBoxDepartureStation;
        private DataGridView dataGridViewConnectionTable;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn DeparturePlatform;
        private DataGridViewTextBoxColumn To;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Ankunft;
        private TableLayoutPanel tableLayoutPanelVerbindungen;
        private ComboBox comboBoxArrivalStation;
        private Button buttonSearch;
    }
}