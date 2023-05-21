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
            public static readonly string PRODUCT_GROUP = Language("ProductGroup");
            public static readonly string QUANTITY_MEASURE = Language("QuantityMeasure");
            public static readonly string BRAND = Language("Brand");
            public static readonly string OFFER_BANNER = Language("OfferBanner");
            public static readonly string OFFER = Language("Offer");
            public static readonly string BANK_ACCOUNT = Language("BankAccount");
            public static readonly string REDEEM_REQUEST = Language("RedeemRequest");
            public static readonly string ADDRESS = Language("Address");
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


            public static readonly string ERROR_ADDING_PRODUCT_GROUP = string.Format(ERROR, ADDING, PRODUCT_GROUP);
            public static readonly string ERROR_UPDATING_PRODUCT_GROUP = string.Format(ERROR, UPDATING, PRODUCT_GROUP);
            public static readonly string ERROR_DELETING_PRODUCT_GROUP = string.Format(ERROR, DELETING, PRODUCT_GROUP);

            public static readonly string ERROR_ADDING_QUANTITY_MEASURE = string.Format(ERROR, ADDING, QUANTITY_MEASURE);
            public static readonly string ERROR_UPDATING_QUANTITY_MEASURE = string.Format(ERROR, UPDATING, QUANTITY_MEASURE);
            public static readonly string ERROR_DELETING_QUANTITY_MEASURE = string.Format(ERROR, DELETING, QUANTITY_MEASURE);

            public static readonly string ERROR_ADDING_BRAND = string.Format(ERROR, ADDING, BRAND);
            public static readonly string ERROR_UPDATING_BRAND = string.Format(ERROR, UPDATING, BRAND);
            public static readonly string ERROR_DELETING_BRAND = string.Format(ERROR, DELETING, BRAND);
             
            public static readonly string ERROR_ADDING_OFFER_BANNER = string.Format(ERROR, ADDING, OFFER_BANNER);
            public static readonly string ERROR_UPDATING_OFFER_BANNER = string.Format(ERROR, UPDATING, OFFER_BANNER);
            public static readonly string ERROR_DELETING_OFFER_BANNER = string.Format(ERROR, DELETING, OFFER_BANNER);
             
            public static readonly string ERROR_ADDING_OFFER = string.Format(ERROR, ADDING, OFFER);
            public static readonly string ERROR_UPDATING_OFFER = string.Format(ERROR, UPDATING, OFFER);
            public static readonly string ERROR_DELETING_OFFER = string.Format(ERROR, DELETING, OFFER);
             
            public static readonly string ERROR_ADDING_CART = string.Format(ERROR, ADDING, CART);
            public static readonly string ERROR_UPDATING_CART = string.Format(ERROR, UPDATING, CART);
            public static readonly string ERROR_DELETING_CART = string.Format(ERROR, DELETING, CART);

            public static readonly string ERROR_ADDING_DELIVERY_TIMINGS = string.Format(ERROR, ADDING, CART);
            public static readonly string ERROR_UPDATING_DELIVERY_TIMINGS = string.Format(ERROR, UPDATING, CART);
            public static readonly string ERROR_DELETING_DELIVERY_TIMINGS = string.Format(ERROR, DELETING, CART);

            public static readonly string ERROR_ADDING_BANK_ACCOUNT = string.Format(ERROR, ADDING, BANK_ACCOUNT);
            public static readonly string ERROR_UPDATING_BANK_ACCOUNT = string.Format(ERROR, UPDATING, BANK_ACCOUNT);
            public static readonly string ERROR_DELETING_BANK_ACCOUNT = string.Format(ERROR, DELETING, BANK_ACCOUNT);

            public static readonly string ERROR_ADDING_REDEEM_REQUEST = string.Format(ERROR, ADDING, REDEEM_REQUEST);
            public static readonly string ERROR_UPDATING_REDEEM_REQUEST = string.Format(ERROR, UPDATING, REDEEM_REQUEST);
            public static readonly string ERROR_DELETING_REDEEM_REQUEST = string.Format(ERROR, DELETING, REDEEM_REQUEST);

            public static readonly string ERROR_ADDING_ADDRESS = string.Format(ERROR, ADDING, ADDRESS);
            public static readonly string ERROR_UPDATING_ADDRESS = string.Format(ERROR, UPDATING, ADDRESS);
            public static readonly string ERROR_DELETING_ADDRESS = string.Format(ERROR, DELETING, ADDRESS);
        }
    }
}
