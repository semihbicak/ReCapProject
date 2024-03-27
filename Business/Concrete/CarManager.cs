using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

<<<<<<< HEAD
        public void Add(Car car)
        {
            Console.WriteLine((car.Description.Length > 2 && car.DailyPrice > 0) ? "araç eklendi" : "araç bilgileri hatalı");
            _carDal.Add(car);
        }

=======
>>>>>>> b63a759589c960f81c7c9f0cf0fd6f1454cdac45
        public List<Car> GetAll() // İş sınıfı başka sınıfları new'lemez.
        {
            return _carDal.GetAll(); 
        }
<<<<<<< HEAD

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p=> p.ColorId == id);
        }
=======
>>>>>>> b63a759589c960f81c7c9f0cf0fd6f1454cdac45
    }
}
