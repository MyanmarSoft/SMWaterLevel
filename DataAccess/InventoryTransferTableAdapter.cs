using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class InventoryTransferTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public InventoryTransferTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO InventoryTransfer(InventoryTransferNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status) VALUES (@InventoryTransferNo,@ItemCategoryID,@ItemTypeID,@Description,@UnitCost,@Qty,@UnitType,@AmountCost,@Status);SELECT ID FROM InventoryTransfer WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@InventoryTransferNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryTransferNo", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ItemCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemCategoryID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ItemTypeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemTypeID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			InsertCommand.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "UnitCost", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@UnitType", SqlDbType.VarChar, 50,"UnitType"));
			InsertCommand.Parameters.Add(new SqlParameter("@AmountCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "AmountCost", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE InventoryTransfer SET InventoryTransferNo = @InventoryTransferNo, ItemCategoryID = @ItemCategoryID, ItemTypeID = @ItemTypeID, Description = @Description, UnitCost = @UnitCost, Qty = @Qty, UnitType = @UnitType, AmountCost = @AmountCost, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryTransferNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryTransferNo", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemCategoryID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemTypeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemTypeID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "UnitCost", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitType", SqlDbType.VarChar, 50,"UnitType"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AmountCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "AmountCost", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM InventoryTransfer WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,InventoryTransferNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM InventoryTransfer";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,InventoryTransferNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM InventoryTransfer WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,InventoryTransferNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM InventoryTransfer WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //GetDataByInventoryTransferNo
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,InventoryTransferNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM InventoryTransfer WHERE InventoryTransferNo = @InventoryTransferNo AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@InventoryTransferNo", SqlDbType.Int, 4, "InventoryTransferNo"));
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

		public InventoryTransfer GetInventoryTransferByID(int ID)
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
		
		public DataSet GetInventoryTransferByStatus(string status)
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
        public DataTable GetDataByInventoryTransferNo(int inventoryTransferNo, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters["@InventoryTransferNo"].Value = inventoryTransferNo;
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
		#endregion CustomGetTable
	    
		public int Insert(InventoryTransfer inventoryTransfer)
		{
	InsertCommand.Parameters["@InventoryTransferNo"].Value = inventoryTransfer.InventoryTransferNo;
	InsertCommand.Parameters["@ItemCategoryID"].Value = inventoryTransfer.ItemCategoryID;
	InsertCommand.Parameters["@ItemTypeID"].Value = inventoryTransfer.ItemTypeID;
	InsertCommand.Parameters["@Description"].Value = inventoryTransfer.Description;
	InsertCommand.Parameters["@UnitCost"].Value = inventoryTransfer.UnitCost;
	InsertCommand.Parameters["@Qty"].Value = inventoryTransfer.Qty;
	InsertCommand.Parameters["@UnitType"].Value = inventoryTransfer.UnitType;
	InsertCommand.Parameters["@AmountCost"].Value = inventoryTransfer.AmountCost;
	InsertCommand.Parameters["@Status"].Value = inventoryTransfer.Status;
		
			
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
        
		public int Update(InventoryTransfer inventoryTransfer)
		{
	UpdateCommand.Parameters["@ID"].Value = inventoryTransfer.ID;
	UpdateCommand.Parameters["@InventoryTransferNo"].Value = inventoryTransfer.InventoryTransferNo;
	UpdateCommand.Parameters["@ItemCategoryID"].Value = inventoryTransfer.ItemCategoryID;
	UpdateCommand.Parameters["@ItemTypeID"].Value = inventoryTransfer.ItemTypeID;
	UpdateCommand.Parameters["@Description"].Value = inventoryTransfer.Description;
	UpdateCommand.Parameters["@UnitCost"].Value = inventoryTransfer.UnitCost;
	UpdateCommand.Parameters["@Qty"].Value = inventoryTransfer.Qty;
	UpdateCommand.Parameters["@UnitType"].Value = inventoryTransfer.UnitType;
	UpdateCommand.Parameters["@AmountCost"].Value = inventoryTransfer.AmountCost;
	UpdateCommand.Parameters["@Status"].Value = inventoryTransfer.Status;

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
        
        private InventoryTransfer DataTableToEntity(DataTable dt)
        {
           
            InventoryTransfer inventoryTransfer = new InventoryTransfer();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						inventoryTransfer.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						inventoryTransfer.ID=0;
					}
					if (Null.IsNotNull(dr["InventoryTransferNo"]))
					{
						inventoryTransfer.InventoryTransferNo=Convert.ToInt32(dr["InventoryTransferNo"]);
					}
					else
					{
						inventoryTransfer.InventoryTransferNo=0;
					}
					if (Null.IsNotNull(dr["ItemCategoryID"]))
					{
						inventoryTransfer.ItemCategoryID=Convert.ToInt32(dr["ItemCategoryID"]);
					}
					else
					{
						inventoryTransfer.ItemCategoryID=0;
					}
					if (Null.IsNotNull(dr["ItemTypeID"]))
					{
						inventoryTransfer.ItemTypeID=Convert.ToInt32(dr["ItemTypeID"]);
					}
					else
					{
						inventoryTransfer.ItemTypeID=0;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						inventoryTransfer.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						inventoryTransfer.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["UnitCost"]))
					{
						inventoryTransfer.UnitCost= Convert.ToDecimal(dr["UnitCost"]);
					}
					else
					{
						inventoryTransfer.UnitCost=0.00m;
					}
					if (Null.IsNotNull(dr["Qty"]))
					{
						inventoryTransfer.Qty=Convert.ToInt32(dr["Qty"]);
					}
					else
					{
						inventoryTransfer.Qty=0;
					}
					if (Null.IsNotNull(dr["UnitType"]))
					{
						inventoryTransfer.UnitType= Convert.ToString(dr["UnitType"]);
					}
					else
					{
						inventoryTransfer.UnitType=string.Empty;
					}
					if (Null.IsNotNull(dr["AmountCost"]))
					{
						inventoryTransfer.AmountCost= Convert.ToDecimal(dr["AmountCost"]);
					}
					else
					{
						inventoryTransfer.AmountCost=0.00m;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						inventoryTransfer.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						inventoryTransfer.Status=string.Empty;
					}
 
                }
            }
            return inventoryTransfer ;
        }
		#endregion		
	}
}