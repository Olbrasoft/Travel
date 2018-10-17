using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests.Identity
{
    [TestFixture]
    internal class UserTest
    {
        [Test]
        public void Instance_Implement_Interface_IHaveDateTimeOfCreation()
        {
            //Arrange
            var type = typeof(IHaveDateTimeOfCreation);

            //Act
            var user= new Model.Identity.User();

            //Assert
            Assert.IsInstanceOf(type,user);

        }
    }
}