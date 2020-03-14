using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SMWaterLevel.UserControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.Web.UI.DataVisualization.Charting;

namespace SMWaterLevel
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["q"] != null)
                {
                    if (Session["Login"].ToString() != null)
                    {
                        Session["Login"] = null;
                        Session["Name"] = null;

                        Response.Redirect(ConfigurationManager.AppSettings.GetValues("mainURL") + "signin.aspx");
                    }
                }

                UserProfileTableAdapter userProfileTableAdapter = new UserProfileTableAdapter();
                UserProfile userProfile = userProfileTableAdapter.GetUserProfileByID(Convert.ToInt32(Session["Login"]));
                DataTable dtUserProfile = userProfileTableAdapter.GetDataByStatus("ACTIVE");


              

               



                if(userProfile.DepartmentID == 1)
                {
                    if(userProfile.UserRoleID == 1 )
                    {
                        ltlCustomer.Visible = true;
                        ltlDepartmentView.Visible = true;
                        ltlInvoiceReportView.Visible = true;
                        ltlUserProfileView.Visible = true;
                        ltlUserRoleView.Visible = true;
                        ltlRiver.Visible = true;
                        ltlRiverView.Visible = true;
                        

                        //chartWaterLevel.Visible = true;

                        //string[] x = new string[dtWaterLevel.Rows.Count];
                        //int[] y = new int[dtWaterLevel.Rows.Count];
                        //for (int i = 0; i < dtWaterLevel.Rows.Count; i++)
                        //{
                        //    x[i] = dtWaterLevel.Rows[i][2].ToString();
                        //    y[i] = Convert.ToInt32(dtWaterLevel.Rows[i][0]);
                        //}
                        //chartWaterLevel.Series[0].Points.DataBindXY(x, y);
                        //chartWaterLevel.Series[0].ChartType = SeriesChartType.Column;
                        //chartWaterLevel.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
                        //chartWaterLevel.Legends[0].Enabled = true;

                       
                    }

                }
                else if (userProfile.DepartmentID == 2)
                {
                    if (userProfile.UserRoleID == 2)
                    {
                        ltlCustomerView.Visible = true;
                        ltlDepartmentView.Visible = true;
                       
                        ltlUserProfileView.Visible = true;
                        ltlUserRoleView.Visible = true;
                       



                    }
                    else if (userProfile.UserRoleID == 3)
                    {
                        ltlCustomerView.Visible = true;
                        ltlDepartmentView.Visible = false;
                       
                        ltlInvoiceReportView.Visible = true;
                      
                        ltlUserProfileView.Visible = false;
                        ltlUserRoleView.Visible = false;
                      
                    }

                }
                else if (userProfile.DepartmentID == 3)
                {
                    if (userProfile.UserRoleID == 4 )
                    {
                        ltlCustomerView.Visible = false;
                        ltlDepartmentView.Visible = false;
                     
                        ltlUserProfileView.Visible = false;
                        ltlUserRoleView.Visible = false;
                     
                    }

                }
                else if (userProfile.DepartmentID == 4)
                {
                    if (userProfile.UserRoleID == 5  || userProfile.UserRoleID == 6)
                    {
                        ltlCustomerView.Visible = false;
                        ltlDepartmentView.Visible = false;
                       
                        ltlInvoiceReportView.Visible = false;
                       
                        ltlUserProfileView.Visible = false;
                        ltlUserRoleView.Visible = false;
                   
                    }

                }
                else if (userProfile.DepartmentID == 5)
                {
                    if (userProfile.UserRoleID == 7)
                    {
                        ltlCustomerView.Visible = true;
                        ltlDepartmentView.Visible = false;
                        
                        ltlInvoiceReportView.Visible = false;
                   
                        ltlUserProfileView.Visible = false;
                        ltlUserRoleView.Visible = false;
                    
                    }

                }
                else if (userProfile.DepartmentID == 6)
                {
                    if (userProfile.UserRoleID == 8)
                    {
                        ltlCustomerView.Visible = false;
                        ltlDepartmentView.Visible = false;
                     
                        ltlInvoiceReportView.Visible = false;
                  
                        ltlUserProfileView.Visible = false;
                        ltlUserRoleView.Visible = false;
                     
                    }

                }

                DataTable dtUserProfileList = userProfileTableAdapter.GetDataByStatus("ACTIVE");
                ltlUser.Text = dtUserProfileList.Rows.Count.ToString();

                CustomerTableAdapter customeTableAdapter = new CustomerTableAdapter();
                DataTable dtCustomerList = customeTableAdapter.GetDataByStatus("ACTIVE");
                ltlCustomer.Text = dtCustomerList.Rows.Count.ToString();

                ProjectTableAdapter projectTableAdapter = new ProjectTableAdapter();
                DataTable dtProjectList = projectTableAdapter.GetDataByStatus("ACTIVE");

                DepartmentTableAdapter departmentTableAdapter = new DepartmentTableAdapter();
                DataTable dtDepartmentList = departmentTableAdapter.GetDataByStatus("ACTIVE");
                ltlDepartment.Text = dtDepartmentList.Rows.Count.ToString();

                UserRoleTableAdapter userRoleTableAdapter = new UserRoleTableAdapter();
                DataTable dtUserRole = userRoleTableAdapter.GetDataByStatus("ACTIVE");
                ltlUserRole.Text = dtUserRole.Rows.Count.ToString();

                WaterLevelTableAdapter waterLevelTabeleAdapter = new WaterLevelTableAdapter();
                DataTable dtWaterLevel = waterLevelTabeleAdapter.GetDataByStatus("ACTIVE");
                ltlWaterLevel.Text = dtWaterLevel.Rows.Count.ToString();
               
                RiverTableAdapter riverTableAdapter = new RiverTableAdapter();
                DataTable dtRiver = riverTableAdapter.GetDataByStatus("ACTIVE");
                ltlRiver.Text = dtRiver.Rows.Count.ToString();

                DamTableAdapter damTableAdapter = new DamTableAdapter();
                DataTable dtDam = damTableAdapter.GetDataByStatus("ACTIVE");
                ltlDam.Text = dtDam.Rows.Count.ToString();

                WaterLevelDamTableAdapter waterLevelDamTabeleAdapter = new WaterLevelDamTableAdapter();
                DataTable dtWaterLevelDam = waterLevelDamTabeleAdapter.GetDataByStatus("ACTIVE");
                ltlWaterLevelDam.Text = dtWaterLevelDam.Rows.Count.ToString();

                

            }

        }
    }
}