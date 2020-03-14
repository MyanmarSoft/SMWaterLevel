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


namespace SMWaterLevel.Dams
{
    public partial class damlist : System.Web.UI.Page
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
                DamTableAdapter damTableAdapter = new DamTableAdapter();
                DataSet ds = damTableAdapter.GetDamByStatus("ACTIVE");
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


        protected void btnNewDam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Dams/newdam.aspx");
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DamTableAdapter DamTableAdapter = new DamTableAdapter();
            DataSet ds = DamTableAdapter.GetSearchByDam(txtSearch.Text, "ACTIVE");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["dt"] = ds.Tables[0];
                PagingDataBind((DataTable)Session["dt"]);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DamTableAdapter DamTableAdapter = new DamTableAdapter();
            DataSet ds = DamTableAdapter.GetSearchByDam(txtSearch.Text, "ACTIVE");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["dt"] = ds.Tables[0];
                PagingDataBind((DataTable)Session["dt"]);
            }
        }
    }
}