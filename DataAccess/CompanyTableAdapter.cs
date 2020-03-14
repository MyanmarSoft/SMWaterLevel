using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class CompanyTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public CompanyTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO Company(CompanyName,Address,ContactNo,PaymentModeID,PaymentMode,Status) VALUES (@CompanyName,@Address,@ContactNo,@PaymentModeID,@PaymentMode,@Status);SELECT ID FROM Company WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.NVarChar, 100,"CompanyName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200,"Address"));
			InsertCommand.Parameters.Add(new SqlParameter("@ContactNo", SqlDbType.VarChar, 50,"ContactNo"));
			InsertCommand.Parameters.Add(new SqlParameter("@PaymentModeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PaymentModeID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PaymentMode", SqlDbType.VarChar, 50,"PaymentMode"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE Company SET CompanyName = @CompanyName, Address = @Address, ContactNo = @ContactNo, PaymentModeID = @PaymentModeID, PaymentMode = @PaymentMode, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.NVarChar, 100,"CompanyName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200,"Address"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ContactNo", SqlDbType.VarChar, 50,"ContactNo"));
			UpdateCommand.Parameters.Add(new SqlParameter("@PaymentModeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PaymentModeID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PaymentMode", SqlDbType.VarChar, 50,"PaymentMode"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM Company WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[5];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,CompanyName,Address,ContactNo,PaymentModeID,PaymentMode,Status FROM Company";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,CompanyName,Address,ContactNo,PaymentModeID,PaymentMode,Status FROM Company WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,CompanyName,Address,ContactNo,PaymentModeID,PaymentMode,Status FROM Company WHERE Status =  @Status ORDER BY CompanyName ASC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			//GetCompanyByInsurance
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,CompanyName,Address,ContactNo,PaymentModeID,PaymentMode,Status FROM Company WHERE PaymentModeID = @PaymentModeID ANd Status =  @Status ORDER BY CompanyName ASC";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@PaymentModeID", SqlDbType.Int, 4, "PaymentModeID"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			//GetDataByCompanyName
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,CompanyName,Address,ContactNo,PaymentModeID,PaymentMode,Status FROM Company WHERE CompanyName LIKE '%'+ @CompanyName +'%' AND Status =  @Status ORDER BY CompanyName ASC";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 100, "CompanyName"));
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
               Logger.Write(ex);
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
                Logger.Write(ex);
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
                Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return dt;
        }

		public Company GetCompanyByID(int ID)
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
               Logger.Write(ex);
            }
            finally
			{
                 Adapter.SelectCommand.Connection.Close();
            }
		
			return DataTableToEntity(dt);
		}
		
		public DataSet GetCompanyByStatus(string status)
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
                Logger.Write(ex);
            }
            finally
            {
                Adapter.SelectCommand.Connection.Close();
            }

            return ds;
		}

		#region CustomGetTable
        public DataTable GetCompanyByInsurance(int paymentModeID, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters["@PaymentModeID"].Value = paymentModeID;
            Adapter.SelectCommand.Parameters["@Status"].Value = status;

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

            return dt;
        }


        public DataTable GetDataByCompanyName(string companyName, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = companyName;
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

            return dt;
        }

		#endregion CustomGetTable
	    
		public int Insert(Company company)
		{
	InsertCommand.Parameters["@CompanyName"].Value = company.CompanyName;
	InsertCommand.Parameters["@Address"].Value = company.Address;
	InsertCommand.Parameters["@ContactNo"].Value = company.ContactNo;
	InsertCommand.Parameters["@PaymentModeID"].Value = company.PaymentModeID;
	InsertCommand.Parameters["@PaymentMode"].Value = company.PaymentMode;
	InsertCommand.Parameters["@Status"].Value = company.Status;
		
			
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
        
		public int Update(Company company)
		{
	UpdateCommand.Parameters["@ID"].Value = company.ID;
	UpdateCommand.Parameters["@CompanyName"].Value = company.CompanyName;
	UpdateCommand.Parameters["@Address"].Value = company.Address;
	UpdateCommand.Parameters["@ContactNo"].Value = company.ContactNo;
	UpdateCommand.Parameters["@PaymentModeID"].Value = company.PaymentModeID;
	UpdateCommand.Parameters["@PaymentMode"].Value = company.PaymentMode;
	UpdateCommand.Parameters["@Status"].Value = company.Status;

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
        
        private Company DataTableToEntity(DataTable dt)
        {
           
            Company company = new Company();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						company.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						company.ID=0;
					}
					if (Null.IsNotNull(dr["CompanyName"]))
					{
						company.CompanyName= Convert.ToString(dr["CompanyName"]);
					}
					else
					{
						company.CompanyName=string.Empty;
					}
					if (Null.IsNotNull(dr["Address"]))
					{
						company.Address= Convert.ToString(dr["Address"]);
					}
					else
					{
						company.Address=string.Empty;
					}
					if (Null.IsNotNull(dr["ContactNo"]))
					{
						company.ContactNo= Convert.ToString(dr["ContactNo"]);
					}
					else
					{
						company.ContactNo=string.Empty;
					}
					if (Null.IsNotNull(dr["PaymentModeID"]))
					{
						company.PaymentModeID=Convert.ToInt32(dr["PaymentModeID"]);
					}
					else
					{
						company.PaymentModeID=0;
					}
					if (Null.IsNotNull(dr["PaymentMode"]))
					{
						company.PaymentMode= Convert.ToString(dr["PaymentMode"]);
					}
					else
					{
						company.PaymentMode=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						company.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						company.Status=string.Empty;
					}
 
                }
            }
            return company ;
        }
		#endregion		
	}
}