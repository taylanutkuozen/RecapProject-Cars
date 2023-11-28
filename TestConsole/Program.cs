using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;
CarManager carManager = new CarManager(new EfCarDal());
//Car car1 = new Car { BrandId=2, ColorId=5,CarName="City",ModelYear="2022",Description="İlk sahibinden tertemiz",DailyPrice=950000 };
//carManager.Add(car1);
foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine(car.CarName + " " + car.BrandName + " " + " " + car.ColourName + " " + car.DailyPrice);
}
List<Car> cars;
cars = carManager.GetAllCars();
foreach (Car car in cars)
{
    Console.WriteLine(car.BrandId + " " + car.ModelYear + " " + car.Description);
}
//foreach (Car car in carManager.GetAllByBrandId(1))
//{
//    Console.WriteLine(car.BrandId + " " + car.ModelYear + " " + car.Description);
//}
foreach (Car car in carManager.GetByDailyPrice(1,900000))
{
    Console.WriteLine(car.BrandId + " " + car.ModelYear + " " + car.Description);
}
ColourManager colourManager = new ColourManager(new EfColourDal());
//colourManager.Add(new Colour { ColourName = "Gümüş Gri" });
//colourManager.Add(new Colour { ColourName = "Mor" });
List<Colour> colours = colourManager.GetAllColour();
//foreach(Colour color in colours)
//{
//    Console.WriteLine(color.ColourId+" "+color.ColourName);
//}
//colourManager.Update(new Colour { ColourId = 2, ColourName = "Siyah" });
//colours = colourManager.GetAllColour();
//foreach (Colour color in colours)
//{
//    Console.WriteLine(color.ColourId + " " + color.ColourName);
//}
//Colour bordo = new Colour { ColourName = "Bordo" };
//colourManager.Add(bordo);
//colours = colourManager.GetAllColour();
//foreach (Colour color in colours)
//{
//    Console.WriteLine(color.ColourId + " " + color.ColourName);
//}
//colourManager.Delete(bordo);
//colours = colourManager.GetAllColour();
//foreach (Colour color in colours)
//{
//    Console.WriteLine(color.ColourId + " " + color.ColourName);
//}
BrandManager brandManager=new BrandManager(new EfBrandDal());
//brandManager.Add(new Brand { BrandName = "Ford" });
//brandManager.Add(new Brand { BrandName = "Chevrolet" });
List<Brand> brands = brandManager.GetAllBrand();
//foreach (var brand in brands)
//{
//    Console.WriteLine(brand.BrandId + " " + brand.BrandName);
//}
//brandManager.Update(new Brand { BrandId = 2, BrandName = "Honda" });
Brand dodge = new Brand { BrandName = "Dodge" };
brandManager.Add(dodge);
brands = brandManager.GetAllBrand();
foreach (var brand in brands)
{
    Console.WriteLine(brand.BrandId + " " + brand.BrandName);
}
brandManager.Delete(dodge);
brands = brandManager.GetAllBrand();
foreach (var brand in brands)
{
    Console.WriteLine(brand.BrandId + " " + brand.BrandName);
}
Console.ReadLine();