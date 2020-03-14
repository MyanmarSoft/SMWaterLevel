using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class UltrasoundInvoiceTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public UltrasoundInvoiceTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO UltrasoundInvoice(InvoiceNo,ItemTypeID,Description,UnitCost,Qty,AmountCost,Status) VALUES (@InvoiceNo,@ItemTypeID,@Description,@UnitCost,@Qty,@AmountCost,@Status);SELECT ID FROM UltrasoundInvoice WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InvoiceNo", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@ItemTypeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemTypeID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			InsertCommand.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "UnitCost", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@AmountCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "AmountCost", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE UltrasoundInvoice SET InvoiceNo = @InvoiceNo, ItemTypeID = @ItemTypeID, Description = @Description, UnitCost = @UnitCost, Qty = @Qty, AmountCost = @AmountCost, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InvoiceNo", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@ItemTypeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"ItemTypeID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 255,"Description"));
			UpdateCommand.Parameters.Add(new SqlParameter("@UnitCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "UnitCost", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"Qty", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@AmountCost", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "AmountCost", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM UltrasoundInvoice WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,InvoiceNo,ItemTypeID,Description,UnitCost,Qty,AmountCost,Status FROM UltrasoundInvoice";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,InvoiceNo,ItemTypeID,Description,UnitCost,Qty,AmountCost,Status FROM UltrasoundInvoice WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,InvoiceNo,ItemTypeID,Description,UnitCost,Qty,AmountCost,Status FROM UltrasoundInvoice WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			//GetUltrasoundInvoiceByLastID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT TOP 1* FROM  UltrasoundInvoice ORDER BY InvoiceNo DESC";
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

		public UltrasoundInvoice GetUltrasoundInvoiceByID(int ID)
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
		
		public DataSet GetUltrasoundInvoiceByStatus(string status)
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

        public UltrasoundInvoice GetUltrasoundInvoiceByLastID()
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
	    
		public int Insert(UltrasoundInvoice ultrasoundInvoice)
		{
	InsertCommand.Parameters["@InvoiceNo"].Value = ultrasoundInvoice.InvoiceNo;
	InsertCommand.Parameters["@ItemTypeID"].Value = ultrasoundInvoice.ItemTypeID;
	InsertCommand.Parameters["@Description"].Value = ultrasoundInvoice.Description;
	InsertCommand.Parameters["@UnitCost"].Value = ultrasoundInvoice.UnitCost;
	InsertCommand.Parameters["@Qty"].Value = ultrasoundInvoice.Qty;
	InsertCommand.Parameters["@AmountCost"].Value = ultrasoundInvoice.AmountCost;
	InsertCommand.Parameters["@Status"].Value = ultrasoundInvoice.Status;
		
			
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
        
		public int Update(UltrasoundInvoice ultrasoundInvoice)
		{
	UpdateCommand.Parameters["@ID"].Value = ultrasoundInvoice.ID;
	UpdateCommand.Parameters["@InvoiceNo"].Value = ultrasoundInvoice.InvoiceNo;
	UpdateCommand.Parameters["@ItemTypeID"].Value = ultrasoundInvoice.ItemTypeID;
	UpdateCommand.Parameters["@Description"].Value = ultrasoundInvoice.Description;
	UpdateCommand.Parameters["@UnitCost"].Value = ultrasoundInvoice.UnitCost;
	UpdateCommand.Parameters["@Qty"].Value = ultrasoundInvoice.Qty;
	UpdateCommand.Parameters["@AmountCost"].Value = ultrasoundInvoice.AmountCost;
	UpdateCommand.Parameters["@Status"].Value = ultrasoundInvoice.Status;

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
        
        private UltrasoundInvoice DataTableToEntity(DataTable dt)
        {
           
            UltrasoundInvoice ultrasoundInvoice = new UltrasoundInvoice();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						ultrasoundInvoice.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						ultrasoundInvoice.ID=0;
					}
					if (Null.IsNotNull(dr["InvoiceNo"]))
					{
						ultrasoundInvoice.InvoiceNo=Convert.ToInt32(dr["InvoiceNo"]);
					}
					else
					{
						ultrasoundInvoice.InvoiceNo=0;
					}
					if (Null.IsNotNull(dr["ItemTypeID"]))
					{
						ultrasoundInvoice.ItemTypeID=Convert.ToInt32(dr["ItemTypeID"]);
					}
					else
					{
						ultrasoundInvoice.ItemTypeID=0;
					}
					if (Null.IsNotNull(dr["Description"]))
					{
						ultrasoundInvoice.Description= Convert.ToString(dr["Description"]);
					}
					else
					{
						ultrasoundInvoice.Description=string.Empty;
					}
					if (Null.IsNotNull(dr["UnitCost"]))
					{
						ultrasoundInvoice.UnitCost= Convert.ToDecimal(dr["UnitCost"]);
					}
					else
					{
						ultrasoundInvoice.UnitCost=0.00m;
					}
					if (Null.IsNotNull(dr["Qty"]))
					{
						ultrasoundInvoice.Qty=Convert.ToInt32(dr["Qty"]);
					}
					else
					{
						ultrasoundInvoice.Qty=0;
					}
					if (Null.IsNotNull(dr["AmountCost"]))
					{
						ultrasoundInvoice.AmountCost= Convert.ToDecimal(dr["AmountCost"]);
					}
					else
					{
						ultrasoundInvoice.AmountCost=0.00m;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						ultrasoundInvoice.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						ultrasoundInvoice.Status=string.Empty;
					}
 
                }
            }
            return ultrasoundInvoice ;
        }
		#endregion		
	}
}