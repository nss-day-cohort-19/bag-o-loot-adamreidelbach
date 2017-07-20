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
            List<Child> listOfChildren = registry.GetChildren();
            int counter = 1;
            foreach (var child in listOfChildren)
            {
                Console.WriteLine(counter + ". " + child.ChildName);
                counter++;
            }
            Console.Write ("> ");
            var childChoice = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine ($"Enter toy to add to {childChoice}'s Bag o' Loot?");
            Console.Write("> ");
            var toyChoice = Console.ReadLine();

            foreach (var child in listOfChildren)
            {
                if (child.ChildName == childChoice) {
                    _helper.AddToyToBag(child.ChildId, toyChoice);
                }
            }
        }
    }
}