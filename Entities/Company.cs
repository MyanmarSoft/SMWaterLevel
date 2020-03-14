using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Company 
	{
			
		#region Constructers

			public Company(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _CompanyName;
			private	string _Address;
			private	string _ContactNo;
			private	int _PaymentModeID;
			private	string _PaymentMode;
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
			public	string  CompanyName
			{
				get 
				{ 
					if(Null.IsNotNull(_CompanyName)) 
					{
					 return _CompanyName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CompanyName = value;}
			}
			public	string  Address
			{
				get 
				{ 
					if(Null.IsNotNull(_Address)) 
					{
					 return _Address;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Address = value;}
			}
			public	string  ContactNo
			{
				get 
				{ 
					if(Null.IsNotNull(_ContactNo)) 
					{
					 return _ContactNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ContactNo = value;}
			}
			public	int  PaymentModeID
			{
				get 
				{ 
					if(Null.IsNotNull(_PaymentModeID)) 
					{
					 return _PaymentModeID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _PaymentModeID = value;}
			}
			public	string  PaymentMode
			{
				get 
				{ 
					if(Null.IsNotNull(_PaymentMode)) 
					{
					 return _PaymentMode;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PaymentMode = value;}
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