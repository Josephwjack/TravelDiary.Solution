using System;
using System.Collections.Generic;


namespace TravelDiary.Models
{
  public class Place
  {
    // auto implemented properties
    
    public string CityName { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Image { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};

    public Place(string cityName, string description, string date, string image)
    {
      CityName = cityName;
      Description = description;
      Date = date;
      Image = image;
      _instances.Add(this);
      Id = _instances.Count;

    }

     public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
  }
}