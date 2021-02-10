using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //Business katmanının Car nesnesiyle ilgili interface i yazılmıştır.
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
