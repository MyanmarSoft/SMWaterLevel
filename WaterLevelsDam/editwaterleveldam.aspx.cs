using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.WaterLevelsDam
{
    public partial class editwaterleveldam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
            if (!IsPostBack)
            {
                DamTableAdapter damTableAdapter = new DamTableAdapter();
                DataTable dtDam = damTableAdapter.GetDataByStatus("ACTIVE");
                ddlDamName.DataValueField = "ID";
                ddlDamName.DataTextField = "DamName";
                ddlDamName.DataSource = dtDam;
                ddlDamName.DataBind();

                ddlDamName.Items.Insert(0, new ListItem("Select Dam Name"));

               WaterLevelDamTableAdapter WaterLevelDamTableAdapter = new WaterLevelDamTableAdapter();
               WaterLevelDam originalWaterLevelDam = WaterLevelDamTableAdapter.GetWaterLevelByID(Convert.ToInt32(Request["WaterLevelDamID"]));

               ddlDamName.SelectedValue = originalWaterLevelDam.DamID.ToString();
               txtWaterLevelFeet.Text = originalWaterLevelDam.LevelFeet;
               txtRemark.Text = originalWaterLevelDam.Remark;
               txtDate.Text = originalWaterLevelDam.CreatedDate.ToString("dd/MMM/yyyy");
               txtTime.Text = originalWaterLevelDam.CreatedTime;
               
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
            if (txtWaterLevelFeet.Text == string.Empty)
            {
                error += GetGlobalResourceObject("CustomerResource", "requirecustomername").ToString();
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

            WaterLevelDam WaterLevelDam = new WaterLevelDam();
            WaterLevelDamTableAdapter WaterLevelDamTableAdapter = new WaterLevelDamTableAdapter();
            WaterLevelDam originalWaterLevelDam = WaterLevelDamTableAdapter.GetWaterLevelByID(Convert.ToInt32(Request["WaterLevelDamID"]));


            if (IsValidData())
            {
                WaterLevelDam.ID = originalWaterLevelDam.ID;
                WaterLevelDam.DamID = Convert.ToInt32(ddlDamName.SelectedValue);
                WaterLevelDam.DamName = ddlDamName.SelectedItem.ToString();
                WaterLevelDam.LevelFeet = txtWaterLevelFeet.Text.Trim();
                WaterLevelDam.Remark = txtRemark.Text.Trim();
                WaterLevelDam.CreatedDate = Convert.ToDateTime(txtDate.Text);
                WaterLevelDam.CreatedTime = txtTime.Text;

                WaterLevelDam.Status = "ACTIVE";

                if (WaterLevelDamTableAdapter.Update(WaterLevelDam) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Updated <b>" + txtWaterLevelFeet.Text.Trim()+ "</b>.</div>";
                    Response.Redirect("~/WaterLevelsDam/waterlevellistdam.aspx");

                }
            }
        }
    }
}