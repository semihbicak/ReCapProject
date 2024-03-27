using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; // Class içinde ama methodların dışında olduğu için global değişkendir. "_" ile başlar değişken. Naming commention
        public InMemoryCarDal()
        {
            // Veritabanından geliyor bu veriler.
            _cars = new List<Car> {
                new Car {Id =1,BrandId=1,ColorId=1,DailyPrice=2500,Description="Passat",ModelYear=2023},
                new Car {Id =2,BrandId=1,ColorId=3,DailyPrice=2500,Description="Golf",ModelYear=2021},
                new Car {Id =3,BrandId=2,ColorId=1,DailyPrice=2500,Description="Ford Focus",ModelYear=2020},
                new Car {Id =4,BrandId=2,ColorId=1,DailyPrice=2500,Description="Ford Connect",ModelYear=2022},
                new Car {Id =5,BrandId=3,ColorId=3,DailyPrice=2500,Description="Honda",ModelYear=2024}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =_cars.SingleOrDefault(c=>c.Id == car.Id); // SingleOrDefault(c=>) bu kod foreach gibi listeyi tek tek dolaşmaya yarar.
            _cars.Remove(carToDelete);
        }


        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars; //Veritabanının tümünü döndürüyor
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public List<Car> GetById(int carId)
        {
            return _cars.Where(c=> c.Id == carId).ToList();  // Şarta uyan bütün elemanları yeni liste haline getirip oluşturur.
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id); // Güncellemek istediğin veriler tabloda bulunup,güncellenir.
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;  
        }
    }
}
