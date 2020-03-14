using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class InventoryLocation 
	{
			
		#region Constructers

			public InventoryLocation(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _InventoryLocationName;
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
			public	string  InventoryLocationName
			{
				get 
				{ 
					if(Null.IsNotNull(_InventoryLocationName)) 
					{
					 return _InventoryLocationName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _InventoryLocationName = value;}
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