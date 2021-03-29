using Core.Entities.Concrete;
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
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başkabir ürün var";
        internal static string CategoryLimitExceded="Kategory limiti aıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static string SuccessfulLogin;
        internal static User PasswordError;
        internal static User UserNotFound;
        internal static string UserRegistered;
    }
}
