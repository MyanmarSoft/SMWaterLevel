using System;
using Whizzo;
namespace SMWaterLevel.Entities
{
	public class Speciality 
	{
			
		#region Constructers

			public Speciality(){}

		#endregion
		
		#region Internal Members
		
					private	int _ID;
			private	string _SpecialityName;
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
			public	string  SpecialityName
			{
				get 
				{ 
					if(Null.IsNotNull(_SpecialityName)) 
					{
					 return _SpecialityName;
					}
					else 
					{
					 return string.Empty;
					}
				}
				set { _SpecialityName = value;}
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