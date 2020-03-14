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
    public partial class deletemember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            MemberTableAdapter MemberTableAdapter = new MemberTableAdapter();
            Member originalMember = MemberTableAdapter.GetMemberByID(Convert.ToInt32(Request["MemberID"]));

            Member Member = new Member();

            Member.ID = originalMember.ID;
            Member.MemberName = originalMember.MemberName;
            Member.PhoneNo = originalMember.PhoneNo;
            Member.Address = originalMember.Address;
            Member.Remark = originalMember.Remark;

            Member.Status = "INACTIVE";
            if (MemberTableAdapter.Update(Member) > 0)
            {
                ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalMember.MemberName + "</b>.</div>";
                Response.Redirect("~/Members/Memberlist.aspx");

            }
        }
    }
}