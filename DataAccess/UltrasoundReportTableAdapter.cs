using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class UltrasoundReportTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public UltrasoundReportTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO UltrasoundReport(PatientID,PatientName,DOB,Sex,ImagePath,LiverSize,LiverMargin,LiverSOL,LiverEchogenicity,LiverCaudatelobe,GallBLadderWallThickness,GallBLadderContent,HepaticDucts,CBD,Pancreas,Spleen,RightKidney,LeftKidney,Bladder,Uterus,Ovary,Others,Impression,UltrasoundReportDate,ConsultantRadiologist,Status) VALUES (@PatientID,@PatientName,@DOB,@Sex,@ImagePath,@LiverSize,@LiverMargin,@LiverSOL,@LiverEchogenicity,@LiverCaudatelobe,@GallBLadderWallThickness,@GallBLadderContent,@HepaticDucts,@CBD,@Pancreas,@Spleen,@RightKidney,@LeftKidney,@Bladder,@Uterus,@Ovary,@Others,@Impression,@UltrasoundReportDate,@ConsultantRadiologist,@Status);SELECT ID FROM UltrasoundReport WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			InsertCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			InsertCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 10,"Sex"));
			InsertCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			InsertCommand.Parameters.Add(new SqlParameter("@LiverSize", SqlDbType.VarChar, 50,"LiverSize"));
			InsertCommand.Parameters.Add(new SqlParameter("@LiverMargin", SqlDbType.VarChar, 50,"LiverMargin"));
			InsertCommand.Parameters.Add(new SqlParameter("@LiverSOL", SqlDbType.VarChar, 50,"LiverSOL"));
			InsertCommand.Parameters.Add(new SqlParameter("@LiverEchogenicity", SqlDbType.VarChar, 50,"LiverEchogenicity"));
			InsertCommand.Parameters.Add(new SqlParameter("@LiverCaudatelobe", SqlDbType.VarChar, 50,"LiverCaudatelobe"));
			InsertCommand.Parameters.Add(new SqlParameter("@GallBLadderWallThickness", SqlDbType.VarChar, 50,"GallBLadderWallThickness"));
			InsertCommand.Parameters.Add(new SqlParameter("@GallBLadderContent", SqlDbType.VarChar, 50,"GallBLadderContent"));
			InsertCommand.Parameters.Add(new SqlParameter("@HepaticDucts", SqlDbType.VarChar, 100,"HepaticDucts"));
			InsertCommand.Parameters.Add(new SqlParameter("@CBD", SqlDbType.VarChar, 100,"CBD"));
			InsertCommand.Parameters.Add(new SqlParameter("@Pancreas", SqlDbType.VarChar, 100,"Pancreas"));
			InsertCommand.Parameters.Add(new SqlParameter("@Spleen", SqlDbType.VarChar, 100,"Spleen"));
			InsertCommand.Parameters.Add(new SqlParameter("@RightKidney", SqlDbType.VarChar, 100,"RightKidney"));
			InsertCommand.Parameters.Add(new SqlParameter("@LeftKidney", SqlDbType.VarChar, 100,"LeftKidney"));
			InsertCommand.Parameters.Add(new SqlParameter("@Bladder", SqlDbType.VarChar, 100,"Bladder"));
			InsertCommand.Parameters.Add(new SqlParameter("@Uterus", SqlDbType.VarChar, 100,"Uterus"));
			InsertCommand.Parameters.Add(new SqlParameter("@Ovary", SqlDbType.VarChar, 100,"Ovary"));
			InsertCommand.Parameters.Add(new SqlParameter("@Others", SqlDbType.VarChar, 100,"Others"));
			InsertCommand.Parameters.Add(new SqlParameter("@Impression", SqlDbType.VarChar, 100,"Impression"));
			InsertCommand.Parameters.Add(new SqlParameter("@UltrasoundReportDate", SqlDbType.DateTime, 8,"UltrasoundReportDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50,"ConsultantRadiologist"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE UltrasoundReport SET PatientID = @PatientID, PatientName = @PatientName, DOB = @DOB, Sex = @Sex, ImagePath = @ImagePath, LiverSize = @LiverSize, LiverMargin = @LiverMargin, LiverSOL = @LiverSOL, LiverEchogenicity = @LiverEchogenicity, LiverCaudatelobe = @LiverCaudatelobe, GallBLadderWallThickness = @GallBLadderWallThickness, GallBLadderContent = @GallBLadderContent, HepaticDucts = @HepaticDucts, CBD = @CBD, Pancreas = @Pancreas, Spleen = @Spleen, RightKidney = @RightKidney, LeftKidney = @LeftKidney, Bladder = @Bladder, Uterus = @Uterus, Ovary = @Ovary, Others = @Others, Impression = @Impression, UltrasoundReportDate = @UltrasoundReportDate, ConsultantRadiologist = @ConsultantRadiologist, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 10,"Sex"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LiverSize", SqlDbType.VarChar, 50,"LiverSize"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LiverMargin", SqlDbType.VarChar, 50,"LiverMargin"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LiverSOL", SqlDbType.VarChar, 50,"LiverSOL"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LiverEchogenicity", SqlDbType.VarChar, 50,"LiverEchogenicity"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LiverCaudatelobe", SqlDbType.VarChar, 50,"LiverCaudatelobe"));
			UpdateCommand.Parameters.Add(new SqlParameter("@GallBLadderWallThickness", SqlDbType.VarChar, 50,"GallBLadderWallThickness"));
			UpdateCommand.Parameters.Add(new SqlParameter("@GallBLadderContent", SqlDbType.VarChar, 50,"GallBLadderContent"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HepaticDucts", SqlDbType.VarChar, 100,"HepaticDucts"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CBD", SqlDbType.VarChar, 100,"CBD"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Pancreas", SqlDbType.VarChar, 100,"Pancreas"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Spleen", SqlDbType.VarChar, 100,"Spleen"));
			UpdateCommand.Parameters.Add(new SqlParameter("@RightKidney", SqlDbType.VarChar, 100,"RightKidney"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LeftKidney", SqlDbType.VarChar, 100,"LeftKidney"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Bladder", SqlDbType.VarChar, 100,"Bladder"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Uterus", SqlDbType.VarChar, 100,"Uterus"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Ovary", SqlDbType.VarChar, 100,"Ovary"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Others", SqlDbType.VarChar, 100,"Others"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Impression", SqlDbType.VarChar, 100,"Impression"));
			UpdateCommand.Parameters.Add(new SqlParameter("@UltrasoundReportDate", SqlDbType.DateTime, 8,"UltrasoundReportDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ConsultantRadiologist", SqlDbType.VarChar, 50,"ConsultantRadiologist"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM UltrasoundReport WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,LiverSize,LiverMargin,LiverSOL,LiverEchogenicity,LiverCaudatelobe,GallBLadderWallThickness,GallBLadderContent,HepaticDucts,CBD,Pancreas,Spleen,RightKidney,LeftKidney,Bladder,Uterus,Ovary,Others,Impression,UltrasoundReportDate,ConsultantRadiologist,Status FROM UltrasoundReport";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,LiverSize,LiverMargin,LiverSOL,LiverEchogenicity,LiverCaudatelobe,GallBLadderWallThickness,GallBLadderContent,HepaticDucts,CBD,Pancreas,Spleen,RightKidney,LeftKidney,Bladder,Uterus,Ovary,Others,Impression,UltrasoundReportDate,ConsultantRadiologist,Status FROM UltrasoundReport WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,LiverSize,LiverMargin,LiverSOL,LiverEchogenicity,LiverCaudatelobe,GallBLadderWallThickness,GallBLadderContent,HepaticDucts,CBD,Pancreas,Spleen,RightKidney,LeftKidney,Bladder,Uterus,Ovary,Others,Impression,UltrasoundReportDate,ConsultantRadiologist,Status FROM UltrasoundReport WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			//GetUltrasoundReportByPatientID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,PatientID,PatientName,DOB,Sex,ImagePath,LiverSize,LiverMargin,LiverSOL,LiverEchogenicity,LiverCaudatelobe,GallBLadderWallThickness,GallBLadderContent,HepaticDucts,CBD,Pancreas,Spleen,RightKidney,LeftKidney,Bladder,Uterus,Ovary,Others,Impression,UltrasoundReportDate,ConsultantRadiologist,Status FROM UltrasoundReport WHERE PatientID = @PatientID AND Status =  @Status";
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

		public UltrasoundReport GetUltrasoundReportByID(int ID)
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
		
		public DataSet GetUltrasoundReportByStatus(string status)
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
		
        public DataSet GetUltrasoundReportByPatientID(int patientID, string status)
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
	    
		public int Insert(UltrasoundReport ultrasoundReport)
		{
	InsertCommand.Parameters["@PatientID"].Value = ultrasoundReport.PatientID;
	InsertCommand.Parameters["@PatientName"].Value = ultrasoundReport.PatientName;
	InsertCommand.Parameters["@DOB"].Value = ultrasoundReport.DOB;
	InsertCommand.Parameters["@Sex"].Value = ultrasoundReport.Sex;
	InsertCommand.Parameters["@ImagePath"].Value = ultrasoundReport.ImagePath;
	InsertCommand.Parameters["@LiverSize"].Value = ultrasoundReport.LiverSize;
	InsertCommand.Parameters["@LiverMargin"].Value = ultrasoundReport.LiverMargin;
	InsertCommand.Parameters["@LiverSOL"].Value = ultrasoundReport.LiverSOL;
	InsertCommand.Parameters["@LiverEchogenicity"].Value = ultrasoundReport.LiverEchogenicity;
	InsertCommand.Parameters["@LiverCaudatelobe"].Value = ultrasoundReport.LiverCaudatelobe;
	InsertCommand.Parameters["@GallBLadderWallThickness"].Value = ultrasoundReport.GallBLadderWallThickness;
	InsertCommand.Parameters["@GallBLadderContent"].Value = ultrasoundReport.GallBLadderContent;
	InsertCommand.Parameters["@HepaticDucts"].Value = ultrasoundReport.HepaticDucts;
	InsertCommand.Parameters["@CBD"].Value = ultrasoundReport.CBD;
	InsertCommand.Parameters["@Pancreas"].Value = ultrasoundReport.Pancreas;
	InsertCommand.Parameters["@Spleen"].Value = ultrasoundReport.Spleen;
	InsertCommand.Parameters["@RightKidney"].Value = ultrasoundReport.RightKidney;
	InsertCommand.Parameters["@LeftKidney"].Value = ultrasoundReport.LeftKidney;
	InsertCommand.Parameters["@Bladder"].Value = ultrasoundReport.Bladder;
	InsertCommand.Parameters["@Uterus"].Value = ultrasoundReport.Uterus;
	InsertCommand.Parameters["@Ovary"].Value = ultrasoundReport.Ovary;
	InsertCommand.Parameters["@Others"].Value = ultrasoundReport.Others;
	InsertCommand.Parameters["@Impression"].Value = ultrasoundReport.Impression;
	InsertCommand.Parameters["@UltrasoundReportDate"].Value = ultrasoundReport.UltrasoundReportDate;
	InsertCommand.Parameters["@ConsultantRadiologist"].Value = ultrasoundReport.ConsultantRadiologist;
	InsertCommand.Parameters["@Status"].Value = ultrasoundReport.Status;
		
			
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
        
		public int Update(UltrasoundReport ultrasoundReport)
		{
	UpdateCommand.Parameters["@ID"].Value = ultrasoundReport.ID;
	UpdateCommand.Parameters["@PatientID"].Value = ultrasoundReport.PatientID;
	UpdateCommand.Parameters["@PatientName"].Value = ultrasoundReport.PatientName;
	UpdateCommand.Parameters["@DOB"].Value = ultrasoundReport.DOB;
	UpdateCommand.Parameters["@Sex"].Value = ultrasoundReport.Sex;
	UpdateCommand.Parameters["@ImagePath"].Value = ultrasoundReport.ImagePath;
	UpdateCommand.Parameters["@LiverSize"].Value = ultrasoundReport.LiverSize;
	UpdateCommand.Parameters["@LiverMargin"].Value = ultrasoundReport.LiverMargin;
	UpdateCommand.Parameters["@LiverSOL"].Value = ultrasoundReport.LiverSOL;
	UpdateCommand.Parameters["@LiverEchogenicity"].Value = ultrasoundReport.LiverEchogenicity;
	UpdateCommand.Parameters["@LiverCaudatelobe"].Value = ultrasoundReport.LiverCaudatelobe;
	UpdateCommand.Parameters["@GallBLadderWallThickness"].Value = ultrasoundReport.GallBLadderWallThickness;
	UpdateCommand.Parameters["@GallBLadderContent"].Value = ultrasoundReport.GallBLadderContent;
	UpdateCommand.Parameters["@HepaticDucts"].Value = ultrasoundReport.HepaticDucts;
	UpdateCommand.Parameters["@CBD"].Value = ultrasoundReport.CBD;
	UpdateCommand.Parameters["@Pancreas"].Value = ultrasoundReport.Pancreas;
	UpdateCommand.Parameters["@Spleen"].Value = ultrasoundReport.Spleen;
	UpdateCommand.Parameters["@RightKidney"].Value = ultrasoundReport.RightKidney;
	UpdateCommand.Parameters["@LeftKidney"].Value = ultrasoundReport.LeftKidney;
	UpdateCommand.Parameters["@Bladder"].Value = ultrasoundReport.Bladder;
	UpdateCommand.Parameters["@Uterus"].Value = ultrasoundReport.Uterus;
	UpdateCommand.Parameters["@Ovary"].Value = ultrasoundReport.Ovary;
	UpdateCommand.Parameters["@Others"].Value = ultrasoundReport.Others;
	UpdateCommand.Parameters["@Impression"].Value = ultrasoundReport.Impression;
	UpdateCommand.Parameters["@UltrasoundReportDate"].Value = ultrasoundReport.UltrasoundReportDate;
	UpdateCommand.Parameters["@ConsultantRadiologist"].Value = ultrasoundReport.ConsultantRadiologist;
	UpdateCommand.Parameters["@Status"].Value = ultrasoundReport.Status;

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
        
        private UltrasoundReport DataTableToEntity(DataTable dt)
        {
           
            UltrasoundReport ultrasoundReport = new UltrasoundReport();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						ultrasoundReport.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						ultrasoundReport.ID=0;
					}
					if (Null.IsNotNull(dr["PatientID"]))
					{
						ultrasoundReport.PatientID=Convert.ToInt32(dr["PatientID"]);
					}
					else
					{
						ultrasoundReport.PatientID=0;
					}
					if (Null.IsNotNull(dr["PatientName"]))
					{
						ultrasoundReport.PatientName= Convert.ToString(dr["PatientName"]);
					}
					else
					{
						ultrasoundReport.PatientName=string.Empty;
					}
					if (Null.IsNotNull(dr["DOB"]))
					{
						ultrasoundReport.DOB= Convert.ToDateTime(dr["DOB"]);
					}
					else
					{
						ultrasoundReport.DOB=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Sex"]))
					{
						ultrasoundReport.Sex= Convert.ToString(dr["Sex"]);
					}
					else
					{
						ultrasoundReport.Sex=string.Empty;
					}
					if (Null.IsNotNull(dr["ImagePath"]))
					{
						ultrasoundReport.ImagePath= Convert.ToString(dr["ImagePath"]);
					}
					else
					{
						ultrasoundReport.ImagePath=string.Empty;
					}
					if (Null.IsNotNull(dr["LiverSize"]))
					{
						ultrasoundReport.LiverSize= Convert.ToString(dr["LiverSize"]);
					}
					else
					{
						ultrasoundReport.LiverSize=string.Empty;
					}
					if (Null.IsNotNull(dr["LiverMargin"]))
					{
						ultrasoundReport.LiverMargin= Convert.ToString(dr["LiverMargin"]);
					}
					else
					{
						ultrasoundReport.LiverMargin=string.Empty;
					}
					if (Null.IsNotNull(dr["LiverSOL"]))
					{
						ultrasoundReport.LiverSOL= Convert.ToString(dr["LiverSOL"]);
					}
					else
					{
						ultrasoundReport.LiverSOL=string.Empty;
					}
					if (Null.IsNotNull(dr["LiverEchogenicity"]))
					{
						ultrasoundReport.LiverEchogenicity= Convert.ToString(dr["LiverEchogenicity"]);
					}
					else
					{
						ultrasoundReport.LiverEchogenicity=string.Empty;
					}
					if (Null.IsNotNull(dr["LiverCaudatelobe"]))
					{
						ultrasoundReport.LiverCaudatelobe= Convert.ToString(dr["LiverCaudatelobe"]);
					}
					else
					{
						ultrasoundReport.LiverCaudatelobe=string.Empty;
					}
					if (Null.IsNotNull(dr["GallBLadderWallThickness"]))
					{
						ultrasoundReport.GallBLadderWallThickness= Convert.ToString(dr["GallBLadderWallThickness"]);
					}
					else
					{
						ultrasoundReport.GallBLadderWallThickness=string.Empty;
					}
					if (Null.IsNotNull(dr["GallBLadderContent"]))
					{
						ultrasoundReport.GallBLadderContent= Convert.ToString(dr["GallBLadderContent"]);
					}
					else
					{
						ultrasoundReport.GallBLadderContent=string.Empty;
					}
					if (Null.IsNotNull(dr["HepaticDucts"]))
					{
						ultrasoundReport.HepaticDucts= Convert.ToString(dr["HepaticDucts"]);
					}
					else
					{
						ultrasoundReport.HepaticDucts=string.Empty;
					}
					if (Null.IsNotNull(dr["CBD"]))
					{
						ultrasoundReport.CBD= Convert.ToString(dr["CBD"]);
					}
					else
					{
						ultrasoundReport.CBD=string.Empty;
					}
					if (Null.IsNotNull(dr["Pancreas"]))
					{
						ultrasoundReport.Pancreas= Convert.ToString(dr["Pancreas"]);
					}
					else
					{
						ultrasoundReport.Pancreas=string.Empty;
					}
					if (Null.IsNotNull(dr["Spleen"]))
					{
						ultrasoundReport.Spleen= Convert.ToString(dr["Spleen"]);
					}
					else
					{
						ultrasoundReport.Spleen=string.Empty;
					}
					if (Null.IsNotNull(dr["RightKidney"]))
					{
						ultrasoundReport.RightKidney= Convert.ToString(dr["RightKidney"]);
					}
					else
					{
						ultrasoundReport.RightKidney=string.Empty;
					}
					if (Null.IsNotNull(dr["LeftKidney"]))
					{
						ultrasoundReport.LeftKidney= Convert.ToString(dr["LeftKidney"]);
					}
					else
					{
						ultrasoundReport.LeftKidney=string.Empty;
					}
					if (Null.IsNotNull(dr["Bladder"]))
					{
						ultrasoundReport.Bladder= Convert.ToString(dr["Bladder"]);
					}
					else
					{
						ultrasoundReport.Bladder=string.Empty;
					}
					if (Null.IsNotNull(dr["Uterus"]))
					{
						ultrasoundReport.Uterus= Convert.ToString(dr["Uterus"]);
					}
					else
					{
						ultrasoundReport.Uterus=string.Empty;
					}
					if (Null.IsNotNull(dr["Ovary"]))
					{
						ultrasoundReport.Ovary= Convert.ToString(dr["Ovary"]);
					}
					else
					{
						ultrasoundReport.Ovary=string.Empty;
					}
					if (Null.IsNotNull(dr["Others"]))
					{
						ultrasoundReport.Others= Convert.ToString(dr["Others"]);
					}
					else
					{
						ultrasoundReport.Others=string.Empty;
					}
					if (Null.IsNotNull(dr["Impression"]))
					{
						ultrasoundReport.Impression= Convert.ToString(dr["Impression"]);
					}
					else
					{
						ultrasoundReport.Impression=string.Empty;
					}
					if (Null.IsNotNull(dr["UltrasoundReportDate"]))
					{
						ultrasoundReport.UltrasoundReportDate= Convert.ToDateTime(dr["UltrasoundReportDate"]);
					}
					else
					{
						ultrasoundReport.UltrasoundReportDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["ConsultantRadiologist"]))
					{
						ultrasoundReport.ConsultantRadiologist= Convert.ToString(dr["ConsultantRadiologist"]);
					}
					else
					{
						ultrasoundReport.ConsultantRadiologist=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						ultrasoundReport.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						ultrasoundReport.Status=string.Empty;
					}
 
                }
            }
            return ultrasoundReport ;
        }
		#endregion		
	}
}