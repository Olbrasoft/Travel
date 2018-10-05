using NUnit.Framework;


namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class UserConfigurationTest
    {
        [Test]
        public void Instance_Is_CreationInfoConfiguration_Of_User()
        {
            //Arrange
            var type = typeof(CreationInfoConfiguration<User>);

            //Act
            var configuration = new UserConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}