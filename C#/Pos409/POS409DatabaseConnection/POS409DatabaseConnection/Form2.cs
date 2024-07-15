using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS409DatabaseConnection
{
    public partial class frmEmpList : Form
    {
        public frmEmpList()
        {
            InitializeComponent();
        }

        private void frmEmpList_Load(object sender, EventArgs e)
        {
            if (frmMain.EmployeeAL.Count > 0)
            {
                foreach (MisDept obj in frmMain.EmployeeAL)

                {
                    
                    // idea from stackoverflow.com

                    //http://stackoverflow.com/questions/6092463/how-can-i-manually-add-data-to-a-datagridview

                    DataGridViewRow line = new DataGridViewRow();

                    dataGridViewEmpList.Rows.Add((obj.Id).ToString(),
                                                 (obj.LastName).ToString(),
                                                 (obj.FirstName).ToString(),
                                                 (obj.DoB).ToString(),                                                 
                                                 (obj.Position).ToString(),
                                                 (obj.WorkArea).ToString(),
                                                 (obj.DoH).ToString(),
                                                 (obj.PayGrade).ToString());                    
                }

                dataGridViewEmpList.Show();              
            }
            else
            {
                MessageBox.Show("There are no employees in the system.!");            
            }


        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}


