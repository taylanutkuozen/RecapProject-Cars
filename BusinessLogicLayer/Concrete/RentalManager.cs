using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Constants;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogicLayer.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal=rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate!=null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentAdded);
            }
            return new ErrorResult(Messages.RentError);
        }
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentDeleted);
        }
        public IDataResult<List<Rental>> GetAllByRentId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=>r.ID==id));
        }
        public IDataResult<List<Rental>> GetAllRent()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdatedRent);
        }
    }
}