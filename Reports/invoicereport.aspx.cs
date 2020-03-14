using System;
using Whizzo;
using System.Configuration;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;
using System.IO;
using System.Data.SqlClient;
using SMWaterLevel.UserControls;
using Microsoft.Reporting.WebForms;

namespace SMWaterLevel.Reports
{
    public partial class invoicereport : System.Web.UI.Page
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
            ltlMessage.Text = null;
            if (!Page.IsPostBack)
            {
                
                ddlPaymentMode.Items.Insert(0, new ListItem("All"));

                CompanyTableAdapter companyTableAdapter = new CompanyTableAdapter();
                DataTable dtCompany = companyTableAdapter.GetDataByStatus("ACTIVE");
                ddlCompany.DataValueField = "ID";
                ddlCompany.DataTextField = "CompanyName";
                ddlCompany.DataSource = dtCompany;
                ddlCompany.DataBind();

                ddlCompany.Items.Insert(0, new ListItem("All"));


                ddlDoctor.Items.Insert(0, new ListItem("All"));

            }

            txtFromDate.Text = DateTime.Now.AddDays(-1).ToString("dd/MMM/yyyy");
            txtToDate.Text  = DateTime.Now.ToString("dd/MMM/yyyy");


        }

     

        protected void btnNewInvoice_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Invoices/newinvoice.aspx");
        }

        
        public void ClearData()
        {
            txtFromDate.Text = "";
            txtToDate.Text = "";
            ddlPaymentMode.Text = "All";
            ddlCompany.Text = "All";
            
            
        }
        
        public void ShowErrorMessage(string error)
        {
            ltlMessage.Text = "";
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageOpenTag").ToString();
            ltlMessage.Text += error;
            ltlMessage.Text += GetGlobalResourceObject("GlobalResources", "ErrorMessageCloseTag").ToString();
        }

    
        protected void btnSearchInvoice_Click(object sender, EventArgs e)
        {

        }
      

      
        

    }
}