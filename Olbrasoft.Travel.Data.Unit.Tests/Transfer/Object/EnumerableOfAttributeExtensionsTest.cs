using NUnit.Framework;
using System.Collections.Generic;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Unit.Tests.Transfer.Object
{
    [TestFixture]
    internal class EnumerableOfAttributeExtensionsTest
    {
        [Test]
        public void CreditCards_Return_Instance_Of_IEnumerableOfAttribute()
        {
            //Arrange
            var type = typeof(IEnumerable<Data.Transfer.Object.Attribute>);
            var attributes = new[]
            {
                new Attribute()
                {
                    Id = 43
                }
            };

            //Act
            var creditCards = attributes.OnlyCreditCards();

            //Assert
            Assert.IsInstanceOf(type, creditCards);
        }
    }
}