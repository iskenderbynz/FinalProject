using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Aynı kategoride toplam 10 ürün girişi yapılabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimden farklı bir ürün daha eklenemez.";
    }
}
