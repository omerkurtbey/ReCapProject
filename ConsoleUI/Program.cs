using Business.Concrete;
using DataAccess;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();


            
            Console.ReadLine();
        }


        

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetBrandDetails())
        //    {
        //        Console.WriteLine(brand.BrandName + " / " + brand.Description + " / " + brand.DailyPrice + " / " + brand.ModelYear);
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine($"{car.Id} numaralı aracın renk numarası :  {car.ColorId} dır. {car.DailyPrice} Fiyatından satılmaktadır. {car.ModelYear} modeldir ");
        //    }
        //}
    }
}
