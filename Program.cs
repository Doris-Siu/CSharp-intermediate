// See https://aka.ms/new-console-template for more information
using CSharp_intermediate;
using Amazon;
using System.Collections;



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
//var calculator1 = new RateCalculator();


var order = new Order();
//customer.Orders.Add(order);
//customer.Orders.Add(order);

customer.Promote();

//Console.WriteLine(customer.Orders.Count);

//person.SetBirthdate(new DateTime(1982, 1, 1));
//Console.WriteLine(person.GetBirthdate());


// properties
var person = new Person(new DateTime(1982, 1, 1));

Console.WriteLine(person.Age);


// indexers
var cookie = new HttpCookie();
cookie["name"] = "Doris";
Console.WriteLine(cookie["name"]);


// inheritance
var text = new Text(); //Text inherit by PresentationObject
text.Width = 100; //PresentationObject.Width
//text.Copy(); //PresentationObject.Copy()


// composition
var logger = new Logger();

var dbMigrator = new DbMigrator(logger);
var installer = new Installer(logger);

dbMigrator.Migrate();
installer.Install();

//Constructor inheritance
var car = new Car("xyz123");

//Upcasting - implicit casting
Text text1 = new Text();
Shape shape = text;

text.Width = 200;
shape.Width = 100;

Console.WriteLine(text.Width);

StreamReader reader = new StreamReader(new MemoryStream());

//ArrayList vs List - non-generic vs generic class type
var list = new ArrayList();
list.Add(1);
list.Add("doris");
list.Add(new Text());

var anotherList = new List<int>();

//Downcasting - explicit casting
Shape shape1 = new Text();
Text text2 = (Text)shape1;


// Polymorphism - Method Overriding
var shapes = new List<Shape>();
shapes.Add(new Circle());
shapes.Add(new Rectangle());

var canvas = new Canvas();
canvas.DrawShapes(shapes);



