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
            var queryBuilder = facade.QueryManager;

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
            var type = typeof(ISomeQueryManager);
            var facade = GetFacade();

            //Act
            var queryManager = facade.QueryManager;

            //Assert
            Assert.IsInstanceOf(type, queryManager);
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
            var queryManagerMock = new Mock<ISomeQueryManager>();

            return new SomeFacade(queryManagerMock.Object);
        }
    }



    internal interface ISomeFacade : IFacade
    {
        ISomeQueryManager QueryManager { get; }

        IQueryManager GetBaseQueryBuilder();




    }

    public interface ISomeQueryManager : IQueryManager
    {
    }




    internal class SomeFacade : BaseFacade, ISomeFacade
    {
        public new ISomeQueryManager QueryManager { get; }
        public IQueryManager GetBaseQueryBuilder()
        {
            return base.QueryManager;
        }

        
        public SomeFacade(ISomeQueryManager queryManager) : base(queryManager)
        {
            QueryManager = queryManager;
        }




    }
}