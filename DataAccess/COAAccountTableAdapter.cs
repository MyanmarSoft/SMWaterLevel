using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class COAAccountTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public COAAccountTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO COAAccount(AccountCategoryName,AccountCategoryID,AccountName,ParentGroupID,ParentGroupName,Status) VALUES (@AccountCategoryName,@AccountCategoryID,@AccountName,@ParentGroupID,@ParentGroupName,@Status);SELECT ID FROM COAAccount WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@AccountCategoryName", SqlDbType.VarChar, 50,"AccountCategoryName"));
			InsertCommand.Parameters.Add(new SqlParameter("@AccountCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"AccountCategoryID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@AccountName", SqlDbType.VarChar, 50,"AccountName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ParentGroupID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ParentGroupID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ParentGroupName", SqlDbType.VarChar, 50,"ParentGroupName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE COAAccount SET AccountCategoryName = @AccountCategoryName, AccountCategoryID = @AccountCategoryID, AccountName = @AccountName, ParentGroupID = @ParentGroupID, ParentGroupName = @ParentGroupName, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@AccountCategoryName", SqlDbType.VarChar, 50,"AccountCategoryName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AccountCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"AccountCategoryID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@AccountName", SqlDbType.VarChar, 50,"AccountName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ParentGroupID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ParentGroupID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ParentGroupName", SqlDbType.VarChar, 50,"ParentGroupName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM COAAccount WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[5];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,AccountName,ParentGroupID,ParentGroupName,Status FROM COAAccount";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,AccountName,ParentGroupID,ParentGroupName,Status FROM COAAccount WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,AccountName,ParentGroupID,ParentGroupName,Status FROM COAAccount WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //GetSearchByCOAAccount
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,AccountName,ParentGroupID,ParentGroupName,Status FROM COAAccount WHERE AccountCategoryName LIKE '%' + @AccountCategoryName + '%' AND Status =  @Status OR ParentGroupName LIKE '%' + @ParentGroupName + '%' AND Status =  @Status OR AccountName LIKE '%' + @AccountName + '%' AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@AccountCategoryName", SqlDbType.VarChar, 50, "AccountCategoryName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ParentGroupName", SqlDbType.VarChar, 50, "ParentGroupName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@AccountName", SqlDbType.VarChar, 50, "AccountName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));

            //GetCOAAccountByParentGroupID
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,AccountName,ParentGroupID,ParentGroupName,Status FROM COAAccount WHERE AccountCategoryID = @AccountCategoryID AND ParentGroupID = @ParentGroupID AND Status =  @Status ORDER BY AccountName ASC";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@AccountCategoryID", SqlDbType.Int, 4, "AccountCategoryID"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@ParentGroupID", SqlDbType.Int, 4, "ParentGroupID"));
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

		public COAAccount GetCOAAccountByID(int ID)
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
		
		public DataSet GetCOAAccountByStatus(string status)
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

        public DataSet GetSearchByCOAAccount(string accountCategoryName, string parentGroupName, string accountName, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = accountCategoryName;
            Adapter.SelectCommand.Parameters[1].Value = parentGroupName;
            Adapter.SelectCommand.Parameters[2].Value = accountName;
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

        public DataSet GetCOAAccountByParentGroupID(int accountCategoryID,int parentGroupID, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = accountCategoryID;
            Adapter.SelectCommand.Parameters[1].Value = parentGroupID;
            Adapter.SelectCommand.Parameters[2].Value = status;

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
		
		#endregion CustomGetTable
	    
		public int Insert(COAAccount cOAAccount)
		{
	InsertCommand.Parameters["@AccountCategoryName"].Value = cOAAccount.AccountCategoryName;
	InsertCommand.Parameters["@AccountCategoryID"].Value = cOAAccount.AccountCategoryID;
	InsertCommand.Parameters["@AccountName"].Value = cOAAccount.AccountName;
	InsertCommand.Parameters["@ParentGroupID"].Value = cOAAccount.ParentGroupID;
	InsertCommand.Parameters["@ParentGroupName"].Value = cOAAccount.ParentGroupName;
	InsertCommand.Parameters["@Status"].Value = cOAAccount.Status;
		
			
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
        
		public int Update(COAAccount cOAAccount)
		{
	UpdateCommand.Parameters["@ID"].Value = cOAAccount.ID;
	UpdateCommand.Parameters["@AccountCategoryName"].Value = cOAAccount.AccountCategoryName;
	UpdateCommand.Parameters["@AccountCategoryID"].Value = cOAAccount.AccountCategoryID;
	UpdateCommand.Parameters["@AccountName"].Value = cOAAccount.AccountName;
	UpdateCommand.Parameters["@ParentGroupID"].Value = cOAAccount.ParentGroupID;
	UpdateCommand.Parameters["@ParentGroupName"].Value = cOAAccount.ParentGroupName;
	UpdateCommand.Parameters["@Status"].Value = cOAAccount.Status;

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
        
        private COAAccount DataTableToEntity(DataTable dt)
        {
           
            COAAccount cOAAccount = new COAAccount();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						cOAAccount.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						cOAAccount.ID=0;
					}
					if (Null.IsNotNull(dr["AccountCategoryName"]))
					{
						cOAAccount.AccountCategoryName= Convert.ToString(dr["AccountCategoryName"]);
					}
					else
					{
						cOAAccount.AccountCategoryName=string.Empty;
					}
					if (Null.IsNotNull(dr["AccountCategoryID"]))
					{
						cOAAccount.AccountCategoryID=Convert.ToInt32(dr["AccountCategoryID"]);
					}
					else
					{
						cOAAccount.AccountCategoryID=0;
					}
					if (Null.IsNotNull(dr["AccountName"]))
					{
						cOAAccount.AccountName= Convert.ToString(dr["AccountName"]);
					}
					else
					{
						cOAAccount.AccountName=string.Empty;
					}
					if (Null.IsNotNull(dr["ParentGroupID"]))
					{
						cOAAccount.ParentGroupID=Convert.ToInt32(dr["ParentGroupID"]);
					}
					else
					{
						cOAAccount.ParentGroupID=0;
					}
					if (Null.IsNotNull(dr["ParentGroupName"]))
					{
						cOAAccount.ParentGroupName= Convert.ToString(dr["ParentGroupName"]);
					}
					else
					{
						cOAAccount.ParentGroupName=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						cOAAccount.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						cOAAccount.Status=string.Empty;
					}
 
                }
            }
            return cOAAccount ;
        }
		#endregion		
	}
}