using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;


namespace SMWaterLevel.Members
{
    public partial class newmember : System.Web.UI.Page
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
            if (txtMemberName.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("MemberResource", "requireMembername").ToString();
                validData = false;
            }
            if (txtPhone.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("MemberResource", "requirephone").ToString();
                validData = false;
            }
            if (txtAddress.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("MemberResource", "requireaddress").ToString();
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
            Member Member = new Member();
            MemberTableAdapter MemberTableAdapter = new MemberTableAdapter();

            if (IsValidData())
            {
                Member.MemberName = txtMemberName.Text.Trim();
                Member.PhoneNo = txtPhone.Text.Trim();
                Member.Address = txtAddress.Text.Trim();
                Member.Remark = txtremark.Text;

                Member.Status = "ACTIVE";

                if (MemberTableAdapter.Insert(Member) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Created <b>" + txtMemberName.Text.Trim() + "</b>.</div>";
                    Response.Redirect("~/Members/Memberlist.aspx");

                }
            }
        }
       

    }
}