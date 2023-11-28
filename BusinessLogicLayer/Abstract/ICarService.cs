using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogicLayer.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetAllByBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}