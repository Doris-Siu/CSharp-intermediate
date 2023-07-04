// See https://aka.ms/new-console-template for more information
using CSharp_intermediate;



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

// fields: readonly modifier
var customer = new Customer();

var order = new Order();
customer.Orders.Add(order);
customer.Orders.Add(order);

customer.Promote();

Console.WriteLine(customer.Orders.Count);

//person.SetBirthdate(new DateTime(1982, 1, 1));
//Console.WriteLine(person.GetBirthdate());


// properties
var person = new Person(new DateTime(1982, 1, 1));

Console.WriteLine(person.Age);


// indexers
var cookie = new HttpCookie();
cookie["name"] = "Doris";
Console.WriteLine(cookie["name"]);



