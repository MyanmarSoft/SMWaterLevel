using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class River 
	{
			
		#region Constructers

			public River(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _RiverID;
			private	string _RiverName;
			private	string _Latitude;
			private	string _Longitude;
			private	string _Description;
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
			public	string  RiverID
			{
				get 
				{ 
					if(Null.IsNotNull(_RiverID)) 
					{
					 return _RiverID;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RiverID = value;}
			}
			public	string  RiverName
			{
				get 
				{ 
					if(Null.IsNotNull(_RiverName)) 
					{
					 return _RiverName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RiverName = value;}
			}
			public	string  Latitude
			{
				get 
				{ 
					if(Null.IsNotNull(_Latitude)) 
					{
					 return _Latitude;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Latitude = value;}
			}
			public	string  Longitude
			{
				get 
				{ 
					if(Null.IsNotNull(_Longitude)) 
					{
					 return _Longitude;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Longitude = value;}
			}
			public	string  Description
			{
				get 
				{ 
					if(Null.IsNotNull(_Description)) 
					{
					 return _Description;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Description = value;}
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