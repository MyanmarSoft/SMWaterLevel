using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class SaleQuotation 
	{
			
		#region Constructers

			public SaleQuotation(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ReferenceNo;
			private	int _InventoryItemID;
			private	string _ItemName;
			private	string _Description;
			private	decimal _Price;
			private	int _Qty;
			private	decimal _Amount;
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
			public	int  InventoryItemID
			{
				get 
				{ 
					if(Null.IsNotNull(_InventoryItemID)) 
					{
					 return _InventoryItemID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _InventoryItemID = value;}
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
			public	string  Description
			{
				get 
				{ 
					if(Null.IsNotNull(_Description)) 
					{
					 return _Description;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Description = value;}
			}
			public	decimal  Price
			{
				get 
				{ 
					if(Null.IsNotNull(_Price)) 
					{
					 return _Price;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _Price = value;}
			}
			public	int  Qty
			{
				get 
				{ 
					if(Null.IsNotNull(_Qty)) 
					{
					 return _Qty;
					}
					else 
					{
					 return 0;
					}
				}
				set { _Qty = value;}
			}
			public	decimal  Amount
			{
				get 
				{ 
					if(Null.IsNotNull(_Amount)) 
					{
					 return _Amount;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _Amount = value;}
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