using NUnit.Framework;


namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class LogConfigurationTest
    {
        [Test]
        public void Instance_Is_CreationInfoConfiguration_of_LogOfImport()
        {
            //Arrange
            var type = typeof(CreationInfoConfiguration<Log>);

            //Act
            var configuration = new LogConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}