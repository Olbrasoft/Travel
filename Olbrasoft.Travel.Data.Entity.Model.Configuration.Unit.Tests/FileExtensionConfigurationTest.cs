using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class FileExtensionConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_FileExtension()
        {
            //Arrange
            var type = typeof(CreatorConfiguration<FileExtension>);

            //Act
            var configuration = new FileExtensionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}