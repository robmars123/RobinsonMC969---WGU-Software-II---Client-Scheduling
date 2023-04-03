
namespace Client_Scheduler
{
    partial class ConsultantScheduleAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewConsultantSchedules = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalUserAppointments = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalCustomersScheduled = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultantSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsultantSchedules
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewConsultantSchedules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewConsultantSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultantSchedules.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewConsultantSchedules.Location = new System.Drawing.Point(21, 35);
            this.dataGridViewConsultantSchedules.Name = "dataGridViewConsultantSchedules";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridViewConsultantSchedules.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewConsultantSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultantSchedules.Size = new System.Drawing.Size(552, 255);
            this.dataGridViewConsultantSchedules.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Scheduled Appointments:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTotalUserAppointments
            // 
            this.labelTotalUserAppointments.AutoSize = true;
            this.labelTotalUserAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUserAppointments.Location = new System.Drawing.Point(228, 312);
            this.labelTotalUserAppointments.Name = "labelTotalUserAppointments";
            this.labelTotalUserAppointments.Size = new System.Drawing.Size(0, 17);
            this.labelTotalUserAppointments.TabIndex = 2;
            this.labelTotalUserAppointments.Click += new System.EventHandler(this.labelTotalUserAppointments_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Customers Scheduled:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTotalCustomersScheduled
            // 
            this.labelTotalCustomersScheduled.AutoSize = true;
            this.labelTotalCustomersScheduled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCustomersScheduled.Location = new System.Drawing.Point(222, 340);
            this.labelTotalCustomersScheduled.Name = "labelTotalCustomersScheduled";
            this.labelTotalCustomersScheduled.Size = new System.Drawing.Size(0, 17);
            this.labelTotalCustomersScheduled.TabIndex = 4;
            this.labelTotalCustomersScheduled.Click += new System.EventHandler(this.labelTotalCustomersScheduled_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultant Schedule Appointments Report";
            // 
            // ConsultantScheduleAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotalCustomersScheduled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalUserAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewConsultantSchedules);
            this.Name = "ConsultantScheduleAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultantScheduleAppointments";
            this.Load += new System.EventHandler(this.ConsultantScheduleAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultantSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConsultantSchedules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalUserAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalCustomersScheduled;
        private System.Windows.Forms.Label label3;
    }
}