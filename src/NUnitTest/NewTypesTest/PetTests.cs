using Optimus.NewTypes.Pets;
using System;
using Xunit;

namespace NewTypesTest
{
    public class PetTests
    {
        [Fact]
        public void DogTalkToOwnerReturnsHav()
        {
            string expected = "Hav! :)";
            string actual = new Dog().TalkToOwner();

            Assert.Equal(expected, actual);
            //return 1
            //Assert.NotEqual(expected, actual);
            //return 0
        }

        [Fact]
        public void CatTalkToOwnerReturnsMiyav()
        {
            string expected = "Miyav! :)";
            string actual = new Cat().TalkToOwner();

            Assert.Equal(expected, actual);
            //return 1
            //Assert.NotEqual(expected, actual);
            //return 0
        }

        [Fact]
        public void BirdTalkToOwnerReturnsMerhaba()
        {
            string expected = "Merhaba! :)";
            string actual = new Bird().TalkToOwner();

            Assert.Equal(expected, actual);
            //return 1
            //Assert.NotEqual(expected, actual);
            //return 0
        }
    }
}
