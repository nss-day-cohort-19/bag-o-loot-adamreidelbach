using System;
using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new DatabaseInterface();
            db.Check();
            db.CheckBag();

            var menu = new MenuBuilder();

			// Read in the user's choice
			int choice = menu.ShowMainMenu();

            var actions = new Actions();

            switch (choice)
            {

                case 1:
                {
                    actions.RegisterChild();
                    break;
                }
                case 2:
                {
                    actions.AssignToy();
                    break;
                }
                // if (choice == 3)
                // {
                //     Console.WriteLine ("Remove toy from which child");
                // }
                // if (choice == 4)
                // {
                //     Console.WriteLine ("Choose toy to revoke from Kelly's Bag o' Loot");
                // }
                // if (choice == 5)
                // {
                //     Console.WriteLine ("Which child had all of their toys delivered");
                // }
                // if (choice == 6)
                // {
                //     Console.WriteLine ("Yuletime Delivery Report");
                // }
            }
        }
    }
}
