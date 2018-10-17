﻿using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class CaptionConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_Caption()
        {
            //Arrange
            var type = typeof(PropertyConfiguration<Caption>);

            //Act
            var configuration = new CaptionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}