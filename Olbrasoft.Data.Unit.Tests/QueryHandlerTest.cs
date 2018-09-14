using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Linq;

namespace Olbrasoft.Data.Unit.Tests
{
    [TestFixture()]
    internal class QueryHandlerTest
    {
        [Test]
        public void Is_Instance_Of_IQueryHandler()
        {
            //Arrange
            var type = typeof(IQueryHandler<SomQuery, object>);

            //Act
            var someQueryHandler = CreateSomeQueryHandler();

            //Assert
            Assert.IsInstanceOf(type, someQueryHandler);
        }

        private static SomeQueryHandler CreateSomeQueryHandler()
        {
            var objectQueryableMock = new Mock<IQueryable<object>>();

            var source = objectQueryableMock.Object;

            return new SomeQueryHandler(source);
        }

        [Test]
        public void Is_Instance_Of_QueryHandler()
        {
            //Arrange
            var type = typeof(QueryHandler<SomQuery, IQueryable<object>, object>);

            //Act
            var handler = CreateSomeQueryHandler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        [Test]
        public void Handle()
        {
            //Arrange
            var handler = CreateSomeQueryHandler();

            //Act
            var result = handler.Handle(new SomQuery());

            //Assert
            Assert.IsNotNull(result);
        }
    }
}