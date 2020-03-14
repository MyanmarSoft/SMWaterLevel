using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class WaterLevel 
	{
			
		#region Constructers

			public WaterLevel(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _RiverID;
			private	string _RiverName;
			private	string _LevelFeet;
			private	string _Remark;
			private	DateTime _CreatedDate;
			private	string _CreatedTime;
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
			public	int  RiverID
			{
				get 
				{ 
					if(Null.IsNotNull(_RiverID)) 
					{
					 return _RiverID;
					}
					else 
					{
					 return 0;
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
			public	string  LevelFeet
			{
				get 
				{ 
					if(Null.IsNotNull(_LevelFeet)) 
					{
					 return _LevelFeet;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _LevelFeet = value;}
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
			public	DateTime  CreatedDate
			{
				get 
				{ 
					if(Null.IsNotNull(_CreatedDate)) 
					{
					 return _CreatedDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _CreatedDate = value;}
			}
			public	string  CreatedTime
			{
				get 
				{ 
					if(Null.IsNotNull(_CreatedTime)) 
					{
					 return _CreatedTime;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CreatedTime = value;}
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