using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class InventoryItem 
	{
			
		#region Constructers

			public InventoryItem(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ItemCode;
			private	string _ItemName;
			private	int _UnitID;
			private	string _UnitName;
			private	decimal _PurchasePrice;
			private	decimal _SalePrice;
			private	string _Description;
			private	int _CustomIncomeAccountID;
			private	string _CustomIncomeAccountName;
			private	int _CustomExpenseAccountID;
			private	string _CustomExpenseAccountName;
			private	string _QtyToReceive;
			private	string _QtyOnHand;
			private	string _QtyToDeliver;
			private	string _QtyOwned;
			private	string _AverageCost;
			private	string _TotalCost;
			private	DateTime _CreatedDate;
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
			public	string  ItemCode
			{
				get 
				{ 
					if(Null.IsNotNull(_ItemCode)) 
					{
					 return _ItemCode;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ItemCode = value;}
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
			public	int  UnitID
			{
				get 
				{ 
					if(Null.IsNotNull(_UnitID)) 
					{
					 return _UnitID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _UnitID = value;}
			}
			public	string  UnitName
			{
				get 
				{ 
					if(Null.IsNotNull(_UnitName)) 
					{
					 return _UnitName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _UnitName = value;}
			}
			public	decimal  PurchasePrice
			{
				get 
				{ 
					if(Null.IsNotNull(_PurchasePrice)) 
					{
					 return _PurchasePrice;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _PurchasePrice = value;}
			}
			public	decimal  SalePrice
			{
				get 
				{ 
					if(Null.IsNotNull(_SalePrice)) 
					{
					 return _SalePrice;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _SalePrice = value;}
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
			public	int  CustomIncomeAccountID
			{
				get 
				{ 
					if(Null.IsNotNull(_CustomIncomeAccountID)) 
					{
					 return _CustomIncomeAccountID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _CustomIncomeAccountID = value;}
			}
			public	string  CustomIncomeAccountName
			{
				get 
				{ 
					if(Null.IsNotNull(_CustomIncomeAccountName)) 
					{
					 return _CustomIncomeAccountName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CustomIncomeAccountName = value;}
			}
			public	int  CustomExpenseAccountID
			{
				get 
				{ 
					if(Null.IsNotNull(_CustomExpenseAccountID)) 
					{
					 return _CustomExpenseAccountID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _CustomExpenseAccountID = value;}
			}
			public	string  CustomExpenseAccountName
			{
				get 
				{ 
					if(Null.IsNotNull(_CustomExpenseAccountName)) 
					{
					 return _CustomExpenseAccountName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _CustomExpenseAccountName = value;}
			}
			public	string  QtyToReceive
			{
				get 
				{ 
					if(Null.IsNotNull(_QtyToReceive)) 
					{
					 return _QtyToReceive;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _QtyToReceive = value;}
			}
			public	string  QtyOnHand
			{
				get 
				{ 
					if(Null.IsNotNull(_QtyOnHand)) 
					{
					 return _QtyOnHand;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _QtyOnHand = value;}
			}
			public	string  QtyToDeliver
			{
				get 
				{ 
					if(Null.IsNotNull(_QtyToDeliver)) 
					{
					 return _QtyToDeliver;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _QtyToDeliver = value;}
			}
			public	string  QtyOwned
			{
				get 
				{ 
					if(Null.IsNotNull(_QtyOwned)) 
					{
					 return _QtyOwned;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _QtyOwned = value;}
			}
			public	string  AverageCost
			{
				get 
				{ 
					if(Null.IsNotNull(_AverageCost)) 
					{
					 return _AverageCost;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AverageCost = value;}
			}
			public	string  TotalCost
			{
				get 
				{ 
					if(Null.IsNotNull(_TotalCost)) 
					{
					 return _TotalCost;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _TotalCost = value;}
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