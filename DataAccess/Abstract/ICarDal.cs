using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
<<<<<<< HEAD
    public interface ICarDal : IEntityRepository<Car>
    {
=======
    public interface ICarDal // Dal = Data Access Layer
    {
        List <Car> GetAll();    
        List <Car> GetById(int carId);    
        void Add(Car car);  
        void Update(Car car);  
        void Delete(Car car);  
>>>>>>> b63a759589c960f81c7c9f0cf0fd6f1454cdac45


    }
}
