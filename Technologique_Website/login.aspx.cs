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
    public partial class login : System.Web.UI.Page
    {
        Service1Client sc = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var hashed = Secrecy.HashPassword(txtPassword.Value);
            int login = sc.userLogin(txtEmail.Value, hashed);
            if(login != 0)
            {
                Session["LoggedInUser"] = login;
                Response.Redirect("index.aspx");
            }
        }
    }
}