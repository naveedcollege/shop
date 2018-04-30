using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        // Create an instance of the DAL class
        DAL MyDB = new DAL();

        if (rdoRoleList.SelectedValue != "C" || rdoRoleList.SelectedValue != "M")
        {
            lblError.Visible = true;
            lblError.Text = "Please select your role before logging in!";
        }

        if (rdoRoleList.SelectedValue == "C")
        {

            MyDB.checkCustomerLogin();
        }

        if (rdoRoleList.SelectedValue == "M")
        {
            MyDB.checkStaffLogin();
        }
    }
}