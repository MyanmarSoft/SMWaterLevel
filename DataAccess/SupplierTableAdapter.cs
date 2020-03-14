using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class SupplierTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public SupplierTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO Supplier(SupplierName,Phone,Address,Status) VALUES (@SupplierName,@Phone,@Address,@Status);SELECT ID FROM Supplier WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.VarChar, 50,"SupplierName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 50,"Phone"));
			InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 200,"Address"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE Supplier SET SupplierName = @SupplierName, Phone = @Phone, Address = @Address, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.VarChar, 50,"SupplierName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 50,"Phone"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 200,"Address"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM Supplier WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[5];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,SupplierName,Phone,Address,Status FROM Supplier";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,SupplierName,Phone,Address,Status FROM Supplier WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,SupplierName,Phone,Address,Status FROM Supplier WHERE Status =  @Status ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //GetSearchBySupplierName
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,SupplierName,Phone,Address,Status FROM Supplier WHERE SupplierName = @SupplierName AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 50, "SupplierName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));


            //GetSearchBySupplier
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,SupplierName,Phone,Address,Status FROM Supplier WHERE SupplierName LIKE '%' + @SupplierName + '%' AND Status =  @Status OR Phone LIKE '%' + @Phone + '%' AND Status = @Status OR Address LIKE '%' + @Address + '%' AND Status = @Status";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 50, "SupplierName"));
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

		public Supplier GetSupplierByID(int ID)
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
		
		public DataSet GetSupplierByStatus(string status)
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



        public DataSet GetSearchBySupplier(string supplier, string phone, string address, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = supplier;
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
	    
		public int Insert(Supplier supplier)
		{
	InsertCommand.Parameters["@SupplierName"].Value = supplier.SupplierName;
	InsertCommand.Parameters["@Phone"].Value = supplier.Phone;
	InsertCommand.Parameters["@Address"].Value = supplier.Address;
	InsertCommand.Parameters["@Status"].Value = supplier.Status;
		
			
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
        
		public int Update(Supplier supplier)
		{
	UpdateCommand.Parameters["@ID"].Value = supplier.ID;
	UpdateCommand.Parameters["@SupplierName"].Value = supplier.SupplierName;
	UpdateCommand.Parameters["@Phone"].Value = supplier.Phone;
	UpdateCommand.Parameters["@Address"].Value = supplier.Address;
	UpdateCommand.Parameters["@Status"].Value = supplier.Status;

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
        
        private Supplier DataTableToEntity(DataTable dt)
        {
           
            Supplier supplier = new Supplier();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						supplier.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						supplier.ID=0;
					}
					if (Null.IsNotNull(dr["SupplierName"]))
					{
						supplier.SupplierName= Convert.ToString(dr["SupplierName"]);
					}
					else
					{
						supplier.SupplierName=string.Empty;
					}
					if (Null.IsNotNull(dr["Phone"]))
					{
						supplier.Phone= Convert.ToString(dr["Phone"]);
					}
					else
					{
						supplier.Phone=string.Empty;
					}
					if (Null.IsNotNull(dr["Address"]))
					{
						supplier.Address= Convert.ToString(dr["Address"]);
					}
					else
					{
						supplier.Address=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						supplier.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						supplier.Status=string.Empty;
					}
 
                }
            }
            return supplier ;
        }
		#endregion		
	}
}