using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement.UserControls
{
    public partial class UserControl2 : System.Web.UI.UserControl
    { 
        // Create Delegate to Handle Click event in Default page
        public delegate void btnPost_Click(object sender, System.EventArgs e);

        #region Public Event
        public event btnPost_Click btnPostClk;
        #endregion

        #region Vitual Method
        protected virtual void OnButtonDelegateClickEvent(EventArgs e)
        {
            // Call btnPost_Click event delegate instance
            btnPostClk(this, e);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("UC2 Page_Load");
        }
        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("UC2 Clicked");
            this.Label1.Text = "UserControl2 Button Clicked";

            //OnButtonDelegateClickEvent(e);
        }
    }
}