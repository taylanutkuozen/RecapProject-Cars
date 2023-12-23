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
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal= userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }
        public IDataResult<List<User>> GetAllCustomerByUserId(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.ID==id));
        }
        public IDataResult<List<User>> GetAllUser()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }
        public IResult Update(User user)
        {
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}