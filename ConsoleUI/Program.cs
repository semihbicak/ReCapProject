using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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

            RentalsTest();
        }

        private static void RentalsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental { CarId = 5, CustomerId = 4, RentDate = DateTime.Now };
            rentalManager.Add(rental);

            foreach (var Rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine($"{Rental.Id} / {Rental.CarId} / {Rental.CustomerId} / {Rental.RentDate} / {Rental.ReturnDate?.ToString()}");
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine($"{color.ColorName}");
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"Açıklama:{car.CarName} Marka:{car.BrandName} Renk:{car.ColorName} Fiyat:{car.DailyPrice}");

            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }

}