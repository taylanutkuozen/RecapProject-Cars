﻿using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,RecapProjectDbContext>, IRentalDal
    {

    }
}
