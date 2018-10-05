﻿using System.Data.Entity.ModelConfiguration;
using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class UserConfigurationTest
    {
        [Test]
        public void Instance_Is_EntityTypeConfiguration_Of_User()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<User>);

            //Act
            var configuration = new UserConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}