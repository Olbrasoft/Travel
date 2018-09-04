using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared;

namespace Olbrasoft.Data.Entity.UnitTest
{
    [TestFixture]
    public class LocalizedQueryTest
    {
        [Test]
        public void SomeLocalizedQuery_is_instance_of_LocalizeQuery()
        {
            //Arrange
            var type = typeof(LocalizeQuery<object>);

            //Act
            SomeLocalizedQuery someLocalizedQuery = CreateSomeLocalizedQuery();

            //Assert
            Assert.IsInstanceOf(type, someLocalizedQuery);
        }
        

        [Test]
        public void Is_Instance_Of_IQuery()
        {
            //Arrange
            var type = typeof(IQuery<object>);

          

            //Act
            var someLocalizedQuery = CreateSomeLocalizedQuery();

            //Assert
            Assert.IsInstanceOf(type, someLocalizedQuery);
        }


        [Test]
        public void LanguageId_is_1029()
        {
            //Arrange
            var someLocalizedQuery = CreateSomeLocalizedQuery();

            //Act
            var languageId = someLocalizedQuery.LanguageId;

            //Assert
            Assert.IsTrue(languageId==1029);


        }


        private static SomeLocalizedQuery CreateSomeLocalizedQuery()
        {
            var mockLanguageService = new Mock<ILanguageService>();
            mockLanguageService.Setup(p => p.CurrentLanguageId).Returns(1029);

            return new SomeLocalizedQuery(mockLanguageService.Object);
        }

    }

    public class SomeLocalizedQuery : LocalizeQuery<object>
    {
        public new int LanguageId => base.LanguageId;

        public override object Execute()
        {
            throw new System.NotImplementedException();
        }

        public SomeLocalizedQuery(ILanguageService languageService) : base(languageService)
        {
        }
    }
}