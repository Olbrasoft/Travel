using Moq;
using NUnit.Framework;
using Olbrasoft.Data;

namespace Olbrasoft.Business.UnitTest
{
    [TestFixture]
    internal class FacadeTest
    {
        [Test]
        public void Facade_Is_Instance_Of_IFacade()
        {
            //Arrange
            var type = typeof(IFacade);

            //Act
            var facade = GetFacade();

            //Assert
            Assert.IsInstanceOf(type, facade);
        }

        [Test]
        public void Facade_Is_Instance_Of_BaseFacade()
        {
            //Arrange
            var type = typeof(BaseFacade);

            //Act
            var facade = GetFacade();

            //Assert
            Assert.IsInstanceOf(type, facade);
        }

        [Test]
        public void QueryBuilder_Is_Instance_Of_IQueryBuilder()
        {
            //Arrange
            var type = typeof(IQueryBuilder);
            var facade = GetFacade();

            //Act
            var queryBuilder = facade.QueryBuilder;

            //Assert
            Assert.IsInstanceOf(type, queryBuilder);
        }

        [Test]
        public void Facade_Is_Instance_Of_ISomeFacade()
        {
            //Arrange
            var type = typeof(ISomeFacade);

            //Act
            var facade = GetFacade();

            //Assert
            Assert.IsInstanceOf(type, facade);
        }

        [Test]
        public void QueryBuilder_Is_Instance_Of_IFadeQueryBuilder()
        {
            //Arrange
            var type = typeof(ISomeQueryBuilder);
            var facade = GetFacade();

            //Act
            var queryBuilder = facade.QueryBuilder;

            //Assert
            Assert.IsInstanceOf(type, queryBuilder);
        }

        [Test]
        public void BaseFacade_QueryBuilder_Is_Not_Null()
        {
            //Arrange
            var facade = GetFacade();

            //Act
            var queryBuilder = facade.GetBaseQueryBuilder();

            //Assert
            Assert.IsNotNull(queryBuilder);
        }
        



        private static SomeFacade GetFacade()
        {
            var queryBuilderMock = new Mock<ISomeQueryBuilder>();

            return new SomeFacade(queryBuilderMock.Object);
        }
    }

    internal interface ISomeFacade : IFacade
    {
        ISomeQueryBuilder QueryBuilder { get; }

        IQueryBuilder GetBaseQueryBuilder();


    }

    public interface ISomeQueryBuilder : IQueryBuilder
    {
    }




    internal class SomeFacade : BaseFacade, ISomeFacade
    {
        public new ISomeQueryBuilder QueryBuilder { get; }

        public IQueryBuilder GetBaseQueryBuilder()
        {
            return base.QueryBuilder;
        }

        public SomeFacade(ISomeQueryBuilder queryBuilder) : base(queryBuilder)
        {
            QueryBuilder = queryBuilder;
        }
    }
}