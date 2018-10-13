using StateManagement.UserControls;
using System;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;
using static StateManagement.UserControls.UserControl1;

namespace StateManagement
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Init(object sender, EventArgs e)
        {
            
            CreateUserControl();
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {

            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "btnSubmit_Click 1";
            Debug.WriteLine("btnSubmit_Click 1");

            if (Session["userControl1"] == null)
            {
                // Create instance of the UserControl SimpleControl
                UserControl1 userControl1 = Page.LoadControl("~/UserControls/UserControl1.ascx") as UserControl1;

                // Set the Public Properties
                userControl1.FirstName.Text = "Lester";
                userControl1.LastName.Text = "Xu";

                //Create Event Handler for btnPost Click 
                userControl1.btnPostClk += new UserControl1.btnPost_Click(userControl1_btnPostClick);


                this.Placeholder1.Controls.Add(userControl1);

                // Add the instance of the SimpleControl to Session Variable
                Session.Add("userControl1", userControl1);

            }
           

        }
        protected void btnSubmit_Click2(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "btnSubmit_Click 2";
            Debug.WriteLine("btnSubmit_Click 2");

            if (Session["UserControl2"] == null)
            {
                UserControl2 userControl2 = Page.LoadControl("~/UserControls/UserControl2.ascx") as UserControl2;

                //Create Event Handler for btnPost Click 
                //userControl2.btnPostClk += new UserControl2.btnPost_Click(userControl2_btnPostClick);

                this.Placeholder1.Controls.Add(userControl2);

                Session.Add("userControl2", userControl2);

            }

            

        }
        protected void btnSubmit_Click3(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "btnSubmit_Click 3";
            Debug.WriteLine("btnSubmit_Click 3");
            UserControl userControl = Page.LoadControl("~/UserControls/UserControl3.ascx") as UserControl;

            this.Placeholder1.Controls.Add(userControl);

        }

        void userControl1_btnPostClick(object sender, EventArgs e)
        {
            UserControl1 userControl1 = ((UserControl1)(sender));
            lblName.Text = "Welcome " + userControl1.FirstName.Text + " " + userControl1.LastName.Text;
        }

        //void userControl2_btnPostClick(object sender, EventArgs e)
        //{
        //    UserControl2 userControl2 = ((UserControl2)(sender));
        //    lblName.Text = "UserControl2 button clicked with the result text: " + (userControl2.FindControl("Label1") as Label).Text;
        //}


        protected void CreateUserControl()
        {
            // createAgain field is set to true in the OnPreInit method
            // when the 'Create User Control' button is clicked 

            // the createAgain field is used to check if the
            // user control is on the page before the call 
            // if so create the control again and add it to the
            // Control Hierarchy again
            try
            {
                Debug.WriteLine("----------------Session.Count:{0}--------------", Session.Count);
                if (Session.Count > 0)
                {
                    if (Placeholder1 != null)
                    {
                        Placeholder1.Controls.Clear();
                    }

                    for (int i = 0; i < Session.Count; i++)
                    {
                        var result = Session;
                        Debug.WriteLine("----------------result:{0}--------------", result);

                        switch (Session[i].ToString())
                        {
                            case "ASP.usercontrols_usercontrol1_ascx":
                                {
                                    // Create instance of the UserControl SimpleControl
                                    UserControl1 userControl1 = Page.LoadControl("~/UserControls/UserControl1.ascx") as UserControl1;

                                    // Set the Public Properties
                                    userControl1.FirstName.Text = ((UserControl1)(Session[i])).FirstName.Text;
                                    userControl1.LastName.Text = ((UserControl1)(Session[i])).LastName.Text;

                                    ////Create Event Handler for btnPost Click 
                                    userControl1.btnPostClk += new UserControl1.btnPost_Click(userControl1_btnPostClick);

                                    this.Placeholder1.Controls.Add(userControl1);

                                    break;
                                }
                            case "ASP.usercontrols_usercontrol2_ascx":
                                UserControl2 userControl2 = Page.LoadControl("~/UserControls/UserControl2.ascx") as UserControl2;
                                (userControl2.FindControl("Label1") as Label).Text = (((UserControl2)(Session[i])).FindControl("Label1") as Label).Text;
                                //userControl2.btnPostClk += new UserControl2.btnPost_Click(userControl2_btnPostClick);
                                this.Placeholder1.Controls.Add(userControl2);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}