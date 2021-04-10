using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentalCarContext>, ICustomerDal
    {
        public Customer GetByEmail(Expression<Func<Customer, bool>> filter)
        {
            using (var context = new RentalCarContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new CustomerDetailDto
                             {
                                 Id = customer.Id,
                                 UserId = customer.UserId,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 CompanyName = customer.CompanyName,
                                 FindexPoint = (int)customer.FindexPoint
                             };

                return result.SingleOrDefault(filter);
            }
        }

        public List<Customer> GetCustomerDetails()
        {
            using (var context = new RentalCarContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new CustomerDetailDto
                             {
                                 Id = customer.Id,
                                 UserId = customer.UserId,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 CompanyName = customer.CompanyName,
                                 FindexPoint = (int)customer.FindexPoint
                             };

                return result.ToList();
            }
        }
    }
}
