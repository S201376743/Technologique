using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Technologique_Website
{
    public partial class TechnologiqueMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            String display = "";
            
            if (Session["LoggedInUser"] != null)
            {
                display += "<a href='login.aspx'><i class='fa fa-user'></i>Logout</a>";
    }

        }
    }
}