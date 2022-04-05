using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Brand :IEntity
    {
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public ICollection<BrandColor> BrandColors { get; set; } //Marka ve Renk arasında many many ilişkisi

        public ICollection<Car> Cars { get; set; } //Araba ve Marka arasında one many ilişkisi
    }
}
