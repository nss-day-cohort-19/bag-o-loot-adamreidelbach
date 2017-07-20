using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class Actions 
    {
        ChildRegister registry = new ChildRegister();
        SantaHelper _helper = new SantaHelper();
        public void RegisterChild()
        {
            Console.WriteLine ("Enter child name");
            Console.Write ("> ");
            string childName = Console.ReadLine();
            bool childId = registry.AddChild(childName);
            Console.WriteLine(childId);
        }

        public void AssignToy()
        {
            Console.WriteLine ("Assign toy to which child?");
            List<string> listOfChildren = registry.GetChildren();
            int counter = 1;
            foreach (string child in listOfChildren)
            {
                Console.WriteLine(counter + ". " + child);
                counter++;
            }
            Console.Write ("> ");
            var childChoice = Console.ReadLine();
            Console.WriteLine();

            // var childId = registry.GetChild(childChoice);
            // Console.WriteLine("childId" + childId);

            Console.WriteLine ($"Enter toy to add to {childChoice}'s Bag o' Loot?");
            Console.Write("> ");
            var toyChoice = Console.ReadLine();

            _helper.AddToyToBag(childChoice, toyChoice);
            {

            }
        }
    }
}