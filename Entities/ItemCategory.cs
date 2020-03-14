using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class ItemCategory 
	{
			
		#region Constructers

			public ItemCategory(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ItemCategoryName;
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
			public	string  ItemCategoryName
			{
				get 
				{ 
					if(Null.IsNotNull(_ItemCategoryName)) 
					{
					 return _ItemCategoryName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ItemCategoryName = value;}
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