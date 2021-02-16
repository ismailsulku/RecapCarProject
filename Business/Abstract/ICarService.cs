using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //Business katmanının Car nesnesiyle ilgili interface i yazılmıştır.
    public interface ICarService
    {
        List<Car> GetDetailDto();
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<Car> GetCarsBrandId(int id);
        List<Car> GetCarsColorId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
    }
}
