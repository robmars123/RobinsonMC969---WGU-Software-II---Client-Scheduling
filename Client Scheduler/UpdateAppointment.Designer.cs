
namespace Client_Scheduler
{
    partial class UpdateAppointment
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
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            this.labelUserIDLabel = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelAppointmentTime = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.comboBoxCustomerIdAndName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Location = new System.Drawing.Point(164, 215);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(144, 21);
            this.comboBoxUserID.TabIndex = 23;
            // 
            // labelUserIDLabel
            // 
            this.labelUserIDLabel.AutoSize = true;
            this.labelUserIDLabel.Location = new System.Drawing.Point(42, 218);
            this.labelUserIDLabel.Name = "labelUserIDLabel";
            this.labelUserIDLabel.Size = new System.Drawing.Size(46, 13);
            this.labelUserIDLabel.TabIndex = 22;
            this.labelUserIDLabel.Text = "User ID:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 284);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(89, 284);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Save";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(164, 139);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerStart.TabIndex = 15;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(164, 175);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerEnd.TabIndex = 16;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(42, 182);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(55, 13);
            this.labelEndTime.TabIndex = 21;
            this.labelEndTime.Text = "End Time:";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(39, 145);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(58, 13);
            this.labelStartTime.TabIndex = 19;
            this.labelStartTime.Text = "Start Time:";
            // 
            // labelAppointmentTime
            // 
            this.labelAppointmentTime.Location = new System.Drawing.Point(39, 107);
            this.labelAppointmentTime.Name = "labelAppointmentTime";
            this.labelAppointmentTime.Size = new System.Drawing.Size(104, 27);
            this.labelAppointmentTime.TabIndex = 17;
            this.labelAppointmentTime.Text = "Appointment Type:";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(164, 104);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(144, 20);
            this.textBoxType.TabIndex = 13;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(39, 64);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(68, 13);
            this.labelCustomerID.TabIndex = 14;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // comboBoxCustomerIdAndName
            // 
            this.comboBoxCustomerIdAndName.FormattingEnabled = true;
            this.comboBoxCustomerIdAndName.Location = new System.Drawing.Point(164, 61);
            this.comboBoxCustomerIdAndName.Name = "comboBoxCustomerIdAndName";
            this.comboBoxCustomerIdAndName.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCustomerIdAndName.TabIndex = 12;
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 370);
            this.Controls.Add(this.comboBoxUserID);
            this.Controls.Add(this.labelUserIDLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelAppointmentTime);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.comboBoxCustomerIdAndName);
            this.Name = "UpdateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAppointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateAppointment_FormClosed);
            this.Load += new System.EventHandler(this.UpdateAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserID;
        private System.Windows.Forms.Label labelUserIDLabel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelAppointmentTime;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.ComboBox comboBoxCustomerIdAndName;
    }
}