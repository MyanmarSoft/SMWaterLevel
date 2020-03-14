using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class XRayTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public XRayTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO XRay(ItemName,MMK,USD,Status) VALUES (@ItemName,@MMK,@USD,@Status);SELECT ID FROM XRay WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar, 50,"ItemName"));
			InsertCommand.Parameters.Add(new SqlParameter("@MMK", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "MMK", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@USD", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "USD", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE XRay SET ItemName = @ItemName, MMK = @MMK, USD = @USD, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar, 50,"ItemName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MMK", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "MMK", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@USD", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "USD", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM XRay WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ItemName,MMK,USD,Status FROM XRay";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ItemName,MMK,USD,Status FROM XRay WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ItemName,MMK,USD,Status FROM XRay WHERE Status =  @Status ORDER BY ItemName ASC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,ItemName,MMK,USD,Status FROM XRay WHERE ItemName LIKE '%'+ @ItemName +'%' AND Status =  @Status ORDER BY ItemName ASC";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar, 100, "ItemName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
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

		public XRay GetXRayByID(int ID)
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
		
		public DataSet GetXRayByStatus(string status)
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
        public DataTable GetDataByItemName(string itemName, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = itemName;
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
	    
		public int Insert(XRay xRay)
		{
	InsertCommand.Parameters["@ItemName"].Value = xRay.ItemName;
	InsertCommand.Parameters["@MMK"].Value = xRay.MMK;
	InsertCommand.Parameters["@USD"].Value = xRay.USD;
	InsertCommand.Parameters["@Status"].Value = xRay.Status;
		
			
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
        
		public int Update(XRay xRay)
		{
	UpdateCommand.Parameters["@ID"].Value = xRay.ID;
	UpdateCommand.Parameters["@ItemName"].Value = xRay.ItemName;
	UpdateCommand.Parameters["@MMK"].Value = xRay.MMK;
	UpdateCommand.Parameters["@USD"].Value = xRay.USD;
	UpdateCommand.Parameters["@Status"].Value = xRay.Status;

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
        
        private XRay DataTableToEntity(DataTable dt)
        {
           
            XRay xRay = new XRay();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						xRay.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						xRay.ID=0;
					}
					if (Null.IsNotNull(dr["ItemName"]))
					{
						xRay.ItemName= Convert.ToString(dr["ItemName"]);
					}
					else
					{
						xRay.ItemName=string.Empty;
					}
					if (Null.IsNotNull(dr["MMK"]))
					{
						xRay.MMK= Convert.ToDecimal(dr["MMK"]);
					}
					else
					{
						xRay.MMK=0.00m;
					}
					if (Null.IsNotNull(dr["USD"]))
					{
						xRay.USD= Convert.ToDecimal(dr["USD"]);
					}
					else
					{
						xRay.USD=0.00m;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						xRay.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						xRay.Status=string.Empty;
					}
 
                }
            }
            return xRay ;
        }
		#endregion		
	}
}