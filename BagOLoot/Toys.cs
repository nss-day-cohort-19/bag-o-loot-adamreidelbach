using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class Toys 
    {
        public int ToyId { get; set; }
        public string Name { get; set; }
        public int ChildId { get; set; }
        public Toys (int toyId, string name, int childId)
        {
            ToyId = toyId;
            Name = name;
            ChildId = childId;
        }
    }
}