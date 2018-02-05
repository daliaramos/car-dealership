using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _details;

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetPrice(int newPrice)
  {
    if (newPrice >= 0) {
      _price = newPrice;
    }
    else {
      Console.WriteLine("The price for this item is not valid.");
    }
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetDetails(string newDetails)
  {
    _details = newDetails;
  }
  public string GetDetails()
  {
    return _details;
  }

}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);
    porsche.SetDetails("This car goes fast!");

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);
    ford.SetDetails("This car is more affordable.");

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);
    lexus.SetDetails("This car is luxurious.");

    Car mercedes = new Car();
    mercedes.SetMakeModel("Merceded Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);
    mercedes.SetDetails("This car is not as expensive as the others.");

    List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes};

    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMileage = int.Parse(stringMaxMileage);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMileage)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    Console.WriteLine("here are the cars that match your search: ");
    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetDetails());
    }
  }
}
