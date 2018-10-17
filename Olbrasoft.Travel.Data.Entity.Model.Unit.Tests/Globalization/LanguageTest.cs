using NUnit.Framework;
using Olbrasoft.Data;
using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests.Globalization
{
    [TestFixture]
    internal class LanguageTest
    {
        [Test]
        public void Instance_Implement_Interface_IHaveId_Of_Integer()
        {
            //Arrange
            var type = typeof(IHaveId<int>);

            //Act
            var language = new Language();

            //Assert
            Assert.IsInstanceOf(type, language);
        }

        [Test]
        public void Instance_Implement_Interface_ICreatorInfo_Of_Integer()
        {
            //Arrange
            var type = typeof(IHaveCreatorId<int>);

            //Act
            var language = new Language();

            //Assert
            Assert.IsInstanceOf(type, language);
        }
    }
}