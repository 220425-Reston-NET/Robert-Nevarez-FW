// // See https://aka.ms/new-console-template for more information
Console.Clear();
// Console.WriteLine("Hello, World!"); //Writeline will write something in the terminal

// Console.WriteLine("Making a car object!");
// //[Class Name] [NameOfObject] = new [Class name];
// Car carObj1 = new Car();

// //Referencing class members within an object

// int mile = carObj1.TotalDistancePerFuel();

// carObj1.Sum(5,10);

// Console.WriteLine(mile);

// Console.WriteLine("End of Method");

// string owner = "Robert";

// Car carobj2 = new Car(owner);
// Console.WriteLine(carobj2.Owner);
// carobj2.Owner = "Nevark";
// Console.WriteLine(carobj2.Owner);

// carobj2.Fuel = -100;
// Console.WriteLine(carobj2.Fuel);

// //bool repeat = true;
// ///while (repeat)
// //my menu
// menu myMenu = new menu();

// //Menu demo
// menuexample menobj = new menuexample();
// bool repeat = true;
// Console.Clear();
// Console.WriteLine("Hello! What is your name?");
//  menobj.Name = Console.ReadLine();
// while (repeat)
// {
//     menobj.Greetuser();
//     string answer = Console.ReadLine();
//     if (answer == "1")
//     {
//         menobj.Buyitems();
//     }
//     else if (answer == "2")
//     {
//         Console.WriteLine("Your total price will be: $" + menobj.Totalprice);
//         repeat = false;
//     }
// }
// Collections collectobj = new Collections();
// collectobj.CollectionMain();

// Conversions.ConversionsMain();

// Data mydata = new Data();
// Exampledata.ExampledataMain();

Console.WriteLine("===OOP Demo===");
Dog dogobj = new Dog();
dogobj.Name = "Minie";
dogobj.Talk();
dogobj.Talk();
dogobj.Run();
dogobj.Talk("barking!");
dogobj.Breed = "Chihuahua";

Animal aniobj = new Animal();
aniobj.Name = "McCoy";
aniobj.Run();
    //aniobj.Breed this does not work because inheritance works one way. Only the fog gets everything from the animal and the animal doesn't inherit anything from the dog
aniobj.Health();

IAnimal aniobj2 = new Animal();
aniobj2.Health();