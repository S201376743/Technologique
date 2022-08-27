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
            if (txtPassword.Value == txtConfirmPassword.Value)
            {
                var hashed = Secrecy.HashPassword(txtPassword.Value);

            }
        }
    }
}