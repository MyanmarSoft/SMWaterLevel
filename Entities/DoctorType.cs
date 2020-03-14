using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class DoctorType 
	{
			
		#region Constructers

			public DoctorType(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _DoctoryTypeName;
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
			public	string  DoctoryTypeName
			{
				get 
				{ 
					if(Null.IsNotNull(_DoctoryTypeName)) 
					{
					 return _DoctoryTypeName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _DoctoryTypeName = value;}
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