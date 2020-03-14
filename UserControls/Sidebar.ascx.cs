using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.UserControls
{
    public partial class Sidebar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                if (Session["Login"] != null)
                {
                    UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
                    UserProfile userProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Session["Login"]));

                    if (userProfile.DepartmentID == 1)
                    {
                        if (userProfile.UserRoleID == 1)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/management.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }
                    }
                    else if (userProfile.DepartmentID == 2)
                    {
                        if (userProfile.UserRoleID == 2)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/admin.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }
                        if (userProfile.UserRoleID == 3)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/assistantadmin.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }
                    }
                    else if (userProfile.DepartmentID == 3)
                    {
                        if (userProfile.UserRoleID == 4)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/doctor.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }
                       
                    }
                    else if (userProfile.DepartmentID == 4)
                    {
                        if (userProfile.UserRoleID == 5)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/medtech.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }
                        else if (userProfile.UserRoleID == 6)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/labassistant.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }

                    }
                    else if (userProfile.DepartmentID == 5)
                    {
                        if (userProfile.UserRoleID == 7)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/cashier.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }
                    }
                    else if (userProfile.DepartmentID == 6)
                    {
                        if (userProfile.UserRoleID == 8)
                        {
                            using (StreamReader reader = new StreamReader(Server.MapPath("~/TextFiles/radiologist.txt")))
                            {
                                ltlSideBar.Text = reader.ReadToEnd();
                            }
                        }
                    }
                }
                if (Request["q"] != null)
                {
                    if (Session["Login"].ToString() != null)
                    {
                        Session["Login"] = null;
                        Session["Name"] = null;
                        Session["Role"] = null;
                        Session["RoleName"] = null;
                        Response.Redirect("~/signin.aspx");
                    }
                }

            }
        }
       
    }
}