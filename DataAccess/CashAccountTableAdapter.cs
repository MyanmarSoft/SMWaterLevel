using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class CashAccountTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public CashAccountTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO CashAccount(CashAccountName,Balance,Status) VALUES (@CashAccountName,@Balance,@Status);SELECT ID FROM CashAccount WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@CashAccountName", SqlDbType.VarChar, 50,"CashAccountName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Balance", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Balance", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE CashAccount SET CashAccountName = @CashAccountName, Balance = @Balance, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CashAccountName", SqlDbType.VarChar, 50,"CashAccountName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Balance", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Balance", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM CashAccount WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[5];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,CashAccountName,Balance,Status FROM CashAccount";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,CashAccountName,Balance,Status FROM CashAccount WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,CashAccountName,Balance,Status FROM CashAccount WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //GetSearchByBankAccountName
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,CashAccountName,Balance,Status FROM CashAccount WHERE CashAccountName = @CashAccountName AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@CashAccountName", SqlDbType.VarChar, 50, "CashAccountName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));


            //GetSearchByBankAccount
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,CashAccountName,Balance,Status FROM CashAccount WHERE CashAccountName LIKE '%' + @CashAccountName + '%' AND Status =  @Status";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@CashAccountName", SqlDbType.VarChar, 50, "CashAccountName"));
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

		public CashAccount GetCashAccountByID(int ID)
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
		
		public DataSet GetCashAccountByStatus(string status)
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
        public DataSet GetSearchByCashAccount(string cashaccount, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = cashaccount;
            Adapter.SelectCommand.Parameters[1].Value = status;


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
	    
		public int Insert(CashAccount cashAccount)
		{
	InsertCommand.Parameters["@CashAccountName"].Value = cashAccount.CashAccountName;
	InsertCommand.Parameters["@Balance"].Value = cashAccount.Balance;
	InsertCommand.Parameters["@Status"].Value = cashAccount.Status;
		
			
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
        
		public int Update(CashAccount cashAccount)
		{
	UpdateCommand.Parameters["@ID"].Value = cashAccount.ID;
	UpdateCommand.Parameters["@CashAccountName"].Value = cashAccount.CashAccountName;
	UpdateCommand.Parameters["@Balance"].Value = cashAccount.Balance;
	UpdateCommand.Parameters["@Status"].Value = cashAccount.Status;

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
        
        private CashAccount DataTableToEntity(DataTable dt)
        {
           
            CashAccount cashAccount = new CashAccount();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						cashAccount.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						cashAccount.ID=0;
					}
					if (Null.IsNotNull(dr["CashAccountName"]))
					{
						cashAccount.CashAccountName= Convert.ToString(dr["CashAccountName"]);
					}
					else
					{
						cashAccount.CashAccountName=string.Empty;
					}
					if (Null.IsNotNull(dr["Balance"]))
					{
						cashAccount.Balance= Convert.ToDecimal(dr["Balance"]);
					}
					else
					{
						cashAccount.Balance=0.00m;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						cashAccount.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						cashAccount.Status=string.Empty;
					}
 
                }
            }
            return cashAccount ;
        }
		#endregion		
	}
}