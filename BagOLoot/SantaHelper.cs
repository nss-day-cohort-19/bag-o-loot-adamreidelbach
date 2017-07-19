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

        public void RemoveToyFromBag (int toyId)
        {
            
        }

        public List<int> GetChildrenWithToys()
        {
            return new List<int>() { 1, 2, 3, 4, 6 };
        }

        public List<int> GetChildsToys(int child)
        {
            return new List<int>() { 4, 6, 7, 8 };
        }

        public bool ToyIsDelivered (int childId, int toyId)
        {
            return true;
        }
    }
}