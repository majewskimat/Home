using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight_Becominga.NETDeveloper
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Pierogi", "Polish dumplings with cabbage and mushrooms.", 13.99);
            summerMenu.AddMenuItem("Żurek", "Traditional Polish soup with white sausage and egg.", 10.99);
            summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask for Dr. Janusz.";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Vodka", "A classic polish drink.", 40);
            outsideDrinks.AddMenuItem("Beer", "Everything should be more tasty with this.", 4);

            Order hungryGuestOrder = new Order();

            for(int x=0; x<= summerMenu.items.Count - 1; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }

            Console.WriteLine("The total is:" + hungryGuestOrder.Total);

            try
            {
                outsideDrinks.AddMenuItem("Cola", "Cola", 0);
            }
            catch (Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }
            Console.ReadKey();
        }
    }
}
