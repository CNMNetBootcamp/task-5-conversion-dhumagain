using System;

namespace quart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Good
            //setup
            double initalValue = 0.0;
            int conversion = 0;
            string result = String.Empty;
            string reply = String.Empty;

            do
            {

                do
                {
                    Console.WriteLine("Enter 1 if you like to convert to quart/gallon and " +
                    " 2 if you like to convert to cups ");

                    conversion = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the amount of substance you would like to convert");

                    initalValue = double.Parse(Console.ReadLine());


                    if (conversion == 1)
                    {
                        result = initalValue + " cups of substance is " + initalValue / 4.0 +
                            " quarts and " + initalValue / 16.0 + " gallons.";

                    }
                    else if (conversion == 2)
                    {
                        result = initalValue + " quarts of substance is " + 4 * initalValue + " " +
                            " cups.";
                    }

                    Console.WriteLine(result);
                    Console.WriteLine("Would you like to perform another conversion?");                    


                } while (conversion == 1 || conversion == 2);

                reply = Console.ReadLine();

            } while (reply != "N");


            Console.ReadLine();
        }
    }
}
