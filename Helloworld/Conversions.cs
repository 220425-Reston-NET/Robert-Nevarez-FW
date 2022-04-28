public class Conversions
{
    //Static keyword will make whatever class member belong to the class itself
    //For us, it means we don't have create an object out of this class to use it 
    public static void ConversionsMain()
    {
        //General coding terms
        //implicit - just means something is done automatically (usually the compiler)
        //explicit - just meanns you have to write some syntax to do something or to tell compiler to do something

        Console.WriteLine("===Conversion Demo===");
        int number = 10;
        double numberDecimal = 76.3;
        string word = "Hello";

        //implicit conversion
        //the computer/compiler will automatically convert one data type to another without you needing to specify anything
        //The general rule is if you are going from a datatype to another datatype without losing information, it will be implicit conversion
        Console.WriteLine("=implicit=");

        //double datatype can set its values an int datatype
        numberDecimal = number;
        Console.WriteLine(numberDecimal);

        //Explicit conversion
        //You have to write a syntax to tell the compiler/computer to do the conversion regardless of the potential possibility of losing data.

        Console.WriteLine("=explicit=");
        numberDecimal = 76.3;

        //a cast is required
        //syntax: (datatpe)variablename;
        number = (int)numberDecimal;
        Console.WriteLine(number);

        //more explicit conversion
        string numberString = number.ToString();
        Console.WriteLine(numberString);

        //Converting string into numerical values
        string doubleString = "438.1239";
        double double2 = Convert.ToDouble(doubleString);
        Console.WriteLine(double2/2);


    }
}