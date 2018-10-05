using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    internal class PathToPhotoConfigurationTest
    {
        [NUnit.Framework.Test]
        public void Instance_Is_CreatorConfiguration_Of_PathToPhoto()
        {
            //Arrange
            var type = typeof(CreatorConfiguration<PathToPhoto>);

            //Act
            var configuration = new PathToPhotoConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}