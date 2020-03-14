using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMWaterLevel.UserControls
{
    public partial class Header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["Login"] != null)
                {
                    lblName.Text = Session["Name"].ToString();
                    lblRole.Text = Session["RoleName"].ToString();
                    lblNameCircle.Text = Session["Name"].ToString();
                }
                if (Request["q"] != null)
                {
                    if (Session["Login"].ToString() != null)
                    {
                        Session["Login"] = null;
                        Session["Name"] = null;
                        Session["Role"] = null;
                        Session["RoleName"] = null;
                        Response.Redirect("~/signin.aspx");
                    }
                }
            }
        }

        protected void btnSignout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/lockscreen.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
            {
                Session["Name"] = lblName.Text;
                Response.Redirect("~/userprofiles/userprofile.aspx");
            }
        }
    }
}