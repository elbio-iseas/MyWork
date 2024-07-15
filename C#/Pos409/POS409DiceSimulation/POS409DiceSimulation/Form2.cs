using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System;

namespace POS409DiceSimulation
{
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();

            ArrayList diceResults = new ArrayList();

            string file = "rolledDice.txt";

            try

            {
                StreamReader fileReader = new StreamReader(file);

                string recordLine;

                while ((recordLine = fileReader.ReadLine()) != null)

                {

                     diceResults.Add(recordLine);
				     
                }

                fileReader.Close();

                if (diceResults.Count > 99)

                {                       
                        
                    int k = 0;

                    for (int i = 1; i <= 10; i++) 
                    
                    {
                        string txtBoxLine = " "; 

                        for (int j = 1; j <= 10; j++) 

                            {
                                // Two digit result      
                                if (diceResults[k].ToString().Length > 1)

                                   txtBoxLine = txtBoxLine + diceResults[k].ToString() + "    ";

                                else // One digit result                                   

                                   txtBoxLine = txtBoxLine + "  " + diceResults[k].ToString() + "    ";
                                k++;   
                            }

                        k = k-1;
                        
                        if (i == 1)
                            textBox1.Text = txtBoxLine;
                        else if (i == 2)
                            textBox2.Text = txtBoxLine;
                        else if (i == 3)
                            textBox3.Text = txtBoxLine;
                        else if (i == 4)
                            textBox4.Text = txtBoxLine;
                        else if (i == 5)
                            textBox5.Text = txtBoxLine;
                        else if (i == 6)
                            textBox6.Text = txtBoxLine;
                        else if (i == 7)
                            textBox7.Text = txtBoxLine;
                        else if (i == 8)
                            textBox8.Text = txtBoxLine;
                        else if (i == 9)
                            textBox9.Text = txtBoxLine;
                        else if (i == 10)
                            textBox10.Text = txtBoxLine;                            
                        
                    }

                }

                else

                {

                    MessageBox.Show("File does not meet Application's Requirements!");

                }

               
            }

            catch (Exception e)

            {

                MessageBox.Show("Unable to read file!");

                MessageBox.Show(e.Message);

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

