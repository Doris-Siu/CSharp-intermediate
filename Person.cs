using System;
namespace CSharp_intermediate
{
	public class Person
	{
		//// encapsulation - information hiding
		//private DateTime _birthdate;


		//// provide getter/ setter methods as public
		//public void SetBirthdate(DateTime birthdate)
		//{
		//	_birthdate = birthdate;
		//}


		//public DateTime GetBirthdate()
		//{
		//	return _birthdate;
		//}


		// auto-implemented properties
		public string Name { get; set; }
		public string Username { get; set; }
		public DateTime Birthdate { private set; get; }

		// declare the default constructor for the private set of birthdate
		public Person(DateTime birthdate)
		{
			Birthdate = birthdate;  // limit to set only once upon obj initialisation
		}

		public int Age
		{
			get {
				var timeSpan = DateTime.Today - Birthdate;
				var years = timeSpan.Days / 365;

				return years;

			}
		}

	}
}

