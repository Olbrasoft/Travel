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
    internal class LogOfImportConfigurationTest
    {
        [Test]
        public void Instance_Is_EntityTypeConfiguration_of_LogOfImport()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<LogOfImport>);

            //Act
            var configuration= new LogOfImportConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);
        }
    }
}
