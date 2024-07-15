using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS409Inheritance
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

        private void btnEmpList_Click(object sender, EventArgs e)
        {

            frmEmpList frmEL = new frmEmpList();

            frmEL.Show();

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
            double empID = Double.Parse(txtEmployeeID.Text);

            try

            {
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
            int payGrade;

            Int32.TryParse((string)txtPayGrade.Text, out payGrade);

            try
            {
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
     
        private ArrayList createNewEmployee ( ArrayList myArray )

        {
            ArrayList MisAL = new ArrayList();

            MisAL = myArray;
        
            MisDept newITemployee = new MisDept();


            newITemployee.Id = Convert.ToDouble(this.txtEmployeeID.Text);

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

            dateTimePicker2.Text =  "";

            cBoxPosition.Text = "";

            cBoxWorkArea.Text = "";

            txtPayGrade.Text = "";
        }

    }
}
