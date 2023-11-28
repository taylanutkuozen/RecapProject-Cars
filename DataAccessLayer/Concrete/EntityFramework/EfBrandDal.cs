using Core.DataAccess.EntityFramework;
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
    public class EfBrandDal : EfEntityRepositoryBase<Brand,RecapProjectDbContext>,IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RecapProjectDbContext context=new())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Brand entity)
        {
            using (RecapProjectDbContext context=new())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RecapProjectDbContext context=new())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RecapProjectDbContext context=new())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }
        public void Update(Brand entity)
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
