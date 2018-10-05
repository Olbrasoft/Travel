﻿using NUnit.Framework;

using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Geography;


namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Geography
{
    [TestFixture]
    internal class RegionToTypeConfigurationTest
    {
        [Test]
        public void Instance_Is_GeographyConfiguration_Of_RegionToType()
        {
            //Arrange
            var type = typeof(GeographyConfiguration<RegionToType>);

            //Act
            var configuration = new RegionToTypeConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}