using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class XRayReport 
	{
			
		#region Constructers

			public XRayReport(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PatientID;
			private	string _PatientName;
			private	DateTime _DOB;
			private	string _Sex;
			private	string _ImagePath;
			private	DateTime _XRayReportDate;
			private	string _SkeletonAndSoftTissue;
			private	string _CardiacShadow;
			private	string _HilarandLymphaticGlands;
			private	string _HemidiaphragmsAndCostophrenicAngles;
			private	string _LungFields;
			private	string _EvidenceofTB;
			private	string _Evidenceofold;
			private	string _EvidenceSuspicious;
			private	string _ConsultantRadiologist;
			private	string _Remark;
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
			public	DateTime  XRayReportDate
			{
				get 
				{ 
					if(Null.IsNotNull(_XRayReportDate)) 
					{
					 return _XRayReportDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _XRayReportDate = value;}
			}
			public	string  SkeletonAndSoftTissue
			{
				get 
				{ 
					if(Null.IsNotNull(_SkeletonAndSoftTissue)) 
					{
					 return _SkeletonAndSoftTissue;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SkeletonAndSoftTissue = value;}
			}
			public	string  CardiacShadow
			{
				get 
				{ 
					if(Null.IsNotNull(_CardiacShadow)) 
					{
					 return _CardiacShadow;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CardiacShadow = value;}
			}
			public	string  HilarandLymphaticGlands
			{
				get 
				{ 
					if(Null.IsNotNull(_HilarandLymphaticGlands)) 
					{
					 return _HilarandLymphaticGlands;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HilarandLymphaticGlands = value;}
			}
			public	string  HemidiaphragmsAndCostophrenicAngles
			{
				get 
				{ 
					if(Null.IsNotNull(_HemidiaphragmsAndCostophrenicAngles)) 
					{
					 return _HemidiaphragmsAndCostophrenicAngles;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HemidiaphragmsAndCostophrenicAngles = value;}
			}
			public	string  LungFields
			{
				get 
				{ 
					if(Null.IsNotNull(_LungFields)) 
					{
					 return _LungFields;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LungFields = value;}
			}
			public	string  EvidenceofTB
			{
				get 
				{ 
					if(Null.IsNotNull(_EvidenceofTB)) 
					{
					 return _EvidenceofTB;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EvidenceofTB = value;}
			}
			public	string  Evidenceofold
			{
				get 
				{ 
					if(Null.IsNotNull(_Evidenceofold)) 
					{
					 return _Evidenceofold;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Evidenceofold = value;}
			}
			public	string  EvidenceSuspicious
			{
				get 
				{ 
					if(Null.IsNotNull(_EvidenceSuspicious)) 
					{
					 return _EvidenceSuspicious;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _EvidenceSuspicious = value;}
			}
			public	string  ConsultantRadiologist
			{
				get 
				{ 
					if(Null.IsNotNull(_ConsultantRadiologist)) 
					{
					 return _ConsultantRadiologist;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ConsultantRadiologist = value;}
			}
			public	string  Remark
			{
				get 
				{ 
					if(Null.IsNotNull(_Remark)) 
					{
					 return _Remark;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Remark = value;}
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