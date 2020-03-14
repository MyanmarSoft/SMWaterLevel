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
    public partial class deleteuserrole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserRoles/userrolelist.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
            UserRole originalUserRole = userRoleTableAdapter.GetUserRoleByID(Convert.ToInt32(Request["UserRoleID"]));

            UserRole userRole = new UserRole();

            if (originalUserRole.ID != 1)
            {
                userRole.ID = originalUserRole.ID;
                userRole.RoleName = originalUserRole.RoleName;
                userRole.Status = "INACTIVE";
                if (userRoleTableAdapter.Update(userRole) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalUserRole.RoleName + "</b>.</div>";
                    Response.Redirect("~/UserRoles/userrolelist.aspx");
                }
                else
                {
                    ShowErrorMessage(GetGlobalResourceObject("UserRoleResource", "systemdefaultuserrole").ToString());
                }
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