using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService  //bu iş katmanında kullanacağımız servis elemanı
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
