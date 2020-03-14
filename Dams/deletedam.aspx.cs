using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.Dams
{
    public partial class deletedam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Dams/damlist.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            DamTableAdapter DamTableAdapter = new DamTableAdapter();
            Dam originalDam = DamTableAdapter.GetDamByID(Convert.ToInt32(Request["DamID"]));

            Dam Dam = new Dam();

            Dam.ID = originalDam.ID;
            Dam.DamName = originalDam.DamName;
            Dam.DamID = originalDam.DamID;
            Dam.Latitude = originalDam.Latitude;
            Dam.Longitude = originalDam.Longitude;
            Dam.Description = originalDam.Description;
            Dam.Status = "INACTIVE";
            if (DamTableAdapter.Update(Dam) > 0)
            {
                ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalDam.DamName + "</b>.</div>";
                Response.Redirect("~/Dams/damlist.aspx");

            }
        }
    }
}