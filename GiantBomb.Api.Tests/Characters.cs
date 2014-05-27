using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GiantBomb.Api.Tests
{

    [TestFixture]
    public class Characters : TestBase
    {

        [Test]
        public void character_resource_should_return_character_for_23()
        {
            int characterId = 23;

            var character = _client.GetCharacter(characterId);

            Assert.IsNotNull(character);
            Assert.AreEqual(characterId, character.Id);
            Assert.AreEqual("John MacTavish", character.Name);
            Assert.IsNotNull(character.ApiDetailUrl);
            Assert.IsTrue(character.DateAdded > DateTime.MinValue);
            Assert.IsTrue(character.DateLastUpdated > DateTime.MinValue);
            Assert.IsNotNull(character.Deck);
            Assert.IsNotNull(character.Concepts);
            Assert.IsNotNull(character.Enemies);
            Assert.IsNotNull(character.Friends);
            Assert.IsNotNull(character.Locations);
            Assert.IsNotNull(character.Birthday);
            Assert.IsNotNull(character.Franchises);
            Assert.IsNotNull(character.FirstAppearedInGame);
            Assert.IsNotNull(character.Games);
            Assert.IsNotNull(character.Objects);
            Assert.IsNotNull(character.People);
            Assert.IsNotNull(character.RealName);
            Assert.IsNotNull(character.Description);
            Assert.IsNotNull(character.Image);
            Assert.IsNotNull(character.SiteDetailUrl);
        }

        [Test]
        public void characters_resource_should_return_list_of_characters()
        {

            var characters = _client.GetCharacters(pageSize: 2);

            Assert.IsNotNull(characters);
            Assert.IsTrue(characters.Count() > 1);
        }

        [Test]
        public void characters_resource_should_limit_fields_to_id_for_14()
        {
            int characterId = 14;

            var character = _client.GetCharacter(characterId, new[] { "id" });

            Assert.IsNotNull(character);
            Assert.AreEqual(characterId, character.Id);
            Assert.IsNullOrEmpty(character.Name);
        }
    }
}
