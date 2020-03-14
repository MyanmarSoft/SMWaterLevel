using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class PaymentMode 
	{
			
		#region Constructers

			public PaymentMode(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _PaymentModeName;
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
			public	string  PaymentModeName
			{
				get 
				{ 
					if(Null.IsNotNull(_PaymentModeName)) 
					{
					 return _PaymentModeName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PaymentModeName = value;}
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