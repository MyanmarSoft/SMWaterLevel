using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class InventoryItemTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public InventoryItemTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO InventoryItem(ItemCode,ItemName,UnitID,UnitName,PurchasePrice,SalePrice,Description,CustomIncomeAccountID,CustomIncomeAccountName,CustomExpenseAccountID,CustomExpenseAccountName,QtyToReceive,QtyOnHand,QtyToDeliver,QtyOwned,AverageCost,TotalCost,CreatedDate,Status) VALUES (@ItemCode,@ItemName,@UnitID,@UnitName,@PurchasePrice,@SalePrice,@Description,@CustomIncomeAccountID,@CustomIncomeAccountName,@CustomExpenseAccountID,@CustomExpenseAccountName,@QtyToReceive,@QtyOnHand,@QtyToDeliver,@QtyOwned,@AverageCost,@TotalCost,@CreatedDate,@Status);SELECT ID FROM InventoryItem WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@ItemCode", SqlDbType.VarChar, 50,"ItemCode"));
			InsertCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar, 100,"ItemName"));
			InsertCommand.Parameters.Add(new SqlParameter("@UnitID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"UnitID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@UnitName", SqlDbType.VarChar, 10,"UnitName"));
			InsertCommand.Parameters.Add(new SqlParameter("@PurchasePrice", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "PurchasePrice", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@SalePrice", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "SalePrice", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 200,"Description"));
			InsertCommand.Parameters.Add(new SqlParameter("@CustomIncomeAccountID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CustomIncomeAccountID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@CustomIncomeAccountName", SqlDbType.VarChar, 50,"CustomIncomeAccountName"));
			InsertCommand.Parameters.Add(new SqlParameter("@CustomExpenseAccountID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CustomExpenseAccountID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@CustomExpenseAccountName", SqlDbType.VarChar, 50,"CustomExpenseAccountName"));
			InsertCommand.Parameters.Add(new SqlParameter("@QtyToReceive", SqlDbType.VarChar, 50,"QtyToReceive"));
			InsertCommand.Parameters.Add(new SqlParameter("@QtyOnHand", SqlDbType.VarChar, 50,"QtyOnHand"));
			InsertCommand.Parameters.Add(new SqlParameter("@QtyToDeliver", SqlDbType.VarChar, 50,"QtyToDeliver"));
			InsertCommand.Parameters.Add(new SqlParameter("@QtyOwned", SqlDbType.VarChar, 50,"QtyOwned"));
			InsertCommand.Parameters.Add(new SqlParameter("@AverageCost", SqlDbType.VarChar, 50,"AverageCost"));
			InsertCommand.Parameters.Add(new SqlParameter("@TotalCost", SqlDbType.VarChar, 50,"TotalCost"));
			InsertCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE InventoryItem SET ItemCode = @ItemCode, ItemName = @ItemName, UnitID = @UnitID, UnitName = @UnitName, PurchasePrice = @PurchasePrice, SalePrice = @SalePrice, Description = @Description, CustomIncomeAccountID = @CustomIncomeAccountID, CustomIncomeAccountName = @CustomIncomeAccountName, CustomExpenseAccountID = @CustomExpenseAccountID, CustomExpenseAccountName = @CustomExpenseAccountName, QtyToReceive = @QtyToReceive, QtyOnHand = @QtyOnHand, QtyToDeliver = @QtyToDeliver, QtyOwned = @QtyOwned, AverageCost = @AverageCost, TotalCost = @TotalCost, CreatedDate = @CreatedDate, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemCode", SqlDbType.VarChar, 50,"ItemCode"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar, 100,"ItemName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"UnitID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitName", SqlDbType.VarChar, 10,"UnitName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@PurchasePrice", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "PurchasePrice", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@SalePrice", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "SalePrice", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 200,"Description"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomIncomeAccountID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CustomIncomeAccountID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomIncomeAccountName", SqlDbType.VarChar, 50,"CustomIncomeAccountName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomExpenseAccountID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CustomExpenseAccountID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CustomExpenseAccountName", SqlDbType.VarChar, 50,"CustomExpenseAccountName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@QtyToReceive", SqlDbType.VarChar, 50,"QtyToReceive"));
			UpdateCommand.Parameters.Add(new SqlParameter("@QtyOnHand", SqlDbType.VarChar, 50,"QtyOnHand"));
			UpdateCommand.Parameters.Add(new SqlParameter("@QtyToDeliver", SqlDbType.VarChar, 50,"QtyToDeliver"));
			UpdateCommand.Parameters.Add(new SqlParameter("@QtyOwned", SqlDbType.VarChar, 50,"QtyOwned"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AverageCost", SqlDbType.VarChar, 50,"AverageCost"));
			UpdateCommand.Parameters.Add(new SqlParameter("@TotalCost", SqlDbType.VarChar, 50,"TotalCost"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8,"CreatedDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM InventoryItem WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,ItemCode,ItemName,UnitID,UnitName,PurchasePrice,SalePrice,Description,CustomIncomeAccountID,CustomIncomeAccountName,CustomExpenseAccountID,CustomExpenseAccountName,QtyToReceive,QtyOnHand,QtyToDeliver,QtyOwned,AverageCost,TotalCost,CreatedDate,Status FROM InventoryItem";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,ItemCode,ItemName,UnitID,UnitName,PurchasePrice,SalePrice,Description,CustomIncomeAccountID,CustomIncomeAccountName,CustomExpenseAccountID,CustomExpenseAccountName,QtyToReceive,QtyOnHand,QtyToDeliver,QtyOwned,AverageCost,TotalCost,CreatedDate,Status FROM InventoryItem WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,ItemCode,ItemName,UnitID,UnitName,PurchasePrice,SalePrice,Description,CustomIncomeAccountID,CustomIncomeAccountName,CustomExpenseAccountID,CustomExpenseAccountName,QtyToReceive,QtyOnHand,QtyToDeliver,QtyOwned,AverageCost,TotalCost,CreatedDate,Status FROM InventoryItem WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			

            //GetSearchByInventoryItem
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,ItemCode,ItemName,UnitID,UnitName,PurchasePrice,SalePrice,Description,CustomIncomeAccountID,CustomIncomeAccountName,CustomExpenseAccountID,CustomExpenseAccountName,QtyToReceive,QtyOnHand,QtyToDeliver,QtyOwned,AverageCost,TotalCost,CreatedDate,Status FROM InventoryItem WHERE ItemCode LIKE '%' + @ItemCode + '%' AND Status =  @Status OR ItemName LIKE '%' + @ItemName + '%' AND Status = @Status OR PurchasePrice LIKE '%' + @PurchasePrice + '%' AND Status = @Status OR SalePrice LIKE '%' + @SalePrice + '%' AND Status = @Status OR Description LIKE '%' + @Description + '%' AND Status = @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ItemCode", SqlDbType.VarChar, 50, "ItemCode"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar, 50, "ItemName"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@PurchasePrice", SqlDbType.VarChar, 50, "PurchasePrice"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@SalePrice", SqlDbType.VarChar, 50, "SalePrice"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 200, "Description"));
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

		public InventoryItem GetInventoryItemByID(int ID)
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
		
		public DataSet GetInventoryItemByStatus(string status)
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
		
        public DataSet GetSearchByInventoryItem(string itemCode,string itemName,string purchasePrice,string salePrice, string description, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = itemCode;
            Adapter.SelectCommand.Parameters[1].Value = itemName;
            Adapter.SelectCommand.Parameters[2].Value = purchasePrice;
            Adapter.SelectCommand.Parameters[3].Value = salePrice;
            Adapter.SelectCommand.Parameters[4].Value = description;
            Adapter.SelectCommand.Parameters[5].Value = status;


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
	    
		public int Insert(InventoryItem inventoryItem)
		{
	InsertCommand.Parameters["@ItemCode"].Value = inventoryItem.ItemCode;
	InsertCommand.Parameters["@ItemName"].Value = inventoryItem.ItemName;
	InsertCommand.Parameters["@UnitID"].Value = inventoryItem.UnitID;
	InsertCommand.Parameters["@UnitName"].Value = inventoryItem.UnitName;
	InsertCommand.Parameters["@PurchasePrice"].Value = inventoryItem.PurchasePrice;
	InsertCommand.Parameters["@SalePrice"].Value = inventoryItem.SalePrice;
	InsertCommand.Parameters["@Description"].Value = inventoryItem.Description;
	InsertCommand.Parameters["@CustomIncomeAccountID"].Value = inventoryItem.CustomIncomeAccountID;
	InsertCommand.Parameters["@CustomIncomeAccountName"].Value = inventoryItem.CustomIncomeAccountName;
	InsertCommand.Parameters["@CustomExpenseAccountID"].Value = inventoryItem.CustomExpenseAccountID;
	InsertCommand.Parameters["@CustomExpenseAccountName"].Value = inventoryItem.CustomExpenseAccountName;
	InsertCommand.Parameters["@QtyToReceive"].Value = inventoryItem.QtyToReceive;
	InsertCommand.Parameters["@QtyOnHand"].Value = inventoryItem.QtyOnHand;
	InsertCommand.Parameters["@QtyToDeliver"].Value = inventoryItem.QtyToDeliver;
	InsertCommand.Parameters["@QtyOwned"].Value = inventoryItem.QtyOwned;
	InsertCommand.Parameters["@AverageCost"].Value = inventoryItem.AverageCost;
	InsertCommand.Parameters["@TotalCost"].Value = inventoryItem.TotalCost;
	InsertCommand.Parameters["@CreatedDate"].Value = inventoryItem.CreatedDate;
	InsertCommand.Parameters["@Status"].Value = inventoryItem.Status;
		
			
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
        
		public int Update(InventoryItem inventoryItem)
		{
	UpdateCommand.Parameters["@ID"].Value = inventoryItem.ID;
	UpdateCommand.Parameters["@ItemCode"].Value = inventoryItem.ItemCode;
	UpdateCommand.Parameters["@ItemName"].Value = inventoryItem.ItemName;
	UpdateCommand.Parameters["@UnitID"].Value = inventoryItem.UnitID;
	UpdateCommand.Parameters["@UnitName"].Value = inventoryItem.UnitName;
	UpdateCommand.Parameters["@PurchasePrice"].Value = inventoryItem.PurchasePrice;
	UpdateCommand.Parameters["@SalePrice"].Value = inventoryItem.SalePrice;
	UpdateCommand.Parameters["@Description"].Value = inventoryItem.Description;
	UpdateCommand.Parameters["@CustomIncomeAccountID"].Value = inventoryItem.CustomIncomeAccountID;
	UpdateCommand.Parameters["@CustomIncomeAccountName"].Value = inventoryItem.CustomIncomeAccountName;
	UpdateCommand.Parameters["@CustomExpenseAccountID"].Value = inventoryItem.CustomExpenseAccountID;
	UpdateCommand.Parameters["@CustomExpenseAccountName"].Value = inventoryItem.CustomExpenseAccountName;
	UpdateCommand.Parameters["@QtyToReceive"].Value = inventoryItem.QtyToReceive;
	UpdateCommand.Parameters["@QtyOnHand"].Value = inventoryItem.QtyOnHand;
	UpdateCommand.Parameters["@QtyToDeliver"].Value = inventoryItem.QtyToDeliver;
	UpdateCommand.Parameters["@QtyOwned"].Value = inventoryItem.QtyOwned;
	UpdateCommand.Parameters["@AverageCost"].Value = inventoryItem.AverageCost;
	UpdateCommand.Parameters["@TotalCost"].Value = inventoryItem.TotalCost;
	UpdateCommand.Parameters["@CreatedDate"].Value = inventoryItem.CreatedDate;
	UpdateCommand.Parameters["@Status"].Value = inventoryItem.Status;

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
        
        private InventoryItem DataTableToEntity(DataTable dt)
        {
           
            InventoryItem inventoryItem = new InventoryItem();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						inventoryItem.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						inventoryItem.ID=0;
					}
					if (Null.IsNotNull(dr["ItemCode"]))
					{
						inventoryItem.ItemCode= Convert.ToString(dr["ItemCode"]);
					}
					else
					{
						inventoryItem.ItemCode=string.Empty;
					}
					if (Null.IsNotNull(dr["ItemName"]))
					{
						inventoryItem.ItemName= Convert.ToString(dr["ItemName"]);
					}
					else
					{
						inventoryItem.ItemName=string.Empty;
					}
					if (Null.IsNotNull(dr["UnitID"]))
					{
						inventoryItem.UnitID=Convert.ToInt32(dr["UnitID"]);
					}
					else
					{
						inventoryItem.UnitID=0;
					}
					if (Null.IsNotNull(dr["UnitName"]))
					{
						inventoryItem.UnitName= Convert.ToString(dr["UnitName"]);
					}
					else
					{
						inventoryItem.UnitName=string.Empty;
					}
					if (Null.IsNotNull(dr["PurchasePrice"]))
					{
						inventoryItem.PurchasePrice= Convert.ToDecimal(dr["PurchasePrice"]);
					}
					else
					{
						inventoryItem.PurchasePrice=0.00m;
					}
					if (Null.IsNotNull(dr["SalePrice"]))
					{
						inventoryItem.SalePrice= Convert.ToDecimal(dr["SalePrice"]);
					}
					else
					{
						inventoryItem.SalePrice=0.00m;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						inventoryItem.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						inventoryItem.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["CustomIncomeAccountID"]))
					{
						inventoryItem.CustomIncomeAccountID=Convert.ToInt32(dr["CustomIncomeAccountID"]);
					}
					else
					{
						inventoryItem.CustomIncomeAccountID=0;
					}
					if (Null.IsNotNull(dr["CustomIncomeAccountName"]))
					{
						inventoryItem.CustomIncomeAccountName= Convert.ToString(dr["CustomIncomeAccountName"]);
					}
					else
					{
						inventoryItem.CustomIncomeAccountName=string.Empty;
					}
					if (Null.IsNotNull(dr["CustomExpenseAccountID"]))
					{
						inventoryItem.CustomExpenseAccountID=Convert.ToInt32(dr["CustomExpenseAccountID"]);
					}
					else
					{
						inventoryItem.CustomExpenseAccountID=0;
					}
					if (Null.IsNotNull(dr["CustomExpenseAccountName"]))
					{
						inventoryItem.CustomExpenseAccountName= Convert.ToString(dr["CustomExpenseAccountName"]);
					}
					else
					{
						inventoryItem.CustomExpenseAccountName=string.Empty;
					}
					if (Null.IsNotNull(dr["QtyToReceive"]))
					{
						inventoryItem.QtyToReceive= Convert.ToString(dr["QtyToReceive"]);
					}
					else
					{
						inventoryItem.QtyToReceive=string.Empty;
					}
					if (Null.IsNotNull(dr["QtyOnHand"]))
					{
						inventoryItem.QtyOnHand= Convert.ToString(dr["QtyOnHand"]);
					}
					else
					{
						inventoryItem.QtyOnHand=string.Empty;
					}
					if (Null.IsNotNull(dr["QtyToDeliver"]))
					{
						inventoryItem.QtyToDeliver= Convert.ToString(dr["QtyToDeliver"]);
					}
					else
					{
						inventoryItem.QtyToDeliver=string.Empty;
					}
					if (Null.IsNotNull(dr["QtyOwned"]))
					{
						inventoryItem.QtyOwned= Convert.ToString(dr["QtyOwned"]);
					}
					else
					{
						inventoryItem.QtyOwned=string.Empty;
					}
					if (Null.IsNotNull(dr["AverageCost"]))
					{
						inventoryItem.AverageCost= Convert.ToString(dr["AverageCost"]);
					}
					else
					{
						inventoryItem.AverageCost=string.Empty;
					}
					if (Null.IsNotNull(dr["TotalCost"]))
					{
						inventoryItem.TotalCost= Convert.ToString(dr["TotalCost"]);
					}
					else
					{
						inventoryItem.TotalCost=string.Empty;
					}
					if (Null.IsNotNull(dr["CreatedDate"]))
					{
						inventoryItem.CreatedDate= Convert.ToDateTime(dr["CreatedDate"]);
					}
					else
					{
						inventoryItem.CreatedDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						inventoryItem.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						inventoryItem.Status=string.Empty;
					}
 
                }
            }
            return inventoryItem ;
        }
		#endregion		
	}
}