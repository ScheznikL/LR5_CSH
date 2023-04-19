namespace LR5_CSH
{
    partial class DilogFormGetInfo
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
            this.dGVDepartments = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfResoures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfWorkers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDepartments
            // 
            this.dGVDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDepartments.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dGVDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AmountOfResoures,
            this.NumberOfWorkers,
            this.Payment});
            this.dGVDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVDepartments.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dGVDepartments.Location = new System.Drawing.Point(0, 0);
            this.dGVDepartments.Name = "dGVDepartments";
            this.dGVDepartments.ReadOnly = true;
            this.dGVDepartments.RowHeadersVisible = false;
            this.dGVDepartments.Size = new System.Drawing.Size(540, 354);
            this.dGVDepartments.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // AmountOfResoures
            // 
            this.AmountOfResoures.DataPropertyName = "AmountOfResourses";
            this.AmountOfResoures.HeaderText = "Resoures";
            this.AmountOfResoures.Name = "AmountOfResoures";
            this.AmountOfResoures.ReadOnly = true;
            // 
            // NumberOfWorkers
            // 
            this.NumberOfWorkers.DataPropertyName = "NumberOfWorkers";
            this.NumberOfWorkers.HeaderText = "Workers";
            this.NumberOfWorkers.Name = "NumberOfWorkers";
            this.NumberOfWorkers.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "Payment";
            this.Payment.HeaderText = "Salary";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // DilogFormGetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(540, 354);
            this.Controls.Add(this.dGVDepartments);
            this.Name = "DilogFormGetInfo";
            this.ShowIcon = false;
            this.Text = "Information about departments";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVDepartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfResoures;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
    }
}