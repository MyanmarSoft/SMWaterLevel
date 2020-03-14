using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Region 
	{
			
		#region Constructers

			public Region(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _RegionName;
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
			public	string  RegionName
			{
				get 
				{ 
					if(Null.IsNotNull(_RegionName)) 
					{
					 return _RegionName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RegionName = value;}
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