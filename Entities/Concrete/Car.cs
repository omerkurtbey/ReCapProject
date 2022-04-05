using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        public ICollection<CarColor> CarColors { get; set; } //Araba ve Renk arasında ki many many ilişkisi

        public int BrandId { get; set; }
        public Brand Brand { get; set; }                                                  
    }
}
