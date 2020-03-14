using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class UltrasoundReport 
	{
			
		#region Constructers

			public UltrasoundReport(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PatientID;
			private	string _PatientName;
			private	DateTime _DOB;
			private	string _Sex;
			private	string _ImagePath;
			private	string _LiverSize;
			private	string _LiverMargin;
			private	string _LiverSOL;
			private	string _LiverEchogenicity;
			private	string _LiverCaudatelobe;
			private	string _GallBLadderWallThickness;
			private	string _GallBLadderContent;
			private	string _HepaticDucts;
			private	string _CBD;
			private	string _Pancreas;
			private	string _Spleen;
			private	string _RightKidney;
			private	string _LeftKidney;
			private	string _Bladder;
			private	string _Uterus;
			private	string _Ovary;
			private	string _Others;
			private	string _Impression;
			private	DateTime _UltrasoundReportDate;
			private	string _ConsultantRadiologist;
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
			public	string  LiverSize
			{
				get 
				{ 
					if(Null.IsNotNull(_LiverSize)) 
					{
					 return _LiverSize;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LiverSize = value;}
			}
			public	string  LiverMargin
			{
				get 
				{ 
					if(Null.IsNotNull(_LiverMargin)) 
					{
					 return _LiverMargin;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LiverMargin = value;}
			}
			public	string  LiverSOL
			{
				get 
				{ 
					if(Null.IsNotNull(_LiverSOL)) 
					{
					 return _LiverSOL;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LiverSOL = value;}
			}
			public	string  LiverEchogenicity
			{
				get 
				{ 
					if(Null.IsNotNull(_LiverEchogenicity)) 
					{
					 return _LiverEchogenicity;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LiverEchogenicity = value;}
			}
			public	string  LiverCaudatelobe
			{
				get 
				{ 
					if(Null.IsNotNull(_LiverCaudatelobe)) 
					{
					 return _LiverCaudatelobe;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LiverCaudatelobe = value;}
			}
			public	string  GallBLadderWallThickness
			{
				get 
				{ 
					if(Null.IsNotNull(_GallBLadderWallThickness)) 
					{
					 return _GallBLadderWallThickness;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GallBLadderWallThickness = value;}
			}
			public	string  GallBLadderContent
			{
				get 
				{ 
					if(Null.IsNotNull(_GallBLadderContent)) 
					{
					 return _GallBLadderContent;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GallBLadderContent = value;}
			}
			public	string  HepaticDucts
			{
				get 
				{ 
					if(Null.IsNotNull(_HepaticDucts)) 
					{
					 return _HepaticDucts;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _HepaticDucts = value;}
			}
			public	string  CBD
			{
				get 
				{ 
					if(Null.IsNotNull(_CBD)) 
					{
					 return _CBD;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CBD = value;}
			}
			public	string  Pancreas
			{
				get 
				{ 
					if(Null.IsNotNull(_Pancreas)) 
					{
					 return _Pancreas;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Pancreas = value;}
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
			public	string  RightKidney
			{
				get 
				{ 
					if(Null.IsNotNull(_RightKidney)) 
					{
					 return _RightKidney;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RightKidney = value;}
			}
			public	string  LeftKidney
			{
				get 
				{ 
					if(Null.IsNotNull(_LeftKidney)) 
					{
					 return _LeftKidney;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LeftKidney = value;}
			}
			public	string  Bladder
			{
				get 
				{ 
					if(Null.IsNotNull(_Bladder)) 
					{
					 return _Bladder;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Bladder = value;}
			}
			public	string  Uterus
			{
				get 
				{ 
					if(Null.IsNotNull(_Uterus)) 
					{
					 return _Uterus;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Uterus = value;}
			}
			public	string  Ovary
			{
				get 
				{ 
					if(Null.IsNotNull(_Ovary)) 
					{
					 return _Ovary;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Ovary = value;}
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
			public	string  Impression
			{
				get 
				{ 
					if(Null.IsNotNull(_Impression)) 
					{
					 return _Impression;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Impression = value;}
			}
			public	DateTime  UltrasoundReportDate
			{
				get 
				{ 
					if(Null.IsNotNull(_UltrasoundReportDate)) 
					{
					 return _UltrasoundReportDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _UltrasoundReportDate = value;}
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