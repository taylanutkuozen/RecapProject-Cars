using Core.Utilities.Results;
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
        IDataResult<List<Colour>> GetAllColour();
        IDataResult<List<Colour>> GetAllByColourId(int id);
        IResult Add(Colour colour);
        IResult Update(Colour colour);
        IResult Delete(Colour colour);
    }
}