using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>  //veriler ekleniyor..
            {
                new Car {Id=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=5000000, Description="Mercedes S-Class"},
                new Car {Id=2, BrandId=2, ColorId=2, ModelYear=2020, DailyPrice=1000000, Description="Volkswogen Passat"},
                new Car {Id=3, BrandId=2, ColorId=3, ModelYear=2019, DailyPrice=700000, Description="Volkswogen Arteon"},
                new Car {Id=4, BrandId=3, ColorId=4, ModelYear=2021, DailyPrice=2000000, Description="Audi Q8 Quattro"},
                new Car {Id=5, BrandId=4, ColorId=5, ModelYear=2020, DailyPrice=1500000, Description="BMW M5"},
                new Car {Id=6, BrandId=3, ColorId=6, ModelYear=2018, DailyPrice=500000, Description="Volkswogen Jetta"}
            };
        }

        //--------------------------//
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
