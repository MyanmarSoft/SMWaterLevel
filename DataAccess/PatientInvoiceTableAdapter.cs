using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class PatientInvoiceTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public PatientInvoiceTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO PatientInvoice(InvoiceNo,PatientID,PatientName,DoctorID,DoctorName,CompanyID,CompanyName,PaymentModeID,PaymentMode,Total,Discount,MOH,NetTotal,InvoiceDate,Username,Status) VALUES (@InvoiceNo,@PatientID,@PatientName,@DoctorID,@DoctorName,@CompanyID,@CompanyName,@PaymentModeID,@PaymentMode,@Total,@Discount,@MOH,@NetTotal,@InvoiceDate,@Username,@Status);SELECT ID FROM PatientInvoice WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InvoiceNo", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			InsertCommand.Parameters.Add(new SqlParameter("@DoctorID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"DoctorID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@DoctorName", SqlDbType.NVarChar, 255,"DoctorName"));
			InsertCommand.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CompanyID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.NVarChar, 255,"CompanyName"));
			InsertCommand.Parameters.Add(new SqlParameter("@PaymentModeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PaymentModeID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PaymentMode", SqlDbType.NVarChar, 255,"PaymentMode"));
			InsertCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@MOH", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "MOH", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@InvoiceDate", SqlDbType.DateTime, 8,"InvoiceDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE PatientInvoice SET InvoiceNo = @InvoiceNo, PatientID = @PatientID, PatientName = @PatientName, DoctorID = @DoctorID, DoctorName = @DoctorName, CompanyID = @CompanyID, CompanyName = @CompanyName, PaymentModeID = @PaymentModeID, PaymentMode = @PaymentMode, Total = @Total, Discount = @Discount, MOH = @MOH, NetTotal = @NetTotal, InvoiceDate = @InvoiceDate, Username = @Username, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"InvoiceNo", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DoctorID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"DoctorID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@DoctorName", SqlDbType.NVarChar, 255,"DoctorName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CompanyID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"CompanyID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.NVarChar, 255,"CompanyName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@PaymentModeID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PaymentModeID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PaymentMode", SqlDbType.NVarChar, 255,"PaymentMode"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Total", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Discount", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "Discount", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@MOH", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "MOH", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@NetTotal", SqlDbType.Decimal, 9, ParameterDirection.Input, true, ((Byte)(18)), ((Byte)(2)), "NetTotal", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@InvoiceDate", SqlDbType.DateTime, 8,"InvoiceDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50,"Username"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM PatientInvoice WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[8];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,InvoiceNo,PatientID,PatientName,DoctorID,DoctorName,CompanyID,CompanyName,PaymentModeID,PaymentMode,Total,Discount,MOH,NetTotal,InvoiceDate,Username,Status FROM PatientInvoice";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,InvoiceNo,PatientID,PatientName,DoctorID,DoctorName,CompanyID,CompanyName,PaymentModeID,PaymentMode,Total,Discount,MOH,NetTotal,InvoiceDate,Username,Status FROM PatientInvoice WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,InvoiceNo,PatientID,PatientName,DoctorID,DoctorName,CompanyID,CompanyName,PaymentModeID,PaymentMode,Total,Discount,MOH,NetTotal,InvoiceDate,Username,Status FROM PatientInvoice WHERE Status =  @Status ORDER BY InvoiceNo DESC";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			//GetDataByInvoiceNo
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,InvoiceNo,PatientID,PatientName,DoctorID,DoctorName,CompanyID,CompanyName,PaymentModeID,PaymentMode,Total,Discount,MOH,NetTotal,InvoiceDate,Username,Status FROM PatientInvoice WHERE InvoiceNo = @InvoiceNo AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@InvoiceNo", SqlDbType.Int, 8, "InvoiceNo"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));

            //Fill/GetDataByDESC
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT TOP 100* FROM  PatientInvoice WHERE Status=@Status ORDER BY InvoiceNo DESC";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			//GetPatientInvoiceByLastID
            CommandCollection[5] = new SqlCommand();
            ((SqlCommand)(CommandCollection[5])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[5])).CommandText = "SELECT TOP 1* FROM  PatientInvoice ORDER BY InvoiceNo DESC";
            ((SqlCommand)(CommandCollection[5])).CommandType = CommandType.Text;


            //GetDataSetByUserProfile
            CommandCollection[7] = new SqlCommand();
            ((SqlCommand)(CommandCollection[7])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[7])).CommandText = "SELECT ID,InvoiceNo,PatientID,PatientName,DoctorID,DoctorName,CompanyID,CompanyName,PaymentModeID,PaymentMode,Total,Discount,MOH,NetTotal,InvoiceDate,Username,Status FROM PatientInvoice WHERE Username = @Username AND Status =  @Status ORDER BY InvoiceNo DESC";
            ((SqlCommand)(CommandCollection[7])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[7])).Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 50, "Username"));
            ((SqlCommand)(this.CommandCollection[7])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			
			
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

		public PatientInvoice GetPatientInvoiceByID(int ID)
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
		
		public DataSet GetPatientInvoiceByStatus(string status)
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
		
		
		
		
		

        

        public DataTable GetDataTableByPatientInvoiceByLastID()
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[5]));

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
        public DataTable GetDataByInvoiceNo(int invoiceNo, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
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
        public DataSet GetDataSetByInvoiceNo(int invoiceNo, string status)
        {

            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters["@InvoiceNo"].Value = invoiceNo;
            Adapter.SelectCommand.Parameters["@Status"].Value = status;

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

        public PatientInvoice GetPatientInvoiceByInvoiceNO(int invoiceNo,string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = invoiceNo;
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

            return DataTableToEntity(dt);
        }

        public DataTable GetDataByDESC(string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
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

        public DataTable GetTopByStatus(string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
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

        public PatientInvoice GetPatientInvoiceByLastID()
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[5]));

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
        public DataSet GetDataSetByInvoiceDate(DateTime fromDate, DateTime toDate, string status)
        {

            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[6]));
            Adapter.SelectCommand.Parameters[0].Value = fromDate;
            Adapter.SelectCommand.Parameters[1].Value = toDate;
            Adapter.SelectCommand.Parameters[2].Value = status;

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

        public DataSet GetDataSetByUserProfile(string username, string status)
        {

            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[7]));
            Adapter.SelectCommand.Parameters["@Username"].Value = username;
            Adapter.SelectCommand.Parameters["@Status"].Value = status;

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
	    
		public int Insert(PatientInvoice patientInvoice)
		{
	InsertCommand.Parameters["@InvoiceNo"].Value = patientInvoice.InvoiceNo;
	InsertCommand.Parameters["@PatientID"].Value = patientInvoice.PatientID;
	InsertCommand.Parameters["@PatientName"].Value = patientInvoice.PatientName;
	InsertCommand.Parameters["@DoctorID"].Value = patientInvoice.DoctorID;
	InsertCommand.Parameters["@DoctorName"].Value = patientInvoice.DoctorName;
	InsertCommand.Parameters["@CompanyID"].Value = patientInvoice.CompanyID;
	InsertCommand.Parameters["@CompanyName"].Value = patientInvoice.CompanyName;
	InsertCommand.Parameters["@PaymentModeID"].Value = patientInvoice.PaymentModeID;
	InsertCommand.Parameters["@PaymentMode"].Value = patientInvoice.PaymentMode;
	InsertCommand.Parameters["@Total"].Value = patientInvoice.Total;
	InsertCommand.Parameters["@Discount"].Value = patientInvoice.Discount;
	InsertCommand.Parameters["@MOH"].Value = patientInvoice.MOH;
	InsertCommand.Parameters["@NetTotal"].Value = patientInvoice.NetTotal;
	InsertCommand.Parameters["@InvoiceDate"].Value = patientInvoice.InvoiceDate;
	InsertCommand.Parameters["@Username"].Value = patientInvoice.Username;
	InsertCommand.Parameters["@Status"].Value = patientInvoice.Status;
		
			
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
        
		public int Update(PatientInvoice patientInvoice)
		{
	UpdateCommand.Parameters["@ID"].Value = patientInvoice.ID;
	UpdateCommand.Parameters["@InvoiceNo"].Value = patientInvoice.InvoiceNo;
	UpdateCommand.Parameters["@PatientID"].Value = patientInvoice.PatientID;
	UpdateCommand.Parameters["@PatientName"].Value = patientInvoice.PatientName;
	UpdateCommand.Parameters["@DoctorID"].Value = patientInvoice.DoctorID;
	UpdateCommand.Parameters["@DoctorName"].Value = patientInvoice.DoctorName;
	UpdateCommand.Parameters["@CompanyID"].Value = patientInvoice.CompanyID;
	UpdateCommand.Parameters["@CompanyName"].Value = patientInvoice.CompanyName;
	UpdateCommand.Parameters["@PaymentModeID"].Value = patientInvoice.PaymentModeID;
	UpdateCommand.Parameters["@PaymentMode"].Value = patientInvoice.PaymentMode;
	UpdateCommand.Parameters["@Total"].Value = patientInvoice.Total;
	UpdateCommand.Parameters["@Discount"].Value = patientInvoice.Discount;
	UpdateCommand.Parameters["@MOH"].Value = patientInvoice.MOH;
	UpdateCommand.Parameters["@NetTotal"].Value = patientInvoice.NetTotal;
	UpdateCommand.Parameters["@InvoiceDate"].Value = patientInvoice.InvoiceDate;
	UpdateCommand.Parameters["@Username"].Value = patientInvoice.Username;
	UpdateCommand.Parameters["@Status"].Value = patientInvoice.Status;

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
        
        private PatientInvoice DataTableToEntity(DataTable dt)
        {
           
            PatientInvoice patientInvoice = new PatientInvoice();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						patientInvoice.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						patientInvoice.ID=0;
					}
					if (Null.IsNotNull(dr["InvoiceNo"]))
					{
						patientInvoice.InvoiceNo=Convert.ToInt32(dr["InvoiceNo"]);
					}
					else
					{
						patientInvoice.InvoiceNo=0;
					}
					if (Null.IsNotNull(dr["PatientID"]))
					{
						patientInvoice.PatientID=Convert.ToInt32(dr["PatientID"]);
					}
					else
					{
						patientInvoice.PatientID=0;
					}
					if (Null.IsNotNull(dr["PatientName"]))
					{
						patientInvoice.PatientName= Convert.ToString(dr["PatientName"]);
					}
					else
					{
						patientInvoice.PatientName=string.Empty;
					}
					if (Null.IsNotNull(dr["DoctorID"]))
					{
						patientInvoice.DoctorID=Convert.ToInt32(dr["DoctorID"]);
					}
					else
					{
						patientInvoice.DoctorID=0;
					}
					if (Null.IsNotNull(dr["DoctorName"]))
					{
						patientInvoice.DoctorName= Convert.ToString(dr["DoctorName"]);
					}
					else
					{
						patientInvoice.DoctorName=string.Empty;
					}
					if (Null.IsNotNull(dr["CompanyID"]))
					{
						patientInvoice.CompanyID=Convert.ToInt32(dr["CompanyID"]);
					}
					else
					{
						patientInvoice.CompanyID=0;
					}
					if (Null.IsNotNull(dr["CompanyName"]))
					{
						patientInvoice.CompanyName= Convert.ToString(dr["CompanyName"]);
					}
					else
					{
						patientInvoice.CompanyName=string.Empty;
					}
					if (Null.IsNotNull(dr["PaymentModeID"]))
					{
						patientInvoice.PaymentModeID=Convert.ToInt32(dr["PaymentModeID"]);
					}
					else
					{
						patientInvoice.PaymentModeID=0;
					}
					if (Null.IsNotNull(dr["PaymentMode"]))
					{
						patientInvoice.PaymentMode= Convert.ToString(dr["PaymentMode"]);
					}
					else
					{
						patientInvoice.PaymentMode=string.Empty;
					}
					if (Null.IsNotNull(dr["Total"]))
					{
						patientInvoice.Total= Convert.ToDecimal(dr["Total"]);
					}
					else
					{
						patientInvoice.Total=0.00m;
					}
					if (Null.IsNotNull(dr["Discount"]))
					{
						patientInvoice.Discount= Convert.ToDecimal(dr["Discount"]);
					}
					else
					{
						patientInvoice.Discount=0.00m;
					}
					if (Null.IsNotNull(dr["MOH"]))
					{
						patientInvoice.MOH= Convert.ToDecimal(dr["MOH"]);
					}
					else
					{
						patientInvoice.MOH=0.00m;
					}
					if (Null.IsNotNull(dr["NetTotal"]))
					{
						patientInvoice.NetTotal= Convert.ToDecimal(dr["NetTotal"]);
					}
					else
					{
						patientInvoice.NetTotal=0.00m;
					}
					if (Null.IsNotNull(dr["InvoiceDate"]))
					{
						patientInvoice.InvoiceDate= Convert.ToDateTime(dr["InvoiceDate"]);
					}
					else
					{
						patientInvoice.InvoiceDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Username"]))
					{
						patientInvoice.Username= Convert.ToString(dr["Username"]);
					}
					else
					{
						patientInvoice.Username=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						patientInvoice.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						patientInvoice.Status=string.Empty;
					}
 
                }
            }
            return patientInvoice ;
        }
		#endregion		
	}
}