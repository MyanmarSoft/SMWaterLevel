using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class UserProfile 
	{
			
		#region Constructers

			public UserProfile(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _Name;
			private	string _Username;
			private	string _Password;
			private	int _UserRoleID;
			private	int _DepartmentID;
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
			public	string  Username
			{
				get 
				{ 
					if(Null.IsNotNull(_Username)) 
					{
					 return _Username;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Username = value;}
			}
			public	string  Password
			{
				get 
				{ 
					if(Null.IsNotNull(_Password)) 
					{
					 return _Password;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Password = value;}
			}
			public	int  UserRoleID
			{
				get 
				{ 
					if(Null.IsNotNull(_UserRoleID)) 
					{
					 return _UserRoleID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _UserRoleID = value;}
			}
			public	int  DepartmentID
			{
				get 
				{ 
					if(Null.IsNotNull(_DepartmentID)) 
					{
					 return _DepartmentID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _DepartmentID = value;}
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