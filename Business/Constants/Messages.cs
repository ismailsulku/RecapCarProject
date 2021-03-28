using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi..";
        public static string CarDescriptionInvalid = "Araç Açıklaması Geçersiz..";
        public static string CarDeleted = "Araç Silindi..";
        public static string CarUpdated = "Araç Güncellendi..";
        public static string CarsListed = "Tüm Araçlar Listelendi..";
        public static string MaintenanceTime = "Sistem Bakımda..";

        public static string AddedRental = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";

        public static string AddedBrand = "Marka eklendi.";
        public static string DeletedBrand = "Marka silindi.";
        public static string UpdatedBrand = "Marka güncellendi.";

        public static string AddedColor = "Renk eklendi.";
        public static string DeletedColor = "Renk silindi.";
        public static string UpdatedColor = "Renk güncellendi.";

        public static string AddedUser = "Kullanıcı başarıyla eklendi.";
        public static string DeletedUser = "Kullanıcı başarıyla silindi.";
        public static string UpdatedUser = "Kullanıcı başarıyla güncellendi.";

        public static string AddedCustomer = "Müşteri başarıyla eklendi.";
        public static string DeletedCustomer = "Müşteri başarıyla silindi.";
        public static string UpdatedCustomer = "Müşteri başarıyla güncellendi.";

        public static string AddedCar = "Araba başarıyla eklendi.";
        public static string DeletedCar = "Araba başarıyla silindi.";
        public static string UpdatedCar = "Araba başarıyla güncellendi.";
        public static string FailedCarAddOrUpdate = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";

        public static string AddedCarImage = "Araba resmi eklendi";
        public static string DeletedCarImage = "Araba resmi silindi";
        public static string FailedCarImageAdd = "Araba resmi eklenirken hata meydana geldi";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string SuccessFullLogin = "Başarıyla giriş yapıldı.";
        public static string PasswordError = "Parola yanlış";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";

        //public static string CarHaveNoImage = "Arabaya ait bi resim yok";
        //public static string ImageLimitExpiredForCar = "Bir arabaya maximum 5 fotoğraf eklenebilir";
        //public static string CarImageMustBeExists = "Böyle bi resim bulunamadı";
        //public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
        internal static string InvalidImageExtension;
        internal static string ImageLimitExpiredForCar;
        internal static string CarImageMustBeExists;
        internal static string CarHaveNoImage;

        public static string CardUpdated { get; internal set; }
        public static string CardDeleted { get; internal set; }
        public static string CardAdded { get; internal set; }
        public static string CardAlreadyExists { get; internal set; }
    }
}
