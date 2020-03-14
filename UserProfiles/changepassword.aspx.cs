using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.UserControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.Text;

namespace SMWaterLevel.app
{
    public partial class changepassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;

            if (txtUsername.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requireusername").ToString();
                validData = false;
            }
            else if (txtNewPassword.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requirenewpassword").ToString();
                validData = false;
            }
            else if (txtConfirmPassword.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requireconfirmpassword").ToString();
                validData = false;
            }
            else if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                error += GetGlobalResourceObject("UserResource", "notsamepassword").ToString();
                validData = false;
            }
            if (!validData)
            {
                ShowErrorMessage(error);
            }
            return validData;
        }
        public void ShowErrorMessage(string error)
        {
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageOpenTag").ToString();
            ltlMessage.Text += error;
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageCloseTag").ToString();
        }


        protected void btnCancel_Click1(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile originalUserProfile = userProfileTableAdapter.GetUserProfileByUsername(txtUsername.Text.Trim(), "ACTIVE");

            UserProfile userProfile = new UserProfile();

            if (IsValidData())
            {
                userProfile.ID = originalUserProfile.ID;
                userProfile.Name = originalUserProfile.Name;
                userProfile.Username = Server.HtmlEncode(txtUsername.Text.Trim());
                userProfile.Password = Server.HtmlEncode(txtNewPassword.Text.Trim());
                userProfile.DepartmentID = originalUserProfile.DepartmentID;
                userProfile.UserRoleID = originalUserProfile.UserRoleID;
                userProfile.Status = "ACTIVE";

                if (userProfileTableAdapter.Update(userProfile) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Change Password.<b>" + originalUserProfile.Username + "</b>.</div>";
                    Response.Redirect("~/signin.aspx");
                }

            }


        }
    }
}