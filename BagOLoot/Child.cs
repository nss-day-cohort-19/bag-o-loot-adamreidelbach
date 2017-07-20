using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class Child 
    {
        public int ChildId { get; set; }
        public string ChildName { get; set; }
        public int Delivered { get; set; }
        public Child (int childId, string childName, int delivered)
        {
            ChildId = childId;
            ChildName = childName;
            Delivered = delivered;
        }
    }
}