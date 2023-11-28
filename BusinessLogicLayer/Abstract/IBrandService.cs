using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogicLayer.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAllBrand();
        List<Brand> GetAllByBrandId(int id);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}