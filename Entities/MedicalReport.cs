using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class MedicalReport 
	{
			
		#region Constructers

			public MedicalReport(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PatientID;
			private	string _PatientName;
			private	string _ImagePath;
			private	string _Height;
			private	string _Weight;
			private	string _BMI;
			private	string _Skin;
			private	string _Scalp;
			private	string _Deformity;
			private	string _FVUncorrectedLeft;
			private	string _FVUncorrectedRight;
			private	string _FVCorrectedLeft;
			private	string _FVCorrectedRight;
			private	string _NVUncorrectedLeft;
			private	string _NVUncorrectedRight;
			private	string _NVCorrectedLeft;
			private	string _NVCorrectedRight;
			private	string _ColourVision;
			private	string _EyeAndPupilsEqual;
			private	string _EyeAndPupilsRegular;
			private	string _FudusExamination;
			private	string _EarDrums;
			private	string _EarHearingLeft;
			private	string _EarHearingRight;
			private	string _EarNose;
			private	string _EarNeckgland;
			private	string _EarTonsils;
			private	string _EarThyroid;
			private	string _TeethAndMouth;
			private	string _TeethUpper;
			private	string _TeethLower;
			private	string _RespRate;
			private	string _BreathSounds;
			private	string _Others;
			private	string _Heartrate;
			private	string _BP;
			private	string _Auscultation;
			private	string _Liver;
			private	string _Spleen;
			private	string _Kidneys;
			private	string _BowelSound;
			private	string _HernialOrifices;
			private	string _GenitoUrinary;
			private	string _ExtremitiesSwelling;
			private	string _ExtremitiesDeformity;
			private	string _Skull;
			private	string _Spine;
			private	string _UpperExtremities;
			private	string _LowerExtremities;
			private	string _SkinAndVariousVeins;
			private	string _Neurological;
			private	string _Motor;
			private	string _Sensory;
			private	string _Reflexes;
			private	string _MentalState;
			private	string _MedicalReportName;
			private	DateTime _MedicalReportDate;
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
			public	string  PatientName
			{
				get 
				{ 
					if(Null.IsNotNull(_PatientName)) 
					{
					 return _PatientName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PatientName = value;}
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
			public	string  FVUncorrectedLeft
			{
				get 
				{ 
					if(Null.IsNotNull(_FVUncorrectedLeft)) 
					{
					 return _FVUncorrectedLeft;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FVUncorrectedLeft = value;}
			}
			public	string  FVUncorrectedRight
			{
				get 
				{ 
					if(Null.IsNotNull(_FVUncorrectedRight)) 
					{
					 return _FVUncorrectedRight;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FVUncorrectedRight = value;}
			}
			public	string  FVCorrectedLeft
			{
				get 
				{ 
					if(Null.IsNotNull(_FVCorrectedLeft)) 
					{
					 return _FVCorrectedLeft;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FVCorrectedLeft = value;}
			}
			public	string  FVCorrectedRight
			{
				get 
				{ 
					if(Null.IsNotNull(_FVCorrectedRight)) 
					{
					 return _FVCorrectedRight;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FVCorrectedRight = value;}
			}
			public	string  NVUncorrectedLeft
			{
				get 
				{ 
					if(Null.IsNotNull(_NVUncorrectedLeft)) 
					{
					 return _NVUncorrectedLeft;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NVUncorrectedLeft = value;}
			}
			public	string  NVUncorrectedRight
			{
				get 
				{ 
					if(Null.IsNotNull(_NVUncorrectedRight)) 
					{
					 return _NVUncorrectedRight;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NVUncorrectedRight = value;}
			}
			public	string  NVCorrectedLeft
			{
				get 
				{ 
					if(Null.IsNotNull(_NVCorrectedLeft)) 
					{
					 return _NVCorrectedLeft;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NVCorrectedLeft = value;}
			}
			public	string  NVCorrectedRight
			{
				get 
				{ 
					if(Null.IsNotNull(_NVCorrectedRight)) 
					{
					 return _NVCorrectedRight;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NVCorrectedRight = value;}
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
			public	string  EyeAndPupilsEqual
			{
				get 
				{ 
					if(Null.IsNotNull(_EyeAndPupilsEqual)) 
					{
					 return _EyeAndPupilsEqual;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EyeAndPupilsEqual = value;}
			}
			public	string  EyeAndPupilsRegular
			{
				get 
				{ 
					if(Null.IsNotNull(_EyeAndPupilsRegular)) 
					{
					 return _EyeAndPupilsRegular;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EyeAndPupilsRegular = value;}
			}
			public	string  FudusExamination
			{
				get 
				{ 
					if(Null.IsNotNull(_FudusExamination)) 
					{
					 return _FudusExamination;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FudusExamination = value;}
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
			public	string  EarHearingLeft
			{
				get 
				{ 
					if(Null.IsNotNull(_EarHearingLeft)) 
					{
					 return _EarHearingLeft;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarHearingLeft = value;}
			}
			public	string  EarHearingRight
			{
				get 
				{ 
					if(Null.IsNotNull(_EarHearingRight)) 
					{
					 return _EarHearingRight;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarHearingRight = value;}
			}
			public	string  EarNose
			{
				get 
				{ 
					if(Null.IsNotNull(_EarNose)) 
					{
					 return _EarNose;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarNose = value;}
			}
			public	string  EarNeckgland
			{
				get 
				{ 
					if(Null.IsNotNull(_EarNeckgland)) 
					{
					 return _EarNeckgland;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarNeckgland = value;}
			}
			public	string  EarTonsils
			{
				get 
				{ 
					if(Null.IsNotNull(_EarTonsils)) 
					{
					 return _EarTonsils;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarTonsils = value;}
			}
			public	string  EarThyroid
			{
				get 
				{ 
					if(Null.IsNotNull(_EarThyroid)) 
					{
					 return _EarThyroid;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EarThyroid = value;}
			}
			public	string  TeethAndMouth
			{
				get 
				{ 
					if(Null.IsNotNull(_TeethAndMouth)) 
					{
					 return _TeethAndMouth;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TeethAndMouth = value;}
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
			public	string  TeethLower
			{
				get 
				{ 
					if(Null.IsNotNull(_TeethLower)) 
					{
					 return _TeethLower;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TeethLower = value;}
			}
			public	string  RespRate
			{
				get 
				{ 
					if(Null.IsNotNull(_RespRate)) 
					{
					 return _RespRate;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RespRate = value;}
			}
			public	string  BreathSounds
			{
				get 
				{ 
					if(Null.IsNotNull(_BreathSounds)) 
					{
					 return _BreathSounds;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BreathSounds = value;}
			}
			public	string  Others
			{
				get 
				{ 
					if(Null.IsNotNull(_Others)) 
					{
					 return _Others;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Others = value;}
			}
			public	string  Heartrate
			{
				get 
				{ 
					if(Null.IsNotNull(_Heartrate)) 
					{
					 return _Heartrate;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Heartrate = value;}
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
			public	string  Liver
			{
				get 
				{ 
					if(Null.IsNotNull(_Liver)) 
					{
					 return _Liver;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Liver = value;}
			}
			public	string  Spleen
			{
				get 
				{ 
					if(Null.IsNotNull(_Spleen)) 
					{
					 return _Spleen;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Spleen = value;}
			}
			public	string  Kidneys
			{
				get 
				{ 
					if(Null.IsNotNull(_Kidneys)) 
					{
					 return _Kidneys;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Kidneys = value;}
			}
			public	string  BowelSound
			{
				get 
				{ 
					if(Null.IsNotNull(_BowelSound)) 
					{
					 return _BowelSound;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BowelSound = value;}
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
			public	string  Skull
			{
				get 
				{ 
					if(Null.IsNotNull(_Skull)) 
					{
					 return _Skull;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Skull = value;}
			}
			public	string  Spine
			{
				get 
				{ 
					if(Null.IsNotNull(_Spine)) 
					{
					 return _Spine;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Spine = value;}
			}
			public	string  UpperExtremities
			{
				get 
				{ 
					if(Null.IsNotNull(_UpperExtremities)) 
					{
					 return _UpperExtremities;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _UpperExtremities = value;}
			}
			public	string  LowerExtremities
			{
				get 
				{ 
					if(Null.IsNotNull(_LowerExtremities)) 
					{
					 return _LowerExtremities;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LowerExtremities = value;}
			}
			public	string  SkinAndVariousVeins
			{
				get 
				{ 
					if(Null.IsNotNull(_SkinAndVariousVeins)) 
					{
					 return _SkinAndVariousVeins;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SkinAndVariousVeins = value;}
			}
			public	string  Neurological
			{
				get 
				{ 
					if(Null.IsNotNull(_Neurological)) 
					{
					 return _Neurological;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Neurological = value;}
			}
			public	string  Motor
			{
				get 
				{ 
					if(Null.IsNotNull(_Motor)) 
					{
					 return _Motor;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Motor = value;}
			}
			public	string  Sensory
			{
				get 
				{ 
					if(Null.IsNotNull(_Sensory)) 
					{
					 return _Sensory;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Sensory = value;}
			}
			public	string  Reflexes
			{
				get 
				{ 
					if(Null.IsNotNull(_Reflexes)) 
					{
					 return _Reflexes;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Reflexes = value;}
			}
			public	string  MentalState
			{
				get 
				{ 
					if(Null.IsNotNull(_MentalState)) 
					{
					 return _MentalState;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MentalState = value;}
			}
			public	string  MedicalReportName
			{
				get 
				{ 
					if(Null.IsNotNull(_MedicalReportName)) 
					{
					 return _MedicalReportName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MedicalReportName = value;}
			}
			public	DateTime  MedicalReportDate
			{
				get 
				{ 
					if(Null.IsNotNull(_MedicalReportDate)) 
					{
					 return _MedicalReportDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _MedicalReportDate = value;}
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