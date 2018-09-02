﻿using AutoMapper;
using Moq;
using NUnit.Framework;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;
using System.Linq;

namespace Olbrasoft.Travel.Business.UnitTest
{
    [TestFixture]
    internal class PagedListAutoMapperTest
    {
        [Test]
        public void PagedEnumerableMapper_Is_Instance_Of_IPagedEnumerableMapper()
        {
            //Arrange
            var type = typeof(IPagedListMapper<object, object>);
            var mapper = new Mock<IMapper>();

            //Act
            var pagedEnumerableMapper = new PagedListAutoMapper<object, object>(mapper.Object);

            //Assert
            Assert.IsInstanceOf(type, pagedEnumerableMapper);
        }

        [Test]
        public void Mapper_is_the_same_object_that_was_passed_as_an_argument_in_the_constructor()
        {
            //Arrange
            var mockMapper = new Mock<IMapper>();
            var pagedEnumerableMapper = new SomePagedListMapper<object, object>(mockMapper.Object);

            //Act
            var mapper = pagedEnumerableMapper.Mapper;

            //Assert
            Assert.AreSame(mockMapper.Object, mapper);
        }

        [Test]
        public void Map()
        {
            //Arrange
            var accommodtions = new[]
            {
                new Accommodation {Address = "Olbramovice Ves"},
                new Accommodation {Address= "Veselka 18"}
            };

            var pagedAccommodation = accommodtions.AsPagedList();
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AccommodationProfile>());
            var mapper = config.CreateMapper();
            var pagedMapper = new PagedListAutoMapper<Accommodation, AccommodationDto>(mapper);

            //Act
            var pagedAccommodationDataTransferObject = pagedMapper.Map(pagedAccommodation);

            //Assert

            Assert.IsTrue(pagedAccommodationDataTransferObject.Last()?.Address == "Veselka 18");
        }

        private class SomePagedListMapper<TSource, TDestination> : PagedListAutoMapper<TSource, TDestination>
        {
            public new IMapper Mapper => base.Mapper;

            public SomePagedListMapper(IMapper mapper) : base(mapper)
            {
            }
        }
    }
}