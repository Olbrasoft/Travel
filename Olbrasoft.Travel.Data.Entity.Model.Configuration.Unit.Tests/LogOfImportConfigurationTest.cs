using NUnit.Framework;


namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class LogOfImportConfigurationTest
    {
        [Test]
        public void Instance_Is_CreationInfoConfiguration_of_LogOfImport()
        {
            //Arrange
            var type = typeof(CreationInfoConfiguration<LogOfImport>);

            //Act
            var configuration = new LogOfImportConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}