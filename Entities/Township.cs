using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Township 
	{
			
		#region Constructers

			public Township(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _TownshipName;
			private	int _RegionID;
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
			public	string  TownshipName
			{
				get 
				{ 
					if(Null.IsNotNull(_TownshipName)) 
					{
					 return _TownshipName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TownshipName = value;}
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