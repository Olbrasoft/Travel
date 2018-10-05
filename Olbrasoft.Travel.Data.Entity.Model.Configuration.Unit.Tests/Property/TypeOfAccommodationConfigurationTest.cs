using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    class TypeOfAccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_PropertyConfiguration_Of_TypeOfAccommodation()
        {
            //Arrange
            var type = typeof(PropertyConfiguration<TypeOfAccommodation>);

            //Act
            var configuration = new TypeOfAccommodationConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);

        }
    }
}
