using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class XRayReportTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public XRayReportTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO XRayReport(PatientID,PatientName,DOB,Sex,ImagePath,XRayReportDate,SkeletonAndSoftTissue,CardiacShadow,HilarandLymphaticGlands,HemidiaphragmsAndCostophrenicAngles,LungFields,EvidenceofTB,Evidenceofold,EvidenceSuspicious,ConsultantRadiologist,Remark,Status) VALUES (@PatientID,@PatientName,@DOB,@Sex,@ImagePath,@XRayReportDate,@SkeletonAndSoftTissue,@CardiacShadow,@HilarandLymphaticGlands,@HemidiaphragmsAndCostophrenicAngles,@LungFields,@EvidenceofTB,@Evidenceofold,@EvidenceSuspicious,@ConsultantRadiologist,@Remark,@Status);SELECT ID FROM XRayReport WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			InsertCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			InsertCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 10,"Sex"));
			InsertCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			InsertCommand.Parameters.Add(new SqlParameter("@XRayReportDate", SqlDbType.DateTime, 8,"XRayReportDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@SkeletonAndSoftTissue", SqlDbType.VarChar, 10,"SkeletonAndSoftTissue"));
			InsertCommand.Parameters.Add(new SqlParameter("@CardiacShadow", SqlDbType.VarChar, 10,"CardiacShadow"));
			InsertCommand.Parameters.Add(new SqlParameter("@HilarandLymphaticGlands", SqlDbType.VarChar, 10,"HilarandLymphaticGlands"));
			InsertCommand.Parameters.Add(new SqlParameter("@HemidiaphragmsAndCostophrenicAngles", SqlDbType.VarChar, 10,"HemidiaphragmsAndCostophrenicAngles"));
			InsertCommand.Parameters.Add(new SqlParameter("@LungFields", SqlDbType.VarChar, 10,"LungFields"));
			InsertCommand.Parameters.Add(new SqlParameter("@EvidenceofTB", SqlDbType.VarChar, 10,"EvidenceofTB"));
			InsertCommand.Parameters.Add(new SqlParameter("@Evidenceofold", SqlDbType.VarChar, 10,"Evidenceofold"));
			InsertCommand.Parameters.Add(new SqlParameter("@EvidenceSuspicious", SqlDbType.VarChar, 10,"EvidenceSuspicious"));
			InsertCommand.Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50,"ConsultantRadiologist"));
            InsertCommand.Parameters.Add(new SqlParameter("@Remark", SqlDbType.VarChar, 2000, "Remark"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE XRayReport SET PatientID = @PatientID, PatientName = @PatientName, DOB = @DOB, Sex = @Sex, ImagePath = @ImagePath, XRayReportDate = @XRayReportDate, SkeletonAndSoftTissue = @SkeletonAndSoftTissue, CardiacShadow = @CardiacShadow, HilarandLymphaticGlands = @HilarandLymphaticGlands, HemidiaphragmsAndCostophrenicAngles = @HemidiaphragmsAndCostophrenicAngles, LungFields = @LungFields, EvidenceofTB = @EvidenceofTB, Evidenceofold = @Evidenceofold, EvidenceSuspicious = @EvidenceSuspicious, ConsultantRadiologist = @ConsultantRadiologist, Remark = @Remark, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 10,"Sex"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			UpdateCommand.Parameters.Add(new SqlParameter("@XRayReportDate", SqlDbType.DateTime, 8,"XRayReportDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@SkeletonAndSoftTissue", SqlDbType.VarChar, 10,"SkeletonAndSoftTissue"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CardiacShadow", SqlDbType.VarChar, 10,"CardiacShadow"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HilarandLymphaticGlands", SqlDbType.VarChar, 10,"HilarandLymphaticGlands"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HemidiaphragmsAndCostophrenicAngles", SqlDbType.VarChar, 10,"HemidiaphragmsAndCostophrenicAngles"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LungFields", SqlDbType.VarChar, 10,"LungFields"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EvidenceofTB", SqlDbType.VarChar, 10,"EvidenceofTB"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Evidenceofold", SqlDbType.VarChar, 10,"Evidenceofold"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EvidenceSuspicious", SqlDbType.VarChar, 10,"EvidenceSuspicious"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50,"ConsultantRadiologist"));
            UpdateCommand.Parameters.Add(new SqlParameter("@Remark", SqlDbType.VarChar, 2000, "Remark"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM XRayReport WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[6];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,XRayReportDate,SkeletonAndSoftTissue,CardiacShadow,HilarandLymphaticGlands,HemidiaphragmsAndCostophrenicAngles,LungFields,EvidenceofTB,Evidenceofold,EvidenceSuspicious,ConsultantRadiologist,Remark,Status FROM XRayReport";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,XRayReportDate,SkeletonAndSoftTissue,CardiacShadow,HilarandLymphaticGlands,HemidiaphragmsAndCostophrenicAngles,LungFields,EvidenceofTB,Evidenceofold,EvidenceSuspicious,ConsultantRadiologist,Remark,Status FROM XRayReport WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,XRayReportDate,SkeletonAndSoftTissue,CardiacShadow,HilarandLymphaticGlands,HemidiaphragmsAndCostophrenicAngles,LungFields,EvidenceofTB,Evidenceofold,EvidenceSuspicious,ConsultantRadiologist,Remark,Status FROM XRayReport WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			//GetXRayReportByPatientID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,XRayReportDate,SkeletonAndSoftTissue,CardiacShadow,HilarandLymphaticGlands,HemidiaphragmsAndCostophrenicAngles,LungFields,EvidenceofTB,Evidenceofold,EvidenceSuspicious,ConsultantRadiologist,Remark,Status FROM XRayReport WHERE ConsultantRadiologist = @ConsultantRadiologist AND PatientID =  @PatientID AND Status = @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50, "ConsultantRadiologist"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, "PatientID"));
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10, "Status"));

            //GetXRayReportByConsultantRadiologist
            CommandCollection[4] = new SqlCommand();
            ((SqlCommand)(CommandCollection[4])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[4])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,XRayReportDate,SkeletonAndSoftTissue,CardiacShadow,HilarandLymphaticGlands,HemidiaphragmsAndCostophrenicAngles,LungFields,EvidenceofTB,Evidenceofold,EvidenceSuspicious,ConsultantRadiologist,Remark,Status FROM XRayReport WHERE ConsultantRadiologist =  @ConsultantRadiologist AND Status = @Status";
            ((SqlCommand)(CommandCollection[4])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50, "ConsultantRadiologist"));
            ((SqlCommand)(this.CommandCollection[4])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10, "Status"));

            //GetXRayReportByPatient
            CommandCollection[5] = new SqlCommand();
            ((SqlCommand)(CommandCollection[5])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[5])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,XRayReportDate,SkeletonAndSoftTissue,CardiacShadow,HilarandLymphaticGlands,HemidiaphragmsAndCostophrenicAngles,LungFields,EvidenceofTB,Evidenceofold,EvidenceSuspicious,ConsultantRadiologist,Remark,Status FROM XRayReport WHERE PatientID =  @PatientID AND Status = @Status";
            ((SqlCommand)(CommandCollection[5])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[5])).Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, "PatientID"));
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

		public XRayReport GetXRayReportByID(int ID)
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
		
		public DataSet GetXRayReportByStatus(string status)
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
		

        public DataSet GetXRayReportByPatientID(string consultantRadiologist, int patientID, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[3]));
            Adapter.SelectCommand.Parameters[0].Value = consultantRadiologist;

            Adapter.SelectCommand.Parameters[1].Value = patientID;
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

       

        public DataSet GetXRayReportByConsultantRadiologist(string consultantRadiologist, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = consultantRadiologist;
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

        public DataTable GetDataByConsultantRadiologist(string consultantRadiologist, string status)
        {

            DataTable dt = new DataTable();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[4]));
            Adapter.SelectCommand.Parameters[0].Value = consultantRadiologist;
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

            return dt;
        }



        public DataSet GetXRayReportByPatient(int patientID, string status)
        {
            DataSet ds = new DataSet();
            Adapter.SelectCommand = ((SqlCommand)(CommandCollection[5]));
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
	    
		public int Insert(XRayReport xRayReport)
		{
	InsertCommand.Parameters["@PatientID"].Value = xRayReport.PatientID;
	InsertCommand.Parameters["@PatientName"].Value = xRayReport.PatientName;
	InsertCommand.Parameters["@DOB"].Value = xRayReport.DOB;
	InsertCommand.Parameters["@Sex"].Value = xRayReport.Sex;
	InsertCommand.Parameters["@ImagePath"].Value = xRayReport.ImagePath;
	InsertCommand.Parameters["@XRayReportDate"].Value = xRayReport.XRayReportDate;
	InsertCommand.Parameters["@SkeletonAndSoftTissue"].Value = xRayReport.SkeletonAndSoftTissue;
	InsertCommand.Parameters["@CardiacShadow"].Value = xRayReport.CardiacShadow;
	InsertCommand.Parameters["@HilarandLymphaticGlands"].Value = xRayReport.HilarandLymphaticGlands;
	InsertCommand.Parameters["@HemidiaphragmsAndCostophrenicAngles"].Value = xRayReport.HemidiaphragmsAndCostophrenicAngles;
	InsertCommand.Parameters["@LungFields"].Value = xRayReport.LungFields;
	InsertCommand.Parameters["@EvidenceofTB"].Value = xRayReport.EvidenceofTB;
	InsertCommand.Parameters["@Evidenceofold"].Value = xRayReport.Evidenceofold;
	InsertCommand.Parameters["@EvidenceSuspicious"].Value = xRayReport.EvidenceSuspicious;
	InsertCommand.Parameters["@ConsultantRadiologist"].Value = xRayReport.ConsultantRadiologist;
	InsertCommand.Parameters["@Remark"].Value = xRayReport.Remark;
	InsertCommand.Parameters["@Status"].Value = xRayReport.Status;
		
			
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
        
		public int Update(XRayReport xRayReport)
		{
	UpdateCommand.Parameters["@ID"].Value = xRayReport.ID;
	UpdateCommand.Parameters["@PatientID"].Value = xRayReport.PatientID;
	UpdateCommand.Parameters["@PatientName"].Value = xRayReport.PatientName;
	UpdateCommand.Parameters["@DOB"].Value = xRayReport.DOB;
	UpdateCommand.Parameters["@Sex"].Value = xRayReport.Sex;
	UpdateCommand.Parameters["@ImagePath"].Value = xRayReport.ImagePath;
	UpdateCommand.Parameters["@XRayReportDate"].Value = xRayReport.XRayReportDate;
	UpdateCommand.Parameters["@SkeletonAndSoftTissue"].Value = xRayReport.SkeletonAndSoftTissue;
	UpdateCommand.Parameters["@CardiacShadow"].Value = xRayReport.CardiacShadow;
	UpdateCommand.Parameters["@HilarandLymphaticGlands"].Value = xRayReport.HilarandLymphaticGlands;
	UpdateCommand.Parameters["@HemidiaphragmsAndCostophrenicAngles"].Value = xRayReport.HemidiaphragmsAndCostophrenicAngles;
	UpdateCommand.Parameters["@LungFields"].Value = xRayReport.LungFields;
	UpdateCommand.Parameters["@EvidenceofTB"].Value = xRayReport.EvidenceofTB;
	UpdateCommand.Parameters["@Evidenceofold"].Value = xRayReport.Evidenceofold;
	UpdateCommand.Parameters["@EvidenceSuspicious"].Value = xRayReport.EvidenceSuspicious;
	UpdateCommand.Parameters["@ConsultantRadiologist"].Value = xRayReport.ConsultantRadiologist;
	UpdateCommand.Parameters["@Remark"].Value = xRayReport.Remark;
	UpdateCommand.Parameters["@Status"].Value = xRayReport.Status;

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
        
        private XRayReport DataTableToEntity(DataTable dt)
        {
           
            XRayReport xRayReport = new XRayReport();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						xRayReport.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						xRayReport.ID=0;
					}
					if (Null.IsNotNull(dr["PatientID"]))
					{
						xRayReport.PatientID=Convert.ToInt32(dr["PatientID"]);
					}
					else
					{
						xRayReport.PatientID=0;
					}
					if (Null.IsNotNull(dr["PatientName"]))
					{
						xRayReport.PatientName= Convert.ToString(dr["PatientName"]);
					}
					else
					{
						xRayReport.PatientName=string.Empty;
					}
					if (Null.IsNotNull(dr["DOB"]))
					{
						xRayReport.DOB= Convert.ToDateTime(dr["DOB"]);
					}
					else
					{
						xRayReport.DOB=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Sex"]))
					{
						xRayReport.Sex= Convert.ToString(dr["Sex"]);
					}
					else
					{
						xRayReport.Sex=string.Empty;
					}
					if (Null.IsNotNull(dr["ImagePath"]))
					{
						xRayReport.ImagePath= Convert.ToString(dr["ImagePath"]);
					}
					else
					{
						xRayReport.ImagePath=string.Empty;
					}
					if (Null.IsNotNull(dr["XRayReportDate"]))
					{
						xRayReport.XRayReportDate= Convert.ToDateTime(dr["XRayReportDate"]);
					}
					else
					{
						xRayReport.XRayReportDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["SkeletonAndSoftTissue"]))
					{
						xRayReport.SkeletonAndSoftTissue= Convert.ToString(dr["SkeletonAndSoftTissue"]);
					}
					else
					{
						xRayReport.SkeletonAndSoftTissue=string.Empty;
					}
					if (Null.IsNotNull(dr["CardiacShadow"]))
					{
						xRayReport.CardiacShadow= Convert.ToString(dr["CardiacShadow"]);
					}
					else
					{
						xRayReport.CardiacShadow=string.Empty;
					}
					if (Null.IsNotNull(dr["HilarandLymphaticGlands"]))
					{
						xRayReport.HilarandLymphaticGlands= Convert.ToString(dr["HilarandLymphaticGlands"]);
					}
					else
					{
						xRayReport.HilarandLymphaticGlands=string.Empty;
					}
					if (Null.IsNotNull(dr["HemidiaphragmsAndCostophrenicAngles"]))
					{
						xRayReport.HemidiaphragmsAndCostophrenicAngles= Convert.ToString(dr["HemidiaphragmsAndCostophrenicAngles"]);
					}
					else
					{
						xRayReport.HemidiaphragmsAndCostophrenicAngles=string.Empty;
					}
					if (Null.IsNotNull(dr["LungFields"]))
					{
						xRayReport.LungFields= Convert.ToString(dr["LungFields"]);
					}
					else
					{
						xRayReport.LungFields=string.Empty;
					}
					if (Null.IsNotNull(dr["EvidenceofTB"]))
					{
						xRayReport.EvidenceofTB= Convert.ToString(dr["EvidenceofTB"]);
					}
					else
					{
						xRayReport.EvidenceofTB=string.Empty;
					}
					if (Null.IsNotNull(dr["Evidenceofold"]))
					{
						xRayReport.Evidenceofold= Convert.ToString(dr["Evidenceofold"]);
					}
					else
					{
						xRayReport.Evidenceofold=string.Empty;
					}
					if (Null.IsNotNull(dr["EvidenceSuspicious"]))
					{
						xRayReport.EvidenceSuspicious= Convert.ToString(dr["EvidenceSuspicious"]);
					}
					else
					{
						xRayReport.EvidenceSuspicious=string.Empty;
					}
					if (Null.IsNotNull(dr["ConsultantRadiologist"]))
					{
						xRayReport.ConsultantRadiologist= Convert.ToString(dr["ConsultantRadiologist"]);
					}
					else
					{
						xRayReport.ConsultantRadiologist=string.Empty;
					}
					if (Null.IsNotNull(dr["Remark"]))
					{
						xRayReport.Remark= Convert.ToString(dr["Remark"]);
					}
					else
					{
						xRayReport.Remark=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						xRayReport.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						xRayReport.Status=string.Empty;
					}
 
                }
            }
            return xRayReport ;
        }
		#endregion		
	}
}