using System;
namespace CSharp_intermediate
{
	public class Vehicle
	{
        private readonly string _registrationNumber;

  //      public Vehicle()
		//{
		//	Console.WriteLine("Vehicle is being initialzed.");
		//}

		public Vehicle(string registrationNumber)
		{
			_registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialzed.{0}", registrationNumber);

        }
    }
}

