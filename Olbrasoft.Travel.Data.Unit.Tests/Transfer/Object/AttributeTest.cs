﻿using NUnit.Framework;
using NUnit.Framework.Constraints;
using Olbrasoft.Data;
using Attribute = Olbrasoft.Travel.Data.Transfer.Object.Attribute;

namespace Olbrasoft.Travel.Data.Unit.Tests.Transfer.Object
{
    [TestFixture]
    internal class AttributeTest
    {
        [Test]
        public void Create_And_Fill_Properties()
        {
            //Arrange
            var attribute = new Attribute
            {
                TypId = int.MinValue,
                SubTypeId = int.MaxValue,
                Description = string.Empty,
                Text = string.Empty,
                Ban=true
            };

            //Act
            var typId = attribute.TypId;
            var subTypeId = attribute.SubTypeId;
            var description = attribute.Description;
            var text = attribute.Text;
            var ban = attribute.Ban;

            //Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(typId == int.MinValue);
                Assert.IsTrue(int.MaxValue == subTypeId);
                Assert.IsTrue(description == string.Empty);
                Assert.IsTrue(text == string.Empty);
                Assert.IsTrue(ban);
            });
        }

        [Test]
        public void Instance_Implement_Interface_IHaveId()
        {
            //Arrange
            var type = typeof(IHaveId<int>);

            //Act
            var attribute = new Attribute();

            //Assert
            Assert.IsInstanceOf(type,attribute);
        }



    }
}