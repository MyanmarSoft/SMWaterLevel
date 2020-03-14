using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Customer 
	{
			
		#region Constructers

			public Customer(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _CustomerName;
			private	string _Phone;
			private	string _Address;
			private	string _ImagePath;
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
			public	string  CustomerName
			{
				get 
				{ 
					if(Null.IsNotNull(_CustomerName)) 
					{
					 return _CustomerName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CustomerName = value;}
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
			public	string  ImagePath
			{
				get 
				{ 
					if(Null.IsNotNull(_ImagePath)) 
					{
					 return _ImagePath;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ImagePath = value;}
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