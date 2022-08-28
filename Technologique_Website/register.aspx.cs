using HashPass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Technologique_Website.ServiceReference1;

namespace Technologique_Website
{
    public partial class register : System.Web.UI.Page
    {
        Service1Client sc = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var hashed = Secrecy.HashPassword(txtPassword.Value);
            bool isRegistered = sc.userRegister(txtName.Value, txtSurname.Value, txtEmail.Value,hashed);
            if (hashed == txtConfirmPassword.Value)
            {
                if(isRegistered == true)
                {
                    Response.Redirect("login.aspx");
                }

            }
        }
    }
}