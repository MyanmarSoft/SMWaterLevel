using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMWaterLevel.Entities;
using SMWaterLevel.DataAccess;

namespace SMWaterLevel.Customers
{
    public partial class deletecustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();
            Customer originalCustomer = customerTableAdapter.GetCustomerByID(Convert.ToInt32(Request["CustomerID"]));

            Customer customer = new Customer();

            customer.ID = originalCustomer.ID;
            customer.CustomerName = originalCustomer.CustomerName;
            customer.Phone = originalCustomer.Phone;
            customer.Address = originalCustomer.Address;
            customer.ImagePath = originalCustomer.ImagePath;
            customer.Status = "INACTIVE";
            if (customerTableAdapter.Update(customer) > 0)
            {
                ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Deleted <b>" + originalCustomer.CustomerName + "</b>.</div>";
                Response.Redirect("~/Customers/customerlist.aspx");

            }
        }
    }
}