using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Checkup 
	{
			
		#region Constructers

			public Checkup(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _Name;
			private	string _Sex;
			private	DateTime _DOB;
			private	string _Nationality;
			private	string _ContactNo;
			private	string _MaritalStatus;
			private	string _NRCNo;
			private	string _Address;
			private	string _Height;
			private	string _Weight;
			private	string _BMI;
			private	string _Skin;
			private	string _Scalp;
			private	string _Deformity;
			private	string _FarVisionUncorrected;
			private	string _FarVisionCorrected;
			private	string _NearVisionUncorrected;
			private	string _NearVisionCorrected;
			private	string _ColourVision;
			private	string _EyesAndPupilsBothSides;
			private	string _EyesAndPupilsRegular;
			private	string _EyesAndPupilsFudusExamination;
			private	string _EarDrums;
			private	string _Hearing;
			private	string _Nose;
			private	string _Tonsils;
			private	string _TeethAndMouthHealthy;
			private	string _TeethUpper;
			private	string _RespiratoryRate;
			private	string _RespiratoryBreathSounds;
			private	string _RespiratoryOthers;
			private	string _HeartRate;
			private	string _BP;
			private	string _Auscultation;
			private	string _AbdomenLiver;
			private	string _AbdomenSpleen;
			private	string _AbdomenKidneys;
			private	string _AbdomenBowelSound;
			private	string _HernialOrifices;
			private	string _GenitoUrinary;
			private	string _ExtremitiesSwelling;
			private	string _ExtremitiesDeformity;
			private	string _MusculoSkeletalSkull;
			private	string _MusculoSpine;
			private	string _MusculoUpperExtremities;
			private	string _MusculoLowerExtremities;
			private	string _SkinAndVaricoseVeins;
			private	string _NeurologicalAccomondation;
			private	string _NeurologicalMotor;
			private	string _NeurologicalSensory;
			private	string _NeurologicalReflexes;
			private	string _PsychologicalTest;
			private	DateTime _CheckupDate;
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
			public	string  Height
			{
				get 
				{ 
					if(Null.IsNotNull(_Height)) 
					{
					 return _Height;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Height = value;}
			}
			public	string  Weight
			{
				get 
				{ 
					if(Null.IsNotNull(_Weight)) 
					{
					 return _Weight;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Weight = value;}
			}
			public	string  BMI
			{
				get 
				{ 
					if(Null.IsNotNull(_BMI)) 
					{
					 return _BMI;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BMI = value;}
			}
			public	string  Skin
			{
				get 
				{ 
					if(Null.IsNotNull(_Skin)) 
					{
					 return _Skin;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Skin = value;}
			}
			public	string  Scalp
			{
				get 
				{ 
					if(Null.IsNotNull(_Scalp)) 
					{
					 return _Scalp;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Scalp = value;}
			}
			public	string  Deformity
			{
				get 
				{ 
					if(Null.IsNotNull(_Deformity)) 
					{
					 return _Deformity;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Deformity = value;}
			}
			public	string  FarVisionUncorrected
			{
				get 
				{ 
					if(Null.IsNotNull(_FarVisionUncorrected)) 
					{
					 return _FarVisionUncorrected;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FarVisionUncorrected = value;}
			}
			public	string  FarVisionCorrected
			{
				get 
				{ 
					if(Null.IsNotNull(_FarVisionCorrected)) 
					{
					 return _FarVisionCorrected;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FarVisionCorrected = value;}
			}
			public	string  NearVisionUncorrected
			{
				get 
				{ 
					if(Null.IsNotNull(_NearVisionUncorrected)) 
					{
					 return _NearVisionUncorrected;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NearVisionUncorrected = value;}
			}
			public	string  NearVisionCorrected
			{
				get 
				{ 
					if(Null.IsNotNull(_NearVisionCorrected)) 
					{
					 return _NearVisionCorrected;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NearVisionCorrected = value;}
			}
			public	string  ColourVision
			{
				get 
				{ 
					if(Null.IsNotNull(_ColourVision)) 
					{
					 return _ColourVision;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ColourVision = value;}
			}
			public	string  EyesAndPupilsBothSides
			{
				get 
				{ 
					if(Null.IsNotNull(_EyesAndPupilsBothSides)) 
					{
					 return _EyesAndPupilsBothSides;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EyesAndPupilsBothSides = value;}
			}
			public	string  EyesAndPupilsRegular
			{
				get 
				{ 
					if(Null.IsNotNull(_EyesAndPupilsRegular)) 
					{
					 return _EyesAndPupilsRegular;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EyesAndPupilsRegular = value;}
			}
			public	string  EyesAndPupilsFudusExamination
			{
				get 
				{ 
					if(Null.IsNotNull(_EyesAndPupilsFudusExamination)) 
					{
					 return _EyesAndPupilsFudusExamination;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EyesAndPupilsFudusExamination = value;}
			}
			public	string  EarDrums
			{
				get 
				{ 
					if(Null.IsNotNull(_EarDrums)) 
					{
					 return _EarDrums;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarDrums = value;}
			}
			public	string  Hearing
			{
				get 
				{ 
					if(Null.IsNotNull(_Hearing)) 
					{
					 return _Hearing;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Hearing = value;}
			}
			public	string  Nose
			{
				get 
				{ 
					if(Null.IsNotNull(_Nose)) 
					{
					 return _Nose;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Nose = value;}
			}
			public	string  Tonsils
			{
				get 
				{ 
					if(Null.IsNotNull(_Tonsils)) 
					{
					 return _Tonsils;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Tonsils = value;}
			}
			public	string  TeethAndMouthHealthy
			{
				get 
				{ 
					if(Null.IsNotNull(_TeethAndMouthHealthy)) 
					{
					 return _TeethAndMouthHealthy;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TeethAndMouthHealthy = value;}
			}
			public	string  TeethUpper
			{
				get 
				{ 
					if(Null.IsNotNull(_TeethUpper)) 
					{
					 return _TeethUpper;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TeethUpper = value;}
			}
			public	string  RespiratoryRate
			{
				get 
				{ 
					if(Null.IsNotNull(_RespiratoryRate)) 
					{
					 return _RespiratoryRate;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RespiratoryRate = value;}
			}
			public	string  RespiratoryBreathSounds
			{
				get 
				{ 
					if(Null.IsNotNull(_RespiratoryBreathSounds)) 
					{
					 return _RespiratoryBreathSounds;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RespiratoryBreathSounds = value;}
			}
			public	string  RespiratoryOthers
			{
				get 
				{ 
					if(Null.IsNotNull(_RespiratoryOthers)) 
					{
					 return _RespiratoryOthers;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RespiratoryOthers = value;}
			}
			public	string  HeartRate
			{
				get 
				{ 
					if(Null.IsNotNull(_HeartRate)) 
					{
					 return _HeartRate;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HeartRate = value;}
			}
			public	string  BP
			{
				get 
				{ 
					if(Null.IsNotNull(_BP)) 
					{
					 return _BP;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BP = value;}
			}
			public	string  Auscultation
			{
				get 
				{ 
					if(Null.IsNotNull(_Auscultation)) 
					{
					 return _Auscultation;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Auscultation = value;}
			}
			public	string  AbdomenLiver
			{
				get 
				{ 
					if(Null.IsNotNull(_AbdomenLiver)) 
					{
					 return _AbdomenLiver;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AbdomenLiver = value;}
			}
			public	string  AbdomenSpleen
			{
				get 
				{ 
					if(Null.IsNotNull(_AbdomenSpleen)) 
					{
					 return _AbdomenSpleen;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AbdomenSpleen = value;}
			}
			public	string  AbdomenKidneys
			{
				get 
				{ 
					if(Null.IsNotNull(_AbdomenKidneys)) 
					{
					 return _AbdomenKidneys;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AbdomenKidneys = value;}
			}
			public	string  AbdomenBowelSound
			{
				get 
				{ 
					if(Null.IsNotNull(_AbdomenBowelSound)) 
					{
					 return _AbdomenBowelSound;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AbdomenBowelSound = value;}
			}
			public	string  HernialOrifices
			{
				get 
				{ 
					if(Null.IsNotNull(_HernialOrifices)) 
					{
					 return _HernialOrifices;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HernialOrifices = value;}
			}
			public	string  GenitoUrinary
			{
				get 
				{ 
					if(Null.IsNotNull(_GenitoUrinary)) 
					{
					 return _GenitoUrinary;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GenitoUrinary = value;}
			}
			public	string  ExtremitiesSwelling
			{
				get 
				{ 
					if(Null.IsNotNull(_ExtremitiesSwelling)) 
					{
					 return _ExtremitiesSwelling;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ExtremitiesSwelling = value;}
			}
			public	string  ExtremitiesDeformity
			{
				get 
				{ 
					if(Null.IsNotNull(_ExtremitiesDeformity)) 
					{
					 return _ExtremitiesDeformity;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ExtremitiesDeformity = value;}
			}
			public	string  MusculoSkeletalSkull
			{
				get 
				{ 
					if(Null.IsNotNull(_MusculoSkeletalSkull)) 
					{
					 return _MusculoSkeletalSkull;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MusculoSkeletalSkull = value;}
			}
			public	string  MusculoSpine
			{
				get 
				{ 
					if(Null.IsNotNull(_MusculoSpine)) 
					{
					 return _MusculoSpine;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MusculoSpine = value;}
			}
			public	string  MusculoUpperExtremities
			{
				get 
				{ 
					if(Null.IsNotNull(_MusculoUpperExtremities)) 
					{
					 return _MusculoUpperExtremities;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MusculoUpperExtremities = value;}
			}
			public	string  MusculoLowerExtremities
			{
				get 
				{ 
					if(Null.IsNotNull(_MusculoLowerExtremities)) 
					{
					 return _MusculoLowerExtremities;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MusculoLowerExtremities = value;}
			}
			public	string  SkinAndVaricoseVeins
			{
				get 
				{ 
					if(Null.IsNotNull(_SkinAndVaricoseVeins)) 
					{
					 return _SkinAndVaricoseVeins;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SkinAndVaricoseVeins = value;}
			}
			public	string  NeurologicalAccomondation
			{
				get 
				{ 
					if(Null.IsNotNull(_NeurologicalAccomondation)) 
					{
					 return _NeurologicalAccomondation;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NeurologicalAccomondation = value;}
			}
			public	string  NeurologicalMotor
			{
				get 
				{ 
					if(Null.IsNotNull(_NeurologicalMotor)) 
					{
					 return _NeurologicalMotor;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NeurologicalMotor = value;}
			}
			public	string  NeurologicalSensory
			{
				get 
				{ 
					if(Null.IsNotNull(_NeurologicalSensory)) 
					{
					 return _NeurologicalSensory;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NeurologicalSensory = value;}
			}
			public	string  NeurologicalReflexes
			{
				get 
				{ 
					if(Null.IsNotNull(_NeurologicalReflexes)) 
					{
					 return _NeurologicalReflexes;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NeurologicalReflexes = value;}
			}
			public	string  PsychologicalTest
			{
				get 
				{ 
					if(Null.IsNotNull(_PsychologicalTest)) 
					{
					 return _PsychologicalTest;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PsychologicalTest = value;}
			}
			public	DateTime  CheckupDate
			{
				get 
				{ 
					if(Null.IsNotNull(_CheckupDate)) 
					{
					 return _CheckupDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _CheckupDate = value;}
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