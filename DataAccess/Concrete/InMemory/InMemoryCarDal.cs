using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    public class InMemoryCarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>  //veriler ekleniyor..
        //    {
        //        new Car {CarId=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=5000000, Descriptions="Mercedes S-Class"},
        //        new Car {CarId=2, BrandId=2, ColorId=2, ModelYear=2020, DailyPrice=1000000, Descriptions="Volkswogen Passat"},
        //        new Car {CarId=3, BrandId=2, ColorId=3, ModelYear=2019, DailyPrice=700000, Descriptions="Volkswogen Arteon"},
        //        new Car {CarId=4, BrandId=3, ColorId=4, ModelYear=2021, DailyPrice=2000000, Descriptions="Audi Q8 Quattro"},
        //        new Car {CarId=5, BrandId=4, ColorId=5, ModelYear=2020, DailyPrice=1500000, Descriptions="BMW M5"},
        //        new Car {CarId=6, BrandId=3, ColorId=6, ModelYear=2018, DailyPrice=500000, Descriptions="Volkswogen Jetta"}
        //    };
        //}

        ////--------------------------//
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    _cars.Remove(carToDelete);
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetById(int id)
        //{
        //    return _cars.Where(c => c.CarId == id).ToList();
        //}

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Descriptions = car.Descriptions;
        //    carToUpdate.ModelYear = car.ModelYear;
        //}
    }
}
