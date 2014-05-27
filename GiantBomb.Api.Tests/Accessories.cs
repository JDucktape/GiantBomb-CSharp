using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GiantBomb.Api.Tests
{

    [TestFixture]
    public class Accessories : TestBase
    {

        [Test]
        public void accessory_resource_should_return_accessory_for_9()
        {
            int accessoryId = 9;

            var accessory = _client.GetAccessory(accessoryId);

            Assert.IsNotNull(accessory);
            Assert.AreEqual(accessoryId, accessory.Id);
            Assert.AreEqual("SIXAXIS Controller", accessory.Name);
            Assert.IsNotNull(accessory.ApiDetailUrl);
            Assert.IsTrue(accessory.DateAdded > DateTime.MinValue);
            Assert.IsTrue(accessory.DateLastUpdated > DateTime.MinValue);
            Assert.IsNotNull(accessory.Deck);
            Assert.IsNotNull(accessory.Description);
            Assert.IsNotNull(accessory.Image);
            Assert.IsNotNull(accessory.SiteDetailUrl);
        }

        [Test]
        public void accessories_resource_should_return_list_of_accessories()
        {

            var accessories = _client.GetAccessories(pageSize: 2);

            Assert.IsNotNull(accessories);
            Assert.IsTrue(accessories.Count() > 1);
        }

        [Test]
        public void accessory_resource_should_limit_fields_to_id_for_9()
        {
            int accessoryId = 9;

            var accessory = _client.GetAccessory(accessoryId, new[] { "id" });

            Assert.IsNotNull(accessory);
            Assert.AreEqual(accessoryId, accessory.Id);
            Assert.IsNullOrEmpty(accessory.Name);
        }
    }
}
