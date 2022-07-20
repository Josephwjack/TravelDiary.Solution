using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelDiary.Models;
using System.Collections.Generic;

namespace TravelDiary.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "test";
      Place newPlace = new Place(cityName);

      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      string cityName = "test";
      Place newPlace = new Place(cityName);

      string updatedCityName = "newtest";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newList = new List<Place> { };

      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string cityName = "Cozumel";
      Place newPlace = new Place(cityName);

      //Act
      int result = newPlace.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}