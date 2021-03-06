﻿using System.Linq;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Mapping;
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
            var objectQueryableMock = new Mock<IHaveQueryable<object>>();
            var projectionMock = new Mock<IProjection>();

            var source = objectQueryableMock.Object;

            return new SomeAsyncHandlerWithDependentSource(source,projectionMock.Object);
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