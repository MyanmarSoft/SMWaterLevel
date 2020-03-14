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
    public partial class newcustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlMessage.Text = null;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        public bool IsValidData()
        {
            string error = "";
            bool validData = true;
            if (txtCustomerName.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("CustomerResource", "requirecustomername").ToString();
                validData = false;
            }
            if (txtPhone.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("CustomerResource", "requirephone").ToString();
                validData = false;
            }
            if (txtAddress.Text.Trim() == string.Empty)
            {
                error += GetGlobalResourceObject("CustomerResource", "requireaddress").ToString();
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
            Customer customer = new Customer();
            CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();

            if (IsValidData())
            {
                customer.CustomerName = txtCustomerName.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                customer.Address = txtAddress.Text.Trim();
                customer.ImagePath = ltlImagePath.Text;

                customer.Status = "ACTIVE";

                if (customerTableAdapter.Insert(customer) > 0)
                {
                    ltlMessage.Text = "<div class=\"alert alert-success alert-dismissible\"><button type = \"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h4><i class=\"icon fa fa-check\"></i> Alert!</h4> Sucessfully Created <b>" + txtCustomerName.Text.Trim() + "</b>.</div>";
                    Response.Redirect("~/Customers/customerlist.aspx");

                }
            }
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUploadCustomerImage.HasFile)
            {
                string str = FileUploadCustomerImage.FileName;
                FileUploadCustomerImage.PostedFile.SaveAs(Server.MapPath("~/Upload/" + str));
                string Image = "~/Upload/" + str.ToString();

                imgCustomer.ImageUrl = Image;
                ltlImagePath.Text = str;
            }

            else
            {
                ltlMessage.Text = "Please Upload your Image";
            }
        }

    }
}