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
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;
        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }
        public void Add(Colour colour)
        {
            _colourDal.Add(colour);
        }
        public void Delete(Colour colour)
        {
            _colourDal.Delete(colour);
        }
        public List<Colour> GetAllByColourId(int id)
        {
            return _colourDal.GetAll(c=>c.ColourId == id);
        }
        public List<Colour> GetAllColour()
        {
            return _colourDal.GetAll();
        }
        public void Update(Colour colour)
        {
            _colourDal.Update(colour);
        }
    }
}