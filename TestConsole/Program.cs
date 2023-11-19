using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;
CarManager carManager = new CarManager(new EfCarDal());
List<Car> cars;
cars = carManager.GetAllCars();
foreach (Car car in cars)
{
    Console.WriteLine(car.BrandId + " " + car.ModelYear + " " + car.Description);
}
foreach (Car car in carManager.GetAllByBrandId(1))
{
    Console.WriteLine(car.BrandId + " " + car.ModelYear + " " + car.Description);
}
foreach (Car car in carManager.GetByDailyPrice(1,900000))
{
    Console.WriteLine(car.BrandId + " " + car.ModelYear + " " + car.Description);
}
Console.ReadLine();