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
        Car newCar = new Car (Request.Query["new-model"]);
        return View["view_all_cars.cshtml", newCar];
      };
    }
  }
}
