using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class ItemType 
	{
			
		#region Constructers

			public ItemType(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ItemTypeName;
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
			public	string  ItemTypeName
			{
				get 
				{ 
					if(Null.IsNotNull(_ItemTypeName)) 
					{
					 return _ItemTypeName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ItemTypeName = value;}
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