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
            string childName = "Billy";
            int toyId = _helper.AddToyToBag(toyName, childName);
            List<int> toys = _helper.GetChildsToys(toyId);

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
        [Fact]
        public void GetListOfChildrenWithToys()
        {
            List<int> listOfChildren = _helper.GetChildrenWithToys();

            Assert.IsType<List<int>>(listOfChildren);
        }

        //4
        [Fact]
        public void GetListOfChildsToys()
        {
            int childId = 9;
            List<int> listOfToys = _helper.GetChildsToys(childId);

            Assert.True(listOfToys.Count >= 0);
        }

        //5
        [Fact]
        public void ToyHasBeenDelivered()
        {
            int childId = 55;
            var isDelivered = _helper.ToyIsDelivered(childId);

            Assert.True(isDelivered);
        }
    }
}