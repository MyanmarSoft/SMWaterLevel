using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class MedicalReportTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public MedicalReportTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO MedicalReport(PatientID,PatientName,ImagePath,Height,Weight,BMI,Skin,Scalp,Deformity,FVUncorrectedLeft,FVUncorrectedRight,FVCorrectedLeft,FVCorrectedRight,NVUncorrectedLeft,NVUncorrectedRight,NVCorrectedLeft,NVCorrectedRight,ColourVision,EyeAndPupilsEqual,EyeAndPupilsRegular,FudusExamination,EarDrums,EarHearingLeft,EarHearingRight,EarNose,EarNeckgland,EarTonsils,EarThyroid,TeethAndMouth,TeethUpper,TeethLower,RespRate,BreathSounds,Others,Heartrate,BP,Auscultation,Liver,Spleen,Kidneys,BowelSound,HernialOrifices,GenitoUrinary,ExtremitiesSwelling,ExtremitiesDeformity,Skull,Spine,UpperExtremities,LowerExtremities,SkinAndVariousVeins,Neurological,Motor,Sensory,Reflexes,MentalState,MedicalReportName,MedicalReportDate,Status) VALUES (@PatientID,@PatientName,@ImagePath,@Height,@Weight,@BMI,@Skin,@Scalp,@Deformity,@FVUncorrectedLeft,@FVUncorrectedRight,@FVCorrectedLeft,@FVCorrectedRight,@NVUncorrectedLeft,@NVUncorrectedRight,@NVCorrectedLeft,@NVCorrectedRight,@ColourVision,@EyeAndPupilsEqual,@EyeAndPupilsRegular,@FudusExamination,@EarDrums,@EarHearingLeft,@EarHearingRight,@EarNose,@EarNeckgland,@EarTonsils,@EarThyroid,@TeethAndMouth,@TeethUpper,@TeethLower,@RespRate,@BreathSounds,@Others,@Heartrate,@BP,@Auscultation,@Liver,@Spleen,@Kidneys,@BowelSound,@HernialOrifices,@GenitoUrinary,@ExtremitiesSwelling,@ExtremitiesDeformity,@Skull,@Spine,@UpperExtremities,@LowerExtremities,@SkinAndVariousVeins,@Neurological,@Motor,@Sensory,@Reflexes,@MentalState,@MedicalReportName,@MedicalReportDate,@Status);SELECT ID FROM MedicalReport WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			InsertCommand.Parameters.Add(new SqlParameter("@Height", SqlDbType.VarChar, 10,"Height"));
			InsertCommand.Parameters.Add(new SqlParameter("@Weight", SqlDbType.VarChar, 10,"Weight"));
			InsertCommand.Parameters.Add(new SqlParameter("@BMI", SqlDbType.VarChar, 10,"BMI"));
			InsertCommand.Parameters.Add(new SqlParameter("@Skin", SqlDbType.VarChar, 10,"Skin"));
			InsertCommand.Parameters.Add(new SqlParameter("@Scalp", SqlDbType.VarChar, 10,"Scalp"));
			InsertCommand.Parameters.Add(new SqlParameter("@Deformity", SqlDbType.VarChar, 50,"Deformity"));
			InsertCommand.Parameters.Add(new SqlParameter("@FVUncorrectedLeft", SqlDbType.VarChar, 10,"FVUncorrectedLeft"));
			InsertCommand.Parameters.Add(new SqlParameter("@FVUncorrectedRight", SqlDbType.VarChar, 10,"FVUncorrectedRight"));
			InsertCommand.Parameters.Add(new SqlParameter("@FVCorrectedLeft", SqlDbType.VarChar, 10,"FVCorrectedLeft"));
			InsertCommand.Parameters.Add(new SqlParameter("@FVCorrectedRight", SqlDbType.VarChar, 10,"FVCorrectedRight"));
			InsertCommand.Parameters.Add(new SqlParameter("@NVUncorrectedLeft", SqlDbType.VarChar, 10,"NVUncorrectedLeft"));
			InsertCommand.Parameters.Add(new SqlParameter("@NVUncorrectedRight", SqlDbType.VarChar, 10,"NVUncorrectedRight"));
			InsertCommand.Parameters.Add(new SqlParameter("@NVCorrectedLeft", SqlDbType.VarChar, 10,"NVCorrectedLeft"));
			InsertCommand.Parameters.Add(new SqlParameter("@NVCorrectedRight", SqlDbType.VarChar, 10,"NVCorrectedRight"));
			InsertCommand.Parameters.Add(new SqlParameter("@ColourVision", SqlDbType.VarChar, 10,"ColourVision"));
			InsertCommand.Parameters.Add(new SqlParameter("@EyeAndPupilsEqual", SqlDbType.VarChar, 10,"EyeAndPupilsEqual"));
			InsertCommand.Parameters.Add(new SqlParameter("@EyeAndPupilsRegular", SqlDbType.VarChar, 10,"EyeAndPupilsRegular"));
			InsertCommand.Parameters.Add(new SqlParameter("@FudusExamination", SqlDbType.VarChar, 10,"FudusExamination"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarDrums", SqlDbType.VarChar, 10,"EarDrums"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarHearingLeft", SqlDbType.VarChar, 10,"EarHearingLeft"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarHearingRight", SqlDbType.VarChar, 10,"EarHearingRight"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarNose", SqlDbType.VarChar, 10,"EarNose"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarNeckgland", SqlDbType.VarChar, 10,"EarNeckgland"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarTonsils", SqlDbType.VarChar, 10,"EarTonsils"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarThyroid", SqlDbType.VarChar, 10,"EarThyroid"));
			InsertCommand.Parameters.Add(new SqlParameter("@TeethAndMouth", SqlDbType.VarChar, 10,"TeethAndMouth"));
			InsertCommand.Parameters.Add(new SqlParameter("@TeethUpper", SqlDbType.VarChar, 10,"TeethUpper"));
			InsertCommand.Parameters.Add(new SqlParameter("@TeethLower", SqlDbType.VarChar, 10,"TeethLower"));
			InsertCommand.Parameters.Add(new SqlParameter("@RespRate", SqlDbType.VarChar, 10,"RespRate"));
			InsertCommand.Parameters.Add(new SqlParameter("@BreathSounds", SqlDbType.VarChar, 10,"BreathSounds"));
			InsertCommand.Parameters.Add(new SqlParameter("@Others", SqlDbType.VarChar, 10,"Others"));
			InsertCommand.Parameters.Add(new SqlParameter("@Heartrate", SqlDbType.VarChar, 10,"Heartrate"));
			InsertCommand.Parameters.Add(new SqlParameter("@BP", SqlDbType.VarChar, 10,"BP"));
			InsertCommand.Parameters.Add(new SqlParameter("@Auscultation", SqlDbType.VarChar, 50,"Auscultation"));
			InsertCommand.Parameters.Add(new SqlParameter("@Liver", SqlDbType.VarChar, 10,"Liver"));
			InsertCommand.Parameters.Add(new SqlParameter("@Spleen", SqlDbType.VarChar, 10,"Spleen"));
			InsertCommand.Parameters.Add(new SqlParameter("@Kidneys", SqlDbType.VarChar, 10,"Kidneys"));
			InsertCommand.Parameters.Add(new SqlParameter("@BowelSound", SqlDbType.VarChar, 10,"BowelSound"));
			InsertCommand.Parameters.Add(new SqlParameter("@HernialOrifices", SqlDbType.VarChar, 10,"HernialOrifices"));
			InsertCommand.Parameters.Add(new SqlParameter("@GenitoUrinary", SqlDbType.VarChar, 10,"GenitoUrinary"));
			InsertCommand.Parameters.Add(new SqlParameter("@ExtremitiesSwelling", SqlDbType.VarChar, 50,"ExtremitiesSwelling"));
			InsertCommand.Parameters.Add(new SqlParameter("@ExtremitiesDeformity", SqlDbType.VarChar, 50,"ExtremitiesDeformity"));
			InsertCommand.Parameters.Add(new SqlParameter("@Skull", SqlDbType.VarChar, 10,"Skull"));
			InsertCommand.Parameters.Add(new SqlParameter("@Spine", SqlDbType.VarChar, 10,"Spine"));
			InsertCommand.Parameters.Add(new SqlParameter("@UpperExtremities", SqlDbType.VarChar, 10,"UpperExtremities"));
			InsertCommand.Parameters.Add(new SqlParameter("@LowerExtremities", SqlDbType.VarChar, 10,"LowerExtremities"));
			InsertCommand.Parameters.Add(new SqlParameter("@SkinAndVariousVeins", SqlDbType.VarChar, 10,"SkinAndVariousVeins"));
			InsertCommand.Parameters.Add(new SqlParameter("@Neurological", SqlDbType.VarChar, 10,"Neurological"));
			InsertCommand.Parameters.Add(new SqlParameter("@Motor", SqlDbType.VarChar, 10,"Motor"));
			InsertCommand.Parameters.Add(new SqlParameter("@Sensory", SqlDbType.VarChar, 10,"Sensory"));
			InsertCommand.Parameters.Add(new SqlParameter("@Reflexes", SqlDbType.VarChar, 10,"Reflexes"));
			InsertCommand.Parameters.Add(new SqlParameter("@MentalState", SqlDbType.VarChar, 10,"MentalState"));
			InsertCommand.Parameters.Add(new SqlParameter("@MedicalReportName", SqlDbType.VarChar, 50,"MedicalReportName"));
			InsertCommand.Parameters.Add(new SqlParameter("@MedicalReportDate", SqlDbType.DateTime, 8,"MedicalReportDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE MedicalReport SET PatientID = @PatientID, PatientName = @PatientName, ImagePath = @ImagePath, Height = @Height, Weight = @Weight, BMI = @BMI, Skin = @Skin, Scalp = @Scalp, Deformity = @Deformity, FVUncorrectedLeft = @FVUncorrectedLeft, FVUncorrectedRight = @FVUncorrectedRight, FVCorrectedLeft = @FVCorrectedLeft, FVCorrectedRight = @FVCorrectedRight, NVUncorrectedLeft = @NVUncorrectedLeft, NVUncorrectedRight = @NVUncorrectedRight, NVCorrectedLeft = @NVCorrectedLeft, NVCorrectedRight = @NVCorrectedRight, ColourVision = @ColourVision, EyeAndPupilsEqual = @EyeAndPupilsEqual, EyeAndPupilsRegular = @EyeAndPupilsRegular, FudusExamination = @FudusExamination, EarDrums = @EarDrums, EarHearingLeft = @EarHearingLeft, EarHearingRight = @EarHearingRight, EarNose = @EarNose, EarNeckgland = @EarNeckgland, EarTonsils = @EarTonsils, EarThyroid = @EarThyroid, TeethAndMouth = @TeethAndMouth, TeethUpper = @TeethUpper, TeethLower = @TeethLower, RespRate = @RespRate, BreathSounds = @BreathSounds, Others = @Others, Heartrate = @Heartrate, BP = @BP, Auscultation = @Auscultation, Liver = @Liver, Spleen = @Spleen, Kidneys = @Kidneys, BowelSound = @BowelSound, HernialOrifices = @HernialOrifices, GenitoUrinary = @GenitoUrinary, ExtremitiesSwelling = @ExtremitiesSwelling, ExtremitiesDeformity = @ExtremitiesDeformity, Skull = @Skull, Spine = @Spine, UpperExtremities = @UpperExtremities, LowerExtremities = @LowerExtremities, SkinAndVariousVeins = @SkinAndVariousVeins, Neurological = @Neurological, Motor = @Motor, Sensory = @Sensory, Reflexes = @Reflexes, MentalState = @MentalState, MedicalReportName = @MedicalReportName, MedicalReportDate = @MedicalReportDate, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientName", SqlDbType.VarChar, 50,"PatientName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Height", SqlDbType.VarChar, 10,"Height"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Weight", SqlDbType.VarChar, 10,"Weight"));
			UpdateCommand.Parameters.Add(new SqlParameter("@BMI", SqlDbType.VarChar, 10,"BMI"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Skin", SqlDbType.VarChar, 10,"Skin"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Scalp", SqlDbType.VarChar, 10,"Scalp"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Deformity", SqlDbType.VarChar, 50,"Deformity"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FVUncorrectedLeft", SqlDbType.VarChar, 10,"FVUncorrectedLeft"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FVUncorrectedRight", SqlDbType.VarChar, 10,"FVUncorrectedRight"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FVCorrectedLeft", SqlDbType.VarChar, 10,"FVCorrectedLeft"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FVCorrectedRight", SqlDbType.VarChar, 10,"FVCorrectedRight"));
			UpdateCommand.Parameters.Add(new SqlParameter("@NVUncorrectedLeft", SqlDbType.VarChar, 10,"NVUncorrectedLeft"));
			UpdateCommand.Parameters.Add(new SqlParameter("@NVUncorrectedRight", SqlDbType.VarChar, 10,"NVUncorrectedRight"));
			UpdateCommand.Parameters.Add(new SqlParameter("@NVCorrectedLeft", SqlDbType.VarChar, 10,"NVCorrectedLeft"));
			UpdateCommand.Parameters.Add(new SqlParameter("@NVCorrectedRight", SqlDbType.VarChar, 10,"NVCorrectedRight"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ColourVision", SqlDbType.VarChar, 10,"ColourVision"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EyeAndPupilsEqual", SqlDbType.VarChar, 10,"EyeAndPupilsEqual"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EyeAndPupilsRegular", SqlDbType.VarChar, 10,"EyeAndPupilsRegular"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FudusExamination", SqlDbType.VarChar, 10,"FudusExamination"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarDrums", SqlDbType.VarChar, 10,"EarDrums"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarHearingLeft", SqlDbType.VarChar, 10,"EarHearingLeft"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarHearingRight", SqlDbType.VarChar, 10,"EarHearingRight"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarNose", SqlDbType.VarChar, 10,"EarNose"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarNeckgland", SqlDbType.VarChar, 10,"EarNeckgland"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarTonsils", SqlDbType.VarChar, 10,"EarTonsils"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarThyroid", SqlDbType.VarChar, 10,"EarThyroid"));
			UpdateCommand.Parameters.Add(new SqlParameter("@TeethAndMouth", SqlDbType.VarChar, 10,"TeethAndMouth"));
			UpdateCommand.Parameters.Add(new SqlParameter("@TeethUpper", SqlDbType.VarChar, 10,"TeethUpper"));
			UpdateCommand.Parameters.Add(new SqlParameter("@TeethLower", SqlDbType.VarChar, 10,"TeethLower"));
			UpdateCommand.Parameters.Add(new SqlParameter("@RespRate", SqlDbType.VarChar, 10,"RespRate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@BreathSounds", SqlDbType.VarChar, 10,"BreathSounds"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Others", SqlDbType.VarChar, 10,"Others"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Heartrate", SqlDbType.VarChar, 10,"Heartrate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@BP", SqlDbType.VarChar, 10,"BP"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Auscultation", SqlDbType.VarChar, 50,"Auscultation"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Liver", SqlDbType.VarChar, 10,"Liver"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Spleen", SqlDbType.VarChar, 10,"Spleen"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Kidneys", SqlDbType.VarChar, 10,"Kidneys"));
			UpdateCommand.Parameters.Add(new SqlParameter("@BowelSound", SqlDbType.VarChar, 10,"BowelSound"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HernialOrifices", SqlDbType.VarChar, 10,"HernialOrifices"));
			UpdateCommand.Parameters.Add(new SqlParameter("@GenitoUrinary", SqlDbType.VarChar, 10,"GenitoUrinary"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ExtremitiesSwelling", SqlDbType.VarChar, 50,"ExtremitiesSwelling"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ExtremitiesDeformity", SqlDbType.VarChar, 50,"ExtremitiesDeformity"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Skull", SqlDbType.VarChar, 10,"Skull"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Spine", SqlDbType.VarChar, 10,"Spine"));
			UpdateCommand.Parameters.Add(new SqlParameter("@UpperExtremities", SqlDbType.VarChar, 10,"UpperExtremities"));
			UpdateCommand.Parameters.Add(new SqlParameter("@LowerExtremities", SqlDbType.VarChar, 10,"LowerExtremities"));
			UpdateCommand.Parameters.Add(new SqlParameter("@SkinAndVariousVeins", SqlDbType.VarChar, 10,"SkinAndVariousVeins"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Neurological", SqlDbType.VarChar, 10,"Neurological"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Motor", SqlDbType.VarChar, 10,"Motor"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Sensory", SqlDbType.VarChar, 10,"Sensory"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Reflexes", SqlDbType.VarChar, 10,"Reflexes"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MentalState", SqlDbType.VarChar, 10,"MentalState"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MedicalReportName", SqlDbType.VarChar, 50,"MedicalReportName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MedicalReportDate", SqlDbType.DateTime, 8,"MedicalReportDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM MedicalReport WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,PatientID,PatientName,ImagePath,Height,Weight,BMI,Skin,Scalp,Deformity,FVUncorrectedLeft,FVUncorrectedRight,FVCorrectedLeft,FVCorrectedRight,NVUncorrectedLeft,NVUncorrectedRight,NVCorrectedLeft,NVCorrectedRight,ColourVision,EyeAndPupilsEqual,EyeAndPupilsRegular,FudusExamination,EarDrums,EarHearingLeft,EarHearingRight,EarNose,EarNeckgland,EarTonsils,EarThyroid,TeethAndMouth,TeethUpper,TeethLower,RespRate,BreathSounds,Others,Heartrate,BP,Auscultation,Liver,Spleen,Kidneys,BowelSound,HernialOrifices,GenitoUrinary,ExtremitiesSwelling,ExtremitiesDeformity,Skull,Spine,UpperExtremities,LowerExtremities,SkinAndVariousVeins,Neurological,Motor,Sensory,Reflexes,MentalState,MedicalReportName,MedicalReportDate,Status FROM MedicalReport";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,PatientID,PatientName,ImagePath,Height,Weight,BMI,Skin,Scalp,Deformity,FVUncorrectedLeft,FVUncorrectedRight,FVCorrectedLeft,FVCorrectedRight,NVUncorrectedLeft,NVUncorrectedRight,NVCorrectedLeft,NVCorrectedRight,ColourVision,EyeAndPupilsEqual,EyeAndPupilsRegular,FudusExamination,EarDrums,EarHearingLeft,EarHearingRight,EarNose,EarNeckgland,EarTonsils,EarThyroid,TeethAndMouth,TeethUpper,TeethLower,RespRate,BreathSounds,Others,Heartrate,BP,Auscultation,Liver,Spleen,Kidneys,BowelSound,HernialOrifices,GenitoUrinary,ExtremitiesSwelling,ExtremitiesDeformity,Skull,Spine,UpperExtremities,LowerExtremities,SkinAndVariousVeins,Neurological,Motor,Sensory,Reflexes,MentalState,MedicalReportName,MedicalReportDate,Status FROM MedicalReport WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,PatientID,PatientName,ImagePath,Height,Weight,BMI,Skin,Scalp,Deformity,FVUncorrectedLeft,FVUncorrectedRight,FVCorrectedLeft,FVCorrectedRight,NVUncorrectedLeft,NVUncorrectedRight,NVCorrectedLeft,NVCorrectedRight,ColourVision,EyeAndPupilsEqual,EyeAndPupilsRegular,FudusExamination,EarDrums,EarHearingLeft,EarHearingRight,EarNose,EarNeckgland,EarTonsils,EarThyroid,TeethAndMouth,TeethUpper,TeethLower,RespRate,BreathSounds,Others,Heartrate,BP,Auscultation,Liver,Spleen,Kidneys,BowelSound,HernialOrifices,GenitoUrinary,ExtremitiesSwelling,ExtremitiesDeformity,Skull,Spine,UpperExtremities,LowerExtremities,SkinAndVariousVeins,Neurological,Motor,Sensory,Reflexes,MentalState,MedicalReportName,MedicalReportDate,Status FROM MedicalReport WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
            //Fill/GetMedicalReportByPatientID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,PatientID,PatientName,Height,Weight,BMI,Skin,Scalp,Deformity,FVUncorrectedLeft,FVUncorrectedRight,FVCorrectedLeft,FVCorrectedRight,NVUncorrectedLeft,NVUncorrectedRight,NVCorrectedLeft,NVCorrectedRight,ColourVision,EyeAndPupilsEqual,EyeAndPupilsRegular,FudusExamination,EarDrums,EarHearingLeft,EarHearingRight,EarNose,EarNeckgland,EarTonsils,EarThyroid,TeethAndMouth,TeethUpper,TeethLower,RespRate,BreathSounds,Others,Heartrate,BP,Auscultation,Liver,Spleen,Kidneys,BowelSound,HernialOrifices,GenitoUrinary,ExtremitiesSwelling,ExtremitiesDeformity,Skull,Spine,UpperExtremities,LowerExtremities,SkinAndVariousVeins,Neurological,Motor,Sensory,Reflexes,MentalState,MedicalReportName,MedicalReportDate,Status FROM MedicalReport WHERE PatientID = @PatientID AND Status =  @Status";
            ((SqlCommand)(CommandCollection[3])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[3])).Parameters.Add(new SqlParameter("@PatientID", SqlDbType.VarChar, 50, "PatientID"));
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

		public MedicalReport GetMedicalReportByID(int ID)
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
		
		public DataSet GetMedicalReportByStatus(string status)
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
		
		
		
		
		
		
		
		#endregion CustomGetTable
	    
		public int Insert(MedicalReport medicalReport)
		{
	InsertCommand.Parameters["@PatientID"].Value = medicalReport.PatientID;
	InsertCommand.Parameters["@PatientName"].Value = medicalReport.PatientName;
	InsertCommand.Parameters["@ImagePath"].Value = medicalReport.ImagePath;
	InsertCommand.Parameters["@Height"].Value = medicalReport.Height;
	InsertCommand.Parameters["@Weight"].Value = medicalReport.Weight;
	InsertCommand.Parameters["@BMI"].Value = medicalReport.BMI;
	InsertCommand.Parameters["@Skin"].Value = medicalReport.Skin;
	InsertCommand.Parameters["@Scalp"].Value = medicalReport.Scalp;
	InsertCommand.Parameters["@Deformity"].Value = medicalReport.Deformity;
	InsertCommand.Parameters["@FVUncorrectedLeft"].Value = medicalReport.FVUncorrectedLeft;
	InsertCommand.Parameters["@FVUncorrectedRight"].Value = medicalReport.FVUncorrectedRight;
	InsertCommand.Parameters["@FVCorrectedLeft"].Value = medicalReport.FVCorrectedLeft;
	InsertCommand.Parameters["@FVCorrectedRight"].Value = medicalReport.FVCorrectedRight;
	InsertCommand.Parameters["@NVUncorrectedLeft"].Value = medicalReport.NVUncorrectedLeft;
	InsertCommand.Parameters["@NVUncorrectedRight"].Value = medicalReport.NVUncorrectedRight;
	InsertCommand.Parameters["@NVCorrectedLeft"].Value = medicalReport.NVCorrectedLeft;
	InsertCommand.Parameters["@NVCorrectedRight"].Value = medicalReport.NVCorrectedRight;
	InsertCommand.Parameters["@ColourVision"].Value = medicalReport.ColourVision;
	InsertCommand.Parameters["@EyeAndPupilsEqual"].Value = medicalReport.EyeAndPupilsEqual;
	InsertCommand.Parameters["@EyeAndPupilsRegular"].Value = medicalReport.EyeAndPupilsRegular;
	InsertCommand.Parameters["@FudusExamination"].Value = medicalReport.FudusExamination;
	InsertCommand.Parameters["@EarDrums"].Value = medicalReport.EarDrums;
	InsertCommand.Parameters["@EarHearingLeft"].Value = medicalReport.EarHearingLeft;
	InsertCommand.Parameters["@EarHearingRight"].Value = medicalReport.EarHearingRight;
	InsertCommand.Parameters["@EarNose"].Value = medicalReport.EarNose;
	InsertCommand.Parameters["@EarNeckgland"].Value = medicalReport.EarNeckgland;
	InsertCommand.Parameters["@EarTonsils"].Value = medicalReport.EarTonsils;
	InsertCommand.Parameters["@EarThyroid"].Value = medicalReport.EarThyroid;
	InsertCommand.Parameters["@TeethAndMouth"].Value = medicalReport.TeethAndMouth;
	InsertCommand.Parameters["@TeethUpper"].Value = medicalReport.TeethUpper;
	InsertCommand.Parameters["@TeethLower"].Value = medicalReport.TeethLower;
	InsertCommand.Parameters["@RespRate"].Value = medicalReport.RespRate;
	InsertCommand.Parameters["@BreathSounds"].Value = medicalReport.BreathSounds;
	InsertCommand.Parameters["@Others"].Value = medicalReport.Others;
	InsertCommand.Parameters["@Heartrate"].Value = medicalReport.Heartrate;
	InsertCommand.Parameters["@BP"].Value = medicalReport.BP;
	InsertCommand.Parameters["@Auscultation"].Value = medicalReport.Auscultation;
	InsertCommand.Parameters["@Liver"].Value = medicalReport.Liver;
	InsertCommand.Parameters["@Spleen"].Value = medicalReport.Spleen;
	InsertCommand.Parameters["@Kidneys"].Value = medicalReport.Kidneys;
	InsertCommand.Parameters["@BowelSound"].Value = medicalReport.BowelSound;
	InsertCommand.Parameters["@HernialOrifices"].Value = medicalReport.HernialOrifices;
	InsertCommand.Parameters["@GenitoUrinary"].Value = medicalReport.GenitoUrinary;
	InsertCommand.Parameters["@ExtremitiesSwelling"].Value = medicalReport.ExtremitiesSwelling;
	InsertCommand.Parameters["@ExtremitiesDeformity"].Value = medicalReport.ExtremitiesDeformity;
	InsertCommand.Parameters["@Skull"].Value = medicalReport.Skull;
	InsertCommand.Parameters["@Spine"].Value = medicalReport.Spine;
	InsertCommand.Parameters["@UpperExtremities"].Value = medicalReport.UpperExtremities;
	InsertCommand.Parameters["@LowerExtremities"].Value = medicalReport.LowerExtremities;
	InsertCommand.Parameters["@SkinAndVariousVeins"].Value = medicalReport.SkinAndVariousVeins;
	InsertCommand.Parameters["@Neurological"].Value = medicalReport.Neurological;
	InsertCommand.Parameters["@Motor"].Value = medicalReport.Motor;
	InsertCommand.Parameters["@Sensory"].Value = medicalReport.Sensory;
	InsertCommand.Parameters["@Reflexes"].Value = medicalReport.Reflexes;
	InsertCommand.Parameters["@MentalState"].Value = medicalReport.MentalState;
	InsertCommand.Parameters["@MedicalReportName"].Value = medicalReport.MedicalReportName;
	InsertCommand.Parameters["@MedicalReportDate"].Value = medicalReport.MedicalReportDate;
	InsertCommand.Parameters["@Status"].Value = medicalReport.Status;
		
			
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
        
		public int Update(MedicalReport medicalReport)
		{
	UpdateCommand.Parameters["@ID"].Value = medicalReport.ID;
	UpdateCommand.Parameters["@PatientID"].Value = medicalReport.PatientID;
	UpdateCommand.Parameters["@PatientName"].Value = medicalReport.PatientName;
	UpdateCommand.Parameters["@ImagePath"].Value = medicalReport.ImagePath;
	UpdateCommand.Parameters["@Height"].Value = medicalReport.Height;
	UpdateCommand.Parameters["@Weight"].Value = medicalReport.Weight;
	UpdateCommand.Parameters["@BMI"].Value = medicalReport.BMI;
	UpdateCommand.Parameters["@Skin"].Value = medicalReport.Skin;
	UpdateCommand.Parameters["@Scalp"].Value = medicalReport.Scalp;
	UpdateCommand.Parameters["@Deformity"].Value = medicalReport.Deformity;
	UpdateCommand.Parameters["@FVUncorrectedLeft"].Value = medicalReport.FVUncorrectedLeft;
	UpdateCommand.Parameters["@FVUncorrectedRight"].Value = medicalReport.FVUncorrectedRight;
	UpdateCommand.Parameters["@FVCorrectedLeft"].Value = medicalReport.FVCorrectedLeft;
	UpdateCommand.Parameters["@FVCorrectedRight"].Value = medicalReport.FVCorrectedRight;
	UpdateCommand.Parameters["@NVUncorrectedLeft"].Value = medicalReport.NVUncorrectedLeft;
	UpdateCommand.Parameters["@NVUncorrectedRight"].Value = medicalReport.NVUncorrectedRight;
	UpdateCommand.Parameters["@NVCorrectedLeft"].Value = medicalReport.NVCorrectedLeft;
	UpdateCommand.Parameters["@NVCorrectedRight"].Value = medicalReport.NVCorrectedRight;
	UpdateCommand.Parameters["@ColourVision"].Value = medicalReport.ColourVision;
	UpdateCommand.Parameters["@EyeAndPupilsEqual"].Value = medicalReport.EyeAndPupilsEqual;
	UpdateCommand.Parameters["@EyeAndPupilsRegular"].Value = medicalReport.EyeAndPupilsRegular;
	UpdateCommand.Parameters["@FudusExamination"].Value = medicalReport.FudusExamination;
	UpdateCommand.Parameters["@EarDrums"].Value = medicalReport.EarDrums;
	UpdateCommand.Parameters["@EarHearingLeft"].Value = medicalReport.EarHearingLeft;
	UpdateCommand.Parameters["@EarHearingRight"].Value = medicalReport.EarHearingRight;
	UpdateCommand.Parameters["@EarNose"].Value = medicalReport.EarNose;
	UpdateCommand.Parameters["@EarNeckgland"].Value = medicalReport.EarNeckgland;
	UpdateCommand.Parameters["@EarTonsils"].Value = medicalReport.EarTonsils;
	UpdateCommand.Parameters["@EarThyroid"].Value = medicalReport.EarThyroid;
	UpdateCommand.Parameters["@TeethAndMouth"].Value = medicalReport.TeethAndMouth;
	UpdateCommand.Parameters["@TeethUpper"].Value = medicalReport.TeethUpper;
	UpdateCommand.Parameters["@TeethLower"].Value = medicalReport.TeethLower;
	UpdateCommand.Parameters["@RespRate"].Value = medicalReport.RespRate;
	UpdateCommand.Parameters["@BreathSounds"].Value = medicalReport.BreathSounds;
	UpdateCommand.Parameters["@Others"].Value = medicalReport.Others;
	UpdateCommand.Parameters["@Heartrate"].Value = medicalReport.Heartrate;
	UpdateCommand.Parameters["@BP"].Value = medicalReport.BP;
	UpdateCommand.Parameters["@Auscultation"].Value = medicalReport.Auscultation;
	UpdateCommand.Parameters["@Liver"].Value = medicalReport.Liver;
	UpdateCommand.Parameters["@Spleen"].Value = medicalReport.Spleen;
	UpdateCommand.Parameters["@Kidneys"].Value = medicalReport.Kidneys;
	UpdateCommand.Parameters["@BowelSound"].Value = medicalReport.BowelSound;
	UpdateCommand.Parameters["@HernialOrifices"].Value = medicalReport.HernialOrifices;
	UpdateCommand.Parameters["@GenitoUrinary"].Value = medicalReport.GenitoUrinary;
	UpdateCommand.Parameters["@ExtremitiesSwelling"].Value = medicalReport.ExtremitiesSwelling;
	UpdateCommand.Parameters["@ExtremitiesDeformity"].Value = medicalReport.ExtremitiesDeformity;
	UpdateCommand.Parameters["@Skull"].Value = medicalReport.Skull;
	UpdateCommand.Parameters["@Spine"].Value = medicalReport.Spine;
	UpdateCommand.Parameters["@UpperExtremities"].Value = medicalReport.UpperExtremities;
	UpdateCommand.Parameters["@LowerExtremities"].Value = medicalReport.LowerExtremities;
	UpdateCommand.Parameters["@SkinAndVariousVeins"].Value = medicalReport.SkinAndVariousVeins;
	UpdateCommand.Parameters["@Neurological"].Value = medicalReport.Neurological;
	UpdateCommand.Parameters["@Motor"].Value = medicalReport.Motor;
	UpdateCommand.Parameters["@Sensory"].Value = medicalReport.Sensory;
	UpdateCommand.Parameters["@Reflexes"].Value = medicalReport.Reflexes;
	UpdateCommand.Parameters["@MentalState"].Value = medicalReport.MentalState;
	UpdateCommand.Parameters["@MedicalReportName"].Value = medicalReport.MedicalReportName;
	UpdateCommand.Parameters["@MedicalReportDate"].Value = medicalReport.MedicalReportDate;
	UpdateCommand.Parameters["@Status"].Value = medicalReport.Status;

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
        
        private MedicalReport DataTableToEntity(DataTable dt)
        {
           
            MedicalReport medicalReport = new MedicalReport();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						medicalReport.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						medicalReport.ID=0;
					}
					if (Null.IsNotNull(dr["PatientID"]))
					{
						medicalReport.PatientID=Convert.ToInt32(dr["PatientID"]);
					}
					else
					{
						medicalReport.PatientID=0;
					}
					if (Null.IsNotNull(dr["PatientName"]))
					{
						medicalReport.PatientName= Convert.ToString(dr["PatientName"]);
					}
					else
					{
						medicalReport.PatientName=string.Empty;
					}
					if (Null.IsNotNull(dr["ImagePath"]))
					{
						medicalReport.ImagePath= Convert.ToString(dr["ImagePath"]);
					}
					else
					{
						medicalReport.ImagePath=string.Empty;
					}
					if (Null.IsNotNull(dr["Height"]))
					{
						medicalReport.Height= Convert.ToString(dr["Height"]);
					}
					else
					{
						medicalReport.Height=string.Empty;
					}
					if (Null.IsNotNull(dr["Weight"]))
					{
						medicalReport.Weight= Convert.ToString(dr["Weight"]);
					}
					else
					{
						medicalReport.Weight=string.Empty;
					}
					if (Null.IsNotNull(dr["BMI"]))
					{
						medicalReport.BMI= Convert.ToString(dr["BMI"]);
					}
					else
					{
						medicalReport.BMI=string.Empty;
					}
					if (Null.IsNotNull(dr["Skin"]))
					{
						medicalReport.Skin= Convert.ToString(dr["Skin"]);
					}
					else
					{
						medicalReport.Skin=string.Empty;
					}
					if (Null.IsNotNull(dr["Scalp"]))
					{
						medicalReport.Scalp= Convert.ToString(dr["Scalp"]);
					}
					else
					{
						medicalReport.Scalp=string.Empty;
					}
					if (Null.IsNotNull(dr["Deformity"]))
					{
						medicalReport.Deformity= Convert.ToString(dr["Deformity"]);
					}
					else
					{
						medicalReport.Deformity=string.Empty;
					}
					if (Null.IsNotNull(dr["FVUncorrectedLeft"]))
					{
						medicalReport.FVUncorrectedLeft= Convert.ToString(dr["FVUncorrectedLeft"]);
					}
					else
					{
						medicalReport.FVUncorrectedLeft=string.Empty;
					}
					if (Null.IsNotNull(dr["FVUncorrectedRight"]))
					{
						medicalReport.FVUncorrectedRight= Convert.ToString(dr["FVUncorrectedRight"]);
					}
					else
					{
						medicalReport.FVUncorrectedRight=string.Empty;
					}
					if (Null.IsNotNull(dr["FVCorrectedLeft"]))
					{
						medicalReport.FVCorrectedLeft= Convert.ToString(dr["FVCorrectedLeft"]);
					}
					else
					{
						medicalReport.FVCorrectedLeft=string.Empty;
					}
					if (Null.IsNotNull(dr["FVCorrectedRight"]))
					{
						medicalReport.FVCorrectedRight= Convert.ToString(dr["FVCorrectedRight"]);
					}
					else
					{
						medicalReport.FVCorrectedRight=string.Empty;
					}
					if (Null.IsNotNull(dr["NVUncorrectedLeft"]))
					{
						medicalReport.NVUncorrectedLeft= Convert.ToString(dr["NVUncorrectedLeft"]);
					}
					else
					{
						medicalReport.NVUncorrectedLeft=string.Empty;
					}
					if (Null.IsNotNull(dr["NVUncorrectedRight"]))
					{
						medicalReport.NVUncorrectedRight= Convert.ToString(dr["NVUncorrectedRight"]);
					}
					else
					{
						medicalReport.NVUncorrectedRight=string.Empty;
					}
					if (Null.IsNotNull(dr["NVCorrectedLeft"]))
					{
						medicalReport.NVCorrectedLeft= Convert.ToString(dr["NVCorrectedLeft"]);
					}
					else
					{
						medicalReport.NVCorrectedLeft=string.Empty;
					}
					if (Null.IsNotNull(dr["NVCorrectedRight"]))
					{
						medicalReport.NVCorrectedRight= Convert.ToString(dr["NVCorrectedRight"]);
					}
					else
					{
						medicalReport.NVCorrectedRight=string.Empty;
					}
					if (Null.IsNotNull(dr["ColourVision"]))
					{
						medicalReport.ColourVision= Convert.ToString(dr["ColourVision"]);
					}
					else
					{
						medicalReport.ColourVision=string.Empty;
					}
					if (Null.IsNotNull(dr["EyeAndPupilsEqual"]))
					{
						medicalReport.EyeAndPupilsEqual= Convert.ToString(dr["EyeAndPupilsEqual"]);
					}
					else
					{
						medicalReport.EyeAndPupilsEqual=string.Empty;
					}
					if (Null.IsNotNull(dr["EyeAndPupilsRegular"]))
					{
						medicalReport.EyeAndPupilsRegular= Convert.ToString(dr["EyeAndPupilsRegular"]);
					}
					else
					{
						medicalReport.EyeAndPupilsRegular=string.Empty;
					}
					if (Null.IsNotNull(dr["FudusExamination"]))
					{
						medicalReport.FudusExamination= Convert.ToString(dr["FudusExamination"]);
					}
					else
					{
						medicalReport.FudusExamination=string.Empty;
					}
					if (Null.IsNotNull(dr["EarDrums"]))
					{
						medicalReport.EarDrums= Convert.ToString(dr["EarDrums"]);
					}
					else
					{
						medicalReport.EarDrums=string.Empty;
					}
					if (Null.IsNotNull(dr["EarHearingLeft"]))
					{
						medicalReport.EarHearingLeft= Convert.ToString(dr["EarHearingLeft"]);
					}
					else
					{
						medicalReport.EarHearingLeft=string.Empty;
					}
					if (Null.IsNotNull(dr["EarHearingRight"]))
					{
						medicalReport.EarHearingRight= Convert.ToString(dr["EarHearingRight"]);
					}
					else
					{
						medicalReport.EarHearingRight=string.Empty;
					}
					if (Null.IsNotNull(dr["EarNose"]))
					{
						medicalReport.EarNose= Convert.ToString(dr["EarNose"]);
					}
					else
					{
						medicalReport.EarNose=string.Empty;
					}
					if (Null.IsNotNull(dr["EarNeckgland"]))
					{
						medicalReport.EarNeckgland= Convert.ToString(dr["EarNeckgland"]);
					}
					else
					{
						medicalReport.EarNeckgland=string.Empty;
					}
					if (Null.IsNotNull(dr["EarTonsils"]))
					{
						medicalReport.EarTonsils= Convert.ToString(dr["EarTonsils"]);
					}
					else
					{
						medicalReport.EarTonsils=string.Empty;
					}
					if (Null.IsNotNull(dr["EarThyroid"]))
					{
						medicalReport.EarThyroid= Convert.ToString(dr["EarThyroid"]);
					}
					else
					{
						medicalReport.EarThyroid=string.Empty;
					}
					if (Null.IsNotNull(dr["TeethAndMouth"]))
					{
						medicalReport.TeethAndMouth= Convert.ToString(dr["TeethAndMouth"]);
					}
					else
					{
						medicalReport.TeethAndMouth=string.Empty;
					}
					if (Null.IsNotNull(dr["TeethUpper"]))
					{
						medicalReport.TeethUpper= Convert.ToString(dr["TeethUpper"]);
					}
					else
					{
						medicalReport.TeethUpper=string.Empty;
					}
					if (Null.IsNotNull(dr["TeethLower"]))
					{
						medicalReport.TeethLower= Convert.ToString(dr["TeethLower"]);
					}
					else
					{
						medicalReport.TeethLower=string.Empty;
					}
					if (Null.IsNotNull(dr["RespRate"]))
					{
						medicalReport.RespRate= Convert.ToString(dr["RespRate"]);
					}
					else
					{
						medicalReport.RespRate=string.Empty;
					}
					if (Null.IsNotNull(dr["BreathSounds"]))
					{
						medicalReport.BreathSounds= Convert.ToString(dr["BreathSounds"]);
					}
					else
					{
						medicalReport.BreathSounds=string.Empty;
					}
					if (Null.IsNotNull(dr["Others"]))
					{
						medicalReport.Others= Convert.ToString(dr["Others"]);
					}
					else
					{
						medicalReport.Others=string.Empty;
					}
					if (Null.IsNotNull(dr["Heartrate"]))
					{
						medicalReport.Heartrate= Convert.ToString(dr["Heartrate"]);
					}
					else
					{
						medicalReport.Heartrate=string.Empty;
					}
					if (Null.IsNotNull(dr["BP"]))
					{
						medicalReport.BP= Convert.ToString(dr["BP"]);
					}
					else
					{
						medicalReport.BP=string.Empty;
					}
					if (Null.IsNotNull(dr["Auscultation"]))
					{
						medicalReport.Auscultation= Convert.ToString(dr["Auscultation"]);
					}
					else
					{
						medicalReport.Auscultation=string.Empty;
					}
					if (Null.IsNotNull(dr["Liver"]))
					{
						medicalReport.Liver= Convert.ToString(dr["Liver"]);
					}
					else
					{
						medicalReport.Liver=string.Empty;
					}
					if (Null.IsNotNull(dr["Spleen"]))
					{
						medicalReport.Spleen= Convert.ToString(dr["Spleen"]);
					}
					else
					{
						medicalReport.Spleen=string.Empty;
					}
					if (Null.IsNotNull(dr["Kidneys"]))
					{
						medicalReport.Kidneys= Convert.ToString(dr["Kidneys"]);
					}
					else
					{
						medicalReport.Kidneys=string.Empty;
					}
					if (Null.IsNotNull(dr["BowelSound"]))
					{
						medicalReport.BowelSound= Convert.ToString(dr["BowelSound"]);
					}
					else
					{
						medicalReport.BowelSound=string.Empty;
					}
					if (Null.IsNotNull(dr["HernialOrifices"]))
					{
						medicalReport.HernialOrifices= Convert.ToString(dr["HernialOrifices"]);
					}
					else
					{
						medicalReport.HernialOrifices=string.Empty;
					}
					if (Null.IsNotNull(dr["GenitoUrinary"]))
					{
						medicalReport.GenitoUrinary= Convert.ToString(dr["GenitoUrinary"]);
					}
					else
					{
						medicalReport.GenitoUrinary=string.Empty;
					}
					if (Null.IsNotNull(dr["ExtremitiesSwelling"]))
					{
						medicalReport.ExtremitiesSwelling= Convert.ToString(dr["ExtremitiesSwelling"]);
					}
					else
					{
						medicalReport.ExtremitiesSwelling=string.Empty;
					}
					if (Null.IsNotNull(dr["ExtremitiesDeformity"]))
					{
						medicalReport.ExtremitiesDeformity= Convert.ToString(dr["ExtremitiesDeformity"]);
					}
					else
					{
						medicalReport.ExtremitiesDeformity=string.Empty;
					}
					if (Null.IsNotNull(dr["Skull"]))
					{
						medicalReport.Skull= Convert.ToString(dr["Skull"]);
					}
					else
					{
						medicalReport.Skull=string.Empty;
					}
					if (Null.IsNotNull(dr["Spine"]))
					{
						medicalReport.Spine= Convert.ToString(dr["Spine"]);
					}
					else
					{
						medicalReport.Spine=string.Empty;
					}
					if (Null.IsNotNull(dr["UpperExtremities"]))
					{
						medicalReport.UpperExtremities= Convert.ToString(dr["UpperExtremities"]);
					}
					else
					{
						medicalReport.UpperExtremities=string.Empty;
					}
					if (Null.IsNotNull(dr["LowerExtremities"]))
					{
						medicalReport.LowerExtremities= Convert.ToString(dr["LowerExtremities"]);
					}
					else
					{
						medicalReport.LowerExtremities=string.Empty;
					}
					if (Null.IsNotNull(dr["SkinAndVariousVeins"]))
					{
						medicalReport.SkinAndVariousVeins= Convert.ToString(dr["SkinAndVariousVeins"]);
					}
					else
					{
						medicalReport.SkinAndVariousVeins=string.Empty;
					}
					if (Null.IsNotNull(dr["Neurological"]))
					{
						medicalReport.Neurological= Convert.ToString(dr["Neurological"]);
					}
					else
					{
						medicalReport.Neurological=string.Empty;
					}
					if (Null.IsNotNull(dr["Motor"]))
					{
						medicalReport.Motor= Convert.ToString(dr["Motor"]);
					}
					else
					{
						medicalReport.Motor=string.Empty;
					}
					if (Null.IsNotNull(dr["Sensory"]))
					{
						medicalReport.Sensory= Convert.ToString(dr["Sensory"]);
					}
					else
					{
						medicalReport.Sensory=string.Empty;
					}
					if (Null.IsNotNull(dr["Reflexes"]))
					{
						medicalReport.Reflexes= Convert.ToString(dr["Reflexes"]);
					}
					else
					{
						medicalReport.Reflexes=string.Empty;
					}
					if (Null.IsNotNull(dr["MentalState"]))
					{
						medicalReport.MentalState= Convert.ToString(dr["MentalState"]);
					}
					else
					{
						medicalReport.MentalState=string.Empty;
					}
					if (Null.IsNotNull(dr["MedicalReportName"]))
					{
						medicalReport.MedicalReportName= Convert.ToString(dr["MedicalReportName"]);
					}
					else
					{
						medicalReport.MedicalReportName=string.Empty;
					}
					if (Null.IsNotNull(dr["MedicalReportDate"]))
					{
						medicalReport.MedicalReportDate= Convert.ToDateTime(dr["MedicalReportDate"]);
					}
					else
					{
						medicalReport.MedicalReportDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						medicalReport.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						medicalReport.Status=string.Empty;
					}
 
                }
            }
            return medicalReport ;
        }
		#endregion		
	}
}