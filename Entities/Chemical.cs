using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Chemical 
	{
			
		#region Constructers

			public Chemical(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _ChemicalName;
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
			public	string  ChemicalName
			{
				get 
				{ 
					if(Null.IsNotNull(_ChemicalName)) 
					{
					 return _ChemicalName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _ChemicalName = value;}
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