namespace librarysystem
{
    partial class FrmAddEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmployee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.cboPermission = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemlibraryDataSet = new librarysystem.systemlibraryDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new librarysystem.systemlibraryDataSetTableAdapters.EmployeeTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemlibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFemale);
            this.groupBox1.Controls.Add(this.rdMale);
            this.groupBox1.Controls.Add(this.datetimepicker);
            this.groupBox1.Controls.Add(this.cboPermission);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(181, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee information";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(216, 72);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 21;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(125, 72);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 20;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // datetimepicker
            // 
            this.datetimepicker.CalendarForeColor = System.Drawing.Color.Blue;
            this.datetimepicker.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.datetimepicker.CustomFormat = "dd/MM/yyyy";
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker.Location = new System.Drawing.Point(113, 103);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(217, 20);
            this.datetimepicker.TabIndex = 17;
            // 
            // cboPermission
            // 
            this.cboPermission.FormattingEnabled = true;
            this.cboPermission.Location = new System.Drawing.Point(113, 318);
            this.cboPermission.Name = "cboPermission";
            this.cboPermission.Size = new System.Drawing.Size(217, 21);
            this.cboPermission.TabIndex = 16;
            // 
            // txtDepartment
            // 
            this.txtDepartment.ForeColor = System.Drawing.Color.Blue;
            this.txtDepartment.Location = new System.Drawing.Point(113, 288);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(217, 20);
            this.txtDepartment.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.Color.Blue;
            this.txtPhone.Location = new System.Drawing.Point(113, 256);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 20);
            this.txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Blue;
            this.txtEmail.Location = new System.Drawing.Point(113, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Blue;
            this.txtPassword.Location = new System.Drawing.Point(113, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Blue;
            this.txtAddress.Location = new System.Drawing.Point(113, 144);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(113, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 20);
            this.txtName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Permission:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Department:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.systemlibraryDataSet;
            // 
            // systemlibraryDataSet
            // 
            this.systemlibraryDataSet.DataSetName = "systemlibraryDataSet";
            this.systemlibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(145, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "     Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(357, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "     Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(139, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 33);
            this.label11.TabIndex = 9;
            this.label11.Text = "Add New Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 191);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(591, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemlibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.ComboBox cboPermission;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private systemlibraryDataSet systemlibraryDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private systemlibraryDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}