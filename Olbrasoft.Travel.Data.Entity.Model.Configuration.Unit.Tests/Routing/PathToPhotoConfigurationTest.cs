using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Routing;
using Olbrasoft.Travel.Data.Entity.Model.Routing;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Routing
{
    internal class PathToPhotoConfigurationTest
    {
        [NUnit.Framework.Test]
        public void Instance_Is_RoutingConfiguration_Of_PathToPhoto()
        {
            //Arrange
            var type = typeof(RoutingConfiguration<PathToPhoto>);

            //Act
            var configuration = new PathToPhotoConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}