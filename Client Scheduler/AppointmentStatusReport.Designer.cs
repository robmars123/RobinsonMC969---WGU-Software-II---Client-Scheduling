
namespace Client_Scheduler
{
    partial class AppointmentStatusReport
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
            this.dataGridViewStatusReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCompletedTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUpcomingTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatusReport
            // 
            this.dataGridViewStatusReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatusReport.Location = new System.Drawing.Point(29, 56);
            this.dataGridViewStatusReport.Name = "dataGridViewStatusReport";
            this.dataGridViewStatusReport.Size = new System.Drawing.Size(350, 283);
            this.dataGridViewStatusReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments Status Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Completed Appointments:";
            // 
            // labelCompletedTotal
            // 
            this.labelCompletedTotal.AutoSize = true;
            this.labelCompletedTotal.Location = new System.Drawing.Point(201, 371);
            this.labelCompletedTotal.Name = "labelCompletedTotal";
            this.labelCompletedTotal.Size = new System.Drawing.Size(0, 13);
            this.labelCompletedTotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Upcoming Appointments:";
            // 
            // labelUpcomingTotal
            // 
            this.labelUpcomingTotal.AutoSize = true;
            this.labelUpcomingTotal.Location = new System.Drawing.Point(197, 398);
            this.labelUpcomingTotal.Name = "labelUpcomingTotal";
            this.labelUpcomingTotal.Size = new System.Drawing.Size(0, 13);
            this.labelUpcomingTotal.TabIndex = 5;
            // 
            // AppointmentStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.labelUpcomingTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCompletedTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStatusReport);
            this.Name = "AppointmentStatusReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentStatusReport";
            this.Load += new System.EventHandler(this.AppointmentStatusReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatusReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatusReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCompletedTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUpcomingTotal;
    }
}