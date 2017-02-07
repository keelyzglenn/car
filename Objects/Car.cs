using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _make;
    private string _model;
    private int _price;

    private static List<Car> _instances = new List<Car> {};

    public Car (string make, string model, int price)
    {
      _make = make;
      _model = model;
      _price = price;
    }
// car
    public string GetMake()
    {
      return _make;
    }

    public void SetMake(string newMake)
    {
      _make = newMake;
    }
// model
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
// price
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

// instances
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}




















































  //
  // public static void Main()
  // {
  //   Car porsche = new Car();
  //   porsche.MakeModel = "2014 Porsche 911";
  //   porsche.Price = 114991;
  //   porsche.Miles = 7864;
  //
  //   Car ford = new Car();
  //   ford.MakeModel = "2011 Ford F450";
  //   ford.Price = 55995;
  //   ford.Miles = 14241;
  //
  //   Car lexus = new Car();
  //   lexus.MakeModel = "2013 Lexus RX 350";
  //   lexus.Price = 44700;
  //   lexus.Miles = 20000;
  //
  //   Car mercedes = new Car();
  //   mercedes.MakeModel = "Mercedes Benz CLS550";
  //   mercedes.Price = 39900;
  //   mercedes.Miles = 37979;
  //
  //   List<Car> Cars = new List<Car>() { porsche, form, lexus, mercedes };
  //
  //   foreach(Car automobile in Cars)
  //   {
  //     Console.WriteLine(automobile.MakeModel);
  //   }
  //   Console.WriteLine("Enter maximum price: ");
  //   string stringMaxPrice
  // }
