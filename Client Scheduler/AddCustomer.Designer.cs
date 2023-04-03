
namespace Client_Scheduler
{
    partial class AddCustomer
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonActiveNo = new System.Windows.Forms.RadioButton();
            this.radioButtonActiveYes = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(54, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(54, 125);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(54, 160);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(81, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(54, 193);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City:";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(54, 229);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(49, 13);
            this.labelZip.TabIndex = 4;
            this.labelZip.Text = "Zipcode:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(23, 232);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(46, 13);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Country:";
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(23, 275);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(40, 13);
            this.labelActive.TabIndex = 7;
            this.labelActive.Text = "Active:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(157, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(157, 118);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddress.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(157, 153);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(140, 20);
            this.textBoxPhone.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(157, 186);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(140, 20);
            this.textBoxCity.TabIndex = 11;
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(157, 222);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(140, 20);
            this.textBoxZip.TabIndex = 12;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(126, 225);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(140, 20);
            this.textBoxCountry.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonActiveNo);
            this.groupBox1.Controls.Add(this.radioButtonActiveYes);
            this.groupBox1.Controls.Add(this.textBoxCountry);
            this.groupBox1.Controls.Add(this.labelCountry);
            this.groupBox1.Controls.Add(this.labelActive);
            this.groupBox1.Location = new System.Drawing.Point(31, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 327);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Customer";
            // 
            // radioButtonActiveNo
            // 
            this.radioButtonActiveNo.AutoSize = true;
            this.radioButtonActiveNo.Location = new System.Drawing.Point(185, 275);
            this.radioButtonActiveNo.Name = "radioButtonActiveNo";
            this.radioButtonActiveNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonActiveNo.TabIndex = 18;
            this.radioButtonActiveNo.TabStop = true;
            this.radioButtonActiveNo.Text = "No";
            this.radioButtonActiveNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonActiveYes
            // 
            this.radioButtonActiveYes.AutoSize = true;
            this.radioButtonActiveYes.Location = new System.Drawing.Point(126, 275);
            this.radioButtonActiveYes.Name = "radioButtonActiveYes";
            this.radioButtonActiveYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonActiveYes.TabIndex = 17;
            this.radioButtonActiveYes.TabStop = true;
            this.radioButtonActiveYes.Text = "Yes";
            this.radioButtonActiveYes.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(95, 399);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(205, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 475);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomer_FormClosed);
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonActiveNo;
        private System.Windows.Forms.RadioButton radioButtonActiveYes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}