using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Repository;
using Olbrasoft.Travel.Data.Entity.Repository.Identity;
using Olbrasoft.Travel.Data.Repository;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Repository
{
    [TestFixture]
    internal class UsersRepositoryTest
    {
        [Test]
        public void Instance_Is_BaseRepository_Of_User()
        {
            //Arrange
            var type = typeof(BaseRepository<Model.Identity.User>);

            //act
            var repository = CreateRepository();

            //Assert
            Assert.IsInstanceOf(type, repository);
        }
        
        [Test]
        public void Instance_Implement_Interface_IUsersRepository()
        {
            //Arrange
            var type = typeof(IUsersRepository);

            //Act
            var repository = CreateRepository();

            //Assert
            Assert.IsInstanceOf(type, repository);
        }


        [Test]
        public void Instance_Is_IdentityRepository_Of_User()
        {
            //Arrange
            var type = typeof(IdentityRepository<Model.Identity.User>);

            //Act
            var repository = CreateRepository();


            //Assert
            Assert.IsInstanceOf(type, repository);

        }

        private static UsersRepository CreateRepository()
        {
            var dboContextMock = new Mock<Entity.IdentityDatabaseContext>();

            var repository = new UsersRepository(dboContextMock.Object);
            return repository;
        }
    }
}