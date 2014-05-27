using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GiantBomb.Api.Tests
{

    [TestFixture]
    public class Promos : TestBase
    {

        [Test]
        public void promo_resource_should_return_promo_for_8832()
        {
            int promoId = 8832;

            var promo = _client.GetPromo(promoId);

            Assert.IsNotNull(promo);
            Assert.AreEqual(promoId, promo.Id);
            Assert.AreEqual("Wolfenstein: The New Order Review", promo.Name);
            Assert.IsNotNull(promo.ApiDetailUrl);
            Assert.IsTrue(promo.DateAdded > DateTime.MinValue);
            Assert.IsNotNull(promo.Deck);
            Assert.IsNotNull(promo.Image);
            Assert.IsNotNull(promo.Link);
            Assert.IsNotNull(promo.User);
            Assert.AreEqual("review", promo.ResourceType);
        }

        [Test]
        public void promos_resource_should_return_list_of_promos()
        {

            var promos = _client.GetPromos(pageSize: 2);

            Assert.IsNotNull(promos);
            Assert.IsTrue(promos.Count() > 1);
        }

        [Test]
        public void promo_resource_should_limit_fields_to_id_for_9()
        {
            int promoId = 8832;

            var promo = _client.GetPromo(promoId, new[] { "id" });

            Assert.IsNotNull(promo);
            Assert.AreEqual(promoId, promo.Id);
            Assert.IsNullOrEmpty(promo.Name);
        }
    }
}
