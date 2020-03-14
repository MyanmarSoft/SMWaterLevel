using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class InventoryTransferItemTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public InventoryTransferItemTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO InventoryTransferItem(InventoryTransferNo,FromInventoryLocationID,FromInventoryLocationName,ToInventoryLocationID,ToInventoryLocationName,Total,Discount,NetTotal,InventoryTransferDate,Username,Status) VALUES (@InventoryTransferNo,@FromInventoryLocationID,@FromInventoryLocationName,@ToInventoryLocationID,@ToInventoryLocationName,@Total,@Discount,@NetTotal,@InventoryTransferDate,@Username,@Status);SELECT ID FROM InventoryTransferItem WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@InventoryTransferNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryTransferNo", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@FromInventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"FromInventoryLocationID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@FromInventoryLocationName", SqlDbType.VarChar, 50,"FromInventoryLocationName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ToInventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ToInventoryLocationID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ToInventoryLocationName", SqlDbType.VarChar, 50,"ToInventoryLocationName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@InventoryTransferDate", SqlDbType.DateTime, 8,"InventoryTransferDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE InventoryTransferItem SET InventoryTransferNo = @InventoryTransferNo, FromInventoryLocationID = @FromInventoryLocationID, FromInventoryLocationName = @FromInventoryLocationName, ToInventoryLocationID = @ToInventoryLocationID, ToInventoryLocationName = @ToInventoryLocationName, Total = @Total, Discount = @Discount, NetTotal = @NetTotal, InventoryTransferDate = @InventoryTransferDate, Username = @Username, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryTransferNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryTransferNo", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@FromInventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"FromInventoryLocationID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@FromInventoryLocationName", SqlDbType.VarChar, 50,"FromInventoryLocationName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ToInventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ToInventoryLocationID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ToInventoryLocationName", SqlDbType.VarChar, 50,"ToInventoryLocationName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryTransferDate", SqlDbType.DateTime, 8,"InventoryTransferDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM InventoryTransferItem WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,InventoryTransferNo,FromInventoryLocationID,FromInventoryLocationName,ToInventoryLocationID,ToInventoryLocationName,Total,Discount,NetTotal,InventoryTransferDate,Username,Status FROM InventoryTransferItem";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,InventoryTransferNo,FromInventoryLocationID,FromInventoryLocationName,ToInventoryLocationID,ToInventoryLocationName,Total,Discount,NetTotal,InventoryTransferDate,Username,Status FROM InventoryTransferItem WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,InventoryTransferNo,FromInventoryLocationID,FromInventoryLocationName,ToInventoryLocationID,ToInventoryLocationName,Total,Discount,NetTotal,InventoryTransferDate,Username,Status FROM InventoryTransferItem WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			
			//GetInventoryTransferByLastID
           
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT TOP 1* FROM  InventoryTransferItem ORDER BY InventoryTransferNo DESC";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
			
			
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

		public InventoryTransferItem GetInventoryTransferItemByID(int ID)
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
		
		public DataSet GetInventoryTransferItemByStatus(string status)
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
		
        public InventoryTransferItem GetInventoryTransferByLastID()
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));

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
		
		
		
		#endregion CustomGetTable
	    
		public int Insert(InventoryTransferItem inventoryTransferItem)
		{
	InsertCommand.Parameters["@InventoryTransferNo"].Value = inventoryTransferItem.InventoryTransferNo;
	InsertCommand.Parameters["@FromInventoryLocationID"].Value = inventoryTransferItem.FromInventoryLocationID;
	InsertCommand.Parameters["@FromInventoryLocationName"].Value = inventoryTransferItem.FromInventoryLocationName;
	InsertCommand.Parameters["@ToInventoryLocationID"].Value = inventoryTransferItem.ToInventoryLocationID;
	InsertCommand.Parameters["@ToInventoryLocationName"].Value = inventoryTransferItem.ToInventoryLocationName;
	InsertCommand.Parameters["@Total"].Value = inventoryTransferItem.Total;
	InsertCommand.Parameters["@Discount"].Value = inventoryTransferItem.Discount;
	InsertCommand.Parameters["@NetTotal"].Value = inventoryTransferItem.NetTotal;
	InsertCommand.Parameters["@InventoryTransferDate"].Value = inventoryTransferItem.InventoryTransferDate;
	InsertCommand.Parameters["@Username"].Value = inventoryTransferItem.Username;
	InsertCommand.Parameters["@Status"].Value = inventoryTransferItem.Status;
		
			
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
        
		public int Update(InventoryTransferItem inventoryTransferItem)
		{
	UpdateCommand.Parameters["@ID"].Value = inventoryTransferItem.ID;
	UpdateCommand.Parameters["@InventoryTransferNo"].Value = inventoryTransferItem.InventoryTransferNo;
	UpdateCommand.Parameters["@FromInventoryLocationID"].Value = inventoryTransferItem.FromInventoryLocationID;
	UpdateCommand.Parameters["@FromInventoryLocationName"].Value = inventoryTransferItem.FromInventoryLocationName;
	UpdateCommand.Parameters["@ToInventoryLocationID"].Value = inventoryTransferItem.ToInventoryLocationID;
	UpdateCommand.Parameters["@ToInventoryLocationName"].Value = inventoryTransferItem.ToInventoryLocationName;
	UpdateCommand.Parameters["@Total"].Value = inventoryTransferItem.Total;
	UpdateCommand.Parameters["@Discount"].Value = inventoryTransferItem.Discount;
	UpdateCommand.Parameters["@NetTotal"].Value = inventoryTransferItem.NetTotal;
	UpdateCommand.Parameters["@InventoryTransferDate"].Value = inventoryTransferItem.InventoryTransferDate;
	UpdateCommand.Parameters["@Username"].Value = inventoryTransferItem.Username;
	UpdateCommand.Parameters["@Status"].Value = inventoryTransferItem.Status;

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
        
        private InventoryTransferItem DataTableToEntity(DataTable dt)
        {
           
            InventoryTransferItem inventoryTransferItem = new InventoryTransferItem();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						inventoryTransferItem.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						inventoryTransferItem.ID=0;
					}
					if (Null.IsNotNull(dr["InventoryTransferNo"]))
					{
						inventoryTransferItem.InventoryTransferNo=Convert.ToInt32(dr["InventoryTransferNo"]);
					}
					else
					{
						inventoryTransferItem.InventoryTransferNo=0;
					}
					if (Null.IsNotNull(dr["FromInventoryLocationID"]))
					{
						inventoryTransferItem.FromInventoryLocationID=Convert.ToInt32(dr["FromInventoryLocationID"]);
					}
					else
					{
						inventoryTransferItem.FromInventoryLocationID=0;
					}
					if (Null.IsNotNull(dr["FromInventoryLocationName"]))
					{
						inventoryTransferItem.FromInventoryLocationName= Convert.ToString(dr["FromInventoryLocationName"]);
					}
					else
					{
						inventoryTransferItem.FromInventoryLocationName=string.Empty;
					}
					if (Null.IsNotNull(dr["ToInventoryLocationID"]))
					{
						inventoryTransferItem.ToInventoryLocationID=Convert.ToInt32(dr["ToInventoryLocationID"]);
					}
					else
					{
						inventoryTransferItem.ToInventoryLocationID=0;
					}
					if (Null.IsNotNull(dr["ToInventoryLocationName"]))
					{
						inventoryTransferItem.ToInventoryLocationName= Convert.ToString(dr["ToInventoryLocationName"]);
					}
					else
					{
						inventoryTransferItem.ToInventoryLocationName=string.Empty;
					}
					if (Null.IsNotNull(dr["Total"]))
					{
						inventoryTransferItem.Total= Convert.ToDecimal(dr["Total"]);
					}
					else
					{
						inventoryTransferItem.Total=0.00m;
					}
					if (Null.IsNotNull(dr["Discount"]))
					{
						inventoryTransferItem.Discount= Convert.ToDecimal(dr["Discount"]);
					}
					else
					{
						inventoryTransferItem.Discount=0.00m;
					}
					if (Null.IsNotNull(dr["NetTotal"]))
					{
						inventoryTransferItem.NetTotal= Convert.ToDecimal(dr["NetTotal"]);
					}
					else
					{
						inventoryTransferItem.NetTotal=0.00m;
					}
					if (Null.IsNotNull(dr["InventoryTransferDate"]))
					{
						inventoryTransferItem.InventoryTransferDate= Convert.ToDateTime(dr["InventoryTransferDate"]);
					}
					else
					{
						inventoryTransferItem.InventoryTransferDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Username"]))
					{
						inventoryTransferItem.Username= Convert.ToString(dr["Username"]);
					}
					else
					{
						inventoryTransferItem.Username=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						inventoryTransferItem.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						inventoryTransferItem.Status=string.Empty;
					}
 
                }
            }
            return inventoryTransferItem ;
        }
		#endregion		
	}
}