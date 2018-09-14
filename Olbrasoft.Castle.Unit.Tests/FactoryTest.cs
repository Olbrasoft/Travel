using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Olbrasoft.Castle.Unit.Tests
{
    [TestFixture()]
    class FactoryTest
    {
        [Test]
        public void MyTestMethod()
        {
            //Arrange
            var type = typeof(ISomeFactory);



            //Act



            //Assert

        }

    }

    internal interface ISomeFactory
    {
                  
    }

    interface ISome {}


    interface ISomeOne:ISome
    {
        int Id { get; set; }    
    }



    interface ISomeTwo:ISome
    {
        Guid Id { get; set; }
    }




    class SomeOne :ISomeOne
    {
        public int Id { get; set; }
    }
    

    class SomeTwo:ISomeTwo
    {
        
        public Guid Id { get; set; }
    }







}
