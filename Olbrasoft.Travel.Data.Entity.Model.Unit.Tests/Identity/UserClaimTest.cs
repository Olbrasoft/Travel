using NUnit.Framework;
using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests.Identity
{
    [TestFixture]
    internal class UserClaimTest
    {
        [Test]
        public void Instance_Implement_Interface_IHaveDateTimeOfCreation()
        {
            //Arrange
            var type = typeof(IHaveDateTimeOfCreation);

            //Act
            var userClaim = new UserClaim();

            //Assert
            Assert.IsInstanceOf(type, userClaim);
        }
    }
}