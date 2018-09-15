using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Pagination;

namespace Olbrasoft.Data.Entity.Unit.Tests
{
    [TestFixture]
    class QueryableExtensionsTest
    {
        private ArgumentException _exception;
        private IQueryable<object> _source;


        [Test]
        public async Task Source_Throw_ArgumentNullException()
        {
            //Arrange
            var pagingMock = new Mock<IPageInfo>();
            _source = null;

            //Act
            try
            {
                await _source.ToPagedListAsync(pagingMock.Object);
            }
            catch (ArgumentException e)
            {

                _exception = e;
            }
            
            //Assert
            Assert.Multiple(() =>
            {
                Assert.IsInstanceOf<ArgumentNullException>(_exception);
                Assert.AreEqual("source", _exception.ParamName);
               
            });
        }

        [Test]
        public async Task Paging_throw_ArgumentNullException()
        {
            //Arrange
            _source=new List<object>().AsQueryable();

            //Act
            try
            {
                await _source.ToPagedListAsync(null);
            }
            catch (ArgumentException e)
            {
                _exception = e;
            }

            //Assert
            Assert.Multiple(() =>
            {
                Assert.IsInstanceOf<ArgumentNullException>(_exception);
                Assert.AreEqual("paging", _exception.ParamName);

            });
        }

        //[Test]
        //public void  Is_Instance_Of_Task()
        //{
        //    //Arrange
        //    _source = new List<object>().AsQueryable();
        //    var pagingMock = new Mock<IPageInfo>();
        //    pagingMock.Setup(p => p.PageSize).Returns(10);
        //    pagingMock.Setup(p => p.NumberOfSelectedPage).Returns(1);
            
        //    //Act
        //    var resultTask = _source.ToPagedListAsync(pagingMock.Object);
        //    var result =  resultTask.Result;


        //    //Assert
        //    Assert.IsInstanceOf<Task<PagedList<object>>>(resultTask);
        //}
    }
}
