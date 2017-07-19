using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using Xunit;

namespace BagOLoot.Tests
{
    public class ChildToyListShould
    {
        private readonly ChildToyList _toyList;

        public ChildToyListShould()
        {
            _toyList = new ChildToyList();
        }

        [Fact]
        public void ReturnChildNameFromDB()
        {
            var result = _toyList.GetChildFromDB("Adam");
            Assert.Equal(result, true);
        }
    }
}
