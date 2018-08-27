using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olbrasoft.Design.Pattern.Behavior;

namespace Olbrasoft.Design.Pattern.UnitTest
{
    [TestFixture]
    public class QueryTest
    {
        [Test]
        public void IsInstanceOfIQuery()
        {
            //Arrange
            var type = typeof(IQuery<object>);

            //Act
            var someQuery = new SomeQuery<object>();

            //Assert
            Assert.IsInstanceOf(type, someQuery);

        }

        [Test]
        public void IsGeneric()
        {
            //Arrange
            var someQuery = new SomeQuery<object>();

            //Act
            var r = someQuery.GetType().GetGenericTypeDefinition();

            //Assert
            Assert.IsTrue(r==typeof(SomeQuery<>));
        }



        [Test]
        public void IsInstanceOfQuery()
        {
            //Arrange
            var type = typeof(Query<object>);
            
            //Act
            var query = new SomeQuery<object>();

            //Assert
            Assert.IsInstanceOf(type, query);

        }



    }
}
