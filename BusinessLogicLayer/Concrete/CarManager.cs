using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogicLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;
        public CarManager(ICarDal carDal)
        {
            _cardal = carDal;
        }

        public void Add(Car car)
        {
            if(car.CarName.Length>2 && car.DailyPrice>0)
                _cardal.Add(car);
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _cardal.GetAll(c => c.CarId == id);
        }

        public List<Car> GetAllCars()
        {
            return _cardal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _cardal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }
    }
}