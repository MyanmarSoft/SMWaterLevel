using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class SaleQuotationTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public SaleQuotationTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO SaleQuotation(ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status) VALUES (@ReferenceNo,@InventoryItemID,@ItemName,@Description,@Price,@Qty,@Amount,@Status);SELECT ID FROM SaleQuotation WHERE (ID = SCOPE_IDENTITY())";
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
			UpdateCommand.CommandText = @"UPDATE SaleQuotation SET ReferenceNo = @ReferenceNo, InventoryItemID = @InventoryItemID, ItemName = @ItemName, Description = @Description, Price = @Price, Qty = @Qty, Amount = @Amount, Status = @Status WHERE (ID = @ID)";
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
			DeleteCommand.CommandText = "DELETE FROM SaleQuotation WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[3];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status FROM SaleQuotation";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status FROM SaleQuotation WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ReferenceNo,InventoryItemID,ItemName,Description,Price,Qty,Amount,Status FROM SaleQuotation WHERE Status =  @Status";
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

		public SaleQuotation GetSaleQuotationByID(int ID)
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
		
		public DataSet GetSaleQuotationByStatus(string status)
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
	    
		public int Insert(SaleQuotation saleQuotation)
		{
	InsertCommand.Parameters["@ReferenceNo"].Value = saleQuotation.ReferenceNo;
	InsertCommand.Parameters["@InventoryItemID"].Value = saleQuotation.InventoryItemID;
	InsertCommand.Parameters["@ItemName"].Value = saleQuotation.ItemName;
	InsertCommand.Parameters["@Description"].Value = saleQuotation.Description;
	InsertCommand.Parameters["@Price"].Value = saleQuotation.Price;
	InsertCommand.Parameters["@Qty"].Value = saleQuotation.Qty;
	InsertCommand.Parameters["@Amount"].Value = saleQuotation.Amount;
	InsertCommand.Parameters["@Status"].Value = saleQuotation.Status;
		
			
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
        
		public int Update(SaleQuotation saleQuotation)
		{
	UpdateCommand.Parameters["@ID"].Value = saleQuotation.ID;
	UpdateCommand.Parameters["@ReferenceNo"].Value = saleQuotation.ReferenceNo;
	UpdateCommand.Parameters["@InventoryItemID"].Value = saleQuotation.InventoryItemID;
	UpdateCommand.Parameters["@ItemName"].Value = saleQuotation.ItemName;
	UpdateCommand.Parameters["@Description"].Value = saleQuotation.Description;
	UpdateCommand.Parameters["@Price"].Value = saleQuotation.Price;
	UpdateCommand.Parameters["@Qty"].Value = saleQuotation.Qty;
	UpdateCommand.Parameters["@Amount"].Value = saleQuotation.Amount;
	UpdateCommand.Parameters["@Status"].Value = saleQuotation.Status;

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
        
        private SaleQuotation DataTableToEntity(DataTable dt)
        {
           
            SaleQuotation saleQuotation = new SaleQuotation();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						saleQuotation.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						saleQuotation.ID=0;
					}
					if (Null.IsNotNull(dr["ReferenceNo"]))
					{
						saleQuotation.ReferenceNo= Convert.ToString(dr["ReferenceNo"]);
					}
					else
					{
						saleQuotation.ReferenceNo=string.Empty;
					}
					if (Null.IsNotNull(dr["InventoryItemID"]))
					{
						saleQuotation.InventoryItemID=Convert.ToInt32(dr["InventoryItemID"]);
					}
					else
					{
						saleQuotation.InventoryItemID=0;
					}
					if (Null.IsNotNull(dr["ItemName"]))
					{
						saleQuotation.ItemName= Convert.ToString(dr["ItemName"]);
					}
					else
					{
						saleQuotation.ItemName=string.Empty;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						saleQuotation.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						saleQuotation.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["Price"]))
					{
						saleQuotation.Price= Convert.ToDecimal(dr["Price"]);
					}
					else
					{
						saleQuotation.Price=0.00m;
					}
					if (Null.IsNotNull(dr["Qty"]))
					{
						saleQuotation.Qty=Convert.ToInt32(dr["Qty"]);
					}
					else
					{
						saleQuotation.Qty=0;
					}
					if (Null.IsNotNull(dr["Amount"]))
					{
						saleQuotation.Amount= Convert.ToDecimal(dr["Amount"]);
					}
					else
					{
						saleQuotation.Amount=0.00m;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						saleQuotation.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						saleQuotation.Status=string.Empty;
					}
 
                }
            }
            return saleQuotation ;
        }
		#endregion		
	}
}