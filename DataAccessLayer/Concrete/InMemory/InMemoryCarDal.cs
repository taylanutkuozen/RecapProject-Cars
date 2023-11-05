using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2017",DailyPrice=700.000M,Description="2.El Araba"},
            new Car{CarId=2,BrandId=2,ColorId=2,ModelYear="2018",DailyPrice=720.000M,Description="2.El Araba"},
            new Car{CarId=3,BrandId=3,ColorId=3,ModelYear="2019",DailyPrice=750.000M,Description="2.El Araba"},
            new Car{CarId=4,BrandId=4,ColorId=4,ModelYear="2020",DailyPrice=780.000M,Description="2.El Araba"},
            new Car{CarId=5,BrandId=5,ColorId=5,ModelYear="2021",DailyPrice=800.000M,Description="2.El Araba"},
            new Car{CarId=6,BrandId=6,ColorId=6,ModelYear="2022",DailyPrice=825.000M,Description="2.El Araba"},
            new Car{CarId=7,BrandId=7,ColorId=7,ModelYear="2023",DailyPrice=900.000M,Description="Sıfır Kilometre Araba"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId== car.CarId);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public List<Car> GetAllById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }
        public void Update(Car car)
        {
           Car carToUpdate= _cars.SingleOrDefault(c=>c.CarId == car.CarId);
           carToUpdate.BrandId= car.BrandId;
           carToUpdate.ColorId= car.ColorId;
           carToUpdate.ModelYear= car.ModelYear;
           carToUpdate.Description= car.Description;
           carToUpdate.DailyPrice= car.DailyPrice;
        }
    }
}