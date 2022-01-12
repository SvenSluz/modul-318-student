namespace MyTransport.Station
{
    partial class StationForm
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
            this.dataGridViewStationTable = new System.Windows.Forms.DataGridView();
            this.columnLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxStations = new System.Windows.Forms.ComboBox();
            this.labelTitel = new System.Windows.Forms.Label();
            this.buttonLoadStationTable = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStationTable
            // 
            this.dataGridViewStationTable.AllowUserToAddRows = false;
            this.dataGridViewStationTable.AllowUserToDeleteRows = false;
            this.dataGridViewStationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStationTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStationTable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewStationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnLine,
            this.Departure,
            this.Duration,
            this.direction});
            this.dataGridViewStationTable.Location = new System.Drawing.Point(176, 348);
            this.dataGridViewStationTable.Name = "dataGridViewStationTable";
            this.dataGridViewStationTable.ReadOnly = true;
            this.dataGridViewStationTable.RowHeadersVisible = false;
            this.dataGridViewStationTable.RowHeadersWidth = 102;
            this.dataGridViewStationTable.RowTemplate.Height = 49;
            this.dataGridViewStationTable.Size = new System.Drawing.Size(1377, 819);
            this.dataGridViewStationTable.TabIndex = 0;
            // 
            // columnLine
            // 
            this.columnLine.HeaderText = "Linie";
            this.columnLine.MinimumWidth = 12;
            this.columnLine.Name = "columnLine";
            this.columnLine.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Abfahrt";
            this.Departure.MinimumWidth = 12;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Dauer";
            this.Duration.MinimumWidth = 12;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // direction
            // 
            this.direction.HeaderText = "Richtung";
            this.direction.MinimumWidth = 12;
            this.direction.Name = "direction";
            this.direction.ReadOnly = true;
            // 
            // comboBoxStations
            // 
            this.comboBoxStations.AllowDrop = true;
            this.comboBoxStations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxStations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStations.FormattingEnabled = true;
            this.comboBoxStations.Location = new System.Drawing.Point(176, 227);
            this.comboBoxStations.Name = "comboBoxStations";
            this.comboBoxStations.Size = new System.Drawing.Size(586, 49);
            this.comboBoxStations.TabIndex = 1;
            this.comboBoxStations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxStations_KeyPress);
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitel.Location = new System.Drawing.Point(176, 40);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(285, 81);
            this.labelTitel.TabIndex = 2;
            this.labelTitel.Text = "Stationen";
            // 
            // buttonLoadStationTable
            // 
            this.buttonLoadStationTable.Location = new System.Drawing.Point(1365, 227);
            this.buttonLoadStationTable.Name = "buttonLoadStationTable";
            this.buttonLoadStationTable.Size = new System.Drawing.Size(188, 58);
            this.buttonLoadStationTable.TabIndex = 3;
            this.buttonLoadStationTable.Text = "Abfahrten";
            this.buttonLoadStationTable.UseVisualStyleBackColor = true;
            this.buttonLoadStationTable.Click += new System.EventHandler(this.buttonLoadStationTable_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(176, 145);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(0, 54);
            this.labelHeader.TabIndex = 4;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(176, 1212);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(0, 41);
            this.loadingLabel.TabIndex = 5;
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1949, 1363);
            this.ControlBox = false;
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonLoadStationTable);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.comboBoxStations);
            this.Controls.Add(this.dataGridViewStationTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StationForm";
            this.Text = "StationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewStationTable;
        private ComboBox comboBoxStations;
        private Label labelTitel;
        private Button buttonLoadStationTable;
        private Label labelHeader;
        private DataGridViewTextBoxColumn columnLine;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn direction;
        private Label loadingLabel;
    }
}