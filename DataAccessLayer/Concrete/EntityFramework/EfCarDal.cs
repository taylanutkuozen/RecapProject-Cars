using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RecapProjectDbContext context=new())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Car entity)
        {
            using (RecapProjectDbContext context=new())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RecapProjectDbContext context=new())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RecapProjectDbContext context=new())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }
        public void Update(Car entity)
        {
            using (RecapProjectDbContext context=new())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}