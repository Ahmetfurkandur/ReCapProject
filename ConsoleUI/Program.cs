﻿using Business.Concrete.Managers;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
//using Entities.Concrete;
using System.Drawing;

namespace ConsoleUI
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //GetAllColors();
            //CarDetailTest();
            //BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void GetAllColors()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        //private static void GetCarsByBrandId()
        //{
        //    Console.WriteLine("Marka Id'sini giriniz: ");
        //    int brandId = Convert.ToInt32(Console.ReadLine());

        //    foreach (var car in _carManager.GetCarsByBrandId(brandId))
        //    {
        //        Console.WriteLine("Filtered Car List: " + car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
        //    }

        //}

        //private static void GetCarsByColorId()
        //{
        //    Console.WriteLine("Renk Id'sini giriniz: ");
        //    int colorId = Convert.ToInt32(Console.ReadLine());

        //    foreach (var car in _carManager.GetCarsByBrandId(colorId))
        //    {
        //        Console.WriteLine("Filtered Car List: " + car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
        //    }

        //}

        static void CarDetailTest()
        {
            CarManager _carManager = new CarManager(new EfCarDal());
            foreach (var car in _carManager.GetCarDetails())
            {
                Console.WriteLine("Car List: " + car.CarName + " " + car.BrandName + " " + car.DailyPrice + " " + car.ColorName);
            }
        }

        //static void Add()
        //{

        //    Console.WriteLine("Arabanın renk Id'sini giriniz: ");
        //    int colorId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Arabanın marka Id'sini giriniz: ");
        //    int brandId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Arabanın kaç model olduğunu giriniz: ");
        //    int modelYear = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Günlük fiyatı giriniz: ");
        //    int dailyPrice = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Açıklama (örn: arabanın markası) giriniz: ");
        //    string description = Console.ReadLine();

        //    Car car = new Car()
        //    {
        //        ColorId = colorId,
        //        BrandId = brandId,
        //        ModelYear = modelYear,
        //        DailyPrice = dailyPrice,
        //        Description = description
        //    };

        //    _carManager.Add(car);

        //}
    }
}