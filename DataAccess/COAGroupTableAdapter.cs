using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class COAGroupTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public COAGroupTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO COAGroup(AccountCategoryName,AccountCategoryID,IsExpense,GroupName,Code,ParentGroupID,ParentGroupName,Status) VALUES (@AccountCategoryName,@AccountCategoryID,@IsExpense,@GroupName,@Code,@ParentGroupID,@ParentGroupName,@Status);SELECT ID FROM COAGroup WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@AccountCategoryName", SqlDbType.VarChar, 50,"AccountCategoryName"));
			InsertCommand.Parameters.Add(new SqlParameter("@AccountCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"AccountCategoryID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@IsExpense", SqlDbType.VarChar, 10,"IsExpense"));
			InsertCommand.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 50,"GroupName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.VarChar, 50,"Code"));
			InsertCommand.Parameters.Add(new SqlParameter("@ParentGroupID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ParentGroupID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ParentGroupName", SqlDbType.VarChar, 50,"ParentGroupName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE COAGroup SET AccountCategoryName = @AccountCategoryName, AccountCategoryID = @AccountCategoryID, IsExpense = @IsExpense, GroupName = @GroupName, Code = @Code, ParentGroupID = @ParentGroupID, ParentGroupName = @ParentGroupName, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@AccountCategoryName", SqlDbType.VarChar, 50,"AccountCategoryName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AccountCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"AccountCategoryID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@IsExpense", SqlDbType.VarChar, 10,"IsExpense"));
			UpdateCommand.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 50,"GroupName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.VarChar, 50,"Code"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ParentGroupID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ParentGroupID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ParentGroupName", SqlDbType.VarChar, 50,"ParentGroupName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM COAGroup WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[6];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,IsExpense,GroupName,Code,ParentGroupID,ParentGroupName,Status FROM COAGroup";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,IsExpense,GroupName,Code,ParentGroupID,ParentGroupName,Status FROM COAGroup WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,IsExpense,GroupName,Code,ParentGroupID,ParentGroupName,Status FROM COAGroup WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			//GetSearchByCOAGroup
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,IsExpense,GroupName,Code,ParentGroupID,ParentGroupName,Status FROM COAGroup WHERE AccountCategoryName LIKE '%' + @AccountCategoryName + '%' AND Status =  @Status OR ParentGroupName LIKE '%' + @ParentGroupName + '%' AND Status =  @Status OR GroupName LIKE '%' + @GroupName + '%' AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@AccountCategoryName", SqlDbType.VarChar, 50, "AccountCategoryName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ParentGroupName", SqlDbType.VarChar, 50, "ParentGroupName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 50, "GroupName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));


            //GetDataByAccountCategory
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,IsExpense,GroupName,Code,ParentGroupID,ParentGroupName,Status FROM COAGroup WHERE AccountCategoryID = @AccountCategoryID AND Status =  @Status ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@AccountCategoryID", SqlDbType.Int, 4, "AccountCategoryID"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));

            //GetDataByAccount
            CommandCollection[5] = new SqlCommand();
            ((SqlCommand)(CommandCollection[5])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[5])).CommandText = "SELECT ID,AccountCategoryName,AccountCategoryID,IsExpense,GroupName,Code,ParentGroupID,ParentGroupName,Status FROM COAGroup WHERE AccountCategoryID = @AccountCategoryID AND Status =  @Status AND ID > 0 ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[5])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[5])).Parameters.Add(new SqlParameter("@AccountCategoryID", SqlDbType.Int, 4, "AccountCategoryID"));
            ((SqlCommand)(this.CommandCollection[5])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			
			
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

		public COAGroup GetCOAGroupByID(int ID)
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
		
		public DataSet GetCOAGroupByStatus(string status)
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
		

        public DataSet GetSearchByCOAGroup(string accountCategoryName, string parentGroupName, string groupName,string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = accountCategoryName;
            Adapter.SelectCommand.Parameters[1].Value = parentGroupName;
            Adapter.SelectCommand.Parameters[2].Value = groupName;
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


        public DataTable GetDataByAccountCategory(int accountCategory , string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = accountCategory;
            Adapter.SelectCommand.Parameters[1].Value = status;

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

        public DataSet GetDataByAccount(int accountCategory, string status)
        {

            DataSet ds = new DataSet(); 
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[5]));
            Adapter.SelectCommand.Parameters[0].Value = accountCategory;
            Adapter.SelectCommand.Parameters[1].Value = status;

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
	    
		public int Insert(COAGroup cOAGroup)
		{
	InsertCommand.Parameters["@AccountCategoryName"].Value = cOAGroup.AccountCategoryName;
	InsertCommand.Parameters["@AccountCategoryID"].Value = cOAGroup.AccountCategoryID;
	InsertCommand.Parameters["@IsExpense"].Value = cOAGroup.IsExpense;
	InsertCommand.Parameters["@GroupName"].Value = cOAGroup.GroupName;
	InsertCommand.Parameters["@Code"].Value = cOAGroup.Code;
	InsertCommand.Parameters["@ParentGroupID"].Value = cOAGroup.ParentGroupID;
	InsertCommand.Parameters["@ParentGroupName"].Value = cOAGroup.ParentGroupName;
	InsertCommand.Parameters["@Status"].Value = cOAGroup.Status;
		
			
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
        
		public int Update(COAGroup cOAGroup)
		{
	UpdateCommand.Parameters["@ID"].Value = cOAGroup.ID;
	UpdateCommand.Parameters["@AccountCategoryName"].Value = cOAGroup.AccountCategoryName;
	UpdateCommand.Parameters["@AccountCategoryID"].Value = cOAGroup.AccountCategoryID;
	UpdateCommand.Parameters["@IsExpense"].Value = cOAGroup.IsExpense;
	UpdateCommand.Parameters["@GroupName"].Value = cOAGroup.GroupName;
	UpdateCommand.Parameters["@Code"].Value = cOAGroup.Code;
	UpdateCommand.Parameters["@ParentGroupID"].Value = cOAGroup.ParentGroupID;
	UpdateCommand.Parameters["@ParentGroupName"].Value = cOAGroup.ParentGroupName;
	UpdateCommand.Parameters["@Status"].Value = cOAGroup.Status;

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
        
        private COAGroup DataTableToEntity(DataTable dt)
        {
           
            COAGroup cOAGroup = new COAGroup();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						cOAGroup.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						cOAGroup.ID=0;
					}
					if (Null.IsNotNull(dr["AccountCategoryName"]))
					{
						cOAGroup.AccountCategoryName= Convert.ToString(dr["AccountCategoryName"]);
					}
					else
					{
						cOAGroup.AccountCategoryName=string.Empty;
					}
					if (Null.IsNotNull(dr["AccountCategoryID"]))
					{
						cOAGroup.AccountCategoryID=Convert.ToInt32(dr["AccountCategoryID"]);
					}
					else
					{
						cOAGroup.AccountCategoryID=0;
					}
					if (Null.IsNotNull(dr["IsExpense"]))
					{
						cOAGroup.IsExpense= Convert.ToString(dr["IsExpense"]);
					}
					else
					{
						cOAGroup.IsExpense=string.Empty;
					}
					if (Null.IsNotNull(dr["GroupName"]))
					{
						cOAGroup.GroupName= Convert.ToString(dr["GroupName"]);
					}
					else
					{
						cOAGroup.GroupName=string.Empty;
					}
					if (Null.IsNotNull(dr["Code"]))
					{
						cOAGroup.Code= Convert.ToString(dr["Code"]);
					}
					else
					{
						cOAGroup.Code=string.Empty;
					}
					if (Null.IsNotNull(dr["ParentGroupID"]))
					{
						cOAGroup.ParentGroupID=Convert.ToInt32(dr["ParentGroupID"]);
					}
					else
					{
						cOAGroup.ParentGroupID=0;
					}
					if (Null.IsNotNull(dr["ParentGroupName"]))
					{
						cOAGroup.ParentGroupName= Convert.ToString(dr["ParentGroupName"]);
					}
					else
					{
						cOAGroup.ParentGroupName=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						cOAGroup.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						cOAGroup.Status=string.Empty;
					}
 
                }
            }
            return cOAGroup ;
        }
		#endregion		
	}
}