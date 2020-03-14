using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class ProjectSaleInvoice 
	{
			
		#region Constructers

			public ProjectSaleInvoice(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ReferenceNo;
			private	int _ProjectID;
			private	string _ProjectName;
			private	string _CustomerName;
			private	decimal _Total;
			private	decimal _Discount;
			private	decimal _NetTotal;
			private	DateTime _CreatedDate;
			private	string _Username;
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
			public	string  ReferenceNo
			{
				get 
				{ 
					if(Null.IsNotNull(_ReferenceNo)) 
					{
					 return _ReferenceNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ReferenceNo = value;}
			}
			public	int  ProjectID
			{
				get 
				{ 
					if(Null.IsNotNull(_ProjectID)) 
					{
					 return _ProjectID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ProjectID = value;}
			}
			public	string  ProjectName
			{
				get 
				{ 
					if(Null.IsNotNull(_ProjectName)) 
					{
					 return _ProjectName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ProjectName = value;}
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
			public	decimal  Total
			{
				get 
				{ 
					if(Null.IsNotNull(_Total)) 
					{
					 return _Total;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _Total = value;}
			}
			public	decimal  Discount
			{
				get 
				{ 
					if(Null.IsNotNull(_Discount)) 
					{
					 return _Discount;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _Discount = value;}
			}
			public	decimal  NetTotal
			{
				get 
				{ 
					if(Null.IsNotNull(_NetTotal)) 
					{
					 return _NetTotal;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _NetTotal = value;}
			}
			public	DateTime  CreatedDate
			{
				get 
				{ 
					if(Null.IsNotNull(_CreatedDate)) 
					{
					 return _CreatedDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _CreatedDate = value;}
			}
			public	string  Username
			{
				get 
				{ 
					if(Null.IsNotNull(_Username)) 
					{
					 return _Username;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Username = value;}
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