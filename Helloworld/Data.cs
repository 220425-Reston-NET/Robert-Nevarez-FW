
public class Data
{
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        int n5 = 0;
        bool repeat = true;
        string name = "";
        string answer1 = "";
        string answer11 = "";
        string answer111= "";
        string answer1111="";

        string answer2= "";
        string answer22="";
        string answer12="";
        
        List<int> _price = new List<int>();
        List<string> _name = new List<string>();



        public Data()
     {
         Console.WriteLine("Welcome to our store!");
        Console.WriteLine("We are selling brand shoes");
         Console.WriteLine("To get started what is your name?");
         name = Console.ReadLine();
            
            while (repeat)
        {
            Console.Clear();
            Console.WriteLine("Hey " + name + "! What brand would you like to buy");
            Console.WriteLine("please choose number for which brand you would like to buy");
            Console.WriteLine("1. Nike");
            Console.WriteLine("2. Yeezy");
            Console.WriteLine("3. Puma");
            Console.WriteLine("4. Adidas");
            Console.WriteLine("5. Jordan");

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
                Console.Clear();
                Console.WriteLine("=======CheckOut=======");
                Console.WriteLine("Your total will be $" + (n1+n2+n3+n4+n5));
                Console.WriteLine("Press 1 to pay, Press 2 to keep shopping, Press 3 to Modify Purchase");
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
                else if (answer111 == "3")
                {
                    _price.Add (n1);
                    _price.Add (n2);
                    _price.Add (n3);
                    _price.Add (n4);
                    _price.Add (n5);

                    _name.Add ("Nike");
                    _name.Add ("Yeezy");
                    _name.Add ("Puma");
                    _name.Add ("Adidas");
                    _name.Add ("Jordan");

                    Console.WriteLine("=======Modify Items=======");
                    Console.WriteLine("Which items would you like to modify");
                  
                   _price.Remove(0);
                  
                     for (int i = 0; i < _price.Count; i++)
                  {
                      _price.Remove(0);
                       Console.WriteLine("Your " + _name[i] + " will come out to be $" + _price[i]);
                    //    _price.Clear();
                    //    _price.Remove(0);
                    //    Console.WriteLine("Your " + _name[i] + " will come out to be $" + _price[i]);
                    //    _price.Clear();   
                  }
                    
                      Console.WriteLine("Press 1 to add, press 2 to delete, press 3 to pay");
                      answer1111 = Console.ReadLine();
                      if (answer1111 == "1")
                      {
                          repeat = true;
                      }
                      else if (answer1111 == "2")
                      {
                          Console.WriteLine("Which item would you like to delete?");
                          Console.WriteLine("Please type the name of the item you would like to delete");
                          answer2 = Console.ReadLine();

                          if (answer2 == "Nike" || answer2 == "nike")
                          {
                              n1 -= 70;
                              Console.WriteLine("Your Nike item has been sucessfully removed");
                              Console.WriteLine("Press 1 to checkout, press 2 to remove another item");
                              answer22 = Console.ReadLine();
                              if (answer22 == "1")
                              {
                                //   answer11.convert
                                //    answer11 = true;
                              }
                          }
                          if (answer2 == "Nike" || answer2 == "nike")
                          {
                              n2 -= 400;
                              Console.WriteLine("Your Yeezy item has been sucessfully removed");
                              Console.WriteLine("Press 1 to checkout, press 2 to remove another item");
                            }
                            if (answer2 == "Yeezy" || answer2 == "yeezy")
                          {
                              n3 -= 150;
                              Console.WriteLine("Your Puma item has been sucessfully removed");
                              Console.WriteLine("Press 1 to checkout, press 2 to remove another item");
                            }
                            if (answer2 == "Puma" || answer2 == "puma")
                          {
                              n4 -= 250;
                              Console.WriteLine("Your Adidas item has been sucessfully removed");
                              Console.WriteLine("Press 1 to checkout, press 2 to remove another item");
                            }
                            if (answer2 == "Jordan" || answer2 == "jordan")
                          {
                              n5 -= 450;
                              Console.WriteLine("Your Jordan item has been sucessfully removed");
                              Console.WriteLine("Press 1 to checkout, press 2 to remove another item");
                            }
                      else if (answer1111 == "3")
                      {
                          repeat = false;
                      }
                  }
                }   
                
            }    
        }
     }

 }

        
    
