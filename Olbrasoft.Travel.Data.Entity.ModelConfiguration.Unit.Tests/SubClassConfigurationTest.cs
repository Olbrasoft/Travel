using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    class SubClassConfigurationTest
    {
        [Test]
        public void Instance_Is_Implement_EntityTypeConfiguration_Of_SubClass()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<SubClass>);

            //Act
            var configuration = new SubClassConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);
        }
    }
}
