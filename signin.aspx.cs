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
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;

            if (!IsPostBack)
            {
                if (Request.Cookies["Email"] != null && Request.Cookies["Password"] != null)
                {
                    txtEmail.Text = Request.Cookies["Email"].Value;
                    txtPassword.Attributes["value"] = Request.Cookies["Password"].Value;
                }
                if ((Session["Login"])!=null || Session["Name"]!=null)
                {
                    Response.Redirect("~/default.aspx");
                }

            }
        }
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
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
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requirepassword").ToString();
                validData = false;
            }
            else if (!validData)
            {
                ShowErrorMessage(error);
            }
            return validData;
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            SignIn();
        }
        private void SignIn()
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile userProfile = userProfileTableAdapter.GetUserProfileByUsername(txtEmail.Text.Trim(), "ACTIVE");

            UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
            UserRole userRole = userRoleTableAdapter.GetUserRoleByID(userProfile.ID);

            if (IsValidData())
            {
                if (userProfile.Username == txtEmail.Text.Trim())
                {
                    if (userProfile.Password == txtPassword.Text.Trim())
                    {
                        if (chbRememberMe.Checked)
                        {
                            Session["Login"] = userProfile.ID;
                            Session["Name"] = userProfile.Name;
                            Session["Role"] = userProfile.UserRoleID;
                            Session["RoleName"] = userRole.RoleName;

                            Response.Cookies["Username"].Value = txtEmail.Text.Trim();
                            Response.Cookies["Password"].Value = txtPassword.Text.Trim();
                            Response.Cookies["Username"].Expires = DateTime.Now.AddDays(1);
                            Response.Cookies["Password"].Expires = DateTime.Now.AddDays(1);
                            Response.Redirect("~/default.aspx");
                        }
                        else
                        {
                            Session["Login"] = userProfile.ID;
                            Session["Name"] = userProfile.Name;
                            Session["Role"] = userProfile.UserRoleID;
                            Session["RoleName"] = userRole.RoleName;

                            Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
                            Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);

                            if(userProfile.DepartmentID == 5 && userProfile.UserRoleID == 7)
                            {
                                Response.Redirect("~/Invoices/newinvoice.aspx");
                            }
                            else
                            {
                                Response.Redirect("~/default.aspx");
                            }
                        }
                    }
                    else
                    {
                        ShowErrorMessage(GetGlobalResourceObject("UserResource", "wrongpassword").ToString());
                    }
                }
                else
                {
                    ShowErrorMessage(GetGlobalResourceObject("UserResource", "wrongusername").ToString());
                }

            }
        }
        
        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            SignIn();
        }

    }
}