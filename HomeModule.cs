using Nancy;
using Cars.Objects;
using System;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };

      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };

      Post["/car_added"] = _ => {
        string make = Request.Form["new-make"];
        string model = Request.Form["new-model"];
        int price = Request.Form["new-price"];
        Car newCar = new Car(make, model, price);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
    }
  }
}
