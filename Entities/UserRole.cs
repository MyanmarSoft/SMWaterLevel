using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class UserRole 
	{
			
		#region Constructers

			public UserRole(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _RoleName;
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
			public	string  RoleName
			{
				get 
				{ 
					if(Null.IsNotNull(_RoleName)) 
					{
					 return _RoleName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RoleName = value;}
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