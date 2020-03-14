using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Department 
	{
			
		#region Constructers

			public Department(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _DepartmentName;
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
			public	string  DepartmentName
			{
				get 
				{ 
					if(Null.IsNotNull(_DepartmentName)) 
					{
					 return _DepartmentName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _DepartmentName = value;}
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