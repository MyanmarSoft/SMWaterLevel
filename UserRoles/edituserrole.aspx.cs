using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.UserRoles
{
    public partial class edituserrole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
            if (!IsPostBack)
            {
                UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
                UserRole originalUserRole = userRoleTableAdapter.GetUserRoleByID(Convert.ToInt32(Request["UserRoleID"]));

                txtUserRoleName.Text = originalUserRole.RoleName;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserRoles/userrolelist.aspx");
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;
            if (txtUserRoleName.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserRoleResource", "requireuserrolename").ToString();
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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            UserRole userRole = new UserRole();
            UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
            UserRole originalUserRole = userRoleTableAdapter.GetUserRoleByID(Convert.ToInt32(Request["UserRoleID"]));

            if (originalUserRole.ID != 1)
            {
                if (IsValidData())
                {
                    userRole.ID = originalUserRole.ID;
                    userRole.RoleName = txtUserRoleName.Text.Trim();
                    userRole.Status = "ACTIVE";
                    if (userRoleTableAdapter.Update(userRole) > 0)
                    {
                        ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Updated <b>" + txtUserRoleName.Text.Trim() + "</b>.</div>";
                        Response.Redirect("~/UserRoles/userrolelist.aspx");

                    }
                }
            }
            else
            {
                ShowErrorMessage(GetGlobalResourceObject("UserRoleResource", "systemdefaultuserrole").ToString());
            }
        }
    }
}