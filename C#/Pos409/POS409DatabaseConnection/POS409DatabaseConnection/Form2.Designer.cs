namespace POS409DatabaseConnection
{
    partial class frmEmpList
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.dataGridViewEmpList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIST OF EMPLOYEES";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMainMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(243, 363);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(164, 33);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // dataGridViewEmpList
            // 
            this.dataGridViewEmpList.AllowUserToDeleteRows = false;
            this.dataGridViewEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.DoB,
            this.Position,
            this.WorkArea,
            this.DoH,
            this.PayGrade});
            this.dataGridViewEmpList.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewEmpList.Name = "dataGridViewEmpList";
            this.dataGridViewEmpList.ReadOnly = true;
            this.dataGridViewEmpList.Size = new System.Drawing.Size(610, 299);
            this.dataGridViewEmpList.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "EmployeeID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // DoB
            // 
            this.DoB.HeaderText = "Date of Birth";
            this.DoB.Name = "DoB";
            this.DoB.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // WorkArea
            // 
            this.WorkArea.HeaderText = "Work Area";
            this.WorkArea.Name = "WorkArea";
            this.WorkArea.ReadOnly = true;
            // 
            // DoH
            // 
            this.DoH.HeaderText = "Data of Hire";
            this.DoH.Name = "DoH";
            this.DoH.ReadOnly = true;
            // 
            // PayGrade
            // 
            this.PayGrade.HeaderText = "Pay Grade";
            this.PayGrade.Name = "PayGrade";
            this.PayGrade.ReadOnly = true;
            // 
            // frmEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(634, 408);
            this.Controls.Add(this.dataGridViewEmpList);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpList";
            this.Text = "frm EmpList";
            this.Load += new System.EventHandler(this.frmEmpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewEmpList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayGrade;
    }
}