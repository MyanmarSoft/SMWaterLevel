using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Doctor 
	{
			
		#region Constructers

			public Doctor(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _DoctorName;
			private	string _Speciality;
			private	string _Sex;
			private	int _DoctorTypeID;
			private	string _DoctorType;
			private	string _ContactNo;
			private	string _Email;
			private	string _Address;
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
			public	string  DoctorName
			{
				get 
				{ 
					if(Null.IsNotNull(_DoctorName)) 
					{
					 return _DoctorName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _DoctorName = value;}
			}
			public	string  Speciality
			{
				get 
				{ 
					if(Null.IsNotNull(_Speciality)) 
					{
					 return _Speciality;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Speciality = value;}
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
			public	int  DoctorTypeID
			{
				get 
				{ 
					if(Null.IsNotNull(_DoctorTypeID)) 
					{
					 return _DoctorTypeID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _DoctorTypeID = value;}
			}
			public	string  DoctorType
			{
				get 
				{ 
					if(Null.IsNotNull(_DoctorType)) 
					{
					 return _DoctorType;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _DoctorType = value;}
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