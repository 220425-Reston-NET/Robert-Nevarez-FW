//Cannot make an object out of the interface
public interface IAnimal
{
    void Health();
}

//Base class
public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }

    public void Talk()
    {
        Console.WriteLine("Animal is talking");
    }

    //this is method overloading
    //It has to have the same name and same return type but different parameters

}
//Inheritance is denoted by ":" syntax, the class after the colon is the one it is trying to inherit from
//So is the case, Dog class is inheriting Animal class
//Derived Class

public class Dog : Animal
{
    public string Breed { get; set; }


    public overide void Run()
    {
        Console.WriteLine ("Dog is running");
    }

//This is an example of multilevel inhertitance
    public class Chihuahua : Dog
    {

    }

//This is an example of of Hierarchal Inheritance
    public class Bird : Animal
    {

    }
}