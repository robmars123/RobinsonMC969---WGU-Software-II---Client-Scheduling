
namespace Client_Scheduler
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAllAppointments = new System.Windows.Forms.RadioButton();
            this.radioButtonCurrentMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonCurrentWeek = new System.Windows.Forms.RadioButton();
            this.buttonDeleteAppointment = new System.Windows.Forms.Button();
            this.buttonUpdateAppointment = new System.Windows.Forms.Button();
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoggedInUser = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonApptStatusReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonApptByMonth = new System.Windows.Forms.Button();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(30, 33);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersVisible = false;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(503, 209);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(30, 29);
            this.dataGridViewCustomers.MultiSelect = false;
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersVisible = false;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(503, 209);
            this.dataGridViewCustomers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonDeleteAppointment);
            this.groupBox1.Controls.Add(this.buttonUpdateAppointment);
            this.groupBox1.Controls.Add(this.buttonAddAppointment);
            this.groupBox1.Controls.Add(this.dataGridViewAppointments);
            this.groupBox1.Location = new System.Drawing.Point(36, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Calendar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAllAppointments);
            this.groupBox2.Controls.Add(this.radioButtonCurrentMonth);
            this.groupBox2.Controls.Add(this.radioButtonCurrentWeek);
            this.groupBox2.Location = new System.Drawing.Point(550, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // radioButtonAllAppointments
            // 
            this.radioButtonAllAppointments.AutoSize = true;
            this.radioButtonAllAppointments.Location = new System.Drawing.Point(14, 65);
            this.radioButtonAllAppointments.Name = "radioButtonAllAppointments";
            this.radioButtonAllAppointments.Size = new System.Drawing.Size(103, 17);
            this.radioButtonAllAppointments.TabIndex = 7;
            this.radioButtonAllAppointments.TabStop = true;
            this.radioButtonAllAppointments.Text = "All Appointments";
            this.radioButtonAllAppointments.UseVisualStyleBackColor = true;
            this.radioButtonAllAppointments.CheckedChanged += new System.EventHandler(this.radioButtonAllAppointments_CheckedChanged);
            // 
            // radioButtonCurrentMonth
            // 
            this.radioButtonCurrentMonth.AutoSize = true;
            this.radioButtonCurrentMonth.Location = new System.Drawing.Point(14, 42);
            this.radioButtonCurrentMonth.Name = "radioButtonCurrentMonth";
            this.radioButtonCurrentMonth.Size = new System.Drawing.Size(92, 17);
            this.radioButtonCurrentMonth.TabIndex = 6;
            this.radioButtonCurrentMonth.TabStop = true;
            this.radioButtonCurrentMonth.Text = "Current Month";
            this.radioButtonCurrentMonth.UseVisualStyleBackColor = true;
            this.radioButtonCurrentMonth.CheckedChanged += new System.EventHandler(this.radioButtonCurrentMonth_CheckedChanged);
            // 
            // radioButtonCurrentWeek
            // 
            this.radioButtonCurrentWeek.AutoSize = true;
            this.radioButtonCurrentWeek.Location = new System.Drawing.Point(14, 19);
            this.radioButtonCurrentWeek.Name = "radioButtonCurrentWeek";
            this.radioButtonCurrentWeek.Size = new System.Drawing.Size(91, 17);
            this.radioButtonCurrentWeek.TabIndex = 5;
            this.radioButtonCurrentWeek.TabStop = true;
            this.radioButtonCurrentWeek.Text = "Current Week";
            this.radioButtonCurrentWeek.UseVisualStyleBackColor = true;
            this.radioButtonCurrentWeek.CheckedChanged += new System.EventHandler(this.radioButtonCurrentWeek_CheckedChanged);
            // 
            // buttonDeleteAppointment
            // 
            this.buttonDeleteAppointment.Location = new System.Drawing.Point(550, 91);
            this.buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            this.buttonDeleteAppointment.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAppointment.TabIndex = 7;
            this.buttonDeleteAppointment.Text = "Delete";
            this.buttonDeleteAppointment.UseVisualStyleBackColor = true;
            this.buttonDeleteAppointment.Click += new System.EventHandler(this.buttonDeleteAppointment_Click);
            // 
            // buttonUpdateAppointment
            // 
            this.buttonUpdateAppointment.Location = new System.Drawing.Point(550, 62);
            this.buttonUpdateAppointment.Name = "buttonUpdateAppointment";
            this.buttonUpdateAppointment.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateAppointment.TabIndex = 6;
            this.buttonUpdateAppointment.Text = "Update";
            this.buttonUpdateAppointment.UseVisualStyleBackColor = true;
            this.buttonUpdateAppointment.Click += new System.EventHandler(this.buttonUpdateAppointment_Click);
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(550, 33);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAppointment.TabIndex = 5;
            this.buttonAddAppointment.Text = "Add";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(550, 88);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCustomer.TabIndex = 10;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(550, 59);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateCustomer.TabIndex = 9;
            this.buttonUpdateCustomer.Text = "Update";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(550, 29);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCustomer.TabIndex = 8;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridViewCustomers);
            this.groupBox4.Controls.Add(this.buttonUpdateCustomer);
            this.groupBox4.Controls.Add(this.buttonDeleteCustomer);
            this.groupBox4.Controls.Add(this.buttonAddCustomer);
            this.groupBox4.Location = new System.Drawing.Point(36, 354);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(699, 264);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Welcome,";
            // 
            // labelLoggedInUser
            // 
            this.labelLoggedInUser.AutoSize = true;
            this.labelLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInUser.Location = new System.Drawing.Point(915, 12);
            this.labelLoggedInUser.Name = "labelLoggedInUser";
            this.labelLoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.labelLoggedInUser.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.buttonApptStatusReport);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.buttonApptByMonth);
            this.groupBox3.Location = new System.Drawing.Point(767, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 198);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // buttonApptStatusReport
            // 
            this.buttonApptStatusReport.Location = new System.Drawing.Point(25, 145);
            this.buttonApptStatusReport.Name = "buttonApptStatusReport";
            this.buttonApptStatusReport.Size = new System.Drawing.Size(173, 23);
            this.buttonApptStatusReport.TabIndex = 17;
            this.buttonApptStatusReport.Text = "Appointments Status Report";
            this.buttonApptStatusReport.UseVisualStyleBackColor = true;
            this.buttonApptStatusReport.Click += new System.EventHandler(this.buttonApptStatusReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Consultant Schedules Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonApptByMonth
            // 
            this.buttonApptByMonth.Location = new System.Drawing.Point(25, 39);
            this.buttonApptByMonth.Name = "buttonApptByMonth";
            this.buttonApptByMonth.Size = new System.Drawing.Size(173, 25);
            this.buttonApptByMonth.TabIndex = 0;
            this.buttonApptByMonth.Text = "Appointments by Month";
            this.buttonApptByMonth.UseVisualStyleBackColor = true;
            this.buttonApptByMonth.Click += new System.EventHandler(this.buttonApptByMonth_Click);
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(968, 14);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 17;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 654);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelLoggedInUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonDeleteAppointment;
        private System.Windows.Forms.Button buttonUpdateAppointment;
        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCurrentMonth;
        private System.Windows.Forms.RadioButton radioButtonCurrentWeek;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoggedInUser;
        private System.Windows.Forms.RadioButton radioButtonAllAppointments;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonApptByMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonApptStatusReport;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
    }
}