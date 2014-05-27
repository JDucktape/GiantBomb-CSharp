using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GiantBomb.Api.Tests
{

    [TestFixture]
    public class Reviews : TestBase
    {

        [Test]
        public void review_resource_should_return_review_for_9()
        {
            int reviewId = 9;

            var review = _client.GetReview(reviewId);

            Assert.IsNotNull(review);
            Assert.IsNotNull(review.ApiDetailUrl);
            Assert.IsNotNull(review.Deck);
            Assert.IsNotNull(review.Description);
            Assert.IsNotNull(review.SiteDetailUrl);
        }

        //[Test]
        //public void accessories_resource_should_return_list_of_accessories()
        //{

        //    var accessories = _client.GetAccessories(pageSize: 2);

        //    Assert.IsNotNull(accessories);
        //    Assert.IsTrue(accessories.Count() > 1);
        //}

        //[Test]
        //public void accessory_resource_should_limit_fields_to_id_for_9()
        //{
        //    int accessoryId = 9;

        //    var accessory = _client.GetAccessory(accessoryId, new[] { "id" });

        //    Assert.IsNotNull(accessory);
        //    Assert.AreEqual(accessoryId, accessory.Id);
        //    Assert.IsNullOrEmpty(accessory.Name);
        //}
    }
}
