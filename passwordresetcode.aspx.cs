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
    public partial class passwordresetcode : System.Web.UI.Page
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

                UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
                UserProfile userProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Session["Login"]));

                if (userProfile.UserRoleID == 1)
                {
                    ltlResetCode.Text = "<h2 class='login-box-msg'>" + resetCode() + "</h2>";
                }
            }
            
        }

        private string resetCode()
        {
            Random rnd = new Random();
            string code = rnd.Next(123456, 999999).ToString();
            return code;
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile userProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Session["Login"]));

            if (userProfile.UserRoleID == 1)
            {
                Session["Login"] = userProfile.ID;
                Session["Name"] = userProfile.Name;
                Session["Role"] = userProfile.UserRoleID;
                Session["ResetCode"] = resetCode();
                Response.Redirect("~/verifypasswordresetcode.aspx");
            }
        }
    }
}