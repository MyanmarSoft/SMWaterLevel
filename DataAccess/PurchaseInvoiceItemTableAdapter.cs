using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class PurchaseInvoiceItemTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public PurchaseInvoiceItemTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO PurchaseInvoiceItem(PurchaseInvoiceNo,ReferenceNo,SupplierID,SupplierName,PaymentModeID,PaymentMode,Total,Discount,NetTotal,PurchaseInvoiceDate,InventoryLocationID,InventoryLocationName,Username,Status) VALUES (@PurchaseInvoiceNo,@ReferenceNo,@SupplierID,@SupplierName,@PaymentModeID,@PaymentMode,@Total,@Discount,@NetTotal,@PurchaseInvoiceDate,@InventoryLocationID,@InventoryLocationName,@Username,@Status);SELECT ID FROM PurchaseInvoiceItem WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@PurchaseInvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PurchaseInvoiceNo", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ReferenceNo", SqlDbType.VarChar, 50,"ReferenceNo"));
			InsertCommand.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"SupplierID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 255,"SupplierName"));
			InsertCommand.Parameters.Add(new SqlParameter("@PaymentModeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PaymentModeID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PaymentMode", SqlDbType.NVarChar, 255,"PaymentMode"));
			InsertCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PurchaseInvoiceDate", SqlDbType.DateTime, 8,"PurchaseInvoiceDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@InventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryLocationID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@InventoryLocationName", SqlDbType.VarChar, 10,"InventoryLocationName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE PurchaseInvoiceItem SET PurchaseInvoiceNo = @PurchaseInvoiceNo, ReferenceNo = @ReferenceNo, SupplierID = @SupplierID, SupplierName = @SupplierName, PaymentModeID = @PaymentModeID, PaymentMode = @PaymentMode, Total = @Total, Discount = @Discount, NetTotal = @NetTotal, PurchaseInvoiceDate = @PurchaseInvoiceDate, InventoryLocationID = @InventoryLocationID, InventoryLocationName = @InventoryLocationName, Username = @Username, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PurchaseInvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PurchaseInvoiceNo", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ReferenceNo", SqlDbType.VarChar, 50,"ReferenceNo"));
			UpdateCommand.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"SupplierID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 255,"SupplierName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@PaymentModeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PaymentModeID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PaymentMode", SqlDbType.NVarChar, 255,"PaymentMode"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PurchaseInvoiceDate", SqlDbType.DateTime, 8,"PurchaseInvoiceDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryLocationID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryLocationID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryLocationName", SqlDbType.VarChar, 10,"InventoryLocationName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM PurchaseInvoiceItem WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,PurchaseInvoiceNo,ReferenceNo,SupplierID,SupplierName,PaymentModeID,PaymentMode,Total,Discount,NetTotal,PurchaseInvoiceDate,InventoryLocationID,InventoryLocationName,Username,Status FROM PurchaseInvoiceItem";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,PurchaseInvoiceNo,ReferenceNo,SupplierID,SupplierName,PaymentModeID,PaymentMode,Total,Discount,NetTotal,PurchaseInvoiceDate,InventoryLocationID,InventoryLocationName,Username,Status FROM PurchaseInvoiceItem WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,PurchaseInvoiceNo,ReferenceNo,SupplierID,SupplierName,PaymentModeID,PaymentMode,Total,Discount,NetTotal,PurchaseInvoiceDate,InventoryLocationID,InventoryLocationName,Username,Status FROM PurchaseInvoiceItem WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //GetPurchaseInvoiceByLastID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT TOP 1* FROM  PurchaseInvoiceItem ORDER BY PurchaseInvoiceNo DESC";
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

		public PurchaseInvoiceItem GetPurchaseInvoiceItemByID(int ID)
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
		
		public DataSet GetPurchaseInvoiceItemByStatus(string status)
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
        public PurchaseInvoiceItem GetPurchaseInvoiceByLastID()
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
	    
		public int Insert(PurchaseInvoiceItem purchaseInvoiceItem)
		{
	InsertCommand.Parameters["@PurchaseInvoiceNo"].Value = purchaseInvoiceItem.PurchaseInvoiceNo;
	InsertCommand.Parameters["@ReferenceNo"].Value = purchaseInvoiceItem.ReferenceNo;
	InsertCommand.Parameters["@SupplierID"].Value = purchaseInvoiceItem.SupplierID;
	InsertCommand.Parameters["@SupplierName"].Value = purchaseInvoiceItem.SupplierName;
	InsertCommand.Parameters["@PaymentModeID"].Value = purchaseInvoiceItem.PaymentModeID;
	InsertCommand.Parameters["@PaymentMode"].Value = purchaseInvoiceItem.PaymentMode;
	InsertCommand.Parameters["@Total"].Value = purchaseInvoiceItem.Total;
	InsertCommand.Parameters["@Discount"].Value = purchaseInvoiceItem.Discount;
	InsertCommand.Parameters["@NetTotal"].Value = purchaseInvoiceItem.NetTotal;
	InsertCommand.Parameters["@PurchaseInvoiceDate"].Value = purchaseInvoiceItem.PurchaseInvoiceDate;
	InsertCommand.Parameters["@InventoryLocationID"].Value = purchaseInvoiceItem.InventoryLocationID;
	InsertCommand.Parameters["@InventoryLocationName"].Value = purchaseInvoiceItem.InventoryLocationName;
	InsertCommand.Parameters["@Username"].Value = purchaseInvoiceItem.Username;
	InsertCommand.Parameters["@Status"].Value = purchaseInvoiceItem.Status;
		
			
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
        
		public int Update(PurchaseInvoiceItem purchaseInvoiceItem)
		{
	UpdateCommand.Parameters["@ID"].Value = purchaseInvoiceItem.ID;
	UpdateCommand.Parameters["@PurchaseInvoiceNo"].Value = purchaseInvoiceItem.PurchaseInvoiceNo;
	UpdateCommand.Parameters["@ReferenceNo"].Value = purchaseInvoiceItem.ReferenceNo;
	UpdateCommand.Parameters["@SupplierID"].Value = purchaseInvoiceItem.SupplierID;
	UpdateCommand.Parameters["@SupplierName"].Value = purchaseInvoiceItem.SupplierName;
	UpdateCommand.Parameters["@PaymentModeID"].Value = purchaseInvoiceItem.PaymentModeID;
	UpdateCommand.Parameters["@PaymentMode"].Value = purchaseInvoiceItem.PaymentMode;
	UpdateCommand.Parameters["@Total"].Value = purchaseInvoiceItem.Total;
	UpdateCommand.Parameters["@Discount"].Value = purchaseInvoiceItem.Discount;
	UpdateCommand.Parameters["@NetTotal"].Value = purchaseInvoiceItem.NetTotal;
	UpdateCommand.Parameters["@PurchaseInvoiceDate"].Value = purchaseInvoiceItem.PurchaseInvoiceDate;
	UpdateCommand.Parameters["@InventoryLocationID"].Value = purchaseInvoiceItem.InventoryLocationID;
	UpdateCommand.Parameters["@InventoryLocationName"].Value = purchaseInvoiceItem.InventoryLocationName;
	UpdateCommand.Parameters["@Username"].Value = purchaseInvoiceItem.Username;
	UpdateCommand.Parameters["@Status"].Value = purchaseInvoiceItem.Status;

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
        
        private PurchaseInvoiceItem DataTableToEntity(DataTable dt)
        {
           
            PurchaseInvoiceItem purchaseInvoiceItem = new PurchaseInvoiceItem();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						purchaseInvoiceItem.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						purchaseInvoiceItem.ID=0;
					}
					if (Null.IsNotNull(dr["PurchaseInvoiceNo"]))
					{
						purchaseInvoiceItem.PurchaseInvoiceNo=Convert.ToInt32(dr["PurchaseInvoiceNo"]);
					}
					else
					{
						purchaseInvoiceItem.PurchaseInvoiceNo=0;
					}
					if (Null.IsNotNull(dr["ReferenceNo"]))
					{
						purchaseInvoiceItem.ReferenceNo= Convert.ToString(dr["ReferenceNo"]);
					}
					else
					{
						purchaseInvoiceItem.ReferenceNo=string.Empty;
					}
					if (Null.IsNotNull(dr["SupplierID"]))
					{
						purchaseInvoiceItem.SupplierID=Convert.ToInt32(dr["SupplierID"]);
					}
					else
					{
						purchaseInvoiceItem.SupplierID=0;
					}
					if (Null.IsNotNull(dr["SupplierName"]))
					{
						purchaseInvoiceItem.SupplierName= Convert.ToString(dr["SupplierName"]);
					}
					else
					{
						purchaseInvoiceItem.SupplierName=string.Empty;
					}
					if (Null.IsNotNull(dr["PaymentModeID"]))
					{
						purchaseInvoiceItem.PaymentModeID=Convert.ToInt32(dr["PaymentModeID"]);
					}
					else
					{
						purchaseInvoiceItem.PaymentModeID=0;
					}
					if (Null.IsNotNull(dr["PaymentMode"]))
					{
						purchaseInvoiceItem.PaymentMode= Convert.ToString(dr["PaymentMode"]);
					}
					else
					{
						purchaseInvoiceItem.PaymentMode=string.Empty;
					}
					if (Null.IsNotNull(dr["Total"]))
					{
						purchaseInvoiceItem.Total= Convert.ToDecimal(dr["Total"]);
					}
					else
					{
						purchaseInvoiceItem.Total=0.00m;
					}
					if (Null.IsNotNull(dr["Discount"]))
					{
						purchaseInvoiceItem.Discount= Convert.ToDecimal(dr["Discount"]);
					}
					else
					{
						purchaseInvoiceItem.Discount=0.00m;
					}
					if (Null.IsNotNull(dr["NetTotal"]))
					{
						purchaseInvoiceItem.NetTotal= Convert.ToDecimal(dr["NetTotal"]);
					}
					else
					{
						purchaseInvoiceItem.NetTotal=0.00m;
					}
					if (Null.IsNotNull(dr["PurchaseInvoiceDate"]))
					{
						purchaseInvoiceItem.PurchaseInvoiceDate= Convert.ToDateTime(dr["PurchaseInvoiceDate"]);
					}
					else
					{
						purchaseInvoiceItem.PurchaseInvoiceDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["InventoryLocationID"]))
					{
						purchaseInvoiceItem.InventoryLocationID=Convert.ToInt32(dr["InventoryLocationID"]);
					}
					else
					{
						purchaseInvoiceItem.InventoryLocationID=0;
					}
					if (Null.IsNotNull(dr["InventoryLocationName"]))
					{
						purchaseInvoiceItem.InventoryLocationName= Convert.ToString(dr["InventoryLocationName"]);
					}
					else
					{
						purchaseInvoiceItem.InventoryLocationName=string.Empty;
					}
					if (Null.IsNotNull(dr["Username"]))
					{
						purchaseInvoiceItem.Username= Convert.ToString(dr["Username"]);
					}
					else
					{
						purchaseInvoiceItem.Username=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						purchaseInvoiceItem.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						purchaseInvoiceItem.Status=string.Empty;
					}
 
                }
            }
            return purchaseInvoiceItem ;
        }
		#endregion		
	}
}