using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class SubXRayReport 
	{
			
		#region Constructers

			public SubXRayReport(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PatientID;
			private	string _PatientName;
			private	DateTime _DOB;
			private	string _Sex;
			private	string _ImagePath;
			private	DateTime _SubXRayReportDate;
			private	string _Report;
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
            public DateTime SubXRayReportDate
			{
				get 
				{
                    if (Null.IsNotNull(_SubXRayReportDate)) 
					{
                        return _SubXRayReportDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
                set { _SubXRayReportDate = value; }
			}
			public	string  Report
			{
				get 
				{ 
					if(Null.IsNotNull(_Report)) 
					{
					 return _Report;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Report = value;}
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