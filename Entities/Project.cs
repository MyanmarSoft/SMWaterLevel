using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Project 
	{
			
		#region Constructers

			public Project(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ProjectName;
			private	int _CustomerID;
			private	string _CustomerName;
			private	int _ProjectCategoryID;
			private	string _ProjectCategoryName;
			private	int _ProjectStatusID;
			private	string _ProjectStatus;
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
			public	int  CustomerID
			{
				get 
				{ 
					if(Null.IsNotNull(_CustomerID)) 
					{
					 return _CustomerID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _CustomerID = value;}
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
			public	int  ProjectCategoryID
			{
				get 
				{ 
					if(Null.IsNotNull(_ProjectCategoryID)) 
					{
					 return _ProjectCategoryID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ProjectCategoryID = value;}
			}
			public	string  ProjectCategoryName
			{
				get 
				{ 
					if(Null.IsNotNull(_ProjectCategoryName)) 
					{
					 return _ProjectCategoryName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ProjectCategoryName = value;}
			}
			public	int  ProjectStatusID
			{
				get 
				{ 
					if(Null.IsNotNull(_ProjectStatusID)) 
					{
					 return _ProjectStatusID;
					}
					else 
					{
					 return 0;
					}
				}
				set { _ProjectStatusID = value;}
			}
			public	string  ProjectStatus
			{
				get 
				{ 
					if(Null.IsNotNull(_ProjectStatus)) 
					{
					 return _ProjectStatus;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ProjectStatus = value;}
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