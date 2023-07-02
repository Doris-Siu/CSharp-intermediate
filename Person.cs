using System;
namespace CSharp_intermediate
{
	public class Person
	{
		// encapsulation - information hiding
		private DateTime _birthdate;


		// provide getter/ setter methods as public
		public void SetBirthdate(DateTime birthdate)
		{
			_birthdate = birthdate;
		}


		public DateTime GetBirthdate()
		{
			return _birthdate;
		}
	}
}

