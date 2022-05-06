//Cannot make an object out of the interface
public interface IAnimal
{   
    //Checks the current health status of the animal
    void Health();
}

//Base class
public class Animal : IAnimal
{
    public string Name { get; set; }
    public string Color { get; set; }

    public void Talk()
    {
        Console.WriteLine("Animal is talking");
    }
    //this is method overloading
    //It has to have the same name and same return type but different parameters
    public void Talk (string p_str)
    {
        Console.WriteLine("Animal is talking" + p_str);
    }
    public void Talk (int p_int)
    {
        Console.WriteLine("Animal is talking" + p_int);
    }
        //Base class method needs the virtual keyword (Non-access modifier)
    public virtual void Run() 
    {
        Console.WriteLine("Dog is running");
    }
    //This is an example of multilevel inhertitance

    public void Health()
    {
        Console.WriteLine ("Animal is Healthy!");
    }

    //constructor overloading

    public Animal()
    {
        this.Name = "Default";
    }
    public Animal(string p_str)
    {
        this.Name = p_str;
    }

}
//Inheritance is denoted by ":" syntax, the class after the colon is the one it is trying to inherit from
//So is the case, Dog class is inheriting Animal class
//Derived Class

public class Dog : Animal
{
    public string Breed { get; set; }

    public string GetName()
    {
        return this.Name;
    }
    //This is called method overriding
    //Usually used to add on pre-existing method from the base class
    //It needs to have the same name, return type, and parameter as the base class have
    //It must have the override non-access modifier
    public override void Run()
    {
        base.Run();
    }
}
//This is an example of multilevel inhertitance
    public class Chihuahua : Dog
    {

    }

//This is an example of of Hierarchal Inheritance
    public class Bird : Animal
    {

    }
