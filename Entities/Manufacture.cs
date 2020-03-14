using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Manufacture 
	{
			
		#region Constructers

			public Manufacture(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ManufactureName;
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
			public	string  ManufactureName
			{
				get 
				{ 
					if(Null.IsNotNull(_ManufactureName)) 
					{
					 return _ManufactureName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ManufactureName = value;}
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