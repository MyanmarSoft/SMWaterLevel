using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.WaterLevelsDam
{
    public partial class deletewaterleveldam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WaterLevelsDam/waterlevellistdam.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            WaterLevelDamTableAdapter WaterLevelDamTableAdapter = new WaterLevelDamTableAdapter();
            WaterLevelDam originalWaterLevelDam = WaterLevelDamTableAdapter.GetWaterLevelByID(Convert.ToInt32(Request["WaterLevelDamID"]));

            WaterLevelDam WaterLevelDam = new WaterLevelDam();

            WaterLevelDam.ID = originalWaterLevelDam.ID;
            WaterLevelDam.DamID = originalWaterLevelDam.DamID;
            WaterLevelDam.DamName = originalWaterLevelDam.DamName;
            WaterLevelDam.LevelFeet = originalWaterLevelDam.LevelFeet;
            WaterLevelDam.Remark = originalWaterLevelDam.Remark;
            WaterLevelDam.CreatedDate = originalWaterLevelDam.CreatedDate;
            WaterLevelDam.CreatedTime = originalWaterLevelDam.CreatedTime;
            WaterLevelDam.Status = "INACTIVE";
            if (WaterLevelDamTableAdapter.Update(WaterLevelDam) > 0)
            {
                ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalWaterLevelDam.DamName + "</b>.</div>";
                Response.Redirect("~/WaterLevelsDam/waterlevellistdam.aspx");

            }
        }
    }
}