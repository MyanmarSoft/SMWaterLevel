using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;


namespace SMWaterLevel.WaterLevels
{
    public partial class newwaterlevel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
            if (!Page.IsPostBack)
            {

                RiverTableAdapter riverTableAdapter = new RiverTableAdapter();
                DataTable dtRiver = riverTableAdapter.GetDataByStatus("ACTIVE");
                ddlRiverName.DataValueField = "ID";
                ddlRiverName.DataTextField = "RiverName";
                ddlRiverName.DataSource = dtRiver;
                ddlRiverName.DataBind();

                ddlRiverName.Items.Insert(0, new ListItem("Select River Name"));

                //txtTime.Text = DateTime.Now.ToShortTimeString();
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;
            if (txtWaterLevelFeet.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("WaterLevelResource", "requireWaterLevelname").ToString();
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
            WaterLevel WaterLevel = new WaterLevel();
            WaterLevelTableAdapter WaterLevelTableAdapter = new WaterLevelTableAdapter();

            if (IsValidData())
            {
                WaterLevel.RiverID = Convert.ToInt32(ddlRiverName.SelectedValue);
                WaterLevel.RiverName = ddlRiverName.SelectedItem.ToString();
                WaterLevel.LevelFeet = txtWaterLevelFeet.Text.Trim();
                WaterLevel.Remark = txtRemark.Text.Trim();
                WaterLevel.CreatedDate = Convert.ToDateTime(txtDate.Text);
                WaterLevel.CreatedTime = txtTime.Text;
                WaterLevel.Status = "ACTIVE";

                if (WaterLevelTableAdapter.Insert(WaterLevel) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Created <b>" + txtWaterLevelFeet.Text.Trim() + "</b>.</div>";
                    Response.Redirect("~/WaterLevels/waterlevellist.aspx");

                }
            }
        }
    }
}