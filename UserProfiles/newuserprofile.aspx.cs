using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;


namespace SMWaterLevel.UserProfiles
{
    public partial class newuserprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;

            if (!Page.IsPostBack)
            {

                DepartmentTableAdapter departmentTableAdapter = new DepartmentTableAdapter();
                DataTable dtDepartment = departmentTableAdapter.GetDataByStatus("ACTIVE");
                ddlDepartment.DataValueField = "ID";
                ddlDepartment.DataTextField = "DepartmentName";
                ddlDepartment.DataSource = dtDepartment;
                ddlDepartment.DataBind();

                ddlDepartment.Items.Insert(0, new ListItem("Select Department"));

                UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
                DataTable dtUserRoleName = userRoleTableAdapter.GetDataByStatus("ACTIVE");
                ddlUserRole.DataValueField = "ID";
                ddlUserRole.DataTextField = "RoleName";
                ddlUserRole.DataSource = dtUserRoleName;
                ddlUserRole.DataBind();

                ddlUserRole.Items.Insert(0, new ListItem("Select User Role"));

               
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfiles/userprofilelist.aspx");
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;
            if (txtName.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requirename").ToString();
                validData = false;
            }
            else if (txtUsername.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requireusername").ToString();
                validData = false;
            }
            else if (txtNewPassword.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("UserResource", "requirenewpassword").ToString();
                validData = false;
            }
            else if (txtNewPassword.Text.Trim() != txtConfirmNewPassword.Text.Trim())
            {
                error += GetGlobalResourceObject("UserResource", "notsamepassword").ToString();
                validData = false;
            }
            else if (txtUsername.Text.Trim() == string.Empty)
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
        public void ShowErrorMessage(string error)
        {
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageOpenTag").ToString();
            ltlMessage.Text += error;
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageCloseTag").ToString();
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile userProfile = new UserProfile();

            if (IsValidData())
            {
                userProfile.Name = txtName.Text.Trim();
                userProfile.Username = txtUsername.Text.Trim();
                userProfile.Password = txtNewPassword.Text.Trim();
                userProfile.DepartmentID = Convert.ToInt32(ddlDepartment.SelectedValue);
                userProfile.UserRoleID = Convert.ToInt32(ddlUserRole.SelectedValue);
                userProfile.Status = "ACTIVE";
                if (userProfileTableAdapter.Insert(userProfile) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Created <b>" + txtName.Text.Trim() + "</b>.</div>";
                    Response.Redirect("~/UserProfiles/userprofilelist.aspx");
                }
            }
        }
    }
}