using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class SaleInvoiceTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public SaleInvoiceTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO SaleInvoice(ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status) VALUES (@ReferenceNo,@InventoryItemID,@ItemName,@Description,@Price,@Qty,@Amount,@Status);SELECT ID FROM SaleInvoice WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@ReferenceNo", SqlDbType.VarChar, 50,"ReferenceNo"));
			InsertCommand.Parameters.Add(new SqlParameter("@InventoryItemID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryItemID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar, 50,"ItemName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			InsertCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Price", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Amount", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE SaleInvoice SET ReferenceNo = @ReferenceNo, InventoryItemID = @InventoryItemID, ItemName = @ItemName, Description = @Description, Price = @Price, Qty = @Qty, Amount = @Amount, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ReferenceNo", SqlDbType.VarChar, 50,"ReferenceNo"));
			UpdateCommand.Parameters.Add(new SqlParameter("@InventoryItemID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InventoryItemID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar, 50,"ItemName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Price", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Amount", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM SaleInvoice WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[3];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status FROM SaleInvoice";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status FROM SaleInvoice WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status FROM SaleInvoice WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			
			
			
			
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

		public SaleInvoice GetSaleInvoiceByID(int ID)
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
		
		public DataSet GetSaleInvoiceByStatus(string status)
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
		
		
		
		
		
		#endregion CustomGetTable
	    
		public int Insert(SaleInvoice saleInvoice)
		{
	InsertCommand.Parameters["@ReferenceNo"].Value = saleInvoice.ReferenceNo;
	InsertCommand.Parameters["@InventoryItemID"].Value = saleInvoice.InventoryItemID;
	InsertCommand.Parameters["@ItemName"].Value = saleInvoice.ItemName;
	InsertCommand.Parameters["@Description"].Value = saleInvoice.Description;
	InsertCommand.Parameters["@Price"].Value = saleInvoice.Price;
	InsertCommand.Parameters["@Qty"].Value = saleInvoice.Qty;
	InsertCommand.Parameters["@Amount"].Value = saleInvoice.Amount;
	InsertCommand.Parameters["@Status"].Value = saleInvoice.Status;
		
			
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
        
		public int Update(SaleInvoice saleInvoice)
		{
	UpdateCommand.Parameters["@ID"].Value = saleInvoice.ID;
	UpdateCommand.Parameters["@ReferenceNo"].Value = saleInvoice.ReferenceNo;
	UpdateCommand.Parameters["@InventoryItemID"].Value = saleInvoice.InventoryItemID;
	UpdateCommand.Parameters["@ItemName"].Value = saleInvoice.ItemName;
	UpdateCommand.Parameters["@Description"].Value = saleInvoice.Description;
	UpdateCommand.Parameters["@Price"].Value = saleInvoice.Price;
	UpdateCommand.Parameters["@Qty"].Value = saleInvoice.Qty;
	UpdateCommand.Parameters["@Amount"].Value = saleInvoice.Amount;
	UpdateCommand.Parameters["@Status"].Value = saleInvoice.Status;

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
        
        private SaleInvoice DataTableToEntity(DataTable dt)
        {
           
            SaleInvoice saleInvoice = new SaleInvoice();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						saleInvoice.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						saleInvoice.ID=0;
					}
					if (Null.IsNotNull(dr["ReferenceNo"]))
					{
						saleInvoice.ReferenceNo= Convert.ToString(dr["ReferenceNo"]);
					}
					else
					{
						saleInvoice.ReferenceNo=string.Empty;
					}
					if (Null.IsNotNull(dr["InventoryItemID"]))
					{
						saleInvoice.InventoryItemID=Convert.ToInt32(dr["InventoryItemID"]);
					}
					else
					{
						saleInvoice.InventoryItemID=0;
					}
					if (Null.IsNotNull(dr["ItemName"]))
					{
						saleInvoice.ItemName= Convert.ToString(dr["ItemName"]);
					}
					else
					{
						saleInvoice.ItemName=string.Empty;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						saleInvoice.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						saleInvoice.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["Price"]))
					{
						saleInvoice.Price= Convert.ToDecimal(dr["Price"]);
					}
					else
					{
						saleInvoice.Price=0.00m;
					}
					if (Null.IsNotNull(dr["Qty"]))
					{
						saleInvoice.Qty=Convert.ToInt32(dr["Qty"]);
					}
					else
					{
						saleInvoice.Qty=0;
					}
					if (Null.IsNotNull(dr["Amount"]))
					{
						saleInvoice.Amount= Convert.ToDecimal(dr["Amount"]);
					}
					else
					{
						saleInvoice.Amount=0.00m;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						saleInvoice.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						saleInvoice.Status=string.Empty;
					}
 
                }
            }
            return saleInvoice ;
        }
		#endregion		
	}
}