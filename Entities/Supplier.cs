using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Supplier 
	{
			
		#region Constructers

			public Supplier(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _SupplierName;
			private	string _Phone;
			private	string _Address;
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
			public	string  SupplierName
			{
				get 
				{ 
					if(Null.IsNotNull(_SupplierName)) 
					{
					 return _SupplierName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SupplierName = value;}
			}
			public	string  Phone
			{
				get 
				{ 
					if(Null.IsNotNull(_Phone)) 
					{
					 return _Phone;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Phone = value;}
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