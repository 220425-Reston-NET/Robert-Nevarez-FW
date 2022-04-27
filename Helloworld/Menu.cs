public class menu
{    public menu()
    {
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        int n5 = 0;
        bool repeat = true;
        string answer1 = "";
        string answer11 = "";
        string answer111= "";
        Console.Clear();

        while (repeat == true)
        {
            Console.WriteLine("Welcome to our store!");
            Console.WriteLine("We are selling brand shoes");
            Console.WriteLine("What brand would you like to buy");
            Console.WriteLine("please choose number for which brand you would like to buy");
            Console.WriteLine("1. Nike");
            Console.WriteLine("2. Yeezy");
            Console.WriteLine("3. Puma");
            Console.WriteLine("4. Adidas");
            Console.WriteLine("5. Jordan");
            Console.WriteLine("");

            answer1 = Console.ReadLine();
            if (answer1 == "1" )
            {
                n1 += 70;
                Console.WriteLine("Your Nike purchse is going to be " + n1 + " U.S Dollars");
                Console.WriteLine("Would you like to buy something esle?");
                Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
                answer11 = Console.ReadLine();
            
                if (answer11 == "1")
                {
                    repeat = true;
                }
            }
            if (answer1 == "2" )
            {
                n2 += 400;
                Console.WriteLine("Your Yeezy purchse is going to be " + n2 + " U.S Dollars");
                Console.WriteLine("Would you like to buy something esle?");
                Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
                answer11 = Console.ReadLine();
            
                if (answer11 == "1")
                {
                    repeat = true;
                }
            }
            if (answer1 == "3" )
            {
                n3 += 150;
                Console.WriteLine("Your Puma purchse is going to be " + n3 + " U.S Dollars");
                Console.WriteLine("Would you like to buy something esle?");
                Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
                answer11 = Console.ReadLine();
            
                if (answer11 == "1")
                    {
                    repeat = true;
                    }
            } 
            if (answer1 == "4" )
            {
                n4 += 250;
                Console.WriteLine("Your Adidas purchse is going to be " + n4 + " U.S Dollars");
                Console.WriteLine("Would you like to buy something esle?");
                Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
                answer11 = Console.ReadLine();
            
                if (answer11 == "1")
                    {
                    repeat = true;
                    }
            }          
            if (answer1 == "5" )
            {
                n5 += 450;
                Console.WriteLine("Your Jordan purchse is going to be " + n5 + " U.S Dollars");
                Console.WriteLine("Would you like to buy something esle?");
                Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
                answer11 = Console.ReadLine();
            
                if (answer11 == "1")
                {
                    repeat = true;
                }
            }
          if (answer11 == "2")
            {
                Console.WriteLine("Your total will be $" + (n1+n2+n3+n4+n5));
                Console.WriteLine("Press 1 to pay, Press 2 to keep shopping");
                answer111 = Console.ReadLine();
                if (answer111 == "1")
                {
                    repeat = false;
                    break;
                }
                else if (answer111 == "2")
                {
                    repeat = true;
                }
            }    
        }
     }

 }
