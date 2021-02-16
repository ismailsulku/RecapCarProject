using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Business katmanında DataAccess katmanını kullanabilmek için constructor injection uygulandı.
    public class CarManager : ICarService
{
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        //---------------------------------//
        public void Add(Car car)
        {
            if (car.Description.Length >= 2)
            {
                if (car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Sıfırdan büyük bir değer giriniz.");
                }
            }
            else
            {
                Console.WriteLine("En az iki karakter giriniz.");
            }
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetDetailDto()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<Car> GetCarsBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}   
