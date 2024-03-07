namespace XOG
{
    public enum BlinkRate
    {
        None,
        Slow,
        Regular,
        Fast,
    }

    public enum EventSchedule
    {
        UpComing,
        Past,
        All,
        Continuing,
    }

    public enum FieldWidth
    {
        xxsmall,
        xsmall,
        small,
        medium,
        large,
        largeXL,
        full,
    }

    public enum ApiResult
    {
        ValidationError = 0,
        Success = 1,
        Failure = 2,
        Error = 3
    }

    public enum FileType
    {
        Image,
        Document,
        PDF,
        Custom,
        All
    }

    public enum Gender
    {
        Male,
        Female,
        Unspecified,
    }

    public enum TransactionType
    {
        Debit = 0,
        Credit = 1
    }
    public enum TransactionFor
    {
        System = 0,
        Wallet = 1
    }

    public enum HashServiceProvider : int
    {
        SHA1,
        SHA256,
        SHA384,
        SHA512,
        MD5,
    }

    public enum LogType
    {
        Error,
        Activity
    }

    public enum UserRole
    {
        User,
        Staff,
        Admin,
        SubAdmin,
        Developer
    }

    public enum EmailType
    {
        WelcomeEmail = 0,
        EmailVerification = 1,
        PaymentConfirmation = 2,
        Promotional = 3,
        CustomerApplication = 4
    }

    public enum ManageMessageId
    {
        AddPhoneSuccess,
        ChangePasswordSuccess,
        SetTwoFactorSuccess,
        SetPasswordSuccess,
        RemoveLoginSuccess,
        RemovePhoneSuccess,
        Error
    }

    public enum MemoryCacheItemPriority
    {
        Default = 1,
        NotRemovable = 2,
    }

    public enum MessageColor
    {
        None,
        White,
        Black,
        Blue,
        Orange,
        Yellow,
        Red,
        Green,
    }

    public enum PageSetting
    {
        Add = 0,
        List = 1,
        Manage = 2,
    }

    public enum PerformanceMode
    {
        None = 0,
        ApplicationState = 1,
        Cache = 2,
        MemoryCache = 3,
        Session = 4,
        Redis = 5
    }

    public enum StatusMessageType
    {
        Info,
        Error,
        Success,
        Warning,
    }

    public enum SymCryptographyServiceProvider : int
    {
        Rijndael,
        RC2,
        DES,
        TripleDES,
    }

    public enum TipPosition
    {
        Left = 0,
        Right = 2,
    }

    public enum UserType
    {
        Customer,
        Staff,
        Admin,
        SubAdmin,
        Developer,
        Any
    }

    //public enum ModelType
    //{
    //    Default,
    //    AdminView,
    //    UserView,
    //    OListItem,
    //    NameArray
    //}

    public enum ListingType
    {
        Queryable,
        GridList,
        List
    }

    public enum ProductQueryType
    {
        FilterOrNone,
        Variants,
        Suggestions,
        Featured,
        Trending,
        QuickSlides,
        Offers,
        Similars
    }

    public enum ProductDivision
    {
        None = -1,
        Grocery = 0,
        HygineAndCleaning = 1,
        PersonalCare = 2,
        BabiesAndKids = 3,
        Stationeries = 4,
        SportsAndFitnes = 5,
        HouseHoldItems = 6
    }

    public enum MeasureType
    {
        Unit,
        Gram,
        KG,
        Liter,
        ML,
        Dozen,
        Tray,
        Large,
        Small,
        Medium,
        LargePack,
        SmallPack,
        MediumPack,
        Bundle
    }

    public enum DBStatus
    {
        Success,
        Conflict,
        Exist,
        DoesntExist,
        Error
    }

    public enum RecordType
    {
        Division,
        Product,
        Category,
        SubCategory,
        Brand,
        Order,
        OrderDetail
    }

    public enum IdType
    {
        Invalid = -1
    }

    public enum OrderStatus
    {
        All = 0,
        Placed = 1,
        Confirmed = 2,
        Packed = 3,
        Dispatched = 4,
        Delivered = 5,
        Cancelled = 6,
        Rejected = 7,
        Pending = 8
    }
    public enum OfferStatus
    {
        All = 0,
        Active = 1,
        InActive = 2
    }
    public enum OfferBannerPlacement
    {
        All = 0,
        DesktopHomee = 1,
        DesktopOfferss = 2,
        MobileStatus = 3,
        MobileOffers = 4
    }
    public enum ReemRequestStatus
    {
        All = 0,
        Requested = 1,
        Approved = 2,
        Rejected = 3,
        UnderProcess = 4,
        Processed = 5
    }

    public enum PaymentType
    {
        CashOnDelivery = 1,
        OnlinePayment = 2,
    }

    public enum OTPType
    {
        Email = 1,
        Phone = 2
    }
}
