namespace MyTransport.Verbindungen
{
    partial class VerbindungenForm
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
            this.comboBoxAbfahrtsStation = new System.Windows.Forms.ComboBox();
            this.comboBoxZielStation = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelVerbindungen = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.DateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDepartureTime = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewConnectionTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelVerbindungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAbfahrtsStation
            // 
            this.comboBoxAbfahrtsStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAbfahrtsStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAbfahrtsStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAbfahrtsStation.FormattingEnabled = true;
            this.comboBoxAbfahrtsStation.Location = new System.Drawing.Point(90, 80);
            this.comboBoxAbfahrtsStation.Name = "comboBoxAbfahrtsStation";
            this.comboBoxAbfahrtsStation.Size = new System.Drawing.Size(454, 49);
            this.comboBoxAbfahrtsStation.TabIndex = 0;
            this.comboBoxAbfahrtsStation.TextChanged += new System.EventHandler(this.ComboBoxWithAutoComplete_TextChanged);
            // 
            // comboBoxZielStation
            // 
            this.comboBoxZielStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxZielStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxZielStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxZielStation.FormattingEnabled = true;
            this.comboBoxZielStation.Location = new System.Drawing.Point(723, 80);
            this.comboBoxZielStation.Name = "comboBoxZielStation";
            this.comboBoxZielStation.Size = new System.Drawing.Size(455, 49);
            this.comboBoxZielStation.TabIndex = 1;
            this.comboBoxZielStation.TextChanged += new System.EventHandler(this.ComboBoxWithAutoComplete_TextChanged);
            // 
            // tableLayoutPanelVerbindungen
            // 
            this.tableLayoutPanelVerbindungen.AutoSize = true;
            this.tableLayoutPanelVerbindungen.ColumnCount = 3;
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelVerbindungen.Controls.Add(this.comboBoxZielStation, 1, 0);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.buttonSearch, 2, 0);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.DateTimePickerDeparture, 1, 1);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.numericUpDownDepartureTime, 0, 1);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.dataGridViewConnectionTable, 0, 2);
            this.tableLayoutPanelVerbindungen.Controls.Add(this.comboBoxAbfahrtsStation, 0, 0);
            this.tableLayoutPanelVerbindungen.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelVerbindungen.Name = "tableLayoutPanelVerbindungen";
            this.tableLayoutPanelVerbindungen.RowCount = 4;
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
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
            // DateTimePickerDeparture
            // 
            this.DateTimePickerDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTimePickerDeparture.Location = new System.Drawing.Point(701, 212);
            this.DateTimePickerDeparture.Name = "DateTimePickerDeparture";
            this.DateTimePickerDeparture.Size = new System.Drawing.Size(500, 47);
            this.DateTimePickerDeparture.TabIndex = 4;
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
            this.dataGridViewConnectionTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewConnectionTable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewConnectionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelVerbindungen.SetColumnSpan(this.dataGridViewConnectionTable, 3);
            this.dataGridViewConnectionTable.Location = new System.Drawing.Point(191, 516);
            this.dataGridViewConnectionTable.Name = "dataGridViewConnectionTable";
            this.dataGridViewConnectionTable.RowHeadersWidth = 102;
            this.tableLayoutPanelVerbindungen.SetRowSpan(this.dataGridViewConnectionTable, 2);
            this.dataGridViewConnectionTable.RowTemplate.Height = 49;
            this.dataGridViewConnectionTable.Size = new System.Drawing.Size(1520, 504);
            this.dataGridViewConnectionTable.TabIndex = 6;
            // 
            // VerbindungenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1174);
            this.Controls.Add(this.tableLayoutPanelVerbindungen);
            this.Name = "VerbindungenForm";
            this.Text = "Verbindungen";
            this.tableLayoutPanelVerbindungen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxAbfahrtsStation;
        private ComboBox comboBoxZielStation;
        private TableLayoutPanel tableLayoutPanelVerbindungen;
        private Button buttonSearch;
        private DateTimePicker DateTimePickerDeparture;
        private NumericUpDown numericUpDownDepartureTime;
        private DataGridView dataGridViewConnectionTable;
    }
}