using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    class RegionToRegionConfigurationTest
    {
        [Test]
        public void Instance_Is_ConfigurationGeography()
        {
            //Arrange
            var type = typeof(ConfigurationGeography<RegionToRegion>);

            //Act
            var configuration= new RegionToRegionConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);

        }
    }
}
