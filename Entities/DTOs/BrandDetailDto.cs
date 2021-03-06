using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BrandDetailDto :IDto
    {
        //Data Transformation Object
        //Join işlemlerinin yapılmasını sağlar

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
