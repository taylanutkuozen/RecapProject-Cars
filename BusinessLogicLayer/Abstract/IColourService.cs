using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogicLayer.Abstract
{
    public interface IColourService
    {
        List<Colour> GetAllColour();
        List<Colour> GetAllByColourId(int id);
        void Add(Colour colour);
        void Update(Colour colour);
        void Delete(Colour colour);
    }
}