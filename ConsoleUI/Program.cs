using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal()); //hangi veri yöntemiyle çalıştığımızı yazıyoruz.. 

            //Database imizdeki tüm araçları yazdıralım...
            Console.WriteLine("****Galerideki Tüm Araçlar****");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " Model " + car.Description + " : " + car.DailyPrice + "TL");
            }

            Console.WriteLine("----------------------------------");
            
            //Araç Ekleme ve Araç Listesini Gösterme

            Car car1 = new Car() {Id=7 , BrandId=5, ColorId=7, DailyPrice=200000 , Description="Opel Astra", ModelYear=2018};
            carManager.Add(car1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " Model " + car.Description + " : " + car.DailyPrice + "TL");
                
            }
            Console.WriteLine("Listeye Yeni Araç Eklendi.");
            Console.WriteLine("----------------------------------");

            //Araç Silme ve Araç Listesini Gösterme

            carManager.Delete(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " Model " + car.Description + " : " + car.DailyPrice + "TL");

            }

            Console.WriteLine("Listeye Eklenen Araç Silindi.");
            Console.WriteLine("----------------------------------");

            //Araç Düzenleme ve Araç Listesini Gösterme

            Car car5 = new Car() { Id = 5, BrandId = 4, ColorId = 5, ModelYear = 2018, DailyPrice = 1300000, Description = "BMW M4" };
            carManager.Update(car5);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " Model " + car.Description + " : " + car.DailyPrice + "TL");
            }

            Console.WriteLine("5.Sıradaki Aracımız Günecellenmiştir.");
            Console.WriteLine("----------------------------------");

            //Araçları Id numarasına göre yazdırma
            Console.WriteLine("İstenen Id nolu Araçlarımızın Listesi");
            carManager.GetById(3);
            carManager.GetById(1);
            carManager.GetById(5);
            Console.WriteLine("----------------------------------");

        }
    }
}
