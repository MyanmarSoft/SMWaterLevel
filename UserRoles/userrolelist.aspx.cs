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

namespace SMWaterLevel.UserRoles
{
    public partial class userrolelist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["Column"] = "ID";
            ViewState["Order"] = "ASC";

            BindRepeater();
            BindPaging();
        }
        private void BindRepeater()
        {
            UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
            DataTable dtUserRoleList = userRoleTableAdapter.GetDataByStatus("ACTIVE");

            if (dtUserRoleList.Rows.Count > 0)
            {
                DataView dvData = new DataView(dtUserRoleList);
                dvData.Sort = ViewState["Column"].ToString() + " " + ViewState["Order"].ToString();

                rptUserRoleList.DataSource = dvData;
                rptUserRoleList.DataBind();
                rptUserRoleList.Dispose();
                dvData.Dispose();
            }
        }
        protected void rptUserRoleList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == ViewState["Column"].ToString())
            {
                if (ViewState["Order"].ToString() == "ASC")
                {
                    ViewState["Order"] = "DESC";
                }
                else
                {
                    ViewState["Order"] = "ASC";
                }
            }
            else
            {
                ViewState["Column"] = e.CommandName;
                ViewState["Order"] = "ASC";

            }
            BindRepeater();
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

        protected void rptPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            BindPaging();
        }
        private void BindPaging()
        {
            UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
            DataTable dtUserRoleList = userRoleTableAdapter.GetDataByStatus("ACTIVE");

            PagedDataSource pgitems = new PagedDataSource();
            pgitems.DataSource = dtUserRoleList.DefaultView;
            pgitems.AllowPaging = true;

            pgitems.PageSize = 12;
            pgitems.CurrentPageIndex = PageNumber;
            if (pgitems.PageCount > 1)
            {
                rptPaging.Visible = true;
                ArrayList pages = new ArrayList();
                for (int i = 0; i <= pgitems.PageCount - 1; i++)
                {
                    pages.Add((i + 1).ToString());
                }
                rptPaging.DataSource = pages;
                rptPaging.DataBind();
            }
            else
            {
                rptPaging.Visible = false;
            }
            rptUserRoleList.DataSource = pgitems;
            rptUserRoleList.DataBind();
        }

        protected void btnNewUserRole_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserRoles/newuserrole.aspx");
        }
    }
}