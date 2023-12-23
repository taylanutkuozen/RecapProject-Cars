using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Constants;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if(car.CarName.Length>2 && car.DailyPrice>0)
            {
                return new ErrorResult(Messages.CarNameInValid);
            }
            return new SuccessResult(Messages.CarAdded);
        }
        public IResult Delete(Car car)
        {
            _cardal.Delete(car);
            return new SuccessResult(Messages.ProductDeleted);
        }
        public IDataResult<Car> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<Car>(_cardal.Get(c => c.CarId == id),Messages.CarListedByBrand);
        }
        public IDataResult<List<Car>> GetAllCars()
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(),Messages.CarListed);
        }
        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
          return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetails());
        }
        public IResult Update(Car car)
        {
            _cardal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}