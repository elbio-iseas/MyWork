using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS409LearningTeamDatabaseApp
{
    public partial class Form1 : Form
    {
        // ================================================================
        public Form1()
        {
            InitializeComponent();
        }
        // ================================================================
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ===============================================================
        private void btnReadFromDatabase_Click(object sender, EventArgs e)
        {

        }
        // ============================================================
        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {

        }
        // ============================================================
        private void btnSearchbyPhone_Click(object sender, EventArgs e)
        {

        }
        // ===================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
          
        // ===================================================================
       
        // idea from YouTube 

        // https://www.youtube.com/watch?v=01LLLYIrVks

        // Restricting TextBox input to numbers only in C#

        private void txtBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
            //e.Handled = !char.IsDigit(e.KeyChar); //&& e.KeyChar!=(char)Keys.Back;
        }  
        // ================================================================
        private void txtBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
        // ================================================================
        private void txtBoxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double phoneNumber = Double.Parse(txtBoxPhoneNumber.Text);

                if (phoneNumber >= 1000000000 && phoneNumber <= 9999999999)
                {
                    // The Phone Number is in the valid range.

                    e.Cancel = false;

                }
                else
                {
                    // The Phone number is not in the valid range.

                    MessageBox.Show("The Phone Number needs to be in the range 1000000000 to 9999999999!");

                    e.Cancel = true;

                    this.txtBoxPhoneNumber.Text = "";

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("The Phone Number needs to be in the range 1000000000 to 9999999999!");

                e.Cancel = true;

                this.txtBoxPhoneNumber.Text = "";

            }
        }
        // ================================================================
        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
        
        // ================================================================
        private void txtBoxLastName_Validating(object sender, CancelEventArgs e)
        {

        } 

        // =================================================================
        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        // ================================================================
        private void txtBoxFirstName_Validating(object sender, CancelEventArgs e)
        {

        }

        // ===============================================================
        private void txtBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }
        // ================================================================
        private void txtBoxAddress_Validating(object sender, CancelEventArgs e)
        {

        }
        // ============================================================
        private void txtBoxCity_TextChanged(object sender, EventArgs e)
        {

        }
        // ================================================================
        private void txtBoxCity_Validating(object sender, CancelEventArgs e)
        {

        }
        // ================================================================
        private void txtBoxState_TextChanged(object sender, EventArgs e)
        {

        }
        // ================================================================
        private void txtBoxState_Validating(object sender, CancelEventArgs e)
        {

        }
        // ====================================================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // ================================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //int countRecords(string textFile)
            //Client[] readFromFile(Client[] array, string textFile)
            //Client[] sortClientArray(Client[] array, int totalElements)
            //int BinSearch(Client[] clients, string term)
            //void loadTextBoxes( Client[] array, int index)                  
            //Boolean goodPhoneNumber(string phoneNo)

            // Client aClient = new Client();
            // int maxRecs = aClient.countRecords("Customers.txt");
            //Client[] myArray = new Client[maxRecs];
            //myArray = aClient.readFromFile(myArray, "Customers.txt");
            //myArray = aClient.sortClientArray(myArray, maxRecs);

            //string phoneToSearch = txtBoxPhoneNumber.Text;
            //int inx = aClient.BinSearch(myArray, phoneToSearch);
                        
            //if (inx >= 0)
            //{
                //MessageBox.Show("Client found on index :  " + inx.ToString() + " in " + aClient.comparisons.ToString() + " comparisons.");      
                    
            //    aClient.loadTextBoxes(myArray, inx);
                
            //    txtBoxLastName.Text = ((Client)myArray[inx]).lastName;
                                               
            //    txtBoxFirstName.Text = ((Client)myArray[inx]).firstName;

            //    txtBoxAddress.Text = ((Client)myArray[inx]).address;

            //    txtBoxCity.Text = ((Client)myArray[inx]).city;

            //    txtBoxState.Text = ((Client)myArray[inx]).state;

            //    txtBoxZipCode.Text = ((Client)myArray[inx]).zipCode;
                
            //}
            //else
            //{
            //    MessageBox.Show("This phone # " + phoneToSearch + " was not found on file!");
            //}

            //txtBoxPhoneNumber.Text = "";

            //txtBoxPhoneNumber.Focus();
        }
                
    }
}


