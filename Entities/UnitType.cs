using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class UnitType_ 
	{
			
		#region Constructers

			public UnitType_(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _UnitTypeName;
			private	string _ShortUnitTypeName;
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
			public	string  UnitTypeName
			{
				get 
				{ 
					if(Null.IsNotNull(_UnitTypeName)) 
					{
					 return _UnitTypeName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _UnitTypeName = value;}
			}
			public	string  ShortUnitTypeName
			{
				get 
				{ 
					if(Null.IsNotNull(_ShortUnitTypeName)) 
					{
					 return _ShortUnitTypeName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ShortUnitTypeName = value;}
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