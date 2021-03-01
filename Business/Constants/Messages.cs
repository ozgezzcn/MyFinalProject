using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz!";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi ";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Olabilir!";
        internal static string ProductNameAlreadyExists = "Bu İsimde Zaten Başka Bir Ürün Var";

        public static string CategoryLimitExceded = "Kategori Limiti Aşıldığından Dolayı Yeni Ürün Eklenemiyor.";
        public static  string AuthorizationDenied= "Yetkiniz Yok";
    }
}
