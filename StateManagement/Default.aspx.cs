using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            //lblName.Text = lblName.Text + "<br/>" + "PreInit";
            Debug.WriteLine("Page_PreInit");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "Init";
            Debug.WriteLine("Page_Init");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "InitComplete";
            Debug.WriteLine("Page_InitComplete");
        }
        protected override void OnPreLoad(EventArgs e)
        {
            //Work and It will assign the values to label.  
            //If the page is post back, then label contrl values will be loaded from view state.  
            //E.g: If you string str = lblName.Text, then str will contain viewstate values.  
            lblName.Text = lblName.Text + "<br/>" + "PreLoad";
            Debug.WriteLine("OnPreLoad");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "Load";
            Debug.WriteLine("Page_Load");
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "btnSubmit_Click";
            Debug.WriteLine("btnSubmit_Click");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "LoadComplete";
            Debug.WriteLine("Page_LoadComplete");
        }
        protected override void OnPreRender(EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "PreRender";
            Debug.WriteLine("OnPreRender");
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            //Work and It will assign the values to label.  
            //But "SaveStateComplete" values will not be available during post back. i.e. View state.  
            lblName.Text = lblName.Text + "<br/>" + "SaveStateComplete";
            Debug.WriteLine("OnSaveStateComplete");
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Work and it will not effect label contrl, view stae and post back data.  
            //lblName.Text = lblName.Text + "<br/>" + "UnLoad";
            Debug.WriteLine("Page_UnLoad");
        }

    }
}