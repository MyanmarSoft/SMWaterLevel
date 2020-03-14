using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class PurchaseInvoiceTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public PurchaseInvoiceTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO PurchaseInvoice(PurchaseInvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,InventoryLocationID,InventoryLocationName,Status) VALUES (@PurchaseInvoiceNo,@ItemCategoryID,@ItemTypeID,@Description,@UnitCost,@Qty,@UnitType,@AmountCost,@InventoryLocationID,@InventoryLocationName,@Status);SELECT ID FROM PurchaseInvoice WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@PurchaseInvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PurchaseInvoiceNo", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ItemCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemCategoryID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ItemTypeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemTypeID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			InsertCommand.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "UnitCost", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@UnitType", SqlDbType.VarChar, 50,"UnitType"));
			InsertCommand.Parameters.Add(new SqlParameter("@AmountCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "AmountCost", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@InventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryLocationID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@InventoryLocationName", SqlDbType.VarChar, 50,"InventoryLocationName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE PurchaseInvoice SET PurchaseInvoiceNo = @PurchaseInvoiceNo, ItemCategoryID = @ItemCategoryID, ItemTypeID = @ItemTypeID, Description = @Description, UnitCost = @UnitCost, Qty = @Qty, UnitType = @UnitType, AmountCost = @AmountCost, InventoryLocationID = @InventoryLocationID, InventoryLocationName = @InventoryLocationName, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PurchaseInvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PurchaseInvoiceNo", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemCategoryID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemCategoryID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemTypeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemTypeID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "UnitCost", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitType", SqlDbType.VarChar, 50,"UnitType"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AmountCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "AmountCost", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryLocationID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryLocationName", SqlDbType.VarChar, 50,"InventoryLocationName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM PurchaseInvoice WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,PurchaseInvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,InventoryLocationID,InventoryLocationName,Status FROM PurchaseInvoice";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,PurchaseInvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,InventoryLocationID,InventoryLocationName,Status FROM PurchaseInvoice WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,PurchaseInvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,InventoryLocationID,InventoryLocationName,Status FROM PurchaseInvoice WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			//GetDataByPurchaseInvoiceNo
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,PurchaseInvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,InventoryLocationID,InventoryLocationName,Status FROM PurchaseInvoice WHERE PurchaseInvoiceNo = @PurchaseInvoiceNo AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@PurchaseInvoiceNo", SqlDbType.Int, 4, "PurchaseInvoiceNo"));
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

		public PurchaseInvoice GetPurchaseInvoiceByID(int ID)
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
		
		public DataSet GetPurchaseInvoiceByStatus(string status)
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
        public DataTable GetDataByPurchaseInvoiceNo(int purchaseInvoiceNo, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters["@PurchaseInvoiceNo"].Value = purchaseInvoiceNo;
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
	    
		public int Insert(PurchaseInvoice purchaseInvoice)
		{
	InsertCommand.Parameters["@PurchaseInvoiceNo"].Value = purchaseInvoice.PurchaseInvoiceNo;
	InsertCommand.Parameters["@ItemCategoryID"].Value = purchaseInvoice.ItemCategoryID;
	InsertCommand.Parameters["@ItemTypeID"].Value = purchaseInvoice.ItemTypeID;
	InsertCommand.Parameters["@Description"].Value = purchaseInvoice.Description;
	InsertCommand.Parameters["@UnitCost"].Value = purchaseInvoice.UnitCost;
	InsertCommand.Parameters["@Qty"].Value = purchaseInvoice.Qty;
	InsertCommand.Parameters["@UnitType"].Value = purchaseInvoice.UnitType;
	InsertCommand.Parameters["@AmountCost"].Value = purchaseInvoice.AmountCost;
	InsertCommand.Parameters["@InventoryLocationID"].Value = purchaseInvoice.InventoryLocationID;
	InsertCommand.Parameters["@InventoryLocationName"].Value = purchaseInvoice.InventoryLocationName;
	InsertCommand.Parameters["@Status"].Value = purchaseInvoice.Status;
		
			
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
        
		public int Update(PurchaseInvoice purchaseInvoice)
		{
	UpdateCommand.Parameters["@ID"].Value = purchaseInvoice.ID;
	UpdateCommand.Parameters["@PurchaseInvoiceNo"].Value = purchaseInvoice.PurchaseInvoiceNo;
	UpdateCommand.Parameters["@ItemCategoryID"].Value = purchaseInvoice.ItemCategoryID;
	UpdateCommand.Parameters["@ItemTypeID"].Value = purchaseInvoice.ItemTypeID;
	UpdateCommand.Parameters["@Description"].Value = purchaseInvoice.Description;
	UpdateCommand.Parameters["@UnitCost"].Value = purchaseInvoice.UnitCost;
	UpdateCommand.Parameters["@Qty"].Value = purchaseInvoice.Qty;
	UpdateCommand.Parameters["@UnitType"].Value = purchaseInvoice.UnitType;
	UpdateCommand.Parameters["@AmountCost"].Value = purchaseInvoice.AmountCost;
	UpdateCommand.Parameters["@InventoryLocationID"].Value = purchaseInvoice.InventoryLocationID;
	UpdateCommand.Parameters["@InventoryLocationName"].Value = purchaseInvoice.InventoryLocationName;
	UpdateCommand.Parameters["@Status"].Value = purchaseInvoice.Status;

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
        
        private PurchaseInvoice DataTableToEntity(DataTable dt)
        {
           
            PurchaseInvoice purchaseInvoice = new PurchaseInvoice();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						purchaseInvoice.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						purchaseInvoice.ID=0;
					}
					if (Null.IsNotNull(dr["PurchaseInvoiceNo"]))
					{
						purchaseInvoice.PurchaseInvoiceNo=Convert.ToInt32(dr["PurchaseInvoiceNo"]);
					}
					else
					{
						purchaseInvoice.PurchaseInvoiceNo=0;
					}
					if (Null.IsNotNull(dr["ItemCategoryID"]))
					{
						purchaseInvoice.ItemCategoryID=Convert.ToInt32(dr["ItemCategoryID"]);
					}
					else
					{
						purchaseInvoice.ItemCategoryID=0;
					}
					if (Null.IsNotNull(dr["ItemTypeID"]))
					{
						purchaseInvoice.ItemTypeID=Convert.ToInt32(dr["ItemTypeID"]);
					}
					else
					{
						purchaseInvoice.ItemTypeID=0;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						purchaseInvoice.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						purchaseInvoice.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["UnitCost"]))
					{
						purchaseInvoice.UnitCost= Convert.ToDecimal(dr["UnitCost"]);
					}
					else
					{
						purchaseInvoice.UnitCost=0.00m;
					}
					if (Null.IsNotNull(dr["Qty"]))
					{
						purchaseInvoice.Qty=Convert.ToInt32(dr["Qty"]);
					}
					else
					{
						purchaseInvoice.Qty=0;
					}
					if (Null.IsNotNull(dr["UnitType"]))
					{
						purchaseInvoice.UnitType= Convert.ToString(dr["UnitType"]);
					}
					else
					{
						purchaseInvoice.UnitType=string.Empty;
					}
					if (Null.IsNotNull(dr["AmountCost"]))
					{
						purchaseInvoice.AmountCost= Convert.ToDecimal(dr["AmountCost"]);
					}
					else
					{
						purchaseInvoice.AmountCost=0.00m;
					}
					if (Null.IsNotNull(dr["InventoryLocationID"]))
					{
						purchaseInvoice.InventoryLocationID=Convert.ToInt32(dr["InventoryLocationID"]);
					}
					else
					{
						purchaseInvoice.InventoryLocationID=0;
					}
					if (Null.IsNotNull(dr["InventoryLocationName"]))
					{
						purchaseInvoice.InventoryLocationName= Convert.ToString(dr["InventoryLocationName"]);
					}
					else
					{
						purchaseInvoice.InventoryLocationName=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						purchaseInvoice.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						purchaseInvoice.Status=string.Empty;
					}
 
                }
            }
            return purchaseInvoice ;
        }
		#endregion		
	}
}