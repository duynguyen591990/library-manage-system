namespace librarysystem
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.systemlibraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemlibraryDataSet = new librarysystem.systemlibraryDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new librarysystem.systemlibraryDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemlibraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemlibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(164, 74);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(153, 20);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(164, 115);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(153, 20);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(74, 173);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(233, 173);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 31);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.systemlibraryDataSetBindingSource;
            // 
            // systemlibraryDataSetBindingSource
            // 
            this.systemlibraryDataSetBindingSource.DataSource = this.systemlibraryDataSet;
            this.systemlibraryDataSetBindingSource.Position = 0;
            // 
            // systemlibraryDataSet
            // 
            this.systemlibraryDataSet.DataSetName = "systemlibraryDataSet";
            this.systemlibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.systemlibraryDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.systemlibraryDataSetBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(94, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login System";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::librarysystem.Properties.Resources.corner_of_a_book_wallpaper_422_14806;
            this.ClientSize = new System.Drawing.Size(371, 254);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemlibraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemlibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnexit;
        private systemlibraryDataSet systemlibraryDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private systemlibraryDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource systemlibraryDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private System.Windows.Forms.Label label4;
    }
}