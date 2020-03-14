using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Patient 
	{
			
		#region Constructers

			public Patient(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PatientID;
			private	string _Name;
			private	string _Sex;
			private	DateTime _DOB;
			private	int _Age;
			private	string _MaritalStatus;
			private	string _Occupation;
			private	string _Nationality;
			private	int _RegionID;
			private	string _Region;
			private	int _TownshipID;
			private	string _Township;
			private	string _Address;
			private	string _ContactNo;
			private	int _CompanyID;
			private	string _CompanyName;
			private	string _CompanyAddress;
			private	string _CompanyContactNo;
			private	string _Email;
			private	string _PassportNo;
			private	string _NRCNo;
			private	string _CDCNo;
			private	string _ImagePath;
			private	DateTime _VisitDate;
			private	decimal _OpeningBalance;
			private	decimal _ClosingBalance;
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
			public	int  Age
			{
				get 
				{ 
					if(Null.IsNotNull(_Age)) 
					{
					 return _Age;
					}
					else 
					{
					 return 0;
					}
				}
				set { _Age = value;}
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
			public	string  Occupation
			{
				get 
				{ 
					if(Null.IsNotNull(_Occupation)) 
					{
					 return _Occupation;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Occupation = value;}
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
			public	int  RegionID
			{
				get 
				{ 
					if(Null.IsNotNull(_RegionID)) 
					{
					 return _RegionID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _RegionID = value;}
			}
			public	string  Region
			{
				get 
				{ 
					if(Null.IsNotNull(_Region)) 
					{
					 return _Region;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Region = value;}
			}
			public	int  TownshipID
			{
				get 
				{ 
					if(Null.IsNotNull(_TownshipID)) 
					{
					 return _TownshipID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _TownshipID = value;}
			}
			public	string  Township
			{
				get 
				{ 
					if(Null.IsNotNull(_Township)) 
					{
					 return _Township;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Township = value;}
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
			public	int  CompanyID
			{
				get 
				{ 
					if(Null.IsNotNull(_CompanyID)) 
					{
					 return _CompanyID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _CompanyID = value;}
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
			public	string  CompanyAddress
			{
				get 
				{ 
					if(Null.IsNotNull(_CompanyAddress)) 
					{
					 return _CompanyAddress;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CompanyAddress = value;}
			}
			public	string  CompanyContactNo
			{
				get 
				{ 
					if(Null.IsNotNull(_CompanyContactNo)) 
					{
					 return _CompanyContactNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CompanyContactNo = value;}
			}
			public	string  Email
			{
				get 
				{ 
					if(Null.IsNotNull(_Email)) 
					{
					 return _Email;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Email = value;}
			}
			public	string  PassportNo
			{
				get 
				{ 
					if(Null.IsNotNull(_PassportNo)) 
					{
					 return _PassportNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PassportNo = value;}
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
			public	DateTime  VisitDate
			{
				get 
				{ 
					if(Null.IsNotNull(_VisitDate)) 
					{
					 return _VisitDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _VisitDate = value;}
			}
			public	decimal  OpeningBalance
			{
				get 
				{ 
					if(Null.IsNotNull(_OpeningBalance)) 
					{
					 return _OpeningBalance;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _OpeningBalance = value;}
			}
			public	decimal  ClosingBalance
			{
				get 
				{ 
					if(Null.IsNotNull(_ClosingBalance)) 
					{
					 return _ClosingBalance;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _ClosingBalance = value;}
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