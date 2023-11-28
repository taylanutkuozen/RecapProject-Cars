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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }
        public List<Brand> GetAllByBrandId(int id)
        {
            return _brandDal.GetAll(b => b.BrandId == id);
        }
        public List<Brand> GetAllBrand()
        {
            return _brandDal.GetAll();
        }
        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
    }
}