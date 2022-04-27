// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!"); //Writeline will write something in the terminal

Console.WriteLine("Making a car object!");
//[Class Name] [NameOfObject] = new [Class name];
Car carObj1 = new Car();

//Referencing class members within an object

int mile = carObj1.TotalDistancePerFuel();

carObj1.Sum(5,10);

Console.WriteLine(mile);

Console.WriteLine("End of Method");

string owner = "Robert";

Car carobj2 = new Car(owner);
Console.WriteLine(carobj2.Owner);
carobj2.Owner = "Nevark";
Console.WriteLine(carobj2.Owner);

carobj2.Fuel = -100;
Console.WriteLine(carobj2.Fuel);