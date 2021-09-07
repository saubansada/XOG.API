using XOG.Util;

namespace XOG
{
    public static class Constants
    {
        public static class Keys
        {
            public const string AnonymousUserIDCookieKey = "_AnonymousUserID__";
            public const string AvatarPathPerformanceKey = "_AvatarPathPerformanceKey__";
            public const string CurrentCultureCookieKey = "_CurrentCulture__";
            public const string CurrentCultureDirectionCookieKey = "_CurrentCultureDirection__";
            public const string CurrentCultureSessionKey = "_CurrentCultureSessionKey__";
            public const string GridViewSortDirection = "_GridViewSortDirection__";
            public const string GridViewSortExpression = "_GridViewSortExpression__";
            public const string GuestEmailIDCookieKey = "_GuestEmailID__";
            public const string PrintSettingsKey = "_PrintSettings__";
        }

        public static string Language(string key)
        {
            return key.ToFriendlyCase();
        }

        public static class Messages
        {
            public const string ADD_SUCCESS_MESSAGE = "Item added successfully";
            public const string DELETE_SUCCESS_MESSAGE = "Item deleted successfully";
            public const string ITEM_ALREADY_PRESENT = "Item already present";
            public const string ITEM_NOT_EXISTS_MESSAGE = "Item does not exists";
            public const string RELATED_RECORD_EXISTS_MESSAGE = "Item cannot be deleted as it has related records";
            public const string SAVE_SUCCESS_MESSAGE = "Item saved successfully";

            public static readonly string DB_CONTEXT_INIT_FAILED = Language("Failed To Initialize DB Context");

            public static readonly string ADDING = Language("Adding");
            public static readonly string UPDATING = Language("Updating");
            public static readonly string DELETING = Language("Deleting");

            public static readonly string PRODUCT = Language("Product");
            public static readonly string CATEGORY = Language("Category");
            public static readonly string SUB_CATEGORY = Language("SubCategory");
            public static readonly string BRAND = Language("Brand");
            public static readonly string CART = Language("Cart");


            public static readonly string ERROR = Language("Error") + " {0} {1} ";
             
            public static readonly string ERROR_ADDING_PRODUCT = string.Format(ERROR, ADDING, PRODUCT); 
            public static readonly string ERROR_UPDATING_PRODUCT = string.Format(ERROR, UPDATING, PRODUCT);
            public static readonly string ERROR_DELETING_PRODUCT = string.Format(ERROR, DELETING, PRODUCT);

            public static readonly string ERROR_ADDING_CATEGORY = string.Format(ERROR, ADDING, CATEGORY);
            public static readonly string ERROR_UPDATING_CATEGORY = string.Format(ERROR, UPDATING, CATEGORY);
            public static readonly string ERROR_DELETING_CATEGORY = string.Format(ERROR, DELETING, CATEGORY);

            public static readonly string ERROR_ADDING_SUB_CATEGORY = string.Format(ERROR, ADDING, SUB_CATEGORY);
            public static readonly string ERROR_UPDATING_SUB_CATEGORY = string.Format(ERROR, UPDATING, SUB_CATEGORY);
            public static readonly string ERROR_DELETING_SUB_CATEGORY = string.Format(ERROR, DELETING, SUB_CATEGORY);

            public static readonly string ERROR_ADDING_BRAND = string.Format(ERROR, ADDING, BRAND);
            public static readonly string ERROR_UPDATING_BRAND = string.Format(ERROR, UPDATING, BRAND);
            public static readonly string ERROR_DELETING_BRAND = string.Format(ERROR, DELETING, BRAND);

            public static readonly string ERROR_ADDING_CART = string.Format(ERROR, ADDING, CART);
            public static readonly string ERROR_UPDATING_CART = string.Format(ERROR, UPDATING, CART);
            public static readonly string ERROR_DELETING_CART = string.Format(ERROR, DELETING, CART);
        }
    }
}
