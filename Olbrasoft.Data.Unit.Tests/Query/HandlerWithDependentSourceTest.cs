﻿using System.Linq;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Data.Unit.Tests.Query
{
    [TestFixture]
    internal class HandlerWithDependentSourceTest
    {
        [Test]
        public void Is_Instance_Of_IQueryHandler()
        {
            //Arrange
            var type = typeof(IHandle<SomQuery, object>);

            //Act
            var someQueryHandler = CreateSomeQueryHandler();

            //Assert
            Assert.IsInstanceOf(type, someQueryHandler);
        }

        private static SomeHandlerWithDependentSource CreateSomeQueryHandler()
        {
            var objectQueryableMock = new Mock<IHaveQueryable<object>>();

            var source = objectQueryableMock.Object;

            return new SomeHandlerWithDependentSource(source);
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

