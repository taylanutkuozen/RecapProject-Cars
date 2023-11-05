using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;
CarManager carManager=new CarManager(new InMemoryCarDal());
List<Car> cars;
cars=carManager.GetAllCars();
foreach (Car car in cars)
{
    Console.WriteLine(car.ModelYear);
}
Console.ReadLine();