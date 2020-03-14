using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class ProjectStatus 
	{
			
		#region Constructers

			public ProjectStatus(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ProjectStatusName;
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
			public	string  ProjectStatusName
			{
				get 
				{ 
					if(Null.IsNotNull(_ProjectStatusName)) 
					{
					 return _ProjectStatusName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ProjectStatusName = value;}
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