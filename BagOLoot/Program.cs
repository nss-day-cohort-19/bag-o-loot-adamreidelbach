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

            Console.WriteLine ("WELCOME TO THE BAG O' LOOT SYSTEM");
            Console.WriteLine ("*********************************");
            Console.WriteLine ("1. Add a child");
            Console.WriteLine("2. Assign toy to a child");
            // Console.WriteLine("3. Revoke toy from child");
            // Console.WriteLine("4. Review child's toy list");
            // Console.WriteLine("5. Child toy delivery complete");
            // Console.WriteLine("6. Yuletime Delivery Report");
			Console.Write ("> ");

			// Read in the user's choice
			int choice;
			Int32.TryParse (Console.ReadLine(), out choice);

            if (choice == 1)
            {
                Console.WriteLine ("Enter child name");
                Console.Write ("> ");
                string childName = Console.ReadLine();
                ChildRegister registry = new ChildRegister();
                bool childId = registry.AddChild(childName);
                Console.WriteLine(childId);
            }
            if (choice == 2)
            {
                Console.WriteLine ("Assign toy to which child?");
                ChildRegister registry = new ChildRegister();
                List<string> listOfChildren = registry.GetChildren();
                int counter = 1;
                foreach (string child in listOfChildren)
                {
                    Console.WriteLine(counter + ". " + child);
                    counter++;
                }

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
