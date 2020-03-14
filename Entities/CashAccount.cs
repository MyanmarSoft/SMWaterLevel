using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class CashAccount 
	{
			
		#region Constructers

			public CashAccount(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _CashAccountName;
			private	decimal _Balance;
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
			public	string  CashAccountName
			{
				get 
				{ 
					if(Null.IsNotNull(_CashAccountName)) 
					{
					 return _CashAccountName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CashAccountName = value;}
			}
			public	decimal  Balance
			{
				get 
				{ 
					if(Null.IsNotNull(_Balance)) 
					{
					 return _Balance;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _Balance = value;}
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