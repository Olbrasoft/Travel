﻿using AutoMapper;
using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Mapping.Unit.Tests
{
    [TestFixture]
    internal class PhotoOfAccommodationToTypeOfRoomToPhotoToRoomTest
    {
        [Test]
        public void Instance_Is_Profile()
        {
            //Arrange
            var type = typeof(Profile);

            //Act
            var profile = new PhotoOfAccommodationToTypeOfRoomToPhotoToRoom();

            //Assert
            Assert.IsInstanceOf(type, profile);
        }
    }
}