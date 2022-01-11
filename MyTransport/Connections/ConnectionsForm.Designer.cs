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
            this.comboBoxDepartureStation = new System.Windows.Forms.ComboBox();
            this.comboBoxArrivalStation = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelVerbindungen = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.numericUpDownDepartureTime = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewConnectionTable = new System.Windows.Forms.DataGridView();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeparturePlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelVerbindungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartureStation
            // 
            this.comboBoxDepartureStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDepartureStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxDepartureStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDepartureStation.FormattingEnabled = true;
            this.comboBoxDepartureStation.Location = new System.Drawing.Point(90, 80);
            this.comboBoxDepartureStation.Name = "comboBoxDepartureStation";
            this.comboBoxDepartureStation.Size = new System.Drawing.Size(454, 49);
            this.comboBoxDepartureStation.TabIndex = 0;
            this.comboBoxDepartureStation.TextChanged += new System.EventHandler(this.ComboBoxWithAutoComplete_TextChanged);
            this.comboBoxDepartureStation.Leave += new System.EventHandler(this.comboBoxDepartureStation_Leave);
            // 
            // comboBoxArrivalStation
            // 
            this.comboBoxArrivalStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxArrivalStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxArrivalStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxArrivalStation.FormattingEnabled = true;
            this.comboBoxArrivalStation.Location = new System.Drawing.Point(723, 80);
            this.comboBoxArrivalStation.Name = "comboBoxArrivalStation";
            this.comboBoxArrivalStation.Size = new System.Drawing.Size(455, 49);
            this.comboBoxArrivalStation.TabIndex = 1;
            this.comboBoxArrivalStation.TextChanged += new System.EventHandler(this.ComboBoxWithAutoComplete_TextChanged);
            this.comboBoxArrivalStation.Leave += new System.EventHandler(this.comboBoxDepartureStation_Leave);
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
            this.tableLayoutPanelVerbindungen.Controls.Add(this.numericUpDownDepartureTime, 0, 1);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.dataGridViewConnectionTable, 0, 2);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.comboBoxDepartureStation, 0, 0);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.DateTimePickerDeparture, 1, 1);
            this.tableLayoutPanelVerbindungen.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelVerbindungen.Name = "tableLayoutPanelVerbindungen";
            this.tableLayoutPanelVerbindungen.RowCount = 4;
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelVerbindungen.Size = new System.Drawing.Size(1903, 1119);
            this.tableLayoutPanelVerbindungen.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.Location = new System.Drawing.Point(1474, 75);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(223, 58);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Suche";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // numericUpDownDepartureTime
            // 
            this.numericUpDownDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownDepartureTime.Location = new System.Drawing.Point(90, 212);
            this.numericUpDownDepartureTime.Name = "numericUpDownDepartureTime";
            this.numericUpDownDepartureTime.Size = new System.Drawing.Size(454, 47);
            this.numericUpDownDepartureTime.TabIndex = 5;
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
            this.dataGridViewConnectionTable.Location = new System.Drawing.Point(191, 516);
            this.dataGridViewConnectionTable.Name = "dataGridViewConnectionTable";
            this.dataGridViewConnectionTable.RowHeadersWidth = 102;
            this.tableLayoutPanelVerbindungen.SetRowSpan(this.dataGridViewConnectionTable, 2);
            this.dataGridViewConnectionTable.RowTemplate.Height = 49;
            this.dataGridViewConnectionTable.Size = new System.Drawing.Size(1520, 504);
            this.dataGridViewConnectionTable.TabIndex = 6;
            // 
            // from
            // 
            this.from.HeaderText = "Von";
            this.from.MinimumWidth = 12;
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // DeparturePlatform
            // 
            this.DeparturePlatform.FillWeight = 25F;
            this.DeparturePlatform.HeaderText = "Pl.";
            this.DeparturePlatform.MinimumWidth = 12;
            this.DeparturePlatform.Name = "DeparturePlatform";
            this.DeparturePlatform.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "Bis";
            this.To.MinimumWidth = 12;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Abfahrt";
            this.Departure.MinimumWidth = 12;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Arrival";
            this.Ankunft.MinimumWidth = 12;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.ReadOnly = true;
            // 
            // DateTimePickerDeparture
            // 
            this.DateTimePickerDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTimePickerDeparture.Location = new System.Drawing.Point(703, 212);
            this.DateTimePickerDeparture.Name = "DateTimePickerDeparture";
            this.DateTimePickerDeparture.Size = new System.Drawing.Size(495, 47);
            this.DateTimePickerDeparture.TabIndex = 4;
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1174);
            this.Controls.Add(this.tableLayoutPanelVerbindungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionsForm";
            this.ShowIcon = false;
            this.Text = "Verbindungen";
            this.tableLayoutPanelVerbindungen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxDepartureStation;
        private ComboBox comboBoxArrivalStation;
        private TableLayoutPanel tableLayoutPanelVerbindungen;
        private Button buttonSearch;
        private DateTimePicker DateTimePickerDeparture;
        private NumericUpDown numericUpDownDepartureTime;
        private DataGridView dataGridViewConnectionTable;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn DeparturePlatform;
        private DataGridViewTextBoxColumn To;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Ankunft;
    }
}