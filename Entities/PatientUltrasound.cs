using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class PatientUltrasound 
	{
			
		#region Constructers

			public PatientUltrasound(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	int _InvoiceNo;
			private	int _PatientID;
			private	string _PatientName;
			private	int _DoctorID;
			private	string _DoctorName;
			private	int _CompanyID;
			private	string _CompanyName;
			private	int _PaymentModeID;
			private	string _PaymentMode;
			private	decimal _Total;
			private	decimal _Discount;
			private	decimal _NetTotal;
			private	DateTime _InvoiceDate;
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
			public	int  InvoiceNo
			{
				get 
				{ 
					if(Null.IsNotNull(_InvoiceNo)) 
					{
					 return _InvoiceNo;
					}
					else 
					{
					 return 0;
					}
				}
				set { _InvoiceNo = value;}
			}
			public	int  PatientID
			{
				get 
				{ 
					if(Null.IsNotNull(_PatientID)) 
					{
					 return _PatientID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _PatientID = value;}
			}
			public	string  PatientName
			{
				get 
				{ 
					if(Null.IsNotNull(_PatientName)) 
					{
					 return _PatientName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PatientName = value;}
			}
			public	int  DoctorID
			{
				get 
				{ 
					if(Null.IsNotNull(_DoctorID)) 
					{
					 return _DoctorID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _DoctorID = value;}
			}
			public	string  DoctorName
			{
				get 
				{ 
					if(Null.IsNotNull(_DoctorName)) 
					{
					 return _DoctorName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _DoctorName = value;}
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
			public	DateTime  InvoiceDate
			{
				get 
				{ 
					if(Null.IsNotNull(_InvoiceDate)) 
					{
					 return _InvoiceDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _InvoiceDate = value;}
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