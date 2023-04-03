
namespace Client_Scheduler
{
    partial class AppointmentsByMonthReport
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
            this.dataGridViewTypesByMonthReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesByMonthReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTypesByMonthReport
            // 
            this.dataGridViewTypesByMonthReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypesByMonthReport.Location = new System.Drawing.Point(31, 45);
            this.dataGridViewTypesByMonthReport.Name = "dataGridViewTypesByMonthReport";
            this.dataGridViewTypesByMonthReport.RowHeadersVisible = false;
            this.dataGridViewTypesByMonthReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTypesByMonthReport.Size = new System.Drawing.Size(315, 207);
            this.dataGridViewTypesByMonthReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Types By Month";
            // 
            // AppointmentsByMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTypesByMonthReport);
            this.Name = "AppointmentsByMonthReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsByMonth";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentsByMonthReport_FormClosed);
            this.Load += new System.EventHandler(this.AppointmentsByMonthReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesByMonthReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTypesByMonthReport;
        private System.Windows.Forms.Label label1;
    }
}