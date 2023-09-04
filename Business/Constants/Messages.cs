using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";

        public static string ProductNameInvalid = "Product name is invalid.";

        public static string MaintenanceTime = "System is on Maintenance Time.";

        public static string ProductsListed = "Products has been listed.";

        public static string ProductCountOfCategoryError = "Product count of category is maximum 10.";

        public static string ThisProductNameIsExist = "This Product name is unavalible";

        public static string CategoryLimitExceed = "This category limit is exceded";

        public static string AuthorizationDenied = "Authorization is denied.";

        public static string UserRegistered = "User registered successfuly.";

        public static string UserNotFound = "User did not found.";

        public static string WrongPassword = "Wrong Password";

        public static string SuccessLogin = "Logined succesfully.";

        public static string UserExist = "The user is exist";

        public static string TokenCreated = "Token created succesfully";
    }
}
