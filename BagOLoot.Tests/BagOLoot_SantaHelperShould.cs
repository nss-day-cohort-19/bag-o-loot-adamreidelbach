using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class SantaHelperShould
    {
        private SantaHelper _helper;
        public SantaHelperShould()
        {
            _helper = new SantaHelper();
        }

        //1
        [Fact]
        public void AddToyToChildsBag()
        {
            string toyName = "Skateboard";
            int childId = 715;
            int toyId = _helper.AddToyToBag(toyName, childId);
            List<int> toys = _helper.GetChildsToys(childId);

            Assert.Contains(toyId, toys);
        }

        //2
        [Fact]
        public void RemoveToyFromChild()
        {
            int childId = 15;
            int toyId = 5;
            _helper.RemoveToyFromBag(toyId);
            var childsToys = _helper.GetChildsToys(childId);

            Assert.DoesNotContain(toyId, childsToys);
        }

        //3
        // [Fact]
        // public void GetChildrenWithToys()
        // {

        //     List<int> listOfChildren = _childrenWithToys.GetChildsToys();

        //     Assert.
        // }

        //4
        [Fact]
        public void GetListOfChildsToys()
        {
            int childId = 9;
            List<int> listOfToys = _helper.GetChildsToys(childId);

            Assert.True(listOfToys.Count >= 0);
        }

        //5

    }
}