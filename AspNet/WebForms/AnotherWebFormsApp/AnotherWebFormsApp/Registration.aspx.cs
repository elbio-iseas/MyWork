using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnotherWebFormsApp
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetFocus(TxtBxFName);
        }

        protected void TxtBxFName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TxtBxLName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {            
            LblWelcome.Text = "Welcome to WebForms, " + TxtBxFName.Text + " " + TxtBxLName.Text;
            LblWelcome.Visible = true;
        }
    }
}

    