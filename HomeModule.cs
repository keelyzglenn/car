using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<string> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };

      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };

      Post["/car_added"] = _ => {
        Car newCar = new Car (Request.Form["new-car"]);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
    }
  }
}
