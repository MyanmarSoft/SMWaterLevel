using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class MedicalCheckup 
	{
			
		#region Constructers

			public MedicalCheckup(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ItemName;
			private	int _CompanyID;
			private	decimal _MMK;
			private	decimal _USD;
			private	string _CheckList;
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
			public	string  ItemName
			{
				get 
				{ 
					if(Null.IsNotNull(_ItemName)) 
					{
					 return _ItemName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ItemName = value;}
			}
			public	int  CompanyID
			{
				get 
				{ 
					if(Null.IsNotNull(_CompanyID)) 
					{
					 return _CompanyID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _CompanyID = value;}
			}
			public	decimal  MMK
			{
				get 
				{ 
					if(Null.IsNotNull(_MMK)) 
					{
					 return _MMK;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _MMK = value;}
			}
			public	decimal  USD
			{
				get 
				{ 
					if(Null.IsNotNull(_USD)) 
					{
					 return _USD;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _USD = value;}
			}
			public	string  CheckList
			{
				get 
				{ 
					if(Null.IsNotNull(_CheckList)) 
					{
					 return _CheckList;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CheckList = value;}
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