using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.Text;

namespace SMWaterLevel
{
    public partial class lockscreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
            if (!Page.IsPostBack)
            {
                if (Session["Login"] != null)
                {
                    ltlName.Text = Session["Name"].ToString();
                }
                else
                {
                    Session["Login"] = null;
                    Session["Name"] = null;
                    Session["Role"] = null;
                    Session["RoleName"] = null;
                    Response.Redirect("~/signin.aspx");
                }
            }
        }

        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        protected void btnSigninDifferentUser_Click(object sender, EventArgs e)
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

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void SignIn()
        {

            if (Session["Login"] != null)
            {
                Session["Login"] = null;
                Session["Role"] = null;
                Session["RoleName"] = null;

                UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
                UserProfile userProfile = userProfileTableAdapter.GetUserProfileByName(ltlName.Text, "ACTIVE");

                UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
                UserRole userRole = userRoleTableAdapter.GetUserRoleByID(userProfile.ID);

                if (userProfile.Password == txtPassword.Text.Trim())
                {
                    Session["Login"] = userProfile.ID;
                    Session["Name"] = userProfile.Name;
                    Session["Role"] = userProfile.UserRoleID;
                    Session["RoleName"] = userRole.RoleName;

                    Response.Redirect("~/default.aspx");
                }
                else
                {
                    ltlMessage.Text = "<div class=\"alert alert-danger alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-ban\"></i> Alert!</h4> Username and Password didn't match.</div>";
                }
            }
            else
            {
                Session["Login"] = null;
                Session["Name"] = null;
                Session["Role"] = null;
                Session["RoleName"] = null;
                Response.Redirect("~/signin.aspx");
            }
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            SignIn();
        }
    }
}