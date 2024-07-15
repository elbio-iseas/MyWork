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
    
    public class Client
    {
        public string lastName;

        public string firstName;

        public string address;

        public string city;

        public string state;

        public string zipCode;

        public string phoneNumber;

        public Client()
        {
            lastName = "";

            firstName = "";

            address = "";

            city = "";

            state = "";

            zipCode = "";

            phoneNumber = "";
        }

        public Client auxClient;

        string textFile = "Customers.txt";

        public int totalClients;

        public Client[] clientArray;

        public int comparisons;
                        
        // =============================================================================================  
        
        public int BinSearch(Client[] clients, string term)

        {
            comparisons = 0;

            int low = 0;

            int high = clients.Length - 1;

            int middle = 0;

            while (low <= high)
            {

                middle = low + ((high - low) / 2);

                if (term.CompareTo(clients[middle].phoneNumber)==0)
                {
                    comparisons++;

                    return middle;
                }
                else if (term.CompareTo(clients[middle].phoneNumber)==-1)
                {
                    comparisons++;

                    high = middle - 1;
                }
                else
                {
                    comparisons++;

                    low = middle + 1;
                }
            }

            return -1;
        }
                
    // =============================================================================================
        public int countRecords(string textFile)

        {
            int totalRecords = 0;

            try
            {
                StreamReader fileReader = new StreamReader(textFile);

                while ((fileReader.ReadLine()) != null)
                {
                    totalRecords++;
                }

                fileReader.Close();

                if (totalRecords == 0)

                   MessageBox.Show("File is empty!");
                
            }

            catch (Exception e)
            {

                MessageBox.Show("Unable to read file!");

                MessageBox.Show(e.Message);

            }

            return totalRecords;
        }

       // =============================================================================================
        public void loadTextBoxes( Client[] array, int index)
        {
            frmMain frm = new frmMain();

            frm.LastName = (string)array[index].lastName;
                        
            frm.FirstName = (string)array[index].firstName;

            frm.Address = (string)array[index].address;

            frm.City = (string)array[index].city;

            frm.State = (string)array[index].state;

            frm.ZipCode = (string)array[index].zipCode;

            frm.Phone = (string)array[index].phoneNumber;

        }
    // =============================================================================================
       public Client[] readFromFile(Client[] array, string textFile)
       {
            
            ArrayList CustAList = new ArrayList();

            string line;

            int totalLines = 0;

            try
            {
                StreamReader fileReader = new StreamReader(textFile);

                while ((line = fileReader.ReadLine()) != null)
                {
                    CustAList.Add(line);
                }

                fileReader.Close();

                totalLines = CustAList.Count;
                
                string last = "";

                string first = "";

                string address = "";

                string city = "";

                string state = "";

                string zipcode = "";

                string phone = "";

                if (totalLines > 0)
                {
                
                    string elementOfAList = "";
                        
                    string[] fields;

                    char[] separator = new char[] {','};

                    for (int i = 0; i < totalLines; i++)
                    {
                                           
                        elementOfAList = (string)CustAList[i];

                        fields = elementOfAList.Split(separator, 7, StringSplitOptions.RemoveEmptyEntries);                      
                                                                                     
                        last = fields[0];
                        
                        first = fields[1];

                        address = fields[2];

                        city = fields[3];

                        state = fields[4];

                        zipcode = fields[5];

                        phone = fields[6];

                        Client newClient = new Client();

                        newClient.lastName = last;

                        newClient.firstName = first;

                        newClient.address = address;

                        newClient.city = city;

                        newClient.state = state;

                        newClient.zipCode = zipcode;

                        newClient.phoneNumber = phone;

                        array[i] = newClient;                          
                    }
                    
                }
                else
                {
                    MessageBox.Show("File is empty!");
                }
                                                
            }

            catch (Exception e)
            {

                MessageBox.Show("Unable to read file!");

                MessageBox.Show(e.Message);

            }

            return array;
        }
        
        // =============================================================================================        
    
        public Client[] sortClientArray(Client[] array, int totalElements)
        {
            Client[] arrayToSort = new Client[totalElements];

            arrayToSort = array;

            Client auxClient = new Client();

            int result = 0;

            for (int i = totalElements - 1; i > 0; i--)
            {
                for (int j = 0; j < totalElements - 1; j++)
                {
                    result = arrayToSort[j].phoneNumber.CompareTo(arrayToSort[j + 1].phoneNumber);

                    if (result > 0)
                    {
                        auxClient = arrayToSort[j];

                        arrayToSort[j] = arrayToSort[j + 1];

                        arrayToSort[j + 1] = auxClient;

                    }

                }
            }
                                  
            return arrayToSort;
        }

        // =============================================================================================        

        public Boolean goodPhoneNumber(string phoneNo)
        {
            Boolean OK = false;

            string phNo = phoneNo.Trim();

            if (phNo.Length == 10)
            {
                Boolean good = true;

                for (int i = 0; i < 10; i++)
                {
                    if (!(char.IsDigit(phNo, i)))
                    {
                        good = false;

                        break;
                    }
                }
                if (good)
                {
                    if (Int32.Parse(phNo.Substring(0, 1)) > 0)
                    {
                        OK = true;
                    }
                    else
                    {
                        MessageBox.Show("The first digit of the phone number must be greater than zero!");
                    }
                }
                else
                {
                    MessageBox.Show("Phone Number must be digits only!");

                }

            }
            else
            {
                MessageBox.Show("Phone Number must be only digits!");
            }


            return OK;
        }    
    }
}

