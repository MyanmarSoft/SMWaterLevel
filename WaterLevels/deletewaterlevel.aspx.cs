using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.WaterLevels
{
    public partial class deletewaterlevel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WaterLevels/waterlevellist.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            WaterLevelTableAdapter WaterLevelTableAdapter = new WaterLevelTableAdapter();
            WaterLevel originalWaterLevel = WaterLevelTableAdapter.GetWaterLevelByID(Convert.ToInt32(Request["WaterLevelID"]));

            WaterLevel WaterLevel = new WaterLevel();

            WaterLevel.ID = originalWaterLevel.ID;
            WaterLevel.RiverID = originalWaterLevel.RiverID;
            WaterLevel.RiverName = originalWaterLevel.RiverName;
            WaterLevel.LevelFeet = originalWaterLevel.LevelFeet;
            WaterLevel.Remark = originalWaterLevel.Remark;
            WaterLevel.CreatedDate = originalWaterLevel.CreatedDate;
            WaterLevel.CreatedTime = originalWaterLevel.CreatedTime;
            WaterLevel.Status = "INACTIVE";
            if (WaterLevelTableAdapter.Update(WaterLevel) > 0)
            {
                ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalWaterLevel.RiverName + "</b>.</div>";
                Response.Redirect("~/WaterLevels/waterlevellist.aspx");

            }
        }
    }
}