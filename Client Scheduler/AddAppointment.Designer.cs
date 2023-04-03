
namespace Client_Scheduler
{
    partial class AddAppointment
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
            this.comboBoxCustomerIdAndName = new System.Windows.Forms.ComboBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelAppointmentTime = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUserIDLabel = new System.Windows.Forms.Label();
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxCustomerIdAndName
            // 
            this.comboBoxCustomerIdAndName.FormattingEnabled = true;
            this.comboBoxCustomerIdAndName.Location = new System.Drawing.Point(158, 71);
            this.comboBoxCustomerIdAndName.Name = "comboBoxCustomerIdAndName";
            this.comboBoxCustomerIdAndName.Size = new System.Drawing.Size(144, 21);
            this.comboBoxCustomerIdAndName.TabIndex = 0;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(33, 74);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(68, 13);
            this.labelCustomerID.TabIndex = 1;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(158, 114);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(144, 20);
            this.textBoxType.TabIndex = 1;
            // 
            // labelAppointmentTime
            // 
            this.labelAppointmentTime.Location = new System.Drawing.Point(33, 117);
            this.labelAppointmentTime.Name = "labelAppointmentTime";
            this.labelAppointmentTime.Size = new System.Drawing.Size(104, 27);
            this.labelAppointmentTime.TabIndex = 3;
            this.labelAppointmentTime.Text = "Appointment Type:";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(33, 155);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(58, 13);
            this.labelStartTime.TabIndex = 4;
            this.labelStartTime.Text = "Start Time:";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(36, 192);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(55, 13);
            this.labelEndTime.TabIndex = 5;
            this.labelEndTime.Text = "End Time:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(158, 185);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(158, 149);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerStart.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(87, 294);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(204, 294);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelUserIDLabel
            // 
            this.labelUserIDLabel.AutoSize = true;
            this.labelUserIDLabel.Location = new System.Drawing.Point(36, 228);
            this.labelUserIDLabel.Name = "labelUserIDLabel";
            this.labelUserIDLabel.Size = new System.Drawing.Size(46, 13);
            this.labelUserIDLabel.TabIndex = 10;
            this.labelUserIDLabel.Text = "User ID:";
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Location = new System.Drawing.Point(158, 225);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(144, 21);
            this.comboBoxUserID.TabIndex = 11;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 370);
            this.Controls.Add(this.comboBoxUserID);
            this.Controls.Add(this.labelUserIDLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelAppointmentTime);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.comboBoxCustomerIdAndName);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAppointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAppointment_FormClosed);
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCustomerIdAndName;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelAppointmentTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUserIDLabel;
        private System.Windows.Forms.ComboBox comboBoxUserID;
    }
}