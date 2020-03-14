using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class RelationFormula 
	{
			
		#region Constructers

			public RelationFormula(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _RelationFormulaName;
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
			public	string  RelationFormulaName
			{
				get 
				{ 
					if(Null.IsNotNull(_RelationFormulaName)) 
					{
					 return _RelationFormulaName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _RelationFormulaName = value;}
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