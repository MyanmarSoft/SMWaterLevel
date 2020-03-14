using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class CustomerTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public CustomerTableAdapter():base()
            {
                InitInsertCommand();
                InitUpdateCommand();
                InitDeleteCommand();
                InitCommandCollection();
            }

		#endregion

		

		#region Initializations

		protected  void InitInsertCommand()
		{
			InsertCommand.CommandType = CommandType.Text;
            InsertCommand.Connection = Connection;
			InsertCommand.CommandText = @"INSERT INTO Customer(CustomerName,Phone,Address,ImagePath,Status) VALUES (@CustomerName,@Phone,@Address,@ImagePath,@Status);SELECT ID FROM Customer WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50,"CustomerName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 50,"Phone"));
			InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200,"Address"));
			InsertCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE Customer SET CustomerName = @CustomerName, Phone = @Phone, Address = @Address, ImagePath = @ImagePath, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50,"CustomerName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 50,"Phone"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200,"Address"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM Customer WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[5];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,CustomerName,Phone,Address,ImagePath,Status FROM Customer";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,CustomerName,Phone,Address,ImagePath,Status FROM Customer WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,CustomerName,Phone,Address,ImagePath,Status FROM Customer WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			//GetCustomerByCustomerName
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,CustomerName,Phone,Address,ImagePath,Status FROM Customer WHERE CustomerName = @CustomerName AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50, "CustomerName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));

            //GetSearchByCustomer
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,CustomerName,Phone,Address,ImagePath,Status FROM Customer WHERE CustomerName LIKE '%' + @CustomerName + '%' AND Status =  @Status OR Phone LIKE '%' + @Phone + '%' AND Status = @Status OR Address LIKE '%' + @Address + '%' AND Status = @Status";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50, "CustomerName"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, "Address"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));


			
			#endregion CustomCommand
			
		}

		#endregion

		#region Data Functions

		
		public int Fill(DataTable dt)
		{
           
            int returnValue =-1;
			Adapter.SelectCommand = ((SqlCommand) (this.CommandCollection[0]));
            
			try
            {
                Adapter.SelectCommand.Connection.Open();
			    returnValue = Adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
               // Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
			return returnValue;
		}

		public DataTable GetData()
		{
           
			Adapter.SelectCommand = ((SqlCommand) (CommandCollection[0]));
			DataTable dt = new DataTable();
            
            try
            {
                Adapter.SelectCommand.Connection.Open();
			    Adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                //Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
			
			return dt;
		}
	       public DataTable GetDataByStatus(string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[2]));
            Adapter.SelectCommand.Parameters["@Status"].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                // Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return dt;
        }

		public Customer GetCustomerByID(int ID)
		{
            
            DataTable dt = new DataTable();
			Adapter.SelectCommand = ((SqlCommand) (CommandCollection[1]));
			Adapter.SelectCommand.Parameters[0].Value = ID;
		   
            try
            {
                Adapter.SelectCommand.Connection.Open();
			    Adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
               // Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
		
			return DataTableToEntity(dt);
		}
		
		public DataSet GetCustomerByStatus(string status)
		{
             DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[2]));
            Adapter.SelectCommand.Parameters[0].Value = status;

            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                // Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return ds;
		}

		#region CustomGetTable
		
        public Customer GetCustomerByCustomerName(string customerName,string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = customerName;
            Adapter.SelectCommand.Parameters[1].Value = status;


            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                 Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return DataTableToEntity(dt);
        }


        public DataSet GetSearchByCustomer(string customer,string phone, string address, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = customer;
            Adapter.SelectCommand.Parameters[1].Value = phone;
            Adapter.SelectCommand.Parameters[2].Value = address;
            Adapter.SelectCommand.Parameters[3].Value = status;


            try
            {
                Adapter.SelectCommand.Connection.Open();
                Adapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return ds;
        }
		
		#endregion CustomGetTable
	    
		public int Insert(Customer customer)
		{
	InsertCommand.Parameters["@CustomerName"].Value = customer.CustomerName;
	InsertCommand.Parameters["@Phone"].Value = customer.Phone;
	InsertCommand.Parameters["@Address"].Value = customer.Address;
	InsertCommand.Parameters["@ImagePath"].Value = customer.ImagePath;
	InsertCommand.Parameters["@Status"].Value = customer.Status;
		
			
            int returnValue = -1;
            try
            {
                InsertCommand.Connection.Open();
                returnValue = (int)InsertCommand.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                InsertCommand.Connection.Close();
            }
            return returnValue;
		}
        
		public int Update(Customer customer)
		{
	UpdateCommand.Parameters["@ID"].Value = customer.ID;
	UpdateCommand.Parameters["@CustomerName"].Value = customer.CustomerName;
	UpdateCommand.Parameters["@Phone"].Value = customer.Phone;
	UpdateCommand.Parameters["@Address"].Value = customer.Address;
	UpdateCommand.Parameters["@ImagePath"].Value = customer.ImagePath;
	UpdateCommand.Parameters["@Status"].Value = customer.Status;

			int returnValue = -1;
            try
            {
                UpdateCommand.Connection.Open();
                returnValue = UpdateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Logger.Write(ex);
            }
            finally
            {
                UpdateCommand.Connection.Close();
            }
            return returnValue;
		}
        
        private Customer DataTableToEntity(DataTable dt)
        {
           
            Customer customer = new Customer();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						customer.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						customer.ID=0;
					}
					if (Null.IsNotNull(dr["CustomerName"]))
					{
						customer.CustomerName= Convert.ToString(dr["CustomerName"]);
					}
					else
					{
						customer.CustomerName=string.Empty;
					}
					if (Null.IsNotNull(dr["Phone"]))
					{
						customer.Phone= Convert.ToString(dr["Phone"]);
					}
					else
					{
						customer.Phone=string.Empty;
					}
					if (Null.IsNotNull(dr["Address"]))
					{
						customer.Address= Convert.ToString(dr["Address"]);
					}
					else
					{
						customer.Address=string.Empty;
					}
					if (Null.IsNotNull(dr["ImagePath"]))
					{
						customer.ImagePath= Convert.ToString(dr["ImagePath"]);
					}
					else
					{
						customer.ImagePath=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						customer.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						customer.Status=string.Empty;
					}
 
                }
            }
            return customer ;
        }
		#endregion		
	}
}