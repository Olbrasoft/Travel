using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Olbrasoft.DataAccessLayer.UnitTest
{
    [TestFixture()]
    public class QueryTest
    {
        [Test]
        public void IsInstanceOfIQuery()
        {
            //Arrange

            //Act
            var query = new Query<SomeItem>();



            //Assert
            Assert.IsInstanceOf<IQuery<SomeItem>>(query);

        }
    }
}
