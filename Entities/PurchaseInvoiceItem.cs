using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class PurchaseInvoiceItem 
	{
			
		#region Constructers

			public PurchaseInvoiceItem(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _PurchaseInvoiceNo;
			private	string _ReferenceNo;
			private	int _SupplierID;
			private	string _SupplierName;
			private	int _PaymentModeID;
			private	string _PaymentMode;
			private	decimal _Total;
			private	decimal _Discount;
			private	decimal _NetTotal;
			private	DateTime _PurchaseInvoiceDate;
			private	int _InventoryLocationID;
			private	string _InventoryLocationName;
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
			public	int  PurchaseInvoiceNo
			{
				get 
				{ 
					if(Null.IsNotNull(_PurchaseInvoiceNo)) 
					{
					 return _PurchaseInvoiceNo;
					}
					else 
					{
					 return 0;
					}
				}
				set { _PurchaseInvoiceNo = value;}
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
			public	int  SupplierID
			{
				get 
				{ 
					if(Null.IsNotNull(_SupplierID)) 
					{
					 return _SupplierID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _SupplierID = value;}
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
			public	DateTime  PurchaseInvoiceDate
			{
				get 
				{ 
					if(Null.IsNotNull(_PurchaseInvoiceDate)) 
					{
					 return _PurchaseInvoiceDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _PurchaseInvoiceDate = value;}
			}
			public	int  InventoryLocationID
			{
				get 
				{ 
					if(Null.IsNotNull(_InventoryLocationID)) 
					{
					 return _InventoryLocationID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _InventoryLocationID = value;}
			}
			public	string  InventoryLocationName
			{
				get 
				{ 
					if(Null.IsNotNull(_InventoryLocationName)) 
					{
					 return _InventoryLocationName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _InventoryLocationName = value;}
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