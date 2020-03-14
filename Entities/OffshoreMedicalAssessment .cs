using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class OffshoreMedicalAssessment 
	{
			
		#region Constructers

			public OffshoreMedicalAssessment(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PatientID;
			private	string _Name;
			private	string _Sex;
			private	DateTime _DOB;
			private	string _Nationality;
			private	string _ContactNo;
			private	string _MaritalStatus;
			private	string _NRCNo;
			private	string _Address;
			private	string _JobPosition;
			private	string _CompanyName;
			private	string _ImagePath;
			private	string _SinusAndThroatTrouble;
			private	string _EarTroubleAndDeafness;
			private	string _DifficultyInVision;
			private	string _AsthmaAndBronchitis;
			private	string _AllergyAndHayFever;
			private	string _Tuberculosis;
			private	string _OtherLungDiseases;
			private	string _HighBloodPressure;
			private	string _HeartDisease;
			private	string _RheumaticFever;
			private	string _Haemorrhoids;
			private	string _StomachUlcer;
			private	string _JaundiceOrHepatitis;
			private	string _GallBladderDiseases;
			private	string _HerniaAndHydrocele;
			private	string _GenitoUrinaryDisease;
			private	string _BloodInUrine;
			private	string _Diabetes;
			private	string _EndocrineDisorders;
			private	string _CancerOrTumour;
			private	string _MentalDisorders;
			private	string _HeadacheAndMigrane;
			private	string _Epilepsy;
			private	string _JointAndSpinalTrouble;
			private	string _SurgicalOperation;
			private	string _VaricoseVeins;
			private	string _AnyAccidentOrInjury;
			private	string _GeneticDisorder;
			private	string _TropicalDiseases;
			private	string _ToxicExposure;
			private	string _BloodDiseases;
			private	string _FearOfHeights;
			private	string _DrugAndDrinkingProblem;
			private	string _Doyousmoke;
			private	string _TakeAlcoholRegularly;
			private	string _VaccinationHistory;
			private	string _FHDiabetes;
			private	string _FHTuberculosis;
			private	string _FHHighBloodPressure;
			private	string _FHAsthma;
			private	string _FHEpilepsyAndStroke;
			private	string _FHBloodDisease;
			private	string _FHEczema;
			private	string _FHHeartDisease;
			private	string _FHCancer;
			private	DateTime _OffshoreMedicalAssessmentDate;
			private	string _MedicationName;
			private	string _Status;

		
		#endregion
		
		#region Properties
		
					public	int  ID
			{
				get 
				{ 
					if(Null.IsNotNull(_ID)) 
					{
					 return _ID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ID = value;}
			}
			public	int  PatientID
			{
				get 
				{ 
					if(Null.IsNotNull(_PatientID)) 
					{
					 return _PatientID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _PatientID = value;}
			}
			public	string  Name
			{
				get 
				{ 
					if(Null.IsNotNull(_Name)) 
					{
					 return _Name;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Name = value;}
			}
			public	string  Sex
			{
				get 
				{ 
					if(Null.IsNotNull(_Sex)) 
					{
					 return _Sex;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Sex = value;}
			}
			public	DateTime  DOB
			{
				get 
				{ 
					if(Null.IsNotNull(_DOB)) 
					{
					 return _DOB;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _DOB = value;}
			}
			public	string  Nationality
			{
				get 
				{ 
					if(Null.IsNotNull(_Nationality)) 
					{
					 return _Nationality;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Nationality = value;}
			}
			public	string  ContactNo
			{
				get 
				{ 
					if(Null.IsNotNull(_ContactNo)) 
					{
					 return _ContactNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ContactNo = value;}
			}
			public	string  MaritalStatus
			{
				get 
				{ 
					if(Null.IsNotNull(_MaritalStatus)) 
					{
					 return _MaritalStatus;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MaritalStatus = value;}
			}
			public	string  NRCNo
			{
				get 
				{ 
					if(Null.IsNotNull(_NRCNo)) 
					{
					 return _NRCNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NRCNo = value;}
			}
			public	string  Address
			{
				get 
				{ 
					if(Null.IsNotNull(_Address)) 
					{
					 return _Address;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Address = value;}
			}
			public	string  JobPosition
			{
				get 
				{ 
					if(Null.IsNotNull(_JobPosition)) 
					{
					 return _JobPosition;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _JobPosition = value;}
			}
			public	string  CompanyName
			{
				get 
				{ 
					if(Null.IsNotNull(_CompanyName)) 
					{
					 return _CompanyName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CompanyName = value;}
			}
			public	string  ImagePath
			{
				get 
				{ 
					if(Null.IsNotNull(_ImagePath)) 
					{
					 return _ImagePath;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ImagePath = value;}
			}
			public	string  SinusAndThroatTrouble
			{
				get 
				{ 
					if(Null.IsNotNull(_SinusAndThroatTrouble)) 
					{
					 return _SinusAndThroatTrouble;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SinusAndThroatTrouble = value;}
			}
			public	string  EarTroubleAndDeafness
			{
				get 
				{ 
					if(Null.IsNotNull(_EarTroubleAndDeafness)) 
					{
					 return _EarTroubleAndDeafness;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarTroubleAndDeafness = value;}
			}
			public	string  DifficultyInVision
			{
				get 
				{ 
					if(Null.IsNotNull(_DifficultyInVision)) 
					{
					 return _DifficultyInVision;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _DifficultyInVision = value;}
			}
			public	string  AsthmaAndBronchitis
			{
				get 
				{ 
					if(Null.IsNotNull(_AsthmaAndBronchitis)) 
					{
					 return _AsthmaAndBronchitis;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AsthmaAndBronchitis = value;}
			}
			public	string  AllergyAndHayFever
			{
				get 
				{ 
					if(Null.IsNotNull(_AllergyAndHayFever)) 
					{
					 return _AllergyAndHayFever;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AllergyAndHayFever = value;}
			}
			public	string  Tuberculosis
			{
				get 
				{ 
					if(Null.IsNotNull(_Tuberculosis)) 
					{
					 return _Tuberculosis;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Tuberculosis = value;}
			}
			public	string  OtherLungDiseases
			{
				get 
				{ 
					if(Null.IsNotNull(_OtherLungDiseases)) 
					{
					 return _OtherLungDiseases;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _OtherLungDiseases = value;}
			}
			public	string  HighBloodPressure
			{
				get 
				{ 
					if(Null.IsNotNull(_HighBloodPressure)) 
					{
					 return _HighBloodPressure;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HighBloodPressure = value;}
			}
			public	string  HeartDisease
			{
				get 
				{ 
					if(Null.IsNotNull(_HeartDisease)) 
					{
					 return _HeartDisease;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HeartDisease = value;}
			}
			public	string  RheumaticFever
			{
				get 
				{ 
					if(Null.IsNotNull(_RheumaticFever)) 
					{
					 return _RheumaticFever;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RheumaticFever = value;}
			}
			public	string  Haemorrhoids
			{
				get 
				{ 
					if(Null.IsNotNull(_Haemorrhoids)) 
					{
					 return _Haemorrhoids;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Haemorrhoids = value;}
			}
			public	string  StomachUlcer
			{
				get 
				{ 
					if(Null.IsNotNull(_StomachUlcer)) 
					{
					 return _StomachUlcer;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _StomachUlcer = value;}
			}
			public	string  JaundiceOrHepatitis
			{
				get 
				{ 
					if(Null.IsNotNull(_JaundiceOrHepatitis)) 
					{
					 return _JaundiceOrHepatitis;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _JaundiceOrHepatitis = value;}
			}
			public	string  GallBladderDiseases
			{
				get 
				{ 
					if(Null.IsNotNull(_GallBladderDiseases)) 
					{
					 return _GallBladderDiseases;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GallBladderDiseases = value;}
			}
			public	string  HerniaAndHydrocele
			{
				get 
				{ 
					if(Null.IsNotNull(_HerniaAndHydrocele)) 
					{
					 return _HerniaAndHydrocele;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HerniaAndHydrocele = value;}
			}
			public	string  GenitoUrinaryDisease
			{
				get 
				{ 
					if(Null.IsNotNull(_GenitoUrinaryDisease)) 
					{
					 return _GenitoUrinaryDisease;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GenitoUrinaryDisease = value;}
			}
			public	string  BloodInUrine
			{
				get 
				{ 
					if(Null.IsNotNull(_BloodInUrine)) 
					{
					 return _BloodInUrine;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BloodInUrine = value;}
			}
			public	string  Diabetes
			{
				get 
				{ 
					if(Null.IsNotNull(_Diabetes)) 
					{
					 return _Diabetes;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Diabetes = value;}
			}
			public	string  EndocrineDisorders
			{
				get 
				{ 
					if(Null.IsNotNull(_EndocrineDisorders)) 
					{
					 return _EndocrineDisorders;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EndocrineDisorders = value;}
			}
			public	string  CancerOrTumour
			{
				get 
				{ 
					if(Null.IsNotNull(_CancerOrTumour)) 
					{
					 return _CancerOrTumour;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CancerOrTumour = value;}
			}
			public	string  MentalDisorders
			{
				get 
				{ 
					if(Null.IsNotNull(_MentalDisorders)) 
					{
					 return _MentalDisorders;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MentalDisorders = value;}
			}
			public	string  HeadacheAndMigrane
			{
				get 
				{ 
					if(Null.IsNotNull(_HeadacheAndMigrane)) 
					{
					 return _HeadacheAndMigrane;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HeadacheAndMigrane = value;}
			}
			public	string  Epilepsy
			{
				get 
				{ 
					if(Null.IsNotNull(_Epilepsy)) 
					{
					 return _Epilepsy;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Epilepsy = value;}
			}
			public	string  JointAndSpinalTrouble
			{
				get 
				{ 
					if(Null.IsNotNull(_JointAndSpinalTrouble)) 
					{
					 return _JointAndSpinalTrouble;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _JointAndSpinalTrouble = value;}
			}
			public	string  SurgicalOperation
			{
				get 
				{ 
					if(Null.IsNotNull(_SurgicalOperation)) 
					{
					 return _SurgicalOperation;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SurgicalOperation = value;}
			}
			public	string  VaricoseVeins
			{
				get 
				{ 
					if(Null.IsNotNull(_VaricoseVeins)) 
					{
					 return _VaricoseVeins;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _VaricoseVeins = value;}
			}
			public	string  AnyAccidentOrInjury
			{
				get 
				{ 
					if(Null.IsNotNull(_AnyAccidentOrInjury)) 
					{
					 return _AnyAccidentOrInjury;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AnyAccidentOrInjury = value;}
			}
			public	string  GeneticDisorder
			{
				get 
				{ 
					if(Null.IsNotNull(_GeneticDisorder)) 
					{
					 return _GeneticDisorder;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GeneticDisorder = value;}
			}
			public	string  TropicalDiseases
			{
				get 
				{ 
					if(Null.IsNotNull(_TropicalDiseases)) 
					{
					 return _TropicalDiseases;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TropicalDiseases = value;}
			}
			public	string  ToxicExposure
			{
				get 
				{ 
					if(Null.IsNotNull(_ToxicExposure)) 
					{
					 return _ToxicExposure;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ToxicExposure = value;}
			}
			public	string  BloodDiseases
			{
				get 
				{ 
					if(Null.IsNotNull(_BloodDiseases)) 
					{
					 return _BloodDiseases;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BloodDiseases = value;}
			}
			public	string  FearOfHeights
			{
				get 
				{ 
					if(Null.IsNotNull(_FearOfHeights)) 
					{
					 return _FearOfHeights;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FearOfHeights = value;}
			}
			public	string  DrugAndDrinkingProblem
			{
				get 
				{ 
					if(Null.IsNotNull(_DrugAndDrinkingProblem)) 
					{
					 return _DrugAndDrinkingProblem;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _DrugAndDrinkingProblem = value;}
			}
			public	string  Doyousmoke
			{
				get 
				{ 
					if(Null.IsNotNull(_Doyousmoke)) 
					{
					 return _Doyousmoke;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Doyousmoke = value;}
			}
			public	string  TakeAlcoholRegularly
			{
				get 
				{ 
					if(Null.IsNotNull(_TakeAlcoholRegularly)) 
					{
					 return _TakeAlcoholRegularly;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TakeAlcoholRegularly = value;}
			}
			public	string  VaccinationHistory
			{
				get 
				{ 
					if(Null.IsNotNull(_VaccinationHistory)) 
					{
					 return _VaccinationHistory;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _VaccinationHistory = value;}
			}
			public	string  FHDiabetes
			{
				get 
				{ 
					if(Null.IsNotNull(_FHDiabetes)) 
					{
					 return _FHDiabetes;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHDiabetes = value;}
			}
			public	string  FHTuberculosis
			{
				get 
				{ 
					if(Null.IsNotNull(_FHTuberculosis)) 
					{
					 return _FHTuberculosis;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHTuberculosis = value;}
			}
			public	string  FHHighBloodPressure
			{
				get 
				{ 
					if(Null.IsNotNull(_FHHighBloodPressure)) 
					{
					 return _FHHighBloodPressure;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHHighBloodPressure = value;}
			}
			public	string  FHAsthma
			{
				get 
				{ 
					if(Null.IsNotNull(_FHAsthma)) 
					{
					 return _FHAsthma;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHAsthma = value;}
			}
			public	string  FHEpilepsyAndStroke
			{
				get 
				{ 
					if(Null.IsNotNull(_FHEpilepsyAndStroke)) 
					{
					 return _FHEpilepsyAndStroke;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHEpilepsyAndStroke = value;}
			}
			public	string  FHBloodDisease
			{
				get 
				{ 
					if(Null.IsNotNull(_FHBloodDisease)) 
					{
					 return _FHBloodDisease;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHBloodDisease = value;}
			}
			public	string  FHEczema
			{
				get 
				{ 
					if(Null.IsNotNull(_FHEczema)) 
					{
					 return _FHEczema;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHEczema = value;}
			}
			public	string  FHHeartDisease
			{
				get 
				{ 
					if(Null.IsNotNull(_FHHeartDisease)) 
					{
					 return _FHHeartDisease;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHHeartDisease = value;}
			}
			public	string  FHCancer
			{
				get 
				{ 
					if(Null.IsNotNull(_FHCancer)) 
					{
					 return _FHCancer;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FHCancer = value;}
			}
			public	DateTime  OffshoreMedicalAssessmentDate
			{
				get 
				{ 
					if(Null.IsNotNull(_OffshoreMedicalAssessmentDate)) 
					{
					 return _OffshoreMedicalAssessmentDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _OffshoreMedicalAssessmentDate = value;}
			}
			public	string  MedicationName
			{
				get 
				{ 
					if(Null.IsNotNull(_MedicationName)) 
					{
					 return _MedicationName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MedicationName = value;}
			}
			public	string  Status
			{
				get 
				{ 
					if(Null.IsNotNull(_Status)) 
					{
					 return _Status;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Status = value;}
			}

		
		#endregion
		
		#region CustomCommand
			
			
			
			
		
		
		
		#endregion CustomCommand
		
	}
}