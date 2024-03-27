using Business.Concrete;
<<<<<<< HEAD
using DataAccess.Concrete.EntityFramework;
=======
>>>>>>> b63a759589c960f81c7c9f0cf0fd6f1454cdac45
using DataAccess.Concrete.InMemory;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args) 
        {
<<<<<<< HEAD
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

            }
            Console.WriteLine("------------");

            foreach (var car in carManager.GetCarsByBrandId(6))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------");

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("---------------------");
            foreach (var car in carManager.GetByDailyPrice(700000, 900000))
            {
                Console.WriteLine(car.Description);
=======
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " "+car.Description);



                
>>>>>>> b63a759589c960f81c7c9f0cf0fd6f1454cdac45
            }
        }
    }

}