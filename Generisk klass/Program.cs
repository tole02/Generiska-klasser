using System;
using System.Collections.Generic;

namespace Generisk_klass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wares = new Dictionary<string, int>();

            wares.Add("Milk", 5);
            wares.Add("Potatoes", 10);
            wares.Add("Meat", 20);
            wares.Add("Mango", 25);
            wares.Add("Chocolate", 15);

            int balance = 100;

            Console.WriteLine("You are at the store and are going to shop groceries.");
            Console.WriteLine("The groceries you can buy are:");
            foreach(string key in wares.Keys)
            {
                Console.WriteLine(key + ": " + wares[key] + ":-");
            }
            System.Console.WriteLine("You have 100:-. What do you want to buy first? Write the name of the product.");
            string input = Console.ReadLine();

            if(input == "milk" || input == "Milk")
            {
                balance -= 5;

                System.Console.WriteLine("You bought milk for 5:-, you now have " + balance + ":-.");
            }
            else if(input == "potatoes" || input == "Potatoes")
            {
                balance -= 10;
                System.Console.WriteLine("You bought potatoes for 10:-, you now have " + balance + ":-.");
            }
            else if(input == "meat" || input == "Meat")
            {
                balance -= 20;
                System.Console.WriteLine("You bought meat for 20:-, you now have " + balance + ":-.");
            }
            else if(input == "mango" || input == "Mango")
            {
                balance -= 25;
                System.Console.WriteLine("You bought mango for 25:-, you now have " + balance + ":-.");
            }
            else if(input == "chocolate" || input == "Chocolate")
            {
                balance -= 15;
                System.Console.WriteLine("You bought chocolate for 15:-, you now have " + balance + ":-.");
            }






            Console.ReadLine();
        }
    }
}
