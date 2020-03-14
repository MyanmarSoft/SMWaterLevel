using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Ultrasound 
	{
			
		#region Constructers

			public Ultrasound(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ItemName;
			private	decimal _ServiceFee;
			private	decimal _ReferFee;
			private	decimal _ReaderFee;
			private	decimal _TechFee;
			private	decimal _Total;
			private	DateTime _CreateDate;
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
			public	decimal  ServiceFee
			{
				get 
				{ 
					if(Null.IsNotNull(_ServiceFee)) 
					{
					 return _ServiceFee;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _ServiceFee = value;}
			}
			public	decimal  ReferFee
			{
				get 
				{ 
					if(Null.IsNotNull(_ReferFee)) 
					{
					 return _ReferFee;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _ReferFee = value;}
			}
			public	decimal  ReaderFee
			{
				get 
				{ 
					if(Null.IsNotNull(_ReaderFee)) 
					{
					 return _ReaderFee;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _ReaderFee = value;}
			}
			public	decimal  TechFee
			{
				get 
				{ 
					if(Null.IsNotNull(_TechFee)) 
					{
					 return _TechFee;
					}
					else 
					{
					 return 0.00m;
					}
				}
				set { _TechFee = value;}
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
			public	DateTime  CreateDate
			{
				get 
				{ 
					if(Null.IsNotNull(_CreateDate)) 
					{
					 return _CreateDate;
					}
					else 
					{
					 return DateTime.Now;
					}
				}
				set { _CreateDate = value;}
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