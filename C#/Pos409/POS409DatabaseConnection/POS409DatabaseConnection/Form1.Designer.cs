namespace POS409DatabaseConnection
{
    partial class frmMain
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cBoxWorkArea = new System.Windows.Forms.ComboBox();
            this.cBoxPosition = new System.Windows.Forms.ComboBox();
            this.txtPayGrade = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblDOH = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPayGrade = new System.Windows.Forms.Label();
            this.lblWorkArea = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEmpList = new System.Windows.Forms.Button();
            this.btnLoadDatabase = new System.Windows.Forms.Button();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(172, 209);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // cBoxWorkArea
            // 
            this.cBoxWorkArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxWorkArea.FormattingEnabled = true;
            this.cBoxWorkArea.Items.AddRange(new object[] {
            "ANALYSIS",
            "DATABASES",
            "DESIGN",
            "DOCUMENTING",
            "INFORMATION SYSTEMS",
            "NETWORKING",
            "PLANNING",
            "PROGRAMMING",
            "QUALITY ASSURANCE",
            "SECURITY",
            "TESTING",
            "TRAINING",
            "WEB DESIGN",
            "WIRELESS"});
            this.cBoxWorkArea.Location = new System.Drawing.Point(171, 308);
            this.cBoxWorkArea.Name = "cBoxWorkArea";
            this.cBoxWorkArea.Size = new System.Drawing.Size(281, 21);
            this.cBoxWorkArea.TabIndex = 39;
            // 
            // cBoxPosition
            // 
            this.cBoxPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxPosition.FormattingEnabled = true;
            this.cBoxPosition.Items.AddRange(new object[] {
            "DATA ARCHITECT",
            "DBA ENGINEER",
            "NETWORK ADMINISTRATOR",
            "PROGRAMMER I",
            "PROGRAMMER II",
            "PROGRAMMER III",
            "PROGRAMMER ANALYST",
            "QUALITY ASSURANCE SPECIALIST",
            "SOFTWARE ENGINEER JUNIOR",
            "SOFTWARE ENGINEER SENIOR",
            "SYSTEMS ADMINISTRATOR",
            "SYSTEMS ANALYST I",
            "SYSTEMS ANALYST II",
            "SYSTEMS ANALYST III",
            "SYSTEMS ENGINEER"});
            this.cBoxPosition.Location = new System.Drawing.Point(171, 274);
            this.cBoxPosition.Name = "cBoxPosition";
            this.cBoxPosition.Size = new System.Drawing.Size(281, 21);
            this.cBoxPosition.TabIndex = 38;
            // 
            // txtPayGrade
            // 
            this.txtPayGrade.Location = new System.Drawing.Point(172, 242);
            this.txtPayGrade.MaxLength = 2;
            this.txtPayGrade.Name = "txtPayGrade";
            this.txtPayGrade.Size = new System.Drawing.Size(32, 20);
            this.txtPayGrade.TabIndex = 37;
            this.txtPayGrade.Validating += new System.ComponentModel.CancelEventHandler(this.txtPayGrade_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirstName.Location = new System.Drawing.Point(171, 141);
            this.txtFirstName.MaxLength = 40;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(281, 20);
            this.txtFirstName.TabIndex = 36;
            // 
            // txtLastName
            // 
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Location = new System.Drawing.Point(171, 110);
            this.txtLastName.MaxLength = 40;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(281, 20);
            this.txtLastName.TabIndex = 35;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.AcceptsReturn = true;
            this.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(171, 75);
            this.txtEmployeeID.MaxLength = 6;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(97, 20);
            this.txtEmployeeID.TabIndex = 34;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            this.txtEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeID_Validating);
            // 
            // lblDOH
            // 
            this.lblDOH.AutoSize = true;
            this.lblDOH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOH.ForeColor = System.Drawing.Color.White;
            this.lblDOH.Location = new System.Drawing.Point(61, 211);
            this.lblDOH.Name = "lblDOH";
            this.lblDOH.Size = new System.Drawing.Size(102, 18);
            this.lblDOH.TabIndex = 33;
            this.lblDOH.Text = "Date of Hire";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(56, 175);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(108, 18);
            this.lblDOB.TabIndex = 32;
            this.lblDOB.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 36);
            this.label7.TabIndex = 31;
            this.label7.Text = "EMPLOYEES DATABASE";
            // 
            // lblPayGrade
            // 
            this.lblPayGrade.AutoSize = true;
            this.lblPayGrade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayGrade.ForeColor = System.Drawing.Color.White;
            this.lblPayGrade.Location = new System.Drawing.Point(71, 245);
            this.lblPayGrade.Name = "lblPayGrade";
            this.lblPayGrade.Size = new System.Drawing.Size(92, 18);
            this.lblPayGrade.TabIndex = 30;
            this.lblPayGrade.Text = "Pay Grade";
            // 
            // lblWorkArea
            // 
            this.lblWorkArea.AutoSize = true;
            this.lblWorkArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkArea.ForeColor = System.Drawing.Color.White;
            this.lblWorkArea.Location = new System.Drawing.Point(71, 308);
            this.lblWorkArea.Name = "lblWorkArea";
            this.lblWorkArea.Size = new System.Drawing.Size(92, 18);
            this.lblWorkArea.TabIndex = 29;
            this.lblWorkArea.Text = "Work Area";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(91, 277);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 18);
            this.lblPosition.TabIndex = 28;
            this.lblPosition.Text = "Position";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(71, 143);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 18);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(72, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(93, 18);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.White;
            this.lblEmpID.Location = new System.Drawing.Point(58, 75);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(107, 18);
            this.lblEmpID.TabIndex = 25;
            this.lblEmpID.Text = "Employee ID";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(482, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 28);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEmpList
            // 
            this.btnEmpList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEmpList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpList.ForeColor = System.Drawing.Color.White;
            this.btnEmpList.Location = new System.Drawing.Point(482, 171);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.Size = new System.Drawing.Size(138, 28);
            this.btnEmpList.TabIndex = 23;
            this.btnEmpList.Text = "Employee List";
            this.btnEmpList.UseVisualStyleBackColor = false;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // btnLoadDatabase
            // 
            this.btnLoadDatabase.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLoadDatabase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDatabase.ForeColor = System.Drawing.Color.White;
            this.btnLoadDatabase.Location = new System.Drawing.Point(482, 75);
            this.btnLoadDatabase.Name = "btnLoadDatabase";
            this.btnLoadDatabase.Size = new System.Drawing.Size(138, 28);
            this.btnLoadDatabase.TabIndex = 42;
            this.btnLoadDatabase.Text = "Load Database";
            this.btnLoadDatabase.UseVisualStyleBackColor = false;
            this.btnLoadDatabase.Click += new System.EventHandler(this.btnLoadDatabase_Click);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveToDatabase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDatabase.ForeColor = System.Drawing.Color.White;
            this.btnSaveToDatabase.Location = new System.Drawing.Point(482, 222);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(138, 28);
            this.btnSaveToDatabase.TabIndex = 43;
            this.btnSaveToDatabase.Text = "Save to Database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = false;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(482, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 28);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit Employee";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(652, 362);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.btnLoadDatabase);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cBoxWorkArea);
            this.Controls.Add(this.cBoxPosition);
            this.Controls.Add(this.txtPayGrade);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblDOH);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPayGrade);
            this.Controls.Add(this.lblWorkArea);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmpList);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS409 Week Five Individual Database Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cBoxWorkArea;
        private System.Windows.Forms.ComboBox cBoxPosition;
        private System.Windows.Forms.TextBox txtPayGrade;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblDOH;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPayGrade;
        private System.Windows.Forms.Label lblWorkArea;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmpList;
        private System.Windows.Forms.Button btnLoadDatabase;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button btnSubmit;
    }
}

