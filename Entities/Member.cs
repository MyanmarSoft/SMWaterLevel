using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Member 
	{
			
		#region Constructers

			public Member(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _MemberName;
			private	string _PhoneNo;
			private	string _Address;
			private	string _Remark;
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
			public	string  MemberName
			{
				get 
				{ 
					if(Null.IsNotNull(_MemberName)) 
					{
					 return _MemberName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _MemberName = value;}
			}
			public	string  PhoneNo
			{
				get 
				{ 
					if(Null.IsNotNull(_PhoneNo)) 
					{
					 return _PhoneNo;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _PhoneNo = value;}
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
			public	string  Remark
			{
				get 
				{ 
					if(Null.IsNotNull(_Remark)) 
					{
					 return _Remark;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Remark = value;}
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