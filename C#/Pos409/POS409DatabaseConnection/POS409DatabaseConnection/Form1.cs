using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace POS409DatabaseConnection
{
    public partial class frmMain : Form
    {
        public static ArrayList EmployeeAL = new ArrayList();

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            this.txtEmployeeID.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // https://www.youtube.com/watch?v=EcZQghn88vE

            char kp = e.KeyChar;

            if (!Char.IsDigit(kp) && kp != 8)
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int empID = Int32.Parse(txtEmployeeID.Text);

                if (empID >= 100000 && empID <= 999999)
                {
                    // The Employee ID number is in the valid range.

                    e.Cancel = false;

                }
                else
                {
                    // The Employee ID number is not in the valid range.

                    MessageBox.Show("The Employee ID needs to be in the range 100000 to 999999!");

                    e.Cancel = true;

                    this.txtEmployeeID.Text = "";

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("The Employee ID needs to be in the range 100000 to 999999!");

                e.Cancel = true;

                this.txtEmployeeID.Text = "";

            }
        }
        
        private void txtPayGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // https://www.youtube.com/watch?v=EcZQghn88vE
            
            char kp = e.KeyChar;

            if (!Char.IsDigit(kp) && kp != 8)
            {
                e.Handled = true;
            }
            
        }

        private void txtPayGrade_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                int payGrade;

                Int32.TryParse((string)txtPayGrade.Text, out payGrade);

                if (payGrade >= 1 && payGrade <= 99)
                {
                    // The Pay Grade number is in the valid range.

                    e.Cancel = false;

                }
                else
                {
                    // The Pay Grade number is not in the valid range.

                    MessageBox.Show("The Pay Grade needs to be in the range 1 to 99!");

                    e.Cancel = true;

                    this.txtPayGrade.Text = "";

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("The Pay Grade needs to be in the range 1 to 99!");

                e.Cancel = true;

                this.txtPayGrade.Text = "";

            }

        }   

        private void cBoxPosition_Leave(object sender, EventArgs e)
        {
            int index = (Int32)(cBoxPosition.SelectedIndex);

            if (index == -1 || cBoxPosition.Text == "")
            {
                cBoxPosition.Focus();
            }
        }

        private void cBoxWorkArea_Leave(object sender, EventArgs e)
        {
            int index = (Int32)(cBoxWorkArea.SelectedIndex);

            if (index == -1 || cBoxWorkArea.Text == "")
            {
                cBoxWorkArea.Focus();
            }
        }       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EmployeeAL = createNewEmployee(EmployeeAL);

        }

        private ArrayList createNewEmployee(ArrayList myArray)
        {
            ArrayList MisAL = new ArrayList();

            MisAL = myArray;

            MisDept newITemployee = new MisDept();


            newITemployee.Id = Convert.ToInt32(this.txtEmployeeID.Text);

            newITemployee.LastName = this.txtLastName.Text;

            newITemployee.FirstName = this.txtFirstName.Text;

            newITemployee.DoB = Convert.ToDateTime(this.dateTimePicker1.Text);

            newITemployee.DoH = Convert.ToDateTime(this.dateTimePicker2.Text);

            newITemployee.Position = this.cBoxPosition.Text;

            newITemployee.WorkArea = this.cBoxWorkArea.Text;

            newITemployee.PayGrade = Convert.ToInt32(this.txtPayGrade.Text);

            MisAL.Add(newITemployee);

            BlankTextBoxes();


            return MisAL;
        }

        private void BlankTextBoxes()
        {
            txtEmployeeID.Text = "";

            txtLastName.Text = "";

            txtFirstName.Text = "";

            dateTimePicker1.Text = "";

            dateTimePicker2.Text = "";

            cBoxPosition.Text = "";

            cBoxWorkArea.Text = "";

            txtPayGrade.Text = "";
        }

        private void btnLoadDatabase_Click(object sender, EventArgs e)
        {
            // Subroutine idea from my POS/408 Week Four Individual Assignment

            OleDbConnection connexion = new OleDbConnection();

            string dbProvider;

            string dbSource;

            string path = Directory.GetCurrentDirectory();

            string dbFile = "Employees.accdb";

            string file = "Employees";

            DataSet dataSet = new DataSet();

            OleDbDataAdapter dataAdapter = new System.Data.OleDb.OleDbDataAdapter();

            OleDbCommand sql = new OleDbCommand();

            dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;";

            dbSource = "Data Source = " + path + "\\" + dbFile;

            connexion.ConnectionString = dbProvider + dbSource;

            connexion.Open();

            sql.CommandText = "SELECT * FROM Employees";

            dataAdapter = new System.Data.OleDb.OleDbDataAdapter(sql.CommandText, connexion);

            dataAdapter.Fill(dataSet, "Employees");

            connexion.Close();         

            EmployeeAL.Clear();

            int totalRecs = dataSet.Tables[0].Rows.Count;

            for ( int i = 0; i < totalRecs; i++ )
            {
                MisDept newITemployee = new MisDept();

                newITemployee.Id = Convert.ToInt32(dataSet.Tables[file].Rows[i][0]);

                newITemployee.LastName = Convert.ToString(dataSet.Tables[file].Rows[i][1]);

                newITemployee.FirstName = Convert.ToString(dataSet.Tables[file].Rows[i][2]);

                newITemployee.DoB = Convert.ToDateTime(dataSet.Tables[file].Rows[i][3]);

                newITemployee.DoH = Convert.ToDateTime(dataSet.Tables[file].Rows[i][4]);             

                newITemployee.Position = Convert.ToString(dataSet.Tables[file].Rows[i][5]);

                newITemployee.WorkArea = Convert.ToString(dataSet.Tables[file].Rows[i][6]);

                newITemployee.PayGrade = Convert.ToByte(dataSet.Tables[file].Rows[i][7]);

                EmployeeAL.Add(newITemployee);

            }

        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {

            // Subroutine idea from my POS/408 Week Four Individual Assignment

            OleDbConnection connexion = new OleDbConnection();

            string dbProvider;

            string dbSource;

            string path = Directory.GetCurrentDirectory();

            string dbFile = "Employees.accdb";

            string file = "Employees";

            DataSet dataSet = new DataSet();

            OleDbDataAdapter dataAdapter = new System.Data.OleDb.OleDbDataAdapter();

            OleDbCommand sql = new OleDbCommand();

            dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;";

            dbSource = "Data Source = " + path + "\\" + dbFile;

            connexion.ConnectionString = dbProvider + dbSource;

            connexion.Open();

            sql.CommandText = "SELECT * FROM Employees";

            //OleDbCommandBuilder commMaker = new OleDbCommandBuilder(dataAdapter);

            dataAdapter = new System.Data.OleDb.OleDbDataAdapter(sql.CommandText, connexion);

            dataAdapter.Fill(dataSet, file);

            dataSet.Clear();

            dataAdapter.Update(dataSet, file);

            int totalRecs = EmployeeAL.Count;

            connexion.Close();

            //msdn.microsoft.com/en-us/library/5ycd1034.aspx

            int empid = 212387;
            string ln = "ISEAS";
            string fn = "ELBIO";
            DateTime dateofbirth = Convert.ToDateTime("02/08/1959");
            DateTime dateofhire = Convert.ToDateTime("10/06/2014");
            string title = "SOFTWARE ENGINEER SENIOR";
            string warea = "DESIGN";
            byte pgrade = 27;

            DataRow rec;

            foreach (MisDept obj in frmMain.EmployeeAL)

            {

                sql.Connection = connexion;

                connexion.Open();

                rec = dataSet.Tables[file].NewRow();

                rec["ID"] = Convert.ToInt32(obj.Id);

                rec["LastName"] = Convert.ToString(obj.LastName);

                rec["FirstName"] = Convert.ToString(obj.FirstName);

                rec["DOB"] = Convert.ToDateTime(obj.DoB);

                rec["DOH"] = Convert.ToDateTime(obj.DoH);

                rec["Position"] = Convert.ToString(obj.Position);

                rec["WorkArea"] = Convert.ToString(obj.WorkArea);

                rec["PayGrade"] = Convert.ToByte(obj.PayGrade);

                dataSet.Tables[file].Rows.Add(rec);
                                
                //sql = new OleDbCommand("INSERT INTO " + file + " (ID, LastName, FirstName, DOB, DOH, Position, WorkArea, PayGrade ) " +

                //                       "VALUES (" + Convert.ToString(empid) + ", " + ln + ", " + fn + ", " + 
                                       
                //                       Convert.ToString(dateofbirth) + ", " + Convert.ToString(dateofhire) + ", " + 
                                       
                //                       title + ", " + warea + ", " + Convert.ToByte(pgrade) + ")", connexion);

                //sql.CommandType = System.Data.CommandType.Text;

                //sql = new OleDbCommand("INSERT INTO " + file + " (ID, LastName, FirstName, DOB, DOH, Position, WorkArea, PayGrade " +

                //                       "VALUES ((Mis)obj).Id), ((MisDept)obj).LastName, ((MisDept)obj).FirstName, " +

                //                       "Convert.ToDateTime((MisDept)obj.DoB), ((MisDept)obj).Position, Convert.ToDateTime((MisDept)obj.DoH)" +
                                       
                //                       "((MisDept)obj).WorkArea, Convert.ToByte(((MisDept)obj).PayGrade))", connexion);

                  //"VALUES (rec[ID], rec[LastName], rec[FirstName], rec[DOB], rec[DOH], " +

                  //"rec[Position], rec[WorkArea], rec[PayGrade]))";                               

                dataAdapter.InsertCommand.CommandText = "INSERT INTO " + file + " (ID, LastName, FirstName, DOB, DOH, Position, WorkArea, PayGrade ) " +

                                       "VALUES (" + Convert.ToString(empid) + ", " + ln + ", " + fn + ", " +

                                       Convert.ToString(dateofbirth) + ", " + Convert.ToString(dateofhire) + ", " +

                                       title + ", " + warea + ", " + Convert.ToByte(pgrade) + ")";

                //dataAdapter.InsertCommand.Connection = connexion;
                 
                dataAdapter.Update(dataSet, file);

                connexion.Close();

            }
                        
            //commMaker.GetUpdateCommand();
            //commMaker.GetInsertCommand();
            
            //connexion.Open();

            

            //connexion.Close();

        }
      
        
        private void btnEmpList_Click(object sender, EventArgs e)
        {
            int elementsCount = EmployeeAL.Count;

            frmEmpList frmEL = new frmEmpList();

            frmEL.ShowDialog(this);            
        }


                            
    }
}
