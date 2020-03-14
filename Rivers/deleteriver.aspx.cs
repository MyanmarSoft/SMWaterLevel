using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.Rivers
{
    public partial class deleteriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Rivers/riverlist.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            RiverTableAdapter RiverTableAdapter = new RiverTableAdapter();
            River originalRiver = RiverTableAdapter.GetRiverByID(Convert.ToInt32(Request["RiverID"]));

            River River = new River();

            River.ID = originalRiver.ID;
            River.RiverName = originalRiver.RiverName;
            River.RiverID = originalRiver.RiverID;
            River.Latitude = originalRiver.Latitude;
            River.Longitude = originalRiver.Longitude;
            River.Description = originalRiver.Description;
            River.Status = "INACTIVE";
            if (RiverTableAdapter.Update(River) > 0)
            {
                ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalRiver.RiverName + "</b>.</div>";
                Response.Redirect("~/Rivers/Riverlist.aspx");

            }
        }
    }
}