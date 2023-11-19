using Entities.Concrete;
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
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        void Add(Car car);
    }
}