using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class InventoryTransferItem 
	{
			
		#region Constructers

			public InventoryTransferItem(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _InventoryTransferNo;
			private	int _FromInventoryLocationID;
			private	string _FromInventoryLocationName;
			private	int _ToInventoryLocationID;
			private	string _ToInventoryLocationName;
			private	decimal _Total;
			private	decimal _Discount;
			private	decimal _NetTotal;
			private	DateTime _InventoryTransferDate;
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
			public	int  InventoryTransferNo
			{
				get 
				{ 
					if(Null.IsNotNull(_InventoryTransferNo)) 
					{
					 return _InventoryTransferNo;
					}
					else 
					{
					 return 0;
					}
				}
				set { _InventoryTransferNo = value;}
			}
			public	int  FromInventoryLocationID
			{
				get 
				{ 
					if(Null.IsNotNull(_FromInventoryLocationID)) 
					{
					 return _FromInventoryLocationID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _FromInventoryLocationID = value;}
			}
			public	string  FromInventoryLocationName
			{
				get 
				{ 
					if(Null.IsNotNull(_FromInventoryLocationName)) 
					{
					 return _FromInventoryLocationName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _FromInventoryLocationName = value;}
			}
			public	int  ToInventoryLocationID
			{
				get 
				{ 
					if(Null.IsNotNull(_ToInventoryLocationID)) 
					{
					 return _ToInventoryLocationID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ToInventoryLocationID = value;}
			}
			public	string  ToInventoryLocationName
			{
				get 
				{ 
					if(Null.IsNotNull(_ToInventoryLocationName)) 
					{
					 return _ToInventoryLocationName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ToInventoryLocationName = value;}
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
			public	DateTime  InventoryTransferDate
			{
				get 
				{ 
					if(Null.IsNotNull(_InventoryTransferDate)) 
					{
					 return _InventoryTransferDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _InventoryTransferDate = value;}
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