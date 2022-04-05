using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //Marka ile ilgili bilgileri dışarıya veren sınıf
    public interface IBrandService
    {
        List<Brand> GetAll();
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);

        List<BrandDetailDto> GetBrandDetails();
    }
}
