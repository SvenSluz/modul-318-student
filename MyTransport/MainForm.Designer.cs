namespace MyTransport
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OpenStationForm = new System.Windows.Forms.Button();
            this.OpenConnectionForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.OpenStationForm);
            this.splitContainer1.Panel1.Controls.Add(this.OpenConnectionForm);
            this.splitContainer1.Size = new System.Drawing.Size(2267, 1278);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // OpenStationForm
            // 
            this.OpenStationForm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpenStationForm.Location = new System.Drawing.Point(12, 56);
            this.OpenStationForm.Name = "OpenStationForm";
            this.OpenStationForm.Size = new System.Drawing.Size(239, 139);
            this.OpenStationForm.TabIndex = 1;
            this.OpenStationForm.Text = "Stationen";
            this.OpenStationForm.UseVisualStyleBackColor = false;
            this.OpenStationForm.Click += new System.EventHandler(this.OpenStationForm_Click);
            // 
            // OpenConnectionForm
            // 
            this.OpenConnectionForm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpenConnectionForm.Location = new System.Drawing.Point(12, 236);
            this.OpenConnectionForm.Name = "OpenConnectionForm";
            this.OpenConnectionForm.Size = new System.Drawing.Size(239, 139);
            this.OpenConnectionForm.TabIndex = 0;
            this.OpenConnectionForm.Text = "Verbindungen";
            this.OpenConnectionForm.UseVisualStyleBackColor = false;
            this.OpenConnectionForm.Click += new System.EventHandler(this.OpenConnectionForm_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2267, 1278);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MyTransportation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button OpenStationForm;
        private Button OpenConnectionForm;
    }
}