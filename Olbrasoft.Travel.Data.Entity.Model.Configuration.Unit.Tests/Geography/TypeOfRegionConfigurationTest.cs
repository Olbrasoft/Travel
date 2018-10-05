﻿using NUnit.Framework;

using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Geography
{
    [TestFixture]
    internal class TypeOfRegionConfigurationTest
    {
        [Test]
        public void Instance_Is_GeographyConfiguration_of_TypeOfRegion()
        {
            //Arrange
            var type = typeof(GeographyConfiguration<TypeOfRegion>);

            //Act
            var configuration = new TypeOfRegionConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);
        }
    }
}
