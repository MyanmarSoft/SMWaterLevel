using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class InventoryTransfer 
	{
			
		#region Constructers

			public InventoryTransfer(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _InventoryTransferNo;
			private	int _ItemCategoryID;
			private	int _ItemTypeID;
			private	string _Description;
			private	decimal _UnitCost;
			private	int _Qty;
			private	string _UnitType;
			private	decimal _AmountCost;
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
			public	int  ItemCategoryID
			{
				get 
				{ 
					if(Null.IsNotNull(_ItemCategoryID)) 
					{
					 return _ItemCategoryID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ItemCategoryID = value;}
			}
			public	int  ItemTypeID
			{
				get 
				{ 
					if(Null.IsNotNull(_ItemTypeID)) 
					{
					 return _ItemTypeID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ItemTypeID = value;}
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
			public	decimal  UnitCost
			{
				get 
				{ 
					if(Null.IsNotNull(_UnitCost)) 
					{
					 return _UnitCost;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _UnitCost = value;}
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
			public	string  UnitType
			{
				get 
				{ 
					if(Null.IsNotNull(_UnitType)) 
					{
					 return _UnitType;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _UnitType = value;}
			}
			public	decimal  AmountCost
			{
				get 
				{ 
					if(Null.IsNotNull(_AmountCost)) 
					{
					 return _AmountCost;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _AmountCost = value;}
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