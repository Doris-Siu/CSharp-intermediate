﻿// See https://aka.ms/new-console-template for more information
using CSharp_intermediate;

//var customer = new Customer();

//var order = new Order();
//customer.Orders.Add(order);


// implement global exception handling mechanism - so the app wont crash despite error
try
{
    var point = new Point(10, 20);
    point.Move(null);

    Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

    point.Move(100, 200);

    Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

}
catch (Exception)
{
    Console.WriteLine("An unexpected error occured.");
}


// effect of the params keyword declared
var calculator = new Calculator();
Console.WriteLine(calculator.Add(1, 2));
Console.WriteLine(calculator.Add(1, 2, 3));
Console.WriteLine(calculator.Add(1, 2, 3 ,4 ));
Console.WriteLine(calculator.Add(new int[] {1,2,3,4,5}));




