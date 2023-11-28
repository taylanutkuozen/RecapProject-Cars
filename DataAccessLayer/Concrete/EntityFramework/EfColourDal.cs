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
    public class EfColourDal : EfEntityRepositoryBase<Colour,RecapProjectDbContext>, IColourDal
    {
        public void Add(Colour entity)
        {
            using (RecapProjectDbContext context=new())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Colour entity)
        {
            using (RecapProjectDbContext context=new())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public Colour Get(Expression<Func<Colour, bool>> filter)
        {
            using (RecapProjectDbContext context=new())
            {
                return context.Set<Colour>().SingleOrDefault(filter);
            }
        }
        public List<Colour> GetAll(Expression<Func<Colour, bool>> filter = null)
        {
            using (RecapProjectDbContext context=new())
            {
                return filter == null ? context.Set<Colour>().ToList() : context.Set<Colour>().Where(filter).ToList();
            }
        }
        public void Update(Colour entity)
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