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
        public static string ProductCountOfCategoryError = "Aynı kategoride toplam 10 ürün girişi yapılabilir";
        public static string ProductNameAlreadyExists = "Aynı isimden farklı bir ürün daha eklenemez";
        public static string CheckIfCategoryCount = "15 den fazla kategori olduğu için ürün eklenemez";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
