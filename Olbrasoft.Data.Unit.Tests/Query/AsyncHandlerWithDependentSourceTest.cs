using System.Linq;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Data.Unit.Tests.Query
{
    [TestFixture]
    internal class AsyncHandlerWithDependentSourceTest
    {
        [Test]
        public void Is_Instance_Of_IQueryHandler()
        {
            //Arrange
            var type = typeof(IHandle<SomQuery, object>);

            //Act
            var someQueryHandler = SomeAsyncHandler();

            //Assert
            Assert.IsInstanceOf(type, someQueryHandler);
        }

        private static SomeAsyncHandlerWithDependentSource SomeAsyncHandler()
        {
            var objectQueryableMock = new Mock<IQueryable<object>>();

            var source = objectQueryableMock.Object;

            return new SomeAsyncHandlerWithDependentSource(source);
        }

        [Test]
        public void Is_Instance_Of_QueryHandler()
        {
            //Arrange
            var type = typeof(AsyncHandlerWithDependentSource<SomQuery, IQueryable<object>, object>);

            //Act
            var handler = SomeAsyncHandler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        [Test]
        public void Handle()
        {
            //Arrange
            var handler = SomeAsyncHandler();

            //Act
            var result = handler.Handle(new SomQuery());

            //Assert
            Assert.IsNotNull(result);
        }
    }
}