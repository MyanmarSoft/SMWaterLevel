using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Whizzo;
using SMWaterLevel.Entities;
namespace SMWaterLevel.DataAccess
{

	public class MedicalAssessmentTableAdapter : BaseDataAdapter
	{
		
		
		#region Constructers

			public MedicalAssessmentTableAdapter():base()
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
			InsertCommand.CommandText = @"INSERT INTO MedicalAssessment(PatientID,Name,Sex,DOB,Nationality,ContactNo,MaritalStatus,NRCNo,Address,JobPosition,CompanyName,ImagePath,SinusAndThroatTrouble,EarTroubleAndDeafness,DifficultyInVision,AsthmaAndBronchitis,AllergyAndHayFever,Tuberculosis,OtherLungDiseases,HighBloodPressure,HeartDisease,RheumaticFever,Haemorrhoids,StomachUlcer,JaundiceOrHepatitis,GallBladderDiseases,HerniaAndHydrocele,GenitoUrinaryDisease,BloodInUrine,Diabetes,EndocrineDisorders,CancerOrTumour,MentalDisorders,HeadacheAndMigrane,Epilepsy,JointAndSpinalTrouble,SurgicalOperation,VaricoseVeins,AnyAccidentOrInjury,GeneticDisorder,TropicalDiseases,ToxicExposure,BloodDiseases,FearOfHeights,DrugAndDrinkingProblem,Doyousmoke,TakeAlcoholRegularly,VaccinationHistory,FHDiabetes,FHTuberculosis,FHHighBloodPressure,FHAsthma,FHEpilepsyAndStroke,FHBloodDisease,FHEczema,FHHeartDisease,FHCancer,MedicalAssessmentDate,MedicationName,Status) VALUES (@PatientID,@Name,@Sex,@DOB,@Nationality,@ContactNo,@MaritalStatus,@NRCNo,@Address,@JobPosition,@CompanyName,@ImagePath,@SinusAndThroatTrouble,@EarTroubleAndDeafness,@DifficultyInVision,@AsthmaAndBronchitis,@AllergyAndHayFever,@Tuberculosis,@OtherLungDiseases,@HighBloodPressure,@HeartDisease,@RheumaticFever,@Haemorrhoids,@StomachUlcer,@JaundiceOrHepatitis,@GallBladderDiseases,@HerniaAndHydrocele,@GenitoUrinaryDisease,@BloodInUrine,@Diabetes,@EndocrineDisorders,@CancerOrTumour,@MentalDisorders,@HeadacheAndMigrane,@Epilepsy,@JointAndSpinalTrouble,@SurgicalOperation,@VaricoseVeins,@AnyAccidentOrInjury,@GeneticDisorder,@TropicalDiseases,@ToxicExposure,@BloodDiseases,@FearOfHeights,@DrugAndDrinkingProblem,@Doyousmoke,@TakeAlcoholRegularly,@VaccinationHistory,@FHDiabetes,@FHTuberculosis,@FHHighBloodPressure,@FHAsthma,@FHEpilepsyAndStroke,@FHBloodDisease,@FHEczema,@FHHeartDisease,@FHCancer,@MedicalAssessmentDate,@MedicationName,@Status);SELECT ID FROM MedicalAssessment WHERE (ID = SCOPE_IDENTITY())";
						InsertCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50,"Name"));
			InsertCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 50,"Sex"));
			InsertCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			InsertCommand.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.VarChar, 50,"Nationality"));
			InsertCommand.Parameters.Add(new SqlParameter("@ContactNo", SqlDbType.VarChar, 50,"ContactNo"));
			InsertCommand.Parameters.Add(new SqlParameter("@MaritalStatus", SqlDbType.VarChar, 50,"MaritalStatus"));
			InsertCommand.Parameters.Add(new SqlParameter("@NRCNo", SqlDbType.VarChar, 50,"NRCNo"));
			InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, -1,"Address"));
			InsertCommand.Parameters.Add(new SqlParameter("@JobPosition", SqlDbType.VarChar, 50,"JobPosition"));
			InsertCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 50,"CompanyName"));
			InsertCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			InsertCommand.Parameters.Add(new SqlParameter("@SinusAndThroatTrouble", SqlDbType.VarChar, 10,"SinusAndThroatTrouble"));
			InsertCommand.Parameters.Add(new SqlParameter("@EarTroubleAndDeafness", SqlDbType.VarChar, 10,"EarTroubleAndDeafness"));
			InsertCommand.Parameters.Add(new SqlParameter("@DifficultyInVision", SqlDbType.VarChar, 10,"DifficultyInVision"));
			InsertCommand.Parameters.Add(new SqlParameter("@AsthmaAndBronchitis", SqlDbType.VarChar, 10,"AsthmaAndBronchitis"));
			InsertCommand.Parameters.Add(new SqlParameter("@AllergyAndHayFever", SqlDbType.VarChar, 10,"AllergyAndHayFever"));
			InsertCommand.Parameters.Add(new SqlParameter("@Tuberculosis", SqlDbType.VarChar, 10,"Tuberculosis"));
			InsertCommand.Parameters.Add(new SqlParameter("@OtherLungDiseases", SqlDbType.VarChar, 10,"OtherLungDiseases"));
			InsertCommand.Parameters.Add(new SqlParameter("@HighBloodPressure", SqlDbType.VarChar, 10,"HighBloodPressure"));
			InsertCommand.Parameters.Add(new SqlParameter("@HeartDisease", SqlDbType.VarChar, 10,"HeartDisease"));
			InsertCommand.Parameters.Add(new SqlParameter("@RheumaticFever", SqlDbType.VarChar, 10,"RheumaticFever"));
			InsertCommand.Parameters.Add(new SqlParameter("@Haemorrhoids", SqlDbType.VarChar, 10,"Haemorrhoids"));
			InsertCommand.Parameters.Add(new SqlParameter("@StomachUlcer", SqlDbType.VarChar, 10,"StomachUlcer"));
			InsertCommand.Parameters.Add(new SqlParameter("@JaundiceOrHepatitis", SqlDbType.VarChar, 10,"JaundiceOrHepatitis"));
			InsertCommand.Parameters.Add(new SqlParameter("@GallBladderDiseases", SqlDbType.VarChar, 10,"GallBladderDiseases"));
			InsertCommand.Parameters.Add(new SqlParameter("@HerniaAndHydrocele", SqlDbType.VarChar, 10,"HerniaAndHydrocele"));
			InsertCommand.Parameters.Add(new SqlParameter("@GenitoUrinaryDisease", SqlDbType.VarChar, 10,"GenitoUrinaryDisease"));
			InsertCommand.Parameters.Add(new SqlParameter("@BloodInUrine", SqlDbType.VarChar, 10,"BloodInUrine"));
			InsertCommand.Parameters.Add(new SqlParameter("@Diabetes", SqlDbType.VarChar, 10,"Diabetes"));
			InsertCommand.Parameters.Add(new SqlParameter("@EndocrineDisorders", SqlDbType.VarChar, 10,"EndocrineDisorders"));
			InsertCommand.Parameters.Add(new SqlParameter("@CancerOrTumour", SqlDbType.VarChar, 10,"CancerOrTumour"));
			InsertCommand.Parameters.Add(new SqlParameter("@MentalDisorders", SqlDbType.VarChar, 10,"MentalDisorders"));
			InsertCommand.Parameters.Add(new SqlParameter("@HeadacheAndMigrane", SqlDbType.VarChar, 10,"HeadacheAndMigrane"));
			InsertCommand.Parameters.Add(new SqlParameter("@Epilepsy", SqlDbType.VarChar, 10,"Epilepsy"));
			InsertCommand.Parameters.Add(new SqlParameter("@JointAndSpinalTrouble", SqlDbType.VarChar, 10,"JointAndSpinalTrouble"));
			InsertCommand.Parameters.Add(new SqlParameter("@SurgicalOperation", SqlDbType.VarChar, 10,"SurgicalOperation"));
			InsertCommand.Parameters.Add(new SqlParameter("@VaricoseVeins", SqlDbType.VarChar, 10,"VaricoseVeins"));
			InsertCommand.Parameters.Add(new SqlParameter("@AnyAccidentOrInjury", SqlDbType.VarChar, 10,"AnyAccidentOrInjury"));
			InsertCommand.Parameters.Add(new SqlParameter("@GeneticDisorder", SqlDbType.VarChar, 10,"GeneticDisorder"));
			InsertCommand.Parameters.Add(new SqlParameter("@TropicalDiseases", SqlDbType.VarChar, 10,"TropicalDiseases"));
			InsertCommand.Parameters.Add(new SqlParameter("@ToxicExposure", SqlDbType.VarChar, 10,"ToxicExposure"));
			InsertCommand.Parameters.Add(new SqlParameter("@BloodDiseases", SqlDbType.VarChar, 10,"BloodDiseases"));
			InsertCommand.Parameters.Add(new SqlParameter("@FearOfHeights", SqlDbType.VarChar, 10,"FearOfHeights"));
			InsertCommand.Parameters.Add(new SqlParameter("@DrugAndDrinkingProblem", SqlDbType.VarChar, 10,"DrugAndDrinkingProblem"));
			InsertCommand.Parameters.Add(new SqlParameter("@Doyousmoke", SqlDbType.VarChar, 10,"Doyousmoke"));
			InsertCommand.Parameters.Add(new SqlParameter("@TakeAlcoholRegularly", SqlDbType.VarChar, 10,"TakeAlcoholRegularly"));
			InsertCommand.Parameters.Add(new SqlParameter("@VaccinationHistory", SqlDbType.VarChar, 50,"VaccinationHistory"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHDiabetes", SqlDbType.VarChar, 10,"FHDiabetes"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHTuberculosis", SqlDbType.VarChar, 50,"FHTuberculosis"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHHighBloodPressure", SqlDbType.VarChar, 10,"FHHighBloodPressure"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHAsthma", SqlDbType.VarChar, 10,"FHAsthma"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHEpilepsyAndStroke", SqlDbType.VarChar, 10,"FHEpilepsyAndStroke"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHBloodDisease", SqlDbType.VarChar, 10,"FHBloodDisease"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHEczema", SqlDbType.VarChar, 10,"FHEczema"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHHeartDisease", SqlDbType.VarChar, 10,"FHHeartDisease"));
			InsertCommand.Parameters.Add(new SqlParameter("@FHCancer", SqlDbType.VarChar, 10,"FHCancer"));
			InsertCommand.Parameters.Add(new SqlParameter("@MedicalAssessmentDate", SqlDbType.DateTime, 8,"MedicalAssessmentDate"));
			InsertCommand.Parameters.Add(new SqlParameter("@MedicationName", SqlDbType.VarChar, 50,"MedicationName"));
			InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitUpdateCommand()
		{
			UpdateCommand.CommandType = CommandType.Text;
            UpdateCommand.Connection = Connection;
			UpdateCommand.CommandText = @"UPDATE MedicalAssessment SET PatientID = @PatientID, Name = @Name, Sex = @Sex, DOB = @DOB, Nationality = @Nationality, ContactNo = @ContactNo, MaritalStatus = @MaritalStatus, NRCNo = @NRCNo, Address = @Address, JobPosition = @JobPosition, CompanyName = @CompanyName, ImagePath = @ImagePath, SinusAndThroatTrouble = @SinusAndThroatTrouble, EarTroubleAndDeafness = @EarTroubleAndDeafness, DifficultyInVision = @DifficultyInVision, AsthmaAndBronchitis = @AsthmaAndBronchitis, AllergyAndHayFever = @AllergyAndHayFever, Tuberculosis = @Tuberculosis, OtherLungDiseases = @OtherLungDiseases, HighBloodPressure = @HighBloodPressure, HeartDisease = @HeartDisease, RheumaticFever = @RheumaticFever, Haemorrhoids = @Haemorrhoids, StomachUlcer = @StomachUlcer, JaundiceOrHepatitis = @JaundiceOrHepatitis, GallBladderDiseases = @GallBladderDiseases, HerniaAndHydrocele = @HerniaAndHydrocele, GenitoUrinaryDisease = @GenitoUrinaryDisease, BloodInUrine = @BloodInUrine, Diabetes = @Diabetes, EndocrineDisorders = @EndocrineDisorders, CancerOrTumour = @CancerOrTumour, MentalDisorders = @MentalDisorders, HeadacheAndMigrane = @HeadacheAndMigrane, Epilepsy = @Epilepsy, JointAndSpinalTrouble = @JointAndSpinalTrouble, SurgicalOperation = @SurgicalOperation, VaricoseVeins = @VaricoseVeins, AnyAccidentOrInjury = @AnyAccidentOrInjury, GeneticDisorder = @GeneticDisorder, TropicalDiseases = @TropicalDiseases, ToxicExposure = @ToxicExposure, BloodDiseases = @BloodDiseases, FearOfHeights = @FearOfHeights, DrugAndDrinkingProblem = @DrugAndDrinkingProblem, Doyousmoke = @Doyousmoke, TakeAlcoholRegularly = @TakeAlcoholRegularly, VaccinationHistory = @VaccinationHistory, FHDiabetes = @FHDiabetes, FHTuberculosis = @FHTuberculosis, FHHighBloodPressure = @FHHighBloodPressure, FHAsthma = @FHAsthma, FHEpilepsyAndStroke = @FHEpilepsyAndStroke, FHBloodDisease = @FHBloodDisease, FHEczema = @FHEczema, FHHeartDisease = @FHHeartDisease, FHCancer = @FHCancer, MedicalAssessmentDate = @MedicalAssessmentDate, MedicationName = @MedicationName, Status = @Status WHERE (ID = @ID)";
						UpdateCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@PatientID", SqlDbType.Int, 4, ParameterDirection.Input, true, ((Byte)(10)), ((Byte)(0)),"PatientID", System.Data.DataRowVersion.Current, null));
			UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50,"Name"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.VarChar, 50,"Sex"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime, 8,"DOB"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.VarChar, 50,"Nationality"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ContactNo", SqlDbType.VarChar, 50,"ContactNo"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MaritalStatus", SqlDbType.VarChar, 50,"MaritalStatus"));
			UpdateCommand.Parameters.Add(new SqlParameter("@NRCNo", SqlDbType.VarChar, 50,"NRCNo"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, -1,"Address"));
			UpdateCommand.Parameters.Add(new SqlParameter("@JobPosition", SqlDbType.VarChar, 50,"JobPosition"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.VarChar, 50,"CompanyName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.VarChar, 100,"ImagePath"));
			UpdateCommand.Parameters.Add(new SqlParameter("@SinusAndThroatTrouble", SqlDbType.VarChar, 10,"SinusAndThroatTrouble"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EarTroubleAndDeafness", SqlDbType.VarChar, 10,"EarTroubleAndDeafness"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DifficultyInVision", SqlDbType.VarChar, 10,"DifficultyInVision"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AsthmaAndBronchitis", SqlDbType.VarChar, 10,"AsthmaAndBronchitis"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AllergyAndHayFever", SqlDbType.VarChar, 10,"AllergyAndHayFever"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Tuberculosis", SqlDbType.VarChar, 10,"Tuberculosis"));
			UpdateCommand.Parameters.Add(new SqlParameter("@OtherLungDiseases", SqlDbType.VarChar, 10,"OtherLungDiseases"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HighBloodPressure", SqlDbType.VarChar, 10,"HighBloodPressure"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HeartDisease", SqlDbType.VarChar, 10,"HeartDisease"));
			UpdateCommand.Parameters.Add(new SqlParameter("@RheumaticFever", SqlDbType.VarChar, 10,"RheumaticFever"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Haemorrhoids", SqlDbType.VarChar, 10,"Haemorrhoids"));
			UpdateCommand.Parameters.Add(new SqlParameter("@StomachUlcer", SqlDbType.VarChar, 10,"StomachUlcer"));
			UpdateCommand.Parameters.Add(new SqlParameter("@JaundiceOrHepatitis", SqlDbType.VarChar, 10,"JaundiceOrHepatitis"));
			UpdateCommand.Parameters.Add(new SqlParameter("@GallBladderDiseases", SqlDbType.VarChar, 10,"GallBladderDiseases"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HerniaAndHydrocele", SqlDbType.VarChar, 10,"HerniaAndHydrocele"));
			UpdateCommand.Parameters.Add(new SqlParameter("@GenitoUrinaryDisease", SqlDbType.VarChar, 10,"GenitoUrinaryDisease"));
			UpdateCommand.Parameters.Add(new SqlParameter("@BloodInUrine", SqlDbType.VarChar, 10,"BloodInUrine"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Diabetes", SqlDbType.VarChar, 10,"Diabetes"));
			UpdateCommand.Parameters.Add(new SqlParameter("@EndocrineDisorders", SqlDbType.VarChar, 10,"EndocrineDisorders"));
			UpdateCommand.Parameters.Add(new SqlParameter("@CancerOrTumour", SqlDbType.VarChar, 10,"CancerOrTumour"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MentalDisorders", SqlDbType.VarChar, 10,"MentalDisorders"));
			UpdateCommand.Parameters.Add(new SqlParameter("@HeadacheAndMigrane", SqlDbType.VarChar, 10,"HeadacheAndMigrane"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Epilepsy", SqlDbType.VarChar, 10,"Epilepsy"));
			UpdateCommand.Parameters.Add(new SqlParameter("@JointAndSpinalTrouble", SqlDbType.VarChar, 10,"JointAndSpinalTrouble"));
			UpdateCommand.Parameters.Add(new SqlParameter("@SurgicalOperation", SqlDbType.VarChar, 10,"SurgicalOperation"));
			UpdateCommand.Parameters.Add(new SqlParameter("@VaricoseVeins", SqlDbType.VarChar, 10,"VaricoseVeins"));
			UpdateCommand.Parameters.Add(new SqlParameter("@AnyAccidentOrInjury", SqlDbType.VarChar, 10,"AnyAccidentOrInjury"));
			UpdateCommand.Parameters.Add(new SqlParameter("@GeneticDisorder", SqlDbType.VarChar, 10,"GeneticDisorder"));
			UpdateCommand.Parameters.Add(new SqlParameter("@TropicalDiseases", SqlDbType.VarChar, 10,"TropicalDiseases"));
			UpdateCommand.Parameters.Add(new SqlParameter("@ToxicExposure", SqlDbType.VarChar, 10,"ToxicExposure"));
			UpdateCommand.Parameters.Add(new SqlParameter("@BloodDiseases", SqlDbType.VarChar, 10,"BloodDiseases"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FearOfHeights", SqlDbType.VarChar, 10,"FearOfHeights"));
			UpdateCommand.Parameters.Add(new SqlParameter("@DrugAndDrinkingProblem", SqlDbType.VarChar, 10,"DrugAndDrinkingProblem"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Doyousmoke", SqlDbType.VarChar, 10,"Doyousmoke"));
			UpdateCommand.Parameters.Add(new SqlParameter("@TakeAlcoholRegularly", SqlDbType.VarChar, 10,"TakeAlcoholRegularly"));
			UpdateCommand.Parameters.Add(new SqlParameter("@VaccinationHistory", SqlDbType.VarChar, 50,"VaccinationHistory"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHDiabetes", SqlDbType.VarChar, 10,"FHDiabetes"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHTuberculosis", SqlDbType.VarChar, 50,"FHTuberculosis"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHHighBloodPressure", SqlDbType.VarChar, 10,"FHHighBloodPressure"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHAsthma", SqlDbType.VarChar, 10,"FHAsthma"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHEpilepsyAndStroke", SqlDbType.VarChar, 10,"FHEpilepsyAndStroke"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHBloodDisease", SqlDbType.VarChar, 10,"FHBloodDisease"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHEczema", SqlDbType.VarChar, 10,"FHEczema"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHHeartDisease", SqlDbType.VarChar, 10,"FHHeartDisease"));
			UpdateCommand.Parameters.Add(new SqlParameter("@FHCancer", SqlDbType.VarChar, 10,"FHCancer"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MedicalAssessmentDate", SqlDbType.DateTime, 8,"MedicalAssessmentDate"));
			UpdateCommand.Parameters.Add(new SqlParameter("@MedicationName", SqlDbType.VarChar, 50,"MedicationName"));
			UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 10,"Status"));

			
		}

		protected  void InitDeleteCommand()
		{
            DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.Connection = Connection;
			DeleteCommand.CommandText = "DELETE FROM MedicalAssessment WHERE (ID = @ID)";
			DeleteCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, ((Byte)(10)), ((Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
		}

		

		protected  void InitCommandCollection()
		{
			CommandCollection = new IDbCommand[4];

			CommandCollection[0] = new SqlCommand();
			((SqlCommand) (CommandCollection[0])).Connection = Connection;
			((SqlCommand) (CommandCollection[0])).CommandText = "SELECT ID,PatientID,Name,Sex,DOB,Nationality,ContactNo,MaritalStatus,NRCNo,Address,JobPosition,CompanyName,ImagePath,SinusAndThroatTrouble,EarTroubleAndDeafness,DifficultyInVision,AsthmaAndBronchitis,AllergyAndHayFever,Tuberculosis,OtherLungDiseases,HighBloodPressure,HeartDisease,RheumaticFever,Haemorrhoids,StomachUlcer,JaundiceOrHepatitis,GallBladderDiseases,HerniaAndHydrocele,GenitoUrinaryDisease,BloodInUrine,Diabetes,EndocrineDisorders,CancerOrTumour,MentalDisorders,HeadacheAndMigrane,Epilepsy,JointAndSpinalTrouble,SurgicalOperation,VaricoseVeins,AnyAccidentOrInjury,GeneticDisorder,TropicalDiseases,ToxicExposure,BloodDiseases,FearOfHeights,DrugAndDrinkingProblem,Doyousmoke,TakeAlcoholRegularly,VaccinationHistory,FHDiabetes,FHTuberculosis,FHHighBloodPressure,FHAsthma,FHEpilepsyAndStroke,FHBloodDisease,FHEczema,FHHeartDisease,FHCancer,MedicalAssessmentDate,MedicationName,Status FROM MedicalAssessment";
			((SqlCommand) (CommandCollection[0])).CommandType = CommandType.Text;
			
			//Fill/GetByID
            CommandCollection[1] = new SqlCommand();
            ((SqlCommand)(CommandCollection[1])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[1])).CommandText = "SELECT ID,PatientID,Name,Sex,DOB,Nationality,ContactNo,MaritalStatus,NRCNo,Address,JobPosition,CompanyName,ImagePath,SinusAndThroatTrouble,EarTroubleAndDeafness,DifficultyInVision,AsthmaAndBronchitis,AllergyAndHayFever,Tuberculosis,OtherLungDiseases,HighBloodPressure,HeartDisease,RheumaticFever,Haemorrhoids,StomachUlcer,JaundiceOrHepatitis,GallBladderDiseases,HerniaAndHydrocele,GenitoUrinaryDisease,BloodInUrine,Diabetes,EndocrineDisorders,CancerOrTumour,MentalDisorders,HeadacheAndMigrane,Epilepsy,JointAndSpinalTrouble,SurgicalOperation,VaricoseVeins,AnyAccidentOrInjury,GeneticDisorder,TropicalDiseases,ToxicExposure,BloodDiseases,FearOfHeights,DrugAndDrinkingProblem,Doyousmoke,TakeAlcoholRegularly,VaccinationHistory,FHDiabetes,FHTuberculosis,FHHighBloodPressure,FHAsthma,FHEpilepsyAndStroke,FHBloodDisease,FHEczema,FHHeartDisease,FHCancer,MedicalAssessmentDate,MedicationName,Status FROM MedicalAssessment WHERE ID =  @ID";
            ((SqlCommand)(CommandCollection[1])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[1])).Parameters.Add(new SqlParameter("@ID", SqlDbType.Int, 4, "ID"));
			
			//Fill/GetByStatus
            CommandCollection[2] = new SqlCommand();
            ((SqlCommand)(CommandCollection[2])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[2])).CommandText = "SELECT ID,PatientID,Name,Sex,DOB,Nationality,ContactNo,MaritalStatus,NRCNo,Address,JobPosition,CompanyName,ImagePath,SinusAndThroatTrouble,EarTroubleAndDeafness,DifficultyInVision,AsthmaAndBronchitis,AllergyAndHayFever,Tuberculosis,OtherLungDiseases,HighBloodPressure,HeartDisease,RheumaticFever,Haemorrhoids,StomachUlcer,JaundiceOrHepatitis,GallBladderDiseases,HerniaAndHydrocele,GenitoUrinaryDisease,BloodInUrine,Diabetes,EndocrineDisorders,CancerOrTumour,MentalDisorders,HeadacheAndMigrane,Epilepsy,JointAndSpinalTrouble,SurgicalOperation,VaricoseVeins,AnyAccidentOrInjury,GeneticDisorder,TropicalDiseases,ToxicExposure,BloodDiseases,FearOfHeights,DrugAndDrinkingProblem,Doyousmoke,TakeAlcoholRegularly,VaccinationHistory,FHDiabetes,FHTuberculosis,FHHighBloodPressure,FHAsthma,FHEpilepsyAndStroke,FHBloodDisease,FHEczema,FHHeartDisease,FHCancer,MedicalAssessmentDate,MedicationName,Status FROM MedicalAssessment WHERE Status =  @Status";
            ((SqlCommand)(CommandCollection[2])).CommandType = CommandType.Text;
            ((SqlCommand)(this.CommandCollection[2])).Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar, 20, "Status"));
			
			#region CustomCommand
			
			
			
			//GetMedicalAssessmentByPatientID
            CommandCollection[3] = new SqlCommand();
            ((SqlCommand)(CommandCollection[3])).Connection = this.Connection;
            ((SqlCommand)(CommandCollection[3])).CommandText = "SELECT ID,PatientID,Name,Sex,DOB,Nationality,ContactNo,MaritalStatus,NRCNo,Address,JobPosition,CompanyName,ImagePath,SinusAndThroatTrouble,EarTroubleAndDeafness,DifficultyInVision,AsthmaAndBronchitis,AllergyAndHayFever,Tuberculosis,OtherLungDiseases,HighBloodPressure,RheumaticFever,Haemorrhoids,StomachUlcer,JaundiceOrHepatitis,GallBladderDiseases,HerniaAndHydrocele,GenitoUrinaryDisease,BloodInUrine,Diabetes,EndocrineDisorders,CancerOrTumour,MentalDisorders,HeadacheAndMigrane,Epilepsy,JointAndSpinalTrouble,SurgicalOperation,VaricoseVeins,AnyAccidentOrInjury,GeneticDisorder,TropicalDiseases,ToxicExposure,BloodDiseases,FearOfHeights,DrugAndDrinkingProblem,FHDiabetes,FHTuberculosis,FHHighBloodPressure,FHAsthma,FHEpilepsyAndStroke,FHBloodDisease,FHEczema,FHHeartDisease,FHCancer,MedicalAssessmentDate,MedicationName,Status FROM MedicalAssessment WHERE PatientID = @PatientID AND Status =  @Status";
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

		public MedicalAssessment GetMedicalAssessmentByID(int ID)
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
		
		public DataSet GetMedicalAssessmentByStatus(string status)
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
		
		
		
        public DataSet GetMedicalAssessmentByPatientID(int patientID, string status)
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
	    
		public int Insert(MedicalAssessment medicalAssessment)
		{
	InsertCommand.Parameters["@PatientID"].Value = medicalAssessment.PatientID;
	InsertCommand.Parameters["@Name"].Value = medicalAssessment.Name;
	InsertCommand.Parameters["@Sex"].Value = medicalAssessment.Sex;
	InsertCommand.Parameters["@DOB"].Value = medicalAssessment.DOB;
	InsertCommand.Parameters["@Nationality"].Value = medicalAssessment.Nationality;
	InsertCommand.Parameters["@ContactNo"].Value = medicalAssessment.ContactNo;
	InsertCommand.Parameters["@MaritalStatus"].Value = medicalAssessment.MaritalStatus;
	InsertCommand.Parameters["@NRCNo"].Value = medicalAssessment.NRCNo;
	InsertCommand.Parameters["@Address"].Value = medicalAssessment.Address;
	InsertCommand.Parameters["@JobPosition"].Value = medicalAssessment.JobPosition;
	InsertCommand.Parameters["@CompanyName"].Value = medicalAssessment.CompanyName;
	InsertCommand.Parameters["@ImagePath"].Value = medicalAssessment.ImagePath;
	InsertCommand.Parameters["@SinusAndThroatTrouble"].Value = medicalAssessment.SinusAndThroatTrouble;
	InsertCommand.Parameters["@EarTroubleAndDeafness"].Value = medicalAssessment.EarTroubleAndDeafness;
	InsertCommand.Parameters["@DifficultyInVision"].Value = medicalAssessment.DifficultyInVision;
	InsertCommand.Parameters["@AsthmaAndBronchitis"].Value = medicalAssessment.AsthmaAndBronchitis;
	InsertCommand.Parameters["@AllergyAndHayFever"].Value = medicalAssessment.AllergyAndHayFever;
	InsertCommand.Parameters["@Tuberculosis"].Value = medicalAssessment.Tuberculosis;
	InsertCommand.Parameters["@OtherLungDiseases"].Value = medicalAssessment.OtherLungDiseases;
	InsertCommand.Parameters["@HighBloodPressure"].Value = medicalAssessment.HighBloodPressure;
	InsertCommand.Parameters["@HeartDisease"].Value = medicalAssessment.HeartDisease;
	InsertCommand.Parameters["@RheumaticFever"].Value = medicalAssessment.RheumaticFever;
	InsertCommand.Parameters["@Haemorrhoids"].Value = medicalAssessment.Haemorrhoids;
	InsertCommand.Parameters["@StomachUlcer"].Value = medicalAssessment.StomachUlcer;
	InsertCommand.Parameters["@JaundiceOrHepatitis"].Value = medicalAssessment.JaundiceOrHepatitis;
	InsertCommand.Parameters["@GallBladderDiseases"].Value = medicalAssessment.GallBladderDiseases;
	InsertCommand.Parameters["@HerniaAndHydrocele"].Value = medicalAssessment.HerniaAndHydrocele;
	InsertCommand.Parameters["@GenitoUrinaryDisease"].Value = medicalAssessment.GenitoUrinaryDisease;
	InsertCommand.Parameters["@BloodInUrine"].Value = medicalAssessment.BloodInUrine;
	InsertCommand.Parameters["@Diabetes"].Value = medicalAssessment.Diabetes;
	InsertCommand.Parameters["@EndocrineDisorders"].Value = medicalAssessment.EndocrineDisorders;
	InsertCommand.Parameters["@CancerOrTumour"].Value = medicalAssessment.CancerOrTumour;
	InsertCommand.Parameters["@MentalDisorders"].Value = medicalAssessment.MentalDisorders;
	InsertCommand.Parameters["@HeadacheAndMigrane"].Value = medicalAssessment.HeadacheAndMigrane;
	InsertCommand.Parameters["@Epilepsy"].Value = medicalAssessment.Epilepsy;
	InsertCommand.Parameters["@JointAndSpinalTrouble"].Value = medicalAssessment.JointAndSpinalTrouble;
	InsertCommand.Parameters["@SurgicalOperation"].Value = medicalAssessment.SurgicalOperation;
	InsertCommand.Parameters["@VaricoseVeins"].Value = medicalAssessment.VaricoseVeins;
	InsertCommand.Parameters["@AnyAccidentOrInjury"].Value = medicalAssessment.AnyAccidentOrInjury;
	InsertCommand.Parameters["@GeneticDisorder"].Value = medicalAssessment.GeneticDisorder;
	InsertCommand.Parameters["@TropicalDiseases"].Value = medicalAssessment.TropicalDiseases;
	InsertCommand.Parameters["@ToxicExposure"].Value = medicalAssessment.ToxicExposure;
	InsertCommand.Parameters["@BloodDiseases"].Value = medicalAssessment.BloodDiseases;
	InsertCommand.Parameters["@FearOfHeights"].Value = medicalAssessment.FearOfHeights;
	InsertCommand.Parameters["@DrugAndDrinkingProblem"].Value = medicalAssessment.DrugAndDrinkingProblem;
	InsertCommand.Parameters["@Doyousmoke"].Value = medicalAssessment.Doyousmoke;
	InsertCommand.Parameters["@TakeAlcoholRegularly"].Value = medicalAssessment.TakeAlcoholRegularly;
	InsertCommand.Parameters["@VaccinationHistory"].Value = medicalAssessment.VaccinationHistory;
	InsertCommand.Parameters["@FHDiabetes"].Value = medicalAssessment.FHDiabetes;
	InsertCommand.Parameters["@FHTuberculosis"].Value = medicalAssessment.FHTuberculosis;
	InsertCommand.Parameters["@FHHighBloodPressure"].Value = medicalAssessment.FHHighBloodPressure;
	InsertCommand.Parameters["@FHAsthma"].Value = medicalAssessment.FHAsthma;
	InsertCommand.Parameters["@FHEpilepsyAndStroke"].Value = medicalAssessment.FHEpilepsyAndStroke;
	InsertCommand.Parameters["@FHBloodDisease"].Value = medicalAssessment.FHBloodDisease;
	InsertCommand.Parameters["@FHEczema"].Value = medicalAssessment.FHEczema;
	InsertCommand.Parameters["@FHHeartDisease"].Value = medicalAssessment.FHHeartDisease;
	InsertCommand.Parameters["@FHCancer"].Value = medicalAssessment.FHCancer;
	InsertCommand.Parameters["@MedicalAssessmentDate"].Value = medicalAssessment.MedicalAssessmentDate;
	InsertCommand.Parameters["@MedicationName"].Value = medicalAssessment.MedicationName;
	InsertCommand.Parameters["@Status"].Value = medicalAssessment.Status;
		
			
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
        
		public int Update(MedicalAssessment medicalAssessment)
		{
	UpdateCommand.Parameters["@ID"].Value = medicalAssessment.ID;
	UpdateCommand.Parameters["@PatientID"].Value = medicalAssessment.PatientID;
	UpdateCommand.Parameters["@Name"].Value = medicalAssessment.Name;
	UpdateCommand.Parameters["@Sex"].Value = medicalAssessment.Sex;
	UpdateCommand.Parameters["@DOB"].Value = medicalAssessment.DOB;
	UpdateCommand.Parameters["@Nationality"].Value = medicalAssessment.Nationality;
	UpdateCommand.Parameters["@ContactNo"].Value = medicalAssessment.ContactNo;
	UpdateCommand.Parameters["@MaritalStatus"].Value = medicalAssessment.MaritalStatus;
	UpdateCommand.Parameters["@NRCNo"].Value = medicalAssessment.NRCNo;
	UpdateCommand.Parameters["@Address"].Value = medicalAssessment.Address;
	UpdateCommand.Parameters["@JobPosition"].Value = medicalAssessment.JobPosition;
	UpdateCommand.Parameters["@CompanyName"].Value = medicalAssessment.CompanyName;
	UpdateCommand.Parameters["@ImagePath"].Value = medicalAssessment.ImagePath;
	UpdateCommand.Parameters["@SinusAndThroatTrouble"].Value = medicalAssessment.SinusAndThroatTrouble;
	UpdateCommand.Parameters["@EarTroubleAndDeafness"].Value = medicalAssessment.EarTroubleAndDeafness;
	UpdateCommand.Parameters["@DifficultyInVision"].Value = medicalAssessment.DifficultyInVision;
	UpdateCommand.Parameters["@AsthmaAndBronchitis"].Value = medicalAssessment.AsthmaAndBronchitis;
	UpdateCommand.Parameters["@AllergyAndHayFever"].Value = medicalAssessment.AllergyAndHayFever;
	UpdateCommand.Parameters["@Tuberculosis"].Value = medicalAssessment.Tuberculosis;
	UpdateCommand.Parameters["@OtherLungDiseases"].Value = medicalAssessment.OtherLungDiseases;
	UpdateCommand.Parameters["@HighBloodPressure"].Value = medicalAssessment.HighBloodPressure;
	UpdateCommand.Parameters["@HeartDisease"].Value = medicalAssessment.HeartDisease;
	UpdateCommand.Parameters["@RheumaticFever"].Value = medicalAssessment.RheumaticFever;
	UpdateCommand.Parameters["@Haemorrhoids"].Value = medicalAssessment.Haemorrhoids;
	UpdateCommand.Parameters["@StomachUlcer"].Value = medicalAssessment.StomachUlcer;
	UpdateCommand.Parameters["@JaundiceOrHepatitis"].Value = medicalAssessment.JaundiceOrHepatitis;
	UpdateCommand.Parameters["@GallBladderDiseases"].Value = medicalAssessment.GallBladderDiseases;
	UpdateCommand.Parameters["@HerniaAndHydrocele"].Value = medicalAssessment.HerniaAndHydrocele;
	UpdateCommand.Parameters["@GenitoUrinaryDisease"].Value = medicalAssessment.GenitoUrinaryDisease;
	UpdateCommand.Parameters["@BloodInUrine"].Value = medicalAssessment.BloodInUrine;
	UpdateCommand.Parameters["@Diabetes"].Value = medicalAssessment.Diabetes;
	UpdateCommand.Parameters["@EndocrineDisorders"].Value = medicalAssessment.EndocrineDisorders;
	UpdateCommand.Parameters["@CancerOrTumour"].Value = medicalAssessment.CancerOrTumour;
	UpdateCommand.Parameters["@MentalDisorders"].Value = medicalAssessment.MentalDisorders;
	UpdateCommand.Parameters["@HeadacheAndMigrane"].Value = medicalAssessment.HeadacheAndMigrane;
	UpdateCommand.Parameters["@Epilepsy"].Value = medicalAssessment.Epilepsy;
	UpdateCommand.Parameters["@JointAndSpinalTrouble"].Value = medicalAssessment.JointAndSpinalTrouble;
	UpdateCommand.Parameters["@SurgicalOperation"].Value = medicalAssessment.SurgicalOperation;
	UpdateCommand.Parameters["@VaricoseVeins"].Value = medicalAssessment.VaricoseVeins;
	UpdateCommand.Parameters["@AnyAccidentOrInjury"].Value = medicalAssessment.AnyAccidentOrInjury;
	UpdateCommand.Parameters["@GeneticDisorder"].Value = medicalAssessment.GeneticDisorder;
	UpdateCommand.Parameters["@TropicalDiseases"].Value = medicalAssessment.TropicalDiseases;
	UpdateCommand.Parameters["@ToxicExposure"].Value = medicalAssessment.ToxicExposure;
	UpdateCommand.Parameters["@BloodDiseases"].Value = medicalAssessment.BloodDiseases;
	UpdateCommand.Parameters["@FearOfHeights"].Value = medicalAssessment.FearOfHeights;
	UpdateCommand.Parameters["@DrugAndDrinkingProblem"].Value = medicalAssessment.DrugAndDrinkingProblem;
	UpdateCommand.Parameters["@Doyousmoke"].Value = medicalAssessment.Doyousmoke;
	UpdateCommand.Parameters["@TakeAlcoholRegularly"].Value = medicalAssessment.TakeAlcoholRegularly;
	UpdateCommand.Parameters["@VaccinationHistory"].Value = medicalAssessment.VaccinationHistory;
	UpdateCommand.Parameters["@FHDiabetes"].Value = medicalAssessment.FHDiabetes;
	UpdateCommand.Parameters["@FHTuberculosis"].Value = medicalAssessment.FHTuberculosis;
	UpdateCommand.Parameters["@FHHighBloodPressure"].Value = medicalAssessment.FHHighBloodPressure;
	UpdateCommand.Parameters["@FHAsthma"].Value = medicalAssessment.FHAsthma;
	UpdateCommand.Parameters["@FHEpilepsyAndStroke"].Value = medicalAssessment.FHEpilepsyAndStroke;
	UpdateCommand.Parameters["@FHBloodDisease"].Value = medicalAssessment.FHBloodDisease;
	UpdateCommand.Parameters["@FHEczema"].Value = medicalAssessment.FHEczema;
	UpdateCommand.Parameters["@FHHeartDisease"].Value = medicalAssessment.FHHeartDisease;
	UpdateCommand.Parameters["@FHCancer"].Value = medicalAssessment.FHCancer;
	UpdateCommand.Parameters["@MedicalAssessmentDate"].Value = medicalAssessment.MedicalAssessmentDate;
	UpdateCommand.Parameters["@MedicationName"].Value = medicalAssessment.MedicationName;
	UpdateCommand.Parameters["@Status"].Value = medicalAssessment.Status;

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
        
        private MedicalAssessment DataTableToEntity(DataTable dt)
        {
           
            MedicalAssessment medicalAssessment = new MedicalAssessment();
            if(Null.IsNotNull(dt)==true && dt.Rows.Count > 0)
            {
                
                if (Null.IsNotNull(dt.Rows[0]))
                {
                    DataRow dr = dt.Rows[0];
                      					if (Null.IsNotNull(dr["ID"]))
					{
						medicalAssessment.ID=Convert.ToInt32(dr["ID"]);
					}
					else
					{
						medicalAssessment.ID=0;
					}
					if (Null.IsNotNull(dr["PatientID"]))
					{
						medicalAssessment.PatientID=Convert.ToInt32(dr["PatientID"]);
					}
					else
					{
						medicalAssessment.PatientID=0;
					}
					if (Null.IsNotNull(dr["Name"]))
					{
						medicalAssessment.Name= Convert.ToString(dr["Name"]);
					}
					else
					{
						medicalAssessment.Name=string.Empty;
					}
					if (Null.IsNotNull(dr["Sex"]))
					{
						medicalAssessment.Sex= Convert.ToString(dr["Sex"]);
					}
					else
					{
						medicalAssessment.Sex=string.Empty;
					}
					if (Null.IsNotNull(dr["DOB"]))
					{
						medicalAssessment.DOB= Convert.ToDateTime(dr["DOB"]);
					}
					else
					{
						medicalAssessment.DOB=DateTime.Now;
					}
					if (Null.IsNotNull(dr["Nationality"]))
					{
						medicalAssessment.Nationality= Convert.ToString(dr["Nationality"]);
					}
					else
					{
						medicalAssessment.Nationality=string.Empty;
					}
					if (Null.IsNotNull(dr["ContactNo"]))
					{
						medicalAssessment.ContactNo= Convert.ToString(dr["ContactNo"]);
					}
					else
					{
						medicalAssessment.ContactNo=string.Empty;
					}
					if (Null.IsNotNull(dr["MaritalStatus"]))
					{
						medicalAssessment.MaritalStatus= Convert.ToString(dr["MaritalStatus"]);
					}
					else
					{
						medicalAssessment.MaritalStatus=string.Empty;
					}
					if (Null.IsNotNull(dr["NRCNo"]))
					{
						medicalAssessment.NRCNo= Convert.ToString(dr["NRCNo"]);
					}
					else
					{
						medicalAssessment.NRCNo=string.Empty;
					}
					if (Null.IsNotNull(dr["Address"]))
					{
						medicalAssessment.Address= Convert.ToString(dr["Address"]);
					}
					else
					{
						medicalAssessment.Address=string.Empty;
					}
					if (Null.IsNotNull(dr["JobPosition"]))
					{
						medicalAssessment.JobPosition= Convert.ToString(dr["JobPosition"]);
					}
					else
					{
						medicalAssessment.JobPosition=string.Empty;
					}
					if (Null.IsNotNull(dr["CompanyName"]))
					{
						medicalAssessment.CompanyName= Convert.ToString(dr["CompanyName"]);
					}
					else
					{
						medicalAssessment.CompanyName=string.Empty;
					}
					if (Null.IsNotNull(dr["ImagePath"]))
					{
						medicalAssessment.ImagePath= Convert.ToString(dr["ImagePath"]);
					}
					else
					{
						medicalAssessment.ImagePath=string.Empty;
					}
					if (Null.IsNotNull(dr["SinusAndThroatTrouble"]))
					{
						medicalAssessment.SinusAndThroatTrouble= Convert.ToString(dr["SinusAndThroatTrouble"]);
					}
					else
					{
						medicalAssessment.SinusAndThroatTrouble=string.Empty;
					}
					if (Null.IsNotNull(dr["EarTroubleAndDeafness"]))
					{
						medicalAssessment.EarTroubleAndDeafness= Convert.ToString(dr["EarTroubleAndDeafness"]);
					}
					else
					{
						medicalAssessment.EarTroubleAndDeafness=string.Empty;
					}
					if (Null.IsNotNull(dr["DifficultyInVision"]))
					{
						medicalAssessment.DifficultyInVision= Convert.ToString(dr["DifficultyInVision"]);
					}
					else
					{
						medicalAssessment.DifficultyInVision=string.Empty;
					}
					if (Null.IsNotNull(dr["AsthmaAndBronchitis"]))
					{
						medicalAssessment.AsthmaAndBronchitis= Convert.ToString(dr["AsthmaAndBronchitis"]);
					}
					else
					{
						medicalAssessment.AsthmaAndBronchitis=string.Empty;
					}
					if (Null.IsNotNull(dr["AllergyAndHayFever"]))
					{
						medicalAssessment.AllergyAndHayFever= Convert.ToString(dr["AllergyAndHayFever"]);
					}
					else
					{
						medicalAssessment.AllergyAndHayFever=string.Empty;
					}
					if (Null.IsNotNull(dr["Tuberculosis"]))
					{
						medicalAssessment.Tuberculosis= Convert.ToString(dr["Tuberculosis"]);
					}
					else
					{
						medicalAssessment.Tuberculosis=string.Empty;
					}
					if (Null.IsNotNull(dr["OtherLungDiseases"]))
					{
						medicalAssessment.OtherLungDiseases= Convert.ToString(dr["OtherLungDiseases"]);
					}
					else
					{
						medicalAssessment.OtherLungDiseases=string.Empty;
					}
					if (Null.IsNotNull(dr["HighBloodPressure"]))
					{
						medicalAssessment.HighBloodPressure= Convert.ToString(dr["HighBloodPressure"]);
					}
					else
					{
						medicalAssessment.HighBloodPressure=string.Empty;
					}
					if (Null.IsNotNull(dr["HeartDisease"]))
					{
						medicalAssessment.HeartDisease= Convert.ToString(dr["HeartDisease"]);
					}
					else
					{
						medicalAssessment.HeartDisease=string.Empty;
					}
					if (Null.IsNotNull(dr["RheumaticFever"]))
					{
						medicalAssessment.RheumaticFever= Convert.ToString(dr["RheumaticFever"]);
					}
					else
					{
						medicalAssessment.RheumaticFever=string.Empty;
					}
					if (Null.IsNotNull(dr["Haemorrhoids"]))
					{
						medicalAssessment.Haemorrhoids= Convert.ToString(dr["Haemorrhoids"]);
					}
					else
					{
						medicalAssessment.Haemorrhoids=string.Empty;
					}
					if (Null.IsNotNull(dr["StomachUlcer"]))
					{
						medicalAssessment.StomachUlcer= Convert.ToString(dr["StomachUlcer"]);
					}
					else
					{
						medicalAssessment.StomachUlcer=string.Empty;
					}
					if (Null.IsNotNull(dr["JaundiceOrHepatitis"]))
					{
						medicalAssessment.JaundiceOrHepatitis= Convert.ToString(dr["JaundiceOrHepatitis"]);
					}
					else
					{
						medicalAssessment.JaundiceOrHepatitis=string.Empty;
					}
					if (Null.IsNotNull(dr["GallBladderDiseases"]))
					{
						medicalAssessment.GallBladderDiseases= Convert.ToString(dr["GallBladderDiseases"]);
					}
					else
					{
						medicalAssessment.GallBladderDiseases=string.Empty;
					}
					if (Null.IsNotNull(dr["HerniaAndHydrocele"]))
					{
						medicalAssessment.HerniaAndHydrocele= Convert.ToString(dr["HerniaAndHydrocele"]);
					}
					else
					{
						medicalAssessment.HerniaAndHydrocele=string.Empty;
					}
					if (Null.IsNotNull(dr["GenitoUrinaryDisease"]))
					{
						medicalAssessment.GenitoUrinaryDisease= Convert.ToString(dr["GenitoUrinaryDisease"]);
					}
					else
					{
						medicalAssessment.GenitoUrinaryDisease=string.Empty;
					}
					if (Null.IsNotNull(dr["BloodInUrine"]))
					{
						medicalAssessment.BloodInUrine= Convert.ToString(dr["BloodInUrine"]);
					}
					else
					{
						medicalAssessment.BloodInUrine=string.Empty;
					}
					if (Null.IsNotNull(dr["Diabetes"]))
					{
						medicalAssessment.Diabetes= Convert.ToString(dr["Diabetes"]);
					}
					else
					{
						medicalAssessment.Diabetes=string.Empty;
					}
					if (Null.IsNotNull(dr["EndocrineDisorders"]))
					{
						medicalAssessment.EndocrineDisorders= Convert.ToString(dr["EndocrineDisorders"]);
					}
					else
					{
						medicalAssessment.EndocrineDisorders=string.Empty;
					}
					if (Null.IsNotNull(dr["CancerOrTumour"]))
					{
						medicalAssessment.CancerOrTumour= Convert.ToString(dr["CancerOrTumour"]);
					}
					else
					{
						medicalAssessment.CancerOrTumour=string.Empty;
					}
					if (Null.IsNotNull(dr["MentalDisorders"]))
					{
						medicalAssessment.MentalDisorders= Convert.ToString(dr["MentalDisorders"]);
					}
					else
					{
						medicalAssessment.MentalDisorders=string.Empty;
					}
					if (Null.IsNotNull(dr["HeadacheAndMigrane"]))
					{
						medicalAssessment.HeadacheAndMigrane= Convert.ToString(dr["HeadacheAndMigrane"]);
					}
					else
					{
						medicalAssessment.HeadacheAndMigrane=string.Empty;
					}
					if (Null.IsNotNull(dr["Epilepsy"]))
					{
						medicalAssessment.Epilepsy= Convert.ToString(dr["Epilepsy"]);
					}
					else
					{
						medicalAssessment.Epilepsy=string.Empty;
					}
					if (Null.IsNotNull(dr["JointAndSpinalTrouble"]))
					{
						medicalAssessment.JointAndSpinalTrouble= Convert.ToString(dr["JointAndSpinalTrouble"]);
					}
					else
					{
						medicalAssessment.JointAndSpinalTrouble=string.Empty;
					}
					if (Null.IsNotNull(dr["SurgicalOperation"]))
					{
						medicalAssessment.SurgicalOperation= Convert.ToString(dr["SurgicalOperation"]);
					}
					else
					{
						medicalAssessment.SurgicalOperation=string.Empty;
					}
					if (Null.IsNotNull(dr["VaricoseVeins"]))
					{
						medicalAssessment.VaricoseVeins= Convert.ToString(dr["VaricoseVeins"]);
					}
					else
					{
						medicalAssessment.VaricoseVeins=string.Empty;
					}
					if (Null.IsNotNull(dr["AnyAccidentOrInjury"]))
					{
						medicalAssessment.AnyAccidentOrInjury= Convert.ToString(dr["AnyAccidentOrInjury"]);
					}
					else
					{
						medicalAssessment.AnyAccidentOrInjury=string.Empty;
					}
					if (Null.IsNotNull(dr["GeneticDisorder"]))
					{
						medicalAssessment.GeneticDisorder= Convert.ToString(dr["GeneticDisorder"]);
					}
					else
					{
						medicalAssessment.GeneticDisorder=string.Empty;
					}
					if (Null.IsNotNull(dr["TropicalDiseases"]))
					{
						medicalAssessment.TropicalDiseases= Convert.ToString(dr["TropicalDiseases"]);
					}
					else
					{
						medicalAssessment.TropicalDiseases=string.Empty;
					}
					if (Null.IsNotNull(dr["ToxicExposure"]))
					{
						medicalAssessment.ToxicExposure= Convert.ToString(dr["ToxicExposure"]);
					}
					else
					{
						medicalAssessment.ToxicExposure=string.Empty;
					}
					if (Null.IsNotNull(dr["BloodDiseases"]))
					{
						medicalAssessment.BloodDiseases= Convert.ToString(dr["BloodDiseases"]);
					}
					else
					{
						medicalAssessment.BloodDiseases=string.Empty;
					}
					if (Null.IsNotNull(dr["FearOfHeights"]))
					{
						medicalAssessment.FearOfHeights= Convert.ToString(dr["FearOfHeights"]);
					}
					else
					{
						medicalAssessment.FearOfHeights=string.Empty;
					}
					if (Null.IsNotNull(dr["DrugAndDrinkingProblem"]))
					{
						medicalAssessment.DrugAndDrinkingProblem= Convert.ToString(dr["DrugAndDrinkingProblem"]);
					}
					else
					{
						medicalAssessment.DrugAndDrinkingProblem=string.Empty;
					}
					if (Null.IsNotNull(dr["Doyousmoke"]))
					{
						medicalAssessment.Doyousmoke= Convert.ToString(dr["Doyousmoke"]);
					}
					else
					{
						medicalAssessment.Doyousmoke=string.Empty;
					}
					if (Null.IsNotNull(dr["TakeAlcoholRegularly"]))
					{
						medicalAssessment.TakeAlcoholRegularly= Convert.ToString(dr["TakeAlcoholRegularly"]);
					}
					else
					{
						medicalAssessment.TakeAlcoholRegularly=string.Empty;
					}
					if (Null.IsNotNull(dr["VaccinationHistory"]))
					{
						medicalAssessment.VaccinationHistory= Convert.ToString(dr["VaccinationHistory"]);
					}
					else
					{
						medicalAssessment.VaccinationHistory=string.Empty;
					}
					if (Null.IsNotNull(dr["FHDiabetes"]))
					{
						medicalAssessment.FHDiabetes= Convert.ToString(dr["FHDiabetes"]);
					}
					else
					{
						medicalAssessment.FHDiabetes=string.Empty;
					}
					if (Null.IsNotNull(dr["FHTuberculosis"]))
					{
						medicalAssessment.FHTuberculosis= Convert.ToString(dr["FHTuberculosis"]);
					}
					else
					{
						medicalAssessment.FHTuberculosis=string.Empty;
					}
					if (Null.IsNotNull(dr["FHHighBloodPressure"]))
					{
						medicalAssessment.FHHighBloodPressure= Convert.ToString(dr["FHHighBloodPressure"]);
					}
					else
					{
						medicalAssessment.FHHighBloodPressure=string.Empty;
					}
					if (Null.IsNotNull(dr["FHAsthma"]))
					{
						medicalAssessment.FHAsthma= Convert.ToString(dr["FHAsthma"]);
					}
					else
					{
						medicalAssessment.FHAsthma=string.Empty;
					}
					if (Null.IsNotNull(dr["FHEpilepsyAndStroke"]))
					{
						medicalAssessment.FHEpilepsyAndStroke= Convert.ToString(dr["FHEpilepsyAndStroke"]);
					}
					else
					{
						medicalAssessment.FHEpilepsyAndStroke=string.Empty;
					}
					if (Null.IsNotNull(dr["FHBloodDisease"]))
					{
						medicalAssessment.FHBloodDisease= Convert.ToString(dr["FHBloodDisease"]);
					}
					else
					{
						medicalAssessment.FHBloodDisease=string.Empty;
					}
					if (Null.IsNotNull(dr["FHEczema"]))
					{
						medicalAssessment.FHEczema= Convert.ToString(dr["FHEczema"]);
					}
					else
					{
						medicalAssessment.FHEczema=string.Empty;
					}
					if (Null.IsNotNull(dr["FHHeartDisease"]))
					{
						medicalAssessment.FHHeartDisease= Convert.ToString(dr["FHHeartDisease"]);
					}
					else
					{
						medicalAssessment.FHHeartDisease=string.Empty;
					}
					if (Null.IsNotNull(dr["FHCancer"]))
					{
						medicalAssessment.FHCancer= Convert.ToString(dr["FHCancer"]);
					}
					else
					{
						medicalAssessment.FHCancer=string.Empty;
					}
					if (Null.IsNotNull(dr["MedicalAssessmentDate"]))
					{
						medicalAssessment.MedicalAssessmentDate= Convert.ToDateTime(dr["MedicalAssessmentDate"]);
					}
					else
					{
						medicalAssessment.MedicalAssessmentDate=DateTime.Now;
					}
					if (Null.IsNotNull(dr["MedicationName"]))
					{
						medicalAssessment.MedicationName= Convert.ToString(dr["MedicationName"]);
					}
					else
					{
						medicalAssessment.MedicationName=string.Empty;
					}
					if (Null.IsNotNull(dr["Status"]))
					{
						medicalAssessment.Status= Convert.ToString(dr["Status"]);
					}
					else
					{
						medicalAssessment.Status=string.Empty;
					}
 
                }
            }
            return medicalAssessment ;
        }
		#endregion		
	}
}