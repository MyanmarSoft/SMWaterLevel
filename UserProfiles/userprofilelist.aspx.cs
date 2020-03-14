using System;
using Whizzo;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.Collections;
using SMWaterLevel.UserControls;
namespace SMWaterLevel.UserProfiles
{
    public partial class userprofilelist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                ViewState["Column"] = "ID";
                ViewState["Order"] = "ASC";

                //BindRepeater();
                //BindPaging();
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
                    UserProfileTableAdapter newsTableAdapter = new UserProfileTableAdapter();
                    DataSet ds = newsTableAdapter.GetUserProfileByStatus("ACTIVE");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Session["dt"] = ds.Tables[0];
                        PagingDataBind();
                    }

                }
        }
        private void BindRepeater()
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile userProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Session["Login"]));

            if (userProfile.UserRoleID == 1)
            {
                DataTable dtUserProfileList = userProfileTableAdapter.GetDataByStatus("ACTIVE");

                if (dtUserProfileList.Rows.Count > 0)
                {
                    DataView dvData = new DataView(dtUserProfileList);
                    dvData.Sort = ViewState["Column"].ToString() + " " + ViewState["Order"].ToString();

                    rptUserProfileList.DataSource = dvData;
                    rptUserProfileList.DataBind();
                    rptUserProfileList.Dispose();
                    dvData.Dispose();
                }
            }
            else
            {
                DataTable dtUserProfileList = userProfileTableAdapter.GetDataByDepartmentIDAndStatus(userProfile.DepartmentID, "ACTIVE");

                if (dtUserProfileList.Rows.Count > 0)
                {
                    DataView dvData = new DataView(dtUserProfileList);
                    dvData.Sort = ViewState["Column"].ToString() + " " + ViewState["Order"].ToString();

                    rptUserProfileList.DataSource = dvData;
                    rptUserProfileList.DataBind();
                    rptUserProfileList.Dispose();
                    dvData.Dispose();
                }
            }
        }
        private void BindRepeaterByName()
        {
            UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
            UserProfile userProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Session["Login"]));

            if (userProfile.UserRoleID == 1)
            {
                DataTable dtUserProfileList = userProfileTableAdapter.GetDataByStatus("ACTIVE");

                if (dtUserProfileList.Rows.Count > 0)
                {
                    DataView dvData = new DataView(dtUserProfileList);
                    dvData.Sort = ViewState["Column"].ToString() + " " + ViewState["Order"].ToString();

                    rptUserProfileList.DataSource = dvData;
                    rptUserProfileList.DataBind();
                    rptUserProfileList.Dispose();
                    dvData.Dispose();
                }
            }
            else
            {
                DataTable dtUserProfileList = userProfileTableAdapter.GetDataByDepartmentIDAndStatus(userProfile.DepartmentID, "ACTIVE");

                if (dtUserProfileList.Rows.Count > 0)
                {
                    DataView dvData = new DataView(dtUserProfileList);
                    dvData.Sort = ViewState["Column"].ToString() + " " + ViewState["Order"].ToString();

                    rptUserProfileList.DataSource = dvData;
                    rptUserProfileList.DataBind();
                    rptUserProfileList.Dispose();
                    dvData.Dispose();
                }
            }
        }
        protected void rptUserProfileList_ItemCommand(object source, RepeaterCommandEventArgs e)
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
        

        protected void btnNewUserProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserProfiles/newuserprofile.aspx");
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
        public void Pager1_Change(object sender, PagerEventArgs e)
        {
            PagingDataBind();
        }
        void PagingDataBind()
        {
            DataTable itemdt = new DataTable();
            if (Null.IsNotNull(Session["dt"]))
            {
                itemdt = (DataTable)Session["dt"];
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
    }
}