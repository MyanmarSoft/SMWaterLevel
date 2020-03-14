using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;


namespace SMWaterLevel.UserProfiles
{
    public partial class deleteuserprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfiles/userprofilelist.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile originalUserProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Request["UserProfileID"]));

            UserProfile userProfile = new UserProfile();

            if (originalUserProfile.ID != 1)
            {
                userProfile.ID = originalUserProfile.ID;
                userProfile.Name = originalUserProfile.Name;
                userProfile.Username = originalUserProfile.Username;
                userProfile.Password = originalUserProfile.Password;
                userProfile.DepartmentID = originalUserProfile.DepartmentID;
                userProfile.UserRoleID = originalUserProfile.UserRoleID;
                userProfile.Status = "INACTIVE";

                if (userProfileTableAdapter.Update(userProfile) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalUserProfile.Name + "</b>.</div>";
                    Response.Redirect("~/UserProfiles/userprofilelist.aspx");
                }
            }
            else
            {
                ShowErrorMessage(GetGlobalResourceObject("UserResource", "systemdefaultuser").ToString());
            }

        }
        public void ShowErrorMessage(string error)
        {
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageOpenTag").ToString();
            ltlMessage.Text += error;
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageCloseTag").ToString();
        }


    }
}