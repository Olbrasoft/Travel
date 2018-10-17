using NUnit.Framework;
using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests.Identity
{
    [TestFixture]
    internal class RoleTest
    {
        [Test]
        public void Instance_Implement_Interface_IHaveDateTimeOfCreation()
        {
            //Arrange
            var type = typeof(IHaveDateTimeOfCreation);

            //Act
            var role = new Role();
            
            //Assert
            Assert.IsInstanceOf(type,role);
        }

    }
}