using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class AccountCategory 
	{
			
		#region Constructers

			public AccountCategory(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _AccountCategoryName;
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
			public	string  AccountCategoryName
			{
				get 
				{ 
					if(Null.IsNotNull(_AccountCategoryName)) 
					{
					 return _AccountCategoryName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AccountCategoryName = value;}
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