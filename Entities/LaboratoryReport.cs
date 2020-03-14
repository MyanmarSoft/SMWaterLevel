using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class LaboratoryReport 
	{
			
		#region Constructers

			public LaboratoryReport(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PatientID;
			private	string _PatientName;
			private	DateTime _DOB;
			private	string _Sex;
			private	string _ImagePath;
			private	string _LabNumber;
			private	string _CDCNo;
			private	string _PPNo;
			private	string _HamoglobinResult;
			private	string _HamoglobinReference;
			private	string _TotalWBCResult;
			private	string _TotalWBCReference;
			private	string _NeutrophilsResult;
			private	string _NeutrophilsReference;
			private	string _LymphocytesResult;
			private	string _LymphocytesReference;
			private	string _MonocytesResult;
			private	string _MonocytesReference;
			private	string _EosinophilsResult;
			private	string _EosinophilsReference;
			private	string _BasophilsResult;
			private	string _BasophilsReference;
			private	string _PlateletCountResult;
			private	string _PlateletCountReference;
			private	string _ESRWestergrenResult;
			private	string _ESRWestergrenReference;
			private	string _ABOGroupingResult;
			private	string _ABOGroupingReference;
			private	string _RHGroupingResult;
			private	string _RHGroupingReference;
			private	string _HIVResult;
			private	string _HIVReference;
			private	string _HBsAgResult;
			private	string _HBsAgReference;
			private	string _HCVAbResult;
			private	string _HCVAbReference;
			private	string _VDRLResult;
			private	string _VDRLReference;
			private	string _Blank1Test;
			private	string _Blank1Result;
			private	string _Blank1Reference;
			private	string _GlucoseRandomResult;
			private	string _GlucoseRandomReference;
			private	string _TotalCholesterolResult;
			private	string _TotalCholesterolReference;
			private	string _Blank2Test;
			private	string _Blank2Result;
			private	string _Blank2Reference;
			private	string _Blank3Test;
			private	string _Blank3Result;
			private	string _Blank3Reference;
			private	string _Blank4Test;
			private	string _Blank4Result;
			private	string _Blank4Reference;
			private	string _UricAcidResult;
			private	string _UricAcidReference;
			private	string _SGOTResult;
			private	string _SGOTReference;
			private	string _SGPTResult;
			private	string _SGPTReference;
			private	string _Blank5Test;
			private	string _Blank5Result;
			private	string _Blank5Reference;
			private	string _ColorResult;
			private	string _ColorReference;
			private	string _ReactionResult;
			private	string _ReactionReference;
			private	string _ProteinResult;
			private	string _ProteinReference;
			private	string _SugarResult;
			private	string _SugarReference;
			private	string _SpecificGravityResult;
			private	string _SpecificGravityReference;
			private	string _EpithelialcellsResult;
			private	string _EpithelialcellsReference;
			private	string _PuscellsResult;
			private	string _PuscellsReference;
			private	string _RBCResult;
			private	string _RBCReference;
			private	string _CastsandCrystalsResult;
			private	string _CastsandCrystalsReference;
			private	string _OthersResult;
			private	string _OthersReference;
			private	string _RBCsResult;
			private	string _WBCsResult;
			private	string _PlateletsResult;
			private	string _RemarksResult;
			private	string _Comments;
			private	string _MedicalTechnologist;
			private	string _Pathologist;
			private	DateTime _LaboratoryReportDate;
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
			public	string  LabNumber
			{
				get 
				{ 
					if(Null.IsNotNull(_LabNumber)) 
					{
					 return _LabNumber;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LabNumber = value;}
			}
			public	string  CDCNo
			{
				get 
				{ 
					if(Null.IsNotNull(_CDCNo)) 
					{
					 return _CDCNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CDCNo = value;}
			}
			public	string  PPNo
			{
				get 
				{ 
					if(Null.IsNotNull(_PPNo)) 
					{
					 return _PPNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PPNo = value;}
			}
			public	string  HamoglobinResult
			{
				get 
				{ 
					if(Null.IsNotNull(_HamoglobinResult)) 
					{
					 return _HamoglobinResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HamoglobinResult = value;}
			}
			public	string  HamoglobinReference
			{
				get 
				{ 
					if(Null.IsNotNull(_HamoglobinReference)) 
					{
					 return _HamoglobinReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HamoglobinReference = value;}
			}
			public	string  TotalWBCResult
			{
				get 
				{ 
					if(Null.IsNotNull(_TotalWBCResult)) 
					{
					 return _TotalWBCResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TotalWBCResult = value;}
			}
			public	string  TotalWBCReference
			{
				get 
				{ 
					if(Null.IsNotNull(_TotalWBCReference)) 
					{
					 return _TotalWBCReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TotalWBCReference = value;}
			}
			public	string  NeutrophilsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_NeutrophilsResult)) 
					{
					 return _NeutrophilsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NeutrophilsResult = value;}
			}
			public	string  NeutrophilsReference
			{
				get 
				{ 
					if(Null.IsNotNull(_NeutrophilsReference)) 
					{
					 return _NeutrophilsReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _NeutrophilsReference = value;}
			}
			public	string  LymphocytesResult
			{
				get 
				{ 
					if(Null.IsNotNull(_LymphocytesResult)) 
					{
					 return _LymphocytesResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LymphocytesResult = value;}
			}
			public	string  LymphocytesReference
			{
				get 
				{ 
					if(Null.IsNotNull(_LymphocytesReference)) 
					{
					 return _LymphocytesReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LymphocytesReference = value;}
			}
			public	string  MonocytesResult
			{
				get 
				{ 
					if(Null.IsNotNull(_MonocytesResult)) 
					{
					 return _MonocytesResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MonocytesResult = value;}
			}
			public	string  MonocytesReference
			{
				get 
				{ 
					if(Null.IsNotNull(_MonocytesReference)) 
					{
					 return _MonocytesReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MonocytesReference = value;}
			}
			public	string  EosinophilsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_EosinophilsResult)) 
					{
					 return _EosinophilsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EosinophilsResult = value;}
			}
			public	string  EosinophilsReference
			{
				get 
				{ 
					if(Null.IsNotNull(_EosinophilsReference)) 
					{
					 return _EosinophilsReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EosinophilsReference = value;}
			}
			public	string  BasophilsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_BasophilsResult)) 
					{
					 return _BasophilsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BasophilsResult = value;}
			}
			public	string  BasophilsReference
			{
				get 
				{ 
					if(Null.IsNotNull(_BasophilsReference)) 
					{
					 return _BasophilsReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _BasophilsReference = value;}
			}
			public	string  PlateletCountResult
			{
				get 
				{ 
					if(Null.IsNotNull(_PlateletCountResult)) 
					{
					 return _PlateletCountResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PlateletCountResult = value;}
			}
			public	string  PlateletCountReference
			{
				get 
				{ 
					if(Null.IsNotNull(_PlateletCountReference)) 
					{
					 return _PlateletCountReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PlateletCountReference = value;}
			}
			public	string  ESRWestergrenResult
			{
				get 
				{ 
					if(Null.IsNotNull(_ESRWestergrenResult)) 
					{
					 return _ESRWestergrenResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ESRWestergrenResult = value;}
			}
			public	string  ESRWestergrenReference
			{
				get 
				{ 
					if(Null.IsNotNull(_ESRWestergrenReference)) 
					{
					 return _ESRWestergrenReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ESRWestergrenReference = value;}
			}
			public	string  ABOGroupingResult
			{
				get 
				{ 
					if(Null.IsNotNull(_ABOGroupingResult)) 
					{
					 return _ABOGroupingResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ABOGroupingResult = value;}
			}
			public	string  ABOGroupingReference
			{
				get 
				{ 
					if(Null.IsNotNull(_ABOGroupingReference)) 
					{
					 return _ABOGroupingReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ABOGroupingReference = value;}
			}
			public	string  RHGroupingResult
			{
				get 
				{ 
					if(Null.IsNotNull(_RHGroupingResult)) 
					{
					 return _RHGroupingResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RHGroupingResult = value;}
			}
			public	string  RHGroupingReference
			{
				get 
				{ 
					if(Null.IsNotNull(_RHGroupingReference)) 
					{
					 return _RHGroupingReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RHGroupingReference = value;}
			}
			public	string  HIVResult
			{
				get 
				{ 
					if(Null.IsNotNull(_HIVResult)) 
					{
					 return _HIVResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HIVResult = value;}
			}
			public	string  HIVReference
			{
				get 
				{ 
					if(Null.IsNotNull(_HIVReference)) 
					{
					 return _HIVReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HIVReference = value;}
			}
			public	string  HBsAgResult
			{
				get 
				{ 
					if(Null.IsNotNull(_HBsAgResult)) 
					{
					 return _HBsAgResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HBsAgResult = value;}
			}
			public	string  HBsAgReference
			{
				get 
				{ 
					if(Null.IsNotNull(_HBsAgReference)) 
					{
					 return _HBsAgReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HBsAgReference = value;}
			}
			public	string  HCVAbResult
			{
				get 
				{ 
					if(Null.IsNotNull(_HCVAbResult)) 
					{
					 return _HCVAbResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HCVAbResult = value;}
			}
			public	string  HCVAbReference
			{
				get 
				{ 
					if(Null.IsNotNull(_HCVAbReference)) 
					{
					 return _HCVAbReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HCVAbReference = value;}
			}
			public	string  VDRLResult
			{
				get 
				{ 
					if(Null.IsNotNull(_VDRLResult)) 
					{
					 return _VDRLResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _VDRLResult = value;}
			}
			public	string  VDRLReference
			{
				get 
				{ 
					if(Null.IsNotNull(_VDRLReference)) 
					{
					 return _VDRLReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _VDRLReference = value;}
			}
			public	string  Blank1Test
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank1Test)) 
					{
					 return _Blank1Test;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank1Test = value;}
			}
			public	string  Blank1Result
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank1Result)) 
					{
					 return _Blank1Result;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank1Result = value;}
			}
			public	string  Blank1Reference
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank1Reference)) 
					{
					 return _Blank1Reference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank1Reference = value;}
			}
			public	string  GlucoseRandomResult
			{
				get 
				{ 
					if(Null.IsNotNull(_GlucoseRandomResult)) 
					{
					 return _GlucoseRandomResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GlucoseRandomResult = value;}
			}
			public	string  GlucoseRandomReference
			{
				get 
				{ 
					if(Null.IsNotNull(_GlucoseRandomReference)) 
					{
					 return _GlucoseRandomReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GlucoseRandomReference = value;}
			}
			public	string  TotalCholesterolResult
			{
				get 
				{ 
					if(Null.IsNotNull(_TotalCholesterolResult)) 
					{
					 return _TotalCholesterolResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TotalCholesterolResult = value;}
			}
			public	string  TotalCholesterolReference
			{
				get 
				{ 
					if(Null.IsNotNull(_TotalCholesterolReference)) 
					{
					 return _TotalCholesterolReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TotalCholesterolReference = value;}
			}
			public	string  Blank2Test
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank2Test)) 
					{
					 return _Blank2Test;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank2Test = value;}
			}
			public	string  Blank2Result
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank2Result)) 
					{
					 return _Blank2Result;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank2Result = value;}
			}
			public	string  Blank2Reference
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank2Reference)) 
					{
					 return _Blank2Reference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank2Reference = value;}
			}
			public	string  Blank3Test
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank3Test)) 
					{
					 return _Blank3Test;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank3Test = value;}
			}
			public	string  Blank3Result
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank3Result)) 
					{
					 return _Blank3Result;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank3Result = value;}
			}
			public	string  Blank3Reference
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank3Reference)) 
					{
					 return _Blank3Reference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank3Reference = value;}
			}
			public	string  Blank4Test
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank4Test)) 
					{
					 return _Blank4Test;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank4Test = value;}
			}
			public	string  Blank4Result
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank4Result)) 
					{
					 return _Blank4Result;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank4Result = value;}
			}
			public	string  Blank4Reference
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank4Reference)) 
					{
					 return _Blank4Reference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank4Reference = value;}
			}
			public	string  UricAcidResult
			{
				get 
				{ 
					if(Null.IsNotNull(_UricAcidResult)) 
					{
					 return _UricAcidResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _UricAcidResult = value;}
			}
			public	string  UricAcidReference
			{
				get 
				{ 
					if(Null.IsNotNull(_UricAcidReference)) 
					{
					 return _UricAcidReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _UricAcidReference = value;}
			}
			public	string  SGOTResult
			{
				get 
				{ 
					if(Null.IsNotNull(_SGOTResult)) 
					{
					 return _SGOTResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SGOTResult = value;}
			}
			public	string  SGOTReference
			{
				get 
				{ 
					if(Null.IsNotNull(_SGOTReference)) 
					{
					 return _SGOTReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SGOTReference = value;}
			}
			public	string  SGPTResult
			{
				get 
				{ 
					if(Null.IsNotNull(_SGPTResult)) 
					{
					 return _SGPTResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SGPTResult = value;}
			}
			public	string  SGPTReference
			{
				get 
				{ 
					if(Null.IsNotNull(_SGPTReference)) 
					{
					 return _SGPTReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SGPTReference = value;}
			}
			public	string  Blank5Test
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank5Test)) 
					{
					 return _Blank5Test;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank5Test = value;}
			}
			public	string  Blank5Result
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank5Result)) 
					{
					 return _Blank5Result;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank5Result = value;}
			}
			public	string  Blank5Reference
			{
				get 
				{ 
					if(Null.IsNotNull(_Blank5Reference)) 
					{
					 return _Blank5Reference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Blank5Reference = value;}
			}
			public	string  ColorResult
			{
				get 
				{ 
					if(Null.IsNotNull(_ColorResult)) 
					{
					 return _ColorResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ColorResult = value;}
			}
			public	string  ColorReference
			{
				get 
				{ 
					if(Null.IsNotNull(_ColorReference)) 
					{
					 return _ColorReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ColorReference = value;}
			}
			public	string  ReactionResult
			{
				get 
				{ 
					if(Null.IsNotNull(_ReactionResult)) 
					{
					 return _ReactionResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ReactionResult = value;}
			}
			public	string  ReactionReference
			{
				get 
				{ 
					if(Null.IsNotNull(_ReactionReference)) 
					{
					 return _ReactionReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ReactionReference = value;}
			}
			public	string  ProteinResult
			{
				get 
				{ 
					if(Null.IsNotNull(_ProteinResult)) 
					{
					 return _ProteinResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ProteinResult = value;}
			}
			public	string  ProteinReference
			{
				get 
				{ 
					if(Null.IsNotNull(_ProteinReference)) 
					{
					 return _ProteinReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ProteinReference = value;}
			}
			public	string  SugarResult
			{
				get 
				{ 
					if(Null.IsNotNull(_SugarResult)) 
					{
					 return _SugarResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SugarResult = value;}
			}
			public	string  SugarReference
			{
				get 
				{ 
					if(Null.IsNotNull(_SugarReference)) 
					{
					 return _SugarReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SugarReference = value;}
			}
			public	string  SpecificGravityResult
			{
				get 
				{ 
					if(Null.IsNotNull(_SpecificGravityResult)) 
					{
					 return _SpecificGravityResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SpecificGravityResult = value;}
			}
			public	string  SpecificGravityReference
			{
				get 
				{ 
					if(Null.IsNotNull(_SpecificGravityReference)) 
					{
					 return _SpecificGravityReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SpecificGravityReference = value;}
			}
			public	string  EpithelialcellsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_EpithelialcellsResult)) 
					{
					 return _EpithelialcellsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EpithelialcellsResult = value;}
			}
			public	string  EpithelialcellsReference
			{
				get 
				{ 
					if(Null.IsNotNull(_EpithelialcellsReference)) 
					{
					 return _EpithelialcellsReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EpithelialcellsReference = value;}
			}
			public	string  PuscellsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_PuscellsResult)) 
					{
					 return _PuscellsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PuscellsResult = value;}
			}
			public	string  PuscellsReference
			{
				get 
				{ 
					if(Null.IsNotNull(_PuscellsReference)) 
					{
					 return _PuscellsReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PuscellsReference = value;}
			}
			public	string  RBCResult
			{
				get 
				{ 
					if(Null.IsNotNull(_RBCResult)) 
					{
					 return _RBCResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RBCResult = value;}
			}
			public	string  RBCReference
			{
				get 
				{ 
					if(Null.IsNotNull(_RBCReference)) 
					{
					 return _RBCReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RBCReference = value;}
			}
			public	string  CastsandCrystalsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_CastsandCrystalsResult)) 
					{
					 return _CastsandCrystalsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CastsandCrystalsResult = value;}
			}
			public	string  CastsandCrystalsReference
			{
				get 
				{ 
					if(Null.IsNotNull(_CastsandCrystalsReference)) 
					{
					 return _CastsandCrystalsReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CastsandCrystalsReference = value;}
			}
			public	string  OthersResult
			{
				get 
				{ 
					if(Null.IsNotNull(_OthersResult)) 
					{
					 return _OthersResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _OthersResult = value;}
			}
			public	string  OthersReference
			{
				get 
				{ 
					if(Null.IsNotNull(_OthersReference)) 
					{
					 return _OthersReference;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _OthersReference = value;}
			}
			public	string  RBCsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_RBCsResult)) 
					{
					 return _RBCsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RBCsResult = value;}
			}
			public	string  WBCsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_WBCsResult)) 
					{
					 return _WBCsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _WBCsResult = value;}
			}
			public	string  PlateletsResult
			{
				get 
				{ 
					if(Null.IsNotNull(_PlateletsResult)) 
					{
					 return _PlateletsResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PlateletsResult = value;}
			}
			public	string  RemarksResult
			{
				get 
				{ 
					if(Null.IsNotNull(_RemarksResult)) 
					{
					 return _RemarksResult;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RemarksResult = value;}
			}
			public	string  Comments
			{
				get 
				{ 
					if(Null.IsNotNull(_Comments)) 
					{
					 return _Comments;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Comments = value;}
			}
			public	string  MedicalTechnologist
			{
				get 
				{ 
					if(Null.IsNotNull(_MedicalTechnologist)) 
					{
					 return _MedicalTechnologist;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MedicalTechnologist = value;}
			}
			public	string  Pathologist
			{
				get 
				{ 
					if(Null.IsNotNull(_Pathologist)) 
					{
					 return _Pathologist;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Pathologist = value;}
			}
			public	DateTime  LaboratoryReportDate
			{
				get 
				{ 
					if(Null.IsNotNull(_LaboratoryReportDate)) 
					{
					 return _LaboratoryReportDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _LaboratoryReportDate = value;}
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