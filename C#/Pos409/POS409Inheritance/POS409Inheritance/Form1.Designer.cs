namespace POS409Inheritance
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEmpList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblWorkArea = new System.Windows.Forms.Label();
            this.lblPayGrade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblDOH = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPayGrade = new System.Windows.Forms.TextBox();
            this.cBoxPosition = new System.Windows.Forms.ComboBox();
            this.cBoxWorkArea = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(48, 358);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(165, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Employee";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnEmpList
            // 
            this.btnEmpList.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEmpList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpList.Location = new System.Drawing.Point(233, 358);
            this.btnEmpList.Name = "btnEmpList";
            this.btnEmpList.Size = new System.Drawing.Size(165, 28);
            this.btnEmpList.TabIndex = 1;
            this.btnEmpList.Text = "Employee List";
            this.btnEmpList.UseVisualStyleBackColor = false;
            this.btnEmpList.Click += new System.EventHandler(this.btnEmpList_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(416, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(106, 83);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(107, 18);
            this.lblEmpID.TabIndex = 3;
            this.lblEmpID.Text = "Employee ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(120, 115);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(93, 18);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(119, 151);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 18);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(139, 285);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 18);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Position";
            // 
            // lblWorkArea
            // 
            this.lblWorkArea.AutoSize = true;
            this.lblWorkArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkArea.Location = new System.Drawing.Point(119, 316);
            this.lblWorkArea.Name = "lblWorkArea";
            this.lblWorkArea.Size = new System.Drawing.Size(92, 18);
            this.lblWorkArea.TabIndex = 7;
            this.lblWorkArea.Text = "Work Area";
            // 
            // lblPayGrade
            // 
            this.lblPayGrade.AutoSize = true;
            this.lblPayGrade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayGrade.Location = new System.Drawing.Point(119, 253);
            this.lblPayGrade.Name = "lblPayGrade";
            this.lblPayGrade.Size = new System.Drawing.Size(92, 18);
            this.lblPayGrade.TabIndex = 8;
            this.lblPayGrade.Text = "Pay Grade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "NEW EMPLOYEES SCREEN";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(104, 183);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(108, 18);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblDOH
            // 
            this.lblDOH.AutoSize = true;
            this.lblDOH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOH.Location = new System.Drawing.Point(109, 219);
            this.lblDOH.Name = "lblDOH";
            this.lblDOH.Size = new System.Drawing.Size(102, 18);
            this.lblDOH.TabIndex = 11;
            this.lblDOH.Text = "Date of Hire";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(219, 83);
            this.txtEmployeeID.MaxLength = 6;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(97, 20);
            this.txtEmployeeID.TabIndex = 12;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            this.txtEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeeID_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Location = new System.Drawing.Point(219, 118);
            this.txtLastName.MaxLength = 40;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(281, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirstName.Location = new System.Drawing.Point(219, 149);
            this.txtFirstName.MaxLength = 40;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(281, 20);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtPayGrade
            // 
            this.txtPayGrade.Location = new System.Drawing.Point(220, 250);
            this.txtPayGrade.MaxLength = 2;
            this.txtPayGrade.Name = "txtPayGrade";
            this.txtPayGrade.Size = new System.Drawing.Size(32, 20);
            this.txtPayGrade.TabIndex = 17;
            this.txtPayGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayGrade_KeyPress);
            this.txtPayGrade.Validating += new System.ComponentModel.CancelEventHandler(this.txtPayGrade_Validating);
            // 
            // cBoxPosition
            // 
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
            this.cBoxPosition.Location = new System.Drawing.Point(219, 282);
            this.cBoxPosition.Name = "cBoxPosition";
            this.cBoxPosition.Size = new System.Drawing.Size(281, 21);
            this.cBoxPosition.TabIndex = 18;
            this.cBoxPosition.Leave += new System.EventHandler(this.cBoxPosition_Leave);
            // 
            // cBoxWorkArea
            // 
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
            this.cBoxWorkArea.Location = new System.Drawing.Point(219, 316);
            this.cBoxWorkArea.Name = "cBoxWorkArea";
            this.cBoxWorkArea.Size = new System.Drawing.Size(281, 21);
            this.cBoxWorkArea.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(220, 217);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(634, 408);
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
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS/409 Week Four Individual Assignment";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEmpList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblWorkArea;
        private System.Windows.Forms.Label lblPayGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblDOH;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPayGrade;
        private System.Windows.Forms.ComboBox cBoxPosition;
        private System.Windows.Forms.ComboBox cBoxWorkArea;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

