using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //Car List
            GetCarList(carManager);

            //Customer List
            GetCustomerList(customerManager);

            //Rental Car (Araba Listesi ve Müşteri listesine göre Araba Kiralama işlemi)
            RentalCarAdded(rentalManager);
        }

        private static void RentalCarAdded(RentalManager rentalManager)
        {
            Console.WriteLine("Car Id: ");
            int carIdForAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer Id: ");
            int customerIdForAdd = Convert.ToInt32(Console.ReadLine());

            Rental rentalForAdd = new Rental
            {
                CarId = carIdForAdd,
                CustomerId = customerIdForAdd,
                RentDate = DateTime.Now,
                ReturnDate = null,
            };

            Console.WriteLine(rentalManager.Add(rentalForAdd).Message);
        }

        private static void GetCustomerList(CustomerManager customerManager)
        {
            Console.WriteLine("Müşterilerin Listesi: \nId\tKullanıcı Id\tCustomer Name");
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine($"{customer.Id}\t{customer.Id}\t{customer.CustomerName}");
            }
        }

        private static void GetCarList(CarManager carManager)
        {
            Console.WriteLine("Arabaların detaylı listesi:  \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"{car.CarId}\t{car.ColorName}\t\t{car.BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }
        }
    }
}

