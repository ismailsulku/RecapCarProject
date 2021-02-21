using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetById(int id);

        List<CarDetailDto> GetCarDetails(System.Linq.Expressions.Expression<Func<Car, bool>> filter);
    }
}
