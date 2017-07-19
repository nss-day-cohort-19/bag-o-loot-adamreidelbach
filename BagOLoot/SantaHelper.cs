using System.Collections.Generic;

namespace BagOLoot
{
    public class SantaHelper
    {
        public int AddToyToBag(string toy, int child)
        {
            // Return the new toy id
            return 4;
        }

        public List<int> GetChildsToys(int child)
        {
            return new List<int>() { 4, 6, 7, 8 };
        }

         public void RemoveToyFromBag (int toyId)
        {
            
        }

        public List<int> GetChildrenWithToys(int toyId)
        {
            return new List<int>() { 1, 2, 3, 4, 6 };
        }
    }
}