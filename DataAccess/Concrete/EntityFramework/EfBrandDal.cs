using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Model.Data;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, DatabaseContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from b in context.Brands
                             join c in context.Cars 
                             on b.BrandId equals c.BrandId
                             join bc in context.BrandColors
                             on b.BrandId equals bc.BrandId
                             join co in context.Colors
                             on bc.ColorId equals co.ColorId
                             select new BrandDetailDto
                             {
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ColorName = co.ColorName
                             };
                return result.ToList();
            }
            
        }
    }
}
