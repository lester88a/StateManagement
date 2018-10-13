using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement.UserControls
{
    public partial class UserControl3 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Debug.WriteLine("UC3 Page_Load");
        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("UC3 Clicked");
        }
    }
}