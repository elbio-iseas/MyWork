using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// 

namespace POS409DiceSimulation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // idea from MSDN example
            
            string file = "rolledDice.txt";

            string currentPath = Directory.GetCurrentDirectory();

            string strSumOfDice = "";

            StreamWriter fileWriter = new StreamWriter(file);

            Random r = new Random();

            int numberOne = 0;

            int numberTwo = 0;

            int numberSum = 0;
            
            for (int i = 0; i < 100; i++)

            {
                numberOne = r.Next(1, 6);

                numberTwo = r.Next(1, 6);

                numberSum = numberOne + numberTwo;

                strSumOfDice = numberSum.ToString();

                fileWriter.WriteLine(strSumOfDice);

            }

            fileWriter.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)

        {
            frmResults results = new frmResults();

            results.Show();

        }

    }
}
