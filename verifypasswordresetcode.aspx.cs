using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SMWaterLevel.UserControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;


namespace SMWaterLevel
{
    public partial class verifypasswordresetcode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["q"] != null)
                {
                    if (Session["Login"].ToString() != null)
                    {
                        Session["Login"] = null;
                        Session["Name"] = null;

                        Response.Redirect(ConfigurationManager.AppSettings.GetValues("mainURL") + "signin.aspx");
                    }
                }
            }
            

        }
        protected void btnVerify_Click(object sender, EventArgs e)
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile userProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Session["Login"]));

            if (userProfile.UserRoleID == 1)
            {
                if (txtVerifyCode.Text.Trim() == Session["ResetCode"].ToString())
                {
                    Session["Login"] = userProfile.ID;
                    Session["Name"] = userProfile.Name;
                    Session["Role"] = userProfile.UserRoleID;

                    Response.Redirect("~/changepassword.aspx");
                }

            }
            else
            {
                Response.Redirect("~/signin.aspx");
            }
        }
    }
}