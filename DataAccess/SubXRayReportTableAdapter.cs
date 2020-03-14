using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class SubXRayReportTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public SubXRayReportTableAdapter():base()
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
            InsertCommand.CommandText = @"INSERT INTO SubXRayReport(PatientID,PatientName,DOB,Sex,ImagePath,SubXRayReportDate,Report,ConsultantRadiologist,Status) VALUES (@PatientID,@PatientName,@DOB,@Sex,@ImagePath,@SubXRayReportDate,@Report,@ConsultantRadiologist,@Status);SELECT ID FROM SubXRayReport WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			InsertCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			InsertCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 10,"Sex"));
			InsertCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
            InsertCommand.Parameters.Add(new SqlParameter("@SubXRayReportDate", SqlDbType.DateTime, 8, "SubXRayReportDate"));
            InsertCommand.Parameters.Add(new SqlParameter("@Report", SqlDbType.VarChar, 2000, "Report"));
			InsertCommand.Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50,"ConsultantRadiologist"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
            UpdateCommand.CommandText = @"UPDATE SubXRayReport SET PatientID = @PatientID, PatientName = @PatientName, DOB = @DOB, Sex = @Sex, ImagePath = @ImagePath, SubXRayReportDate = @SubXRayReportDate, Report = @Report, ConsultantRadiologist = @ConsultantRadiologist, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 10,"Sex"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
            UpdateCommand.Parameters.Add(new SqlParameter("@SubXRayReportDate", SqlDbType.DateTime, 8, "SubXRayReport"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Report", SqlDbType.VarChar, 2000,"Report"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50,"ConsultantRadiologist"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM SubXRayReport WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
            ((SqlCommand)(CommandCollection[0])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,SubXRayReportDate,Report,ConsultantRadiologist,Status FROM SubXRayReport";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,SubXRayReportDate,Report,ConsultantRadiologist,Status FROM SubXRayReport WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,SubXRayReportDate,Report,ConsultantRadiologist,Status FROM SubXRayReport WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			//GetSubXRayReportByPatientID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,SubXRayReportDate,Report,ConsultantRadiologist,Status FROM SubXRayReport WHERE PatientID = @PatientID AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, "PatientID"));
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

		public SubXRayReport GetSubXRayReportByID(int ID)
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
		
		public DataSet GetSubXRayReportByStatus(string status)
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
        public DataSet GetSubXRayReportByPatientID(int patientID, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = patientID;
            Adapter.SelectCommand.Parameters[1].Value = status;


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
	    
		public int Insert(SubXRayReport subXRayReport)
		{
	InsertCommand.Parameters["@PatientID"].Value = subXRayReport.PatientID;
	InsertCommand.Parameters["@PatientName"].Value = subXRayReport.PatientName;
	InsertCommand.Parameters["@DOB"].Value = subXRayReport.DOB;
	InsertCommand.Parameters["@Sex"].Value = subXRayReport.Sex;
	InsertCommand.Parameters["@ImagePath"].Value = subXRayReport.ImagePath;
    InsertCommand.Parameters["@SubXRayReportDate"].Value = subXRayReport.SubXRayReportDate;
	InsertCommand.Parameters["@Report"].Value = subXRayReport.Report;
	InsertCommand.Parameters["@ConsultantRadiologist"].Value = subXRayReport.ConsultantRadiologist;
	InsertCommand.Parameters["@Status"].Value = subXRayReport.Status;
		
			
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
        
		public int Update(SubXRayReport subXRayReport)
		{
	UpdateCommand.Parameters["@ID"].Value = subXRayReport.ID;
	UpdateCommand.Parameters["@PatientID"].Value = subXRayReport.PatientID;
	UpdateCommand.Parameters["@PatientName"].Value = subXRayReport.PatientName;
	UpdateCommand.Parameters["@DOB"].Value = subXRayReport.DOB;
	UpdateCommand.Parameters["@Sex"].Value = subXRayReport.Sex;
	UpdateCommand.Parameters["@ImagePath"].Value = subXRayReport.ImagePath;
    UpdateCommand.Parameters["@SubXRayReportDate"].Value = subXRayReport.SubXRayReportDate;
	UpdateCommand.Parameters["@Report"].Value = subXRayReport.Report;
	UpdateCommand.Parameters["@ConsultantRadiologist"].Value = subXRayReport.ConsultantRadiologist;
	UpdateCommand.Parameters["@Status"].Value = subXRayReport.Status;

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
        
        private SubXRayReport DataTableToEntity(DataTable dt)
        {
           
            SubXRayReport subXRayReport = new SubXRayReport();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						subXRayReport.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						subXRayReport.ID=0;
					}
					if (Null.IsNotNull(dr["PatientID"]))
					{
						subXRayReport.PatientID=Convert.ToInt32(dr["PatientID"]);
					}
					else
					{
						subXRayReport.PatientID=0;
					}
					if (Null.IsNotNull(dr["PatientName"]))
					{
						subXRayReport.PatientName= Convert.ToString(dr["PatientName"]);
					}
					else
					{
						subXRayReport.PatientName=string.Empty;
					}
					if (Null.IsNotNull(dr["DOB"]))
					{
						subXRayReport.DOB= Convert.ToDateTime(dr["DOB"]);
					}
					else
					{
						subXRayReport.DOB=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Sex"]))
					{
						subXRayReport.Sex= Convert.ToString(dr["Sex"]);
					}
					else
					{
						subXRayReport.Sex=string.Empty;
					}
					if (Null.IsNotNull(dr["ImagePath"]))
					{
						subXRayReport.ImagePath= Convert.ToString(dr["ImagePath"]);
					}
					else
					{
						subXRayReport.ImagePath=string.Empty;
					}
                    if (Null.IsNotNull(dr["SubXRayReportDate"]))
					{
                        subXRayReport.SubXRayReportDate = Convert.ToDateTime(dr["SubXRayReportDate"]);
					}
					else
					{
                        subXRayReport.SubXRayReportDate = DateTime.Now;
					}
					if (Null.IsNotNull(dr["Report"]))
					{
						subXRayReport.Report= Convert.ToString(dr["Report"]);
					}
					else
					{
						subXRayReport.Report=string.Empty;
					}
					if (Null.IsNotNull(dr["ConsultantRadiologist"]))
					{
						subXRayReport.ConsultantRadiologist= Convert.ToString(dr["ConsultantRadiologist"]);
					}
					else
					{
						subXRayReport.ConsultantRadiologist=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						subXRayReport.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						subXRayReport.Status=string.Empty;
					}
 
                }
            }
            return subXRayReport ;
        }
		#endregion		
	}
}