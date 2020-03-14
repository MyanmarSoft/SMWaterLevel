using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.Collections;
using Whizzo;
using SMWaterLevel.UserControls;


namespace SMWaterLevel.WaterLevelsDam
{
    public partial class waterlevellistdam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Null.IsNotNull(Request["q"]))
            {
                if (Null.IsNotNull(Session["Login"].ToString()))
                {
                    Session["Login"] = null;
                    Session["Name"] = null;
                    Response.Redirect("~/signin.aspx");
                }
            }
            if (Null.IsNotNull(Session["Login"]) || Null.IsNotNull(Session["Name"]))
            {
                WaterLevelDamTableAdapter WaterLevelDamTableAdapter = new WaterLevelDamTableAdapter();
                DataSet ds = WaterLevelDamTableAdapter.GetWaterLevelByStatus("ACTIVE");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["dt"] = ds.Tables[0];
                    PagingDataBind((DataTable)Session["dt"]);
                }

            }
        }
        public void Pager1_Change(object sender, PagerEventArgs e)
        {
            PagingDataBind((DataTable)Session["dt"]);
            txtSearch.Text = "";
        }
        void PagingDataBind(DataTable dt)
        {
            DataTable itemdt = new DataTable();
            if (Null.IsNotNull(dt))
            {
                itemdt = dt;
                if (Null.IsNotNull(itemdt) && itemdt.Rows.Count > 0)
                {
                    Pager1.DataSource = itemdt;
                    Pager1.DataBind();

                    if (itemdt.Rows.Count > Pager1.PageSize)
                    {
                        Pager1.Visible = true;
                    }
                    else
                    {
                        Pager1.Visible = false;
                    }
                }
                else
                {
                    Pager1.Visible = false;
                }
            }

        }
        
       
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                {
                    return Convert.ToInt32(ViewState["PageNumber"]);
                }
                else
                {
                    return 0;
                }
            }
            set { ViewState["PageNumber"] = value; }
        }


        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WaterLevelsDam/newwaterLeveldam.aspx");
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            WaterLevelDamTableAdapter WaterLevelDamTableAdapter = new WaterLevelDamTableAdapter();
            DataSet ds = WaterLevelDamTableAdapter.GetSearchByWaterLevel(txtSearch.Text.Trim(), txtSearch.Text.Trim(), txtSearch.Text.Trim(), Convert.ToDateTime(txtSearch.Text.Trim()), txtSearch.Text.Trim(), "ACTIVE");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["dt"] = ds.Tables[0];
                PagingDataBind((DataTable)Session["dt"]);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            WaterLevelDamTableAdapter WaterLevelDamTableAdapter = new WaterLevelDamTableAdapter();
            DataSet ds = WaterLevelDamTableAdapter.GetSearchByWaterLevel(txtSearch.Text.Trim(), txtSearch.Text.Trim(),txtSearch.Text.Trim(),Convert.ToDateTime(txtSearch.Text.Trim()) ,txtSearch.Text, "ACTIVE");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["dt"] = ds.Tables[0];
                PagingDataBind((DataTable)Session["dt"]);
            }
        }
    }
}