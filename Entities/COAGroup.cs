using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class COAGroup 
	{
			
		#region Constructers

			public COAGroup(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _AccountCategoryName;
			private	int _AccountCategoryID;
			private	string _IsExpense;
			private	string _GroupName;
			private	string _Code;
			private	int _ParentGroupID;
			private	string _ParentGroupName;
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
			public	string  AccountCategoryName
			{
				get 
				{ 
					if(Null.IsNotNull(_AccountCategoryName)) 
					{
					 return _AccountCategoryName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _AccountCategoryName = value;}
			}
			public	int  AccountCategoryID
			{
				get 
				{ 
					if(Null.IsNotNull(_AccountCategoryID)) 
					{
					 return _AccountCategoryID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _AccountCategoryID = value;}
			}
			public	string  IsExpense
			{
				get 
				{ 
					if(Null.IsNotNull(_IsExpense)) 
					{
					 return _IsExpense;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _IsExpense = value;}
			}
			public	string  GroupName
			{
				get 
				{ 
					if(Null.IsNotNull(_GroupName)) 
					{
					 return _GroupName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _GroupName = value;}
			}
			public	string  Code
			{
				get 
				{ 
					if(Null.IsNotNull(_Code)) 
					{
					 return _Code;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _Code = value;}
			}
			public	int  ParentGroupID
			{
				get 
				{ 
					if(Null.IsNotNull(_ParentGroupID)) 
					{
					 return _ParentGroupID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ParentGroupID = value;}
			}
			public	string  ParentGroupName
			{
				get 
				{ 
					if(Null.IsNotNull(_ParentGroupName)) 
					{
					 return _ParentGroupName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ParentGroupName = value;}
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