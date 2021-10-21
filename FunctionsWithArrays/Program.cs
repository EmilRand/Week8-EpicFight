using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "Kohuke", "Burger", "Pizza", "Lasanje" };
            string[] drinks = { "Vesi", "MagicTea", "kohv" };

          //  DisplayRandomForArray(food);
           // DisplayRandomForArray(drinks);
            string randomsnack = PickRandomFromArray(food);
            string randomdrink = PickRandomFromArray(drinks);
            Console.WriteLine($"Computer has chosen {randomsnack} and {randomdrink}.");
          
        }
        
          private static string PickRandomFromArray(string[] someArray)
          {
            Random rnd = new Random();
            int randomtext = rnd.Next(0, someArray.Length);
                string RandomElement = someArray[randomtext];

            return RandomElement;
          }
        private static void DisplayRandomForArray(string[] somearray)
        {
            Random rnd = new Random();
          int randomtext = rnd.Next(0, somearray.Length);
         Console.WriteLine($"computer has chosen {somearray[randomtext]}");


        }
    

    }
}
