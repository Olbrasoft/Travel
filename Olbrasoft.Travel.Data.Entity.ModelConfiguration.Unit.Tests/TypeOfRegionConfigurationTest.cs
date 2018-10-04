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
    internal class TypeOfRegionConfigurationTest
    {
        [Test]
        public void Instance_Is_EntityTypeConfiguration_of_TypeOfRegion()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<TypeOfRegion>);

            //Act
            var configuration = new TypeOfRegionConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);
        }
    }
}
