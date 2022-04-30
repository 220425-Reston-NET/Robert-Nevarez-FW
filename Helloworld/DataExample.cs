public class Exampledata
{
    static List<string> _shoppingCart1 = new List<string>();

    public static void ExampledataMain()
    {
        _shoppingCart1.Add("mouse");

        Console.Clear();
        Console.WriteLine("===Data Demo===");
        bool repeat = true;
        while(repeat)
        {
            Console.WriteLine("What can I do for you?");
            Console.WriteLine("1 - Remove item from the cart");
            Console.WriteLine("2 - search for item in the cart");
            Console.WriteLine("3 - exit");

         string answer = Console.ReadLine();
         if (answer == "1")
        {
        
        }
        }
    }
}