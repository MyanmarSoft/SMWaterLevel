using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class ProjectCategory 
	{
			
		#region Constructers

			public ProjectCategory(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ProjectCategoryName;
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