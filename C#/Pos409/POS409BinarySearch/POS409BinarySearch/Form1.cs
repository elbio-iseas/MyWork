using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace POS409BinarySearch
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        public string LastName
        {
            set { txtBoxLastName.Text = value; }
        }
        public string FirstName
        {
            set { txtBoxFirstName.Text = value; }
        }
        public string Address
        {
            set { txtBoxAddress.Text = value; }
        }
        public string City
        {
            set { txtBoxCity.Text = value; }
        }
        public string State
        {
            set { txtBoxState.Text = value; }
        }
        public string ZipCode
        {
            set { txtBoxZipCode.Text = value; }
        }
        public string Phone
        {
            set { txtBoxPhoneNumber.Text = value; }
        }
        public void frmMain_Load(object sender, EventArgs e)
        {

            

        }

       
        private void bntExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // int countRecords(string textFile)
            // Client[] readFromFile(Client[] array, string textFile)
            // Client[] sortClientArray(Client[] array, int totalElements)
            // int BinSearch(Client[] clients, string term)
            // void loadTextBoxes( Client[] array, int index)                  
            // Boolean goodPhoneNumber(string phoneNo)

            Client aClient = new Client();
            int maxRecs = aClient.countRecords("Customers.txt");
            Client[] myArray = new Client[maxRecs];
            myArray = aClient.readFromFile(myArray, "Customers.txt");
            myArray = aClient.sortClientArray(myArray, maxRecs);

            string phoneToSearch = txtBoxPhoneNumber.Text;
            int inx = aClient.BinSearch(myArray, phoneToSearch);
                        
            if (inx >= 0)
            {
                //MessageBox.Show("Client found on index :  " + inx.ToString() + " in " + aClient.comparisons.ToString() + " comparisons.");      
                    
                aClient.loadTextBoxes(myArray, inx);
                
                txtBoxLastName.Text = ((Client)myArray[inx]).lastName;
                                               
                txtBoxFirstName.Text = ((Client)myArray[inx]).firstName;

                txtBoxAddress.Text = ((Client)myArray[inx]).address;

                txtBoxCity.Text = ((Client)myArray[inx]).city;

                txtBoxState.Text = ((Client)myArray[inx]).state;

                txtBoxZipCode.Text = ((Client)myArray[inx]).zipCode;
                
            }
            else
            {
                MessageBox.Show("This phone # " + phoneToSearch + " was not found on file!");
            }
            txtBoxPhoneNumber.Text = "";
            txtBoxPhoneNumber.Focus();
        }
        // idea from YouTube 
        // https://www.youtube.com/watch?v=01LLLYIrVks
        // Restricting TextBox input to numbers only in C#

        private void txtBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

    }

}

