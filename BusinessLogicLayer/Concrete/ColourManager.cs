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
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;
        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }
        public IResult Add(Colour colour)
        {
            _colourDal.Add(colour);
            return new SuccessResult(Messages.ColourAdded);
        }
        public IResult Delete(Colour colour)
        {
            _colourDal.Delete(colour);
            return new SuccessResult(Messages.ColourDeleted);
        }
        public IDataResult<List<Colour>> GetAllByColourId(int id)
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll(c=>c.ColourId == id));
        }
        public IDataResult<List<Colour>> GetAllColour()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll());
        }
        public IResult Update(Colour colour)
        {
           _colourDal.Update(colour);
            return new SuccessResult(Messages.ColourUpdated);
        }
    }
}