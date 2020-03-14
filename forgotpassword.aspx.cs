using System;
using System.Text;
using System.Configuration;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.Web.Script.Serialization;
using System.Diagnostics;


namespace SMWaterLevel
{
    public partial class forgotpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
        }
        public void ShowErrorMessage(string error)
        {
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageOpenTag").ToString();
            ltlMessage.Text += error;
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageCloseTag").ToString();
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;
            if (txtEmail.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requireusername").ToString();
                validData = false;
            }
            if (!validData)
            {
                ShowErrorMessage(error);
            }
            return validData;
        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
                UserProfile userProfile = userProfileTableAdapter.GetUserProfileByUsername(txtEmail.Text.Trim(), "ACTIVE");

                UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
                UserRole userRole = userRoleTableAdapter.GetUserRoleByID(userProfile.ID);


                if (userProfile.UserRoleID == 1)
                {
                    Session["Login"] = userProfile.ID;
                    Session["Name"] = userProfile.Name;
                    Session["Role"] = userProfile.UserRoleID;
                    Session["RoleName"] = userRole.RoleName;

                    Response.Redirect("~/passwordresetcode.aspx");
                }
                else
                {
                    ShowErrorMessage(GetGlobalResourceObject("UserResource", "pleasecontactadmin").ToString());
                }
            }

        }
    }
}