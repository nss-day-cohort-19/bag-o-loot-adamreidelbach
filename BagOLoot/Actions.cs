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

        public void RemoveToy()
        {
            Console.WriteLine ("Remove toy from which child?");
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

            Console.WriteLine ($"Choose toy to revoke from {childChoice}'s Bag o' Loot");
            int count = 1;
            List<Toys> listOfToys = new List<Toys>();
            List<Toys> childsToys = new List<Toys>();
            foreach (var child in listOfChildren)
            {
                if (child.ChildName == childChoice) {
                    listOfToys = _helper.GetChildsToys(child.ChildId);
                    foreach (var toy in listOfToys) {
                        Console.WriteLine(count + ". " + toy.Name);
                        count++;
                        childsToys.Add(toy);
                    }
                }
            }
            Console.Write("> ");
            var toyChoice = Console.ReadLine();

            foreach (var toy in childsToys)
            {
               if (toy.Name == toyChoice) {
                   _helper.RemoveToyFromBag(toy.ToyId);
               }
            }
        }
    }
}