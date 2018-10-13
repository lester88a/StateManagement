using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement.UserControls
{
    public partial class UserControl1 : System.Web.UI.UserControl
    {
        // Create Delegate to Handle Click event in Default page
        public delegate void btnPost_Click(object sender, System.EventArgs e);

        #region Public Event

        public event btnPost_Click btnPostClk;

        #endregion

        #region Public Properties
        public TextBox FirstName
        {
            get
            {
                return txtFirstName;
            }
            set
            {
                txtFirstName = value;
            }
        }
        public TextBox LastName
        {
            get
            {
                return txtLastName;
            }
            set
            {
                txtLastName = value;
            }
        }
        #endregion

        #region Vitual Methods

        protected virtual void OnButtonDelegateClickEvent(EventArgs e)
        {
            // Call btnPost_Click event delegate instance
            btnPostClk(this, e);
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("UC1 Page_Load");
        }
        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("UC1 Clicked");

            //Call Virtual Method
            OnButtonDelegateClickEvent(e);

            //Session.Clear();

        }
        
    }
}