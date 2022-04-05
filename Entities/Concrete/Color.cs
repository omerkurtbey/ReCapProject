using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public ICollection<BrandColor> BrandColors { get; set; } //Marka ve Renk arasında many many ilişkisi

        public ICollection<CarColor> CarColors { get; set; }// Araba ve Renk arasında many many ilişkisi
    }
}
