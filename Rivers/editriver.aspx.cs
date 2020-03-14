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
    public partial class editriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
            if (!IsPostBack)
            {
                RiverTableAdapter RiverTableAdapter = new RiverTableAdapter();
                River originalRiver = RiverTableAdapter.GetRiverByID(Convert.ToInt32(Request["RiverID"]));

                txtRiverName.Text = originalRiver.RiverName;
                txtLatitude.Text = originalRiver.Latitude;
                txtLongitude.Text = originalRiver.Longitude;
                txtDescription.Text = originalRiver.Description;
                ltlViewMap.Text = "<iframe width=\"100%\" height=\"500\" src=\"https://maps.google.com/maps?width=100%&amp;height=500&amp;hl=en&amp;coord=" + txtLatitude.Text + "," + txtLongitude.Text + "&amp;q=" + txtRiverName.Text + "+(" + txtDescription.Text + ")&amp;ie=UTF8&amp;t=&amp;z=14&amp;iwloc=B&amp;output=embed\" frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\"></iframe>";
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Rivers/riverlist.aspx");
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;
            if (txtRiverName.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("RiverResource", "requireRivername").ToString();
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
            RiverTableAdapter RiverTableAdapter = new RiverTableAdapter();
            River originalRiver = RiverTableAdapter.GetRiverByID(Convert.ToInt32(Request["RiverID"]));

            River River = new River();

            if (IsValidData())
            {
                River.ID = originalRiver.ID;
                River.RiverName = txtRiverName.Text.Trim();
                River.RiverID = Guid.NewGuid().ToString();
                River.Latitude = txtLatitude.Text.Trim();
                River.Longitude = txtLongitude.Text.Trim();
                River.Description = txtDescription.Text.Trim();
                River.Status = "ACTIVE";


                if (RiverTableAdapter.Update(River) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Updated <b>" + txtRiverName.Text.Trim() + "</b>.</div>";
                    Response.Redirect("~/Rivers/riverlist.aspx");

                }
            }
        }
        protected void btnViewMap_Click(object sender, EventArgs e)
        {
            ltlViewMap.Text = "<iframe width=\"100%\" height=\"500\" src=\"https://maps.google.com/maps?width=100%&amp;height=500&amp;hl=en&amp;coord=" + txtLatitude.Text + "," + txtLongitude.Text + "&amp;q=" + txtRiverName.Text + "+(" + txtDescription.Text + ")&amp;ie=UTF8&amp;t=&amp;z=14&amp;iwloc=B&amp;output=embed\" frameborder=\"0\" scrolling=\"no\" marginheight=\"0\" marginwidth=\"0\"></iframe>";
        }
    }
}