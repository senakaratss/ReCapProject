using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=11,ModelYear=2015,DailyPrice=30,Description="aa"},
                new Car{Id=2,BrandId=1,ColorId=8,ModelYear=2023,DailyPrice=100,Description="bb"},
                new Car{Id=3,BrandId=2,ColorId=203,ModelYear=2000,DailyPrice=150,Description="cc"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p=>p.Id==id).ToList();   
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(p=>p.Id==car.Id);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
        }
    }
}
