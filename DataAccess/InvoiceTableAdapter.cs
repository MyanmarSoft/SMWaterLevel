using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class InvoiceTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public InvoiceTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO Invoice(InvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status) VALUES (@InvoiceNo,@ItemCategoryID,@ItemTypeID,@Description,@UnitCost,@Qty,@UnitType,@AmountCost,@Status);SELECT ID FROM Invoice WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InvoiceNo", System.Data.DataRowVersion.Current, null));
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
			UpdateCommand.CommandText = @"UPDATE Invoice SET InvoiceNo = @InvoiceNo, ItemCategoryID = @ItemCategoryID, ItemTypeID = @ItemTypeID, Description = @Description, UnitCost = @UnitCost, Qty = @Qty, UnitType = @UnitType, AmountCost = @AmountCost, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InvoiceNo", System.Data.DataRowVersion.Current, null));
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
			DeleteCommand.CommandText = "DELETE FROM Invoice WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[6];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,InvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM Invoice";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,InvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM Invoice WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,InvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM Invoice WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			
			//GetInvoiceByLastID

            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT TOP 1 * FROM Invoice ORDER BY ID DESC";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;

            //GetInvoiceByInvoiceNo
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,InvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM Invoice WHERE InvoiceNo =  @InvoiceNo";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, "InvoiceNo"));

            //GetDataByInvoiceNo
            CommandCollection[5] = new SqlCommand();
            ((SqlCommand)(CommandCollection[5])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[5])).CommandText = "SELECT ID,InvoiceNo,ItemCategoryID,ItemTypeID,Description,UnitCost,Qty,UnitType,AmountCost,Status FROM Invoice WHERE InvoiceNo =  @InvoiceNo AND Status=@Status";
            ((SqlCommand)(CommandCollection[5])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[5])).Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, "InvoiceNo"));
            ((SqlCommand)(this.CommandCollection[5])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10, "Status"));
			
			
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

		public Invoice GetInvoiceByID(int ID)
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
		
		public DataSet GetInvoiceByStatus(string status)
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
		
		

        public Invoice GetInvoiceByLastID()
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

        public Invoice GetInvoiceByInvoiceNo(int invoiceNo)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = invoiceNo;

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


        public DataTable GetDataByInvoiceNo(int invoiceNo, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[5]));
            Adapter.SelectCommand.Parameters["@InvoiceNo"].Value = invoiceNo;
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
	    
		public int Insert(Invoice invoice)
		{
	InsertCommand.Parameters["@InvoiceNo"].Value = invoice.InvoiceNo;
	InsertCommand.Parameters["@ItemCategoryID"].Value = invoice.ItemCategoryID;
	InsertCommand.Parameters["@ItemTypeID"].Value = invoice.ItemTypeID;
	InsertCommand.Parameters["@Description"].Value = invoice.Description;
	InsertCommand.Parameters["@UnitCost"].Value = invoice.UnitCost;
	InsertCommand.Parameters["@Qty"].Value = invoice.Qty;
	InsertCommand.Parameters["@UnitType"].Value = invoice.UnitType;
	InsertCommand.Parameters["@AmountCost"].Value = invoice.AmountCost;
	InsertCommand.Parameters["@Status"].Value = invoice.Status;
		
			
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
        
		public int Update(Invoice invoice)
		{
	UpdateCommand.Parameters["@ID"].Value = invoice.ID;
	UpdateCommand.Parameters["@InvoiceNo"].Value = invoice.InvoiceNo;
	UpdateCommand.Parameters["@ItemCategoryID"].Value = invoice.ItemCategoryID;
	UpdateCommand.Parameters["@ItemTypeID"].Value = invoice.ItemTypeID;
	UpdateCommand.Parameters["@Description"].Value = invoice.Description;
	UpdateCommand.Parameters["@UnitCost"].Value = invoice.UnitCost;
	UpdateCommand.Parameters["@Qty"].Value = invoice.Qty;
	UpdateCommand.Parameters["@UnitType"].Value = invoice.UnitType;
	UpdateCommand.Parameters["@AmountCost"].Value = invoice.AmountCost;
	UpdateCommand.Parameters["@Status"].Value = invoice.Status;

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
        
        private Invoice DataTableToEntity(DataTable dt)
        {
           
            Invoice invoice = new Invoice();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						invoice.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						invoice.ID=0;
					}
					if (Null.IsNotNull(dr["InvoiceNo"]))
					{
						invoice.InvoiceNo=Convert.ToInt32(dr["InvoiceNo"]);
					}
					else
					{
						invoice.InvoiceNo=0;
					}
					if (Null.IsNotNull(dr["ItemCategoryID"]))
					{
						invoice.ItemCategoryID=Convert.ToInt32(dr["ItemCategoryID"]);
					}
					else
					{
						invoice.ItemCategoryID=0;
					}
					if (Null.IsNotNull(dr["ItemTypeID"]))
					{
						invoice.ItemTypeID=Convert.ToInt32(dr["ItemTypeID"]);
					}
					else
					{
						invoice.ItemTypeID=0;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						invoice.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						invoice.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["UnitCost"]))
					{
						invoice.UnitCost= Convert.ToDecimal(dr["UnitCost"]);
					}
					else
					{
						invoice.UnitCost=0.00m;
					}
					if (Null.IsNotNull(dr["Qty"]))
					{
						invoice.Qty=Convert.ToInt32(dr["Qty"]);
					}
					else
					{
						invoice.Qty=0;
					}
					if (Null.IsNotNull(dr["UnitType"]))
					{
						invoice.UnitType= Convert.ToString(dr["UnitType"]);
					}
					else
					{
						invoice.UnitType=string.Empty;
					}
					if (Null.IsNotNull(dr["AmountCost"]))
					{
						invoice.AmountCost= Convert.ToDecimal(dr["AmountCost"]);
					}
					else
					{
						invoice.AmountCost=0.00m;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						invoice.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						invoice.Status=string.Empty;
					}
 
                }
            }
            return invoice ;
        }
		#endregion		
	}
}