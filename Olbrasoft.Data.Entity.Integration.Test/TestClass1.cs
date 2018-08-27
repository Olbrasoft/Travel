using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Olbrasoft.Data.Entity.Integration.Test
{
    [TestFixture]
    public class TestClass1
    {

        public SomeContext SomeContext { get; set; }

        [SetUp]
        public void Setup()
        {
            SomeContext = new SomeContext();
        }


        [Test]
        public void MyTestMethod()
        {
            //Arrange
            var ctx = SomeContext;
            var se = new SomeEntity { };

            //Act
            ctx.SomeEntities.Add(se);
            ctx.SaveChanges();
            var c = ctx.SomeEntities.Count();

            //Assert
            Assert.IsTrue(c > 0);

        }

        
        [TearDown]
        public void Clean()
        {
            SomeContext.Database.Delete();
        }

    }


    public class SomeEntity
    {
        public int Id { get; set; }

    }

}
