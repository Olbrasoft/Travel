using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Component = Castle.MicroKernel.Registration.Component;

namespace Olbrasoft.Data.UnitTest
{
    [TestClass]
    public class QueryBuilderTest
    {
        private IWindsorContainer _container;

        [TestInitialize]
        public void Initialize()
        {
            _container = new WindsorContainer();
            var classes = Classes.FromAssemblyNamed("Olbrasoft.Data.UnitTest");

            _container.Register(classes
                .Where(type => type.Name.EndsWith("Query"))
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            _container.AddFacility<TypedFactoryFacility>();
            _container.Register(Component.For<IQueryFactory>()
                .AsFactory());
        }

        [TestMethod]
        public void Container_Resolve_ISome_Query()
        {
            var type = typeof(ISomeQuery);

            var query = _container.Resolve<ISomeQuery>();

            Assert.IsInstanceOfType(query, type);

            var queryFactory = _container.Resolve<IQueryFactory>();

            var instance = queryFactory.Create<IAnotherQuery>();

            Assert.IsInstanceOfType(instance, typeof(IAnotherQuery));
        }

        [TestMethod]
        public void SomeQuery_Is_Instance_Of_ISomeQuery()
        {
            //Arrange
            var type = typeof(ISomeQuery);

            //Act
            var someQuery = new SomeQuery();

            //Assert
            Assert.IsInstanceOfType(someQuery, type);
        }

        [TestMethod]
        public void SomeQueryBuilder_Is_Instance_Of_Type_ISomeQueryBuilder()
        {
            //Arrange
            var type = typeof(IQueryBuilder);

            //Act
            var someQueryBuilder = GetQueryBuilder();

            //Assert
            Assert.IsInstanceOfType(someQueryBuilder, type);
        }

        [TestMethod]
        public void Build_Is_Instance_Of_Type_ISomeQuery()
        {
            //Arrange
            var someQueryBuilder = GetQueryBuilder();
            var type = typeof(ISomeQuery);

            //Act
            var query = someQueryBuilder.Build<ISomeQuery>();

            //Assert
            Assert.IsInstanceOfType(query, type);
        }

        [TestMethod]
        public void AnotherQuery_Is_Instance_Of_Type_IAnotherQuery()
        {
            //Arrange
            var type = typeof(IAnotherQuery);

            //Act
            var anotherQuery = new AnotherQuery();

            //Assert
            Assert.IsInstanceOfType(anotherQuery, type);
        }

        [TestMethod]
        public void SomeQuery_Is_Instance_Of_Type_IQuery_Of_Object()
        {
            //Arrange
            var type = typeof(IQuery<object>);

            //Act
            var someQuery = new SomeQuery();

            //Assert
            Assert.IsInstanceOfType(someQuery, type);
        }

        [TestMethod]
        public void Build_Of_Concrete_Class()
        {
            var queryBuilder = GetQueryBuilder();

            queryBuilder.Build<IAnotherQuery>();

            Assert.IsTrue(typeof(AnotherQuery).IsClass);
        }

        [TestMethod]
        public void QueryBuilder_Is_Instance_Of_Type_IQueryBuilder()
        {
            var type = typeof(IQueryBuilder);

            var builder = Builder();

            Assert.IsInstanceOfType(builder, type);
        }

        [TestMethod]
        public void AnotherQuery_Is_Instance_Of_Type_IQuery()
        {
            var type = typeof(IQuery);

            var query = new AnotherQuery();

            Assert.IsInstanceOfType(query, type);
        }

        [TestMethod]
        public void Build_Is_Instance_Of_Type_IAnotherQuery()
        {
            var type = typeof(IAnotherQuery);
            var builder = Builder();

            var query = builder.Build<IAnotherQuery>();

            Assert.IsInstanceOfType(query,type);

        }

        [TestMethod]
        public void SomeQueryBuilder_Build_With_Arguments()
        {
            var builder = GetQueryBuilder();

            var query = builder.Build<ISomeQuery>().SetAndReturn(p => p.Id, 5);

            Assert.IsTrue(query.Id == 5);
        }

        [TestMethod]
        public void AnotherQuery_Build_With_Set_Properties()
        {
            var builder = GetQueryBuilder();

            var query = builder.Build<IAnotherQuery>(p => p.Id, 3).SetAndReturn(p => p.Name, "Jirka");

            Assert.IsTrue(query.Id == 3);

            Assert.IsTrue(query.Name == "Jirka");
        }

        private IQueryBuilder Builder()
        {
            return GetQueryBuilder();
        }

        private IQueryBuilder GetQueryBuilder()
        {
            var queryFactory = _container.Resolve<IQueryFactory>();
            var queryBuilder = new QueryBuilder(queryFactory);
            return queryBuilder;
        }
    }

    public class AnotherQuery : BaseQuery<object, string>, IAnotherQuery
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IAnotherQuery : IQuery
    {
        int Id { get; set; }
        string Name { get; set; }
    }


    public class SomeQuery : BaseQuery<object, object>, ISomeQuery
    {
        public int Id { get; set; }
    }
}