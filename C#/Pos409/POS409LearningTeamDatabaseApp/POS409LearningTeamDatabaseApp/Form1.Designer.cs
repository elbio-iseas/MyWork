namespace POS409LearningTeamDatabaseApp
{
    partial class Form1
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
            this.btnReadFromDatabase = new System.Windows.Forms.Button();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnSearchbyPhone = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReadFromDatabase
            // 
            this.btnReadFromDatabase.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReadFromDatabase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFromDatabase.ForeColor = System.Drawing.Color.White;
            this.btnReadFromDatabase.Location = new System.Drawing.Point(21, 120);
            this.btnReadFromDatabase.Name = "btnReadFromDatabase";
            this.btnReadFromDatabase.Size = new System.Drawing.Size(172, 34);
            this.btnReadFromDatabase.TabIndex = 30;
            this.btnReadFromDatabase.Text = "Read from Database";
            this.btnReadFromDatabase.UseVisualStyleBackColor = false;
            this.btnReadFromDatabase.Click += new System.EventHandler(this.btnReadFromDatabase_Click);
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(313, 110);
            this.txtBoxPhoneNumber.MaxLength = 10;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(126, 22);
            this.txtBoxPhoneNumber.TabIndex = 29;
            this.txtBoxPhoneNumber.TextChanged += new System.EventHandler(this.txtBoxPhoneNumber_TextChanged);
            this.txtBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPhoneNumber_KeyPress);
            this.txtBoxPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPhoneNumber_Validating);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(232, 112);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(72, 18);
            this.lblPhoneNumber.TabIndex = 28;
            this.lblPhoneNumber.Text = "Phone #";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Enabled = false;
            this.txtBoxZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZipCode.Location = new System.Drawing.Point(438, 295);
            this.txtBoxZipCode.MaxLength = 5;
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(68, 22);
            this.txtBoxZipCode.TabIndex = 27;
            this.txtBoxZipCode.TextChanged += new System.EventHandler(this.txtBoxZipCode_TextChanged);
            this.txtBoxZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxZipCode_Validating);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.ForeColor = System.Drawing.Color.White;
            this.lblZipCode.Location = new System.Drawing.Point(354, 299);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(78, 18);
            this.lblZipCode.TabIndex = 26;
            this.lblZipCode.Text = "Zip Code";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxState
            // 
            this.txtBoxState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxState.Enabled = false;
            this.txtBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxState.Location = new System.Drawing.Point(313, 295);
            this.txtBoxState.MaxLength = 2;
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(26, 22);
            this.txtBoxState.TabIndex = 25;
            this.txtBoxState.TextChanged += new System.EventHandler(this.txtBoxState_TextChanged);
            this.txtBoxState.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxState_Validating);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(253, 295);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(51, 18);
            this.lblState.TabIndex = 24;
            this.lblState.Text = "State";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxCity.Enabled = false;
            this.txtBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(313, 258);
            this.txtBoxCity.MaxLength = 40;
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(275, 22);
            this.txtBoxCity.TabIndex = 23;
            this.txtBoxCity.TextChanged += new System.EventHandler(this.txtBoxCity_TextChanged);
            this.txtBoxCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCity_Validating);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(268, 264);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 18);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxAddress.Enabled = false;
            this.txtBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(313, 221);
            this.txtBoxAddress.MaxLength = 50;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(366, 22);
            this.txtBoxAddress.TabIndex = 21;
            this.txtBoxAddress.TextChanged += new System.EventHandler(this.txtBoxAddress_TextChanged);
            this.txtBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxAddress_Validating);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(232, 222);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 18);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxFirstName.Enabled = false;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(313, 184);
            this.txtBoxFirstName.MaxLength = 40;
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(275, 22);
            this.txtBoxFirstName.TabIndex = 19;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.txtBoxFirstName_TextChanged);
            this.txtBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxFirstName_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(213, 182);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 18);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxLastName.Enabled = false;
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(313, 147);
            this.txtBoxLastName.MaxLength = 40;
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(275, 22);
            this.txtBoxLastName.TabIndex = 17;
            this.txtBoxLastName.TextChanged += new System.EventHandler(this.txtBoxLastName_TextChanged);
            this.txtBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(214, 146);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(93, 18);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveToDatabase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDatabase.ForeColor = System.Drawing.Color.White;
            this.btnSaveToDatabase.Location = new System.Drawing.Point(21, 166);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(172, 34);
            this.btnSaveToDatabase.TabIndex = 31;
            this.btnSaveToDatabase.Text = "Save to Database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = false;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnSearchbyPhone
            // 
            this.btnSearchbyPhone.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchbyPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchbyPhone.ForeColor = System.Drawing.Color.White;
            this.btnSearchbyPhone.Location = new System.Drawing.Point(21, 209);
            this.btnSearchbyPhone.Name = "btnSearchbyPhone";
            this.btnSearchbyPhone.Size = new System.Drawing.Size(172, 34);
            this.btnSearchbyPhone.TabIndex = 32;
            this.btnSearchbyPhone.Text = "Search by Phone";
            this.btnSearchbyPhone.UseVisualStyleBackColor = false;
            this.btnSearchbyPhone.Click += new System.EventHandler(this.btnSearchbyPhone_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(21, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 34);
            this.button3.TabIndex = 33;
            this.button3.Text = "Update Client Info";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(21, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 34);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit the App";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impress BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 60);
            this.label1.TabIndex = 35;
            this.label1.Text = "Client Management";
            // 
            // cBoxState
            // 
            this.cBoxState.FormattingEnabled = true;
            this.cBoxState.Items.AddRange(new object[] {
            "AL   ALABAMA",
            "AK   ALASKA",
            "AZ   ARIZONA",
            "AR   ARKANSAS",
            "CA   CALIFORNIA",
            "CO  COLORADO",
            "CT   CONNECTICUT",
            "DE   DELAWARE",
            "FL    FLORIDA",
            "GA   GEORGIA",
            "HI    HAWAII",
            "ID     IDAHO",
            "IL     ILLINOIS",
            "IN    INDIANA",
            "IA    IOWA",
            "KS   KANSAS",
            "KY   KENTUCKY",
            "LA   LOUISIANA",
            "ME  MAINE",
            "MD  MARYLAND",
            "MA  MASSACHUSETTS",
            "MI    MICHIGAN",
            "MN  MINNESOTA",
            "MS   MISSISSIPPI",
            "MO  MISSOURI",
            "MT   MONTANA",
            "NE    NEBRASKA",
            "NV    NEVADA",
            "NH    NEW HAMPSHIRE",
            "NJ     NEW JERSEY",
            "NM   NEW MEXICO",
            "NY    NEW YORK",
            "NC    NORTH CAROLINA",
            "ND    NORTH DAKOTA",
            "OH    OHIO",
            "OK     OKLAHOMA",
            "OR     OREGON",
            "PA     PENNSYLVANIA",
            "RI       RHODE ISLAND",
            "SC     SOUTH CAROLINA",
            "SD     SOUTH DAKOTA",
            "TN    TENNESSEE",
            "TX     TEXAS",
            "UT     UTAH",
            "VT     VERMONT",
            "VA     VIRGINIA",
            "WA    WASHINGTON",
            "WV     WEST VIRGINIA",
            "WI      WISCONSIN",
            "WY     WYOMING"});
            this.cBoxState.Location = new System.Drawing.Point(459, 110);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(193, 21);
            this.cBoxState.TabIndex = 36;
            this.cBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(704, 362);
            this.Controls.Add(this.cBoxState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSearchbyPhone);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.btnReadFromDatabase);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtBoxZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS409 Learning Team B Databases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFromDatabase;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button btnSearchbyPhone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxState;
    }
}

