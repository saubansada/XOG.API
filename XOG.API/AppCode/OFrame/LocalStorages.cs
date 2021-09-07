using XOG.SettingsHelpers;

namespace XOG
{
    public static class LocalStorages
    {
        public static string Storage
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage", value);
            }
        }

        public static string Storage_Logs
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage_Logs");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage_Logs", value);
            }
        }

        public static string Storage_Temp
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage_Temp");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage_Temp", value);
            }
        }

        public static string Storage_Uploads
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage_Uploads");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage_Uploads", value);
            }
        }

        public static string Storage_Product_Image_Uploads
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage_Product_Image_Uploads");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage_Product_Image_Uploads", value);
            }
        }

        public static string Storage_Category_Image_Uploads
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage_Category_Image_Uploads");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage_Category_Image_Uploads", value);
            }
        }

        public static string Storage_Brand_Image_Uploads
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage_Brand_Image_Uploads");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage_Brand_Image_Uploads", value);
            }
        }

        public static string Storage_Sub_Category_Image_Uploads
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Storage_Sub_Category_Image_Uploads");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Storage_Sub_Category_Image_Uploads", value);
            }
        }

        public static string Site_Map
        {
            get
            {
                return LocalStoragesHelper.GetStoragePath("Site_Map");
            }

            set
            {
                LocalStoragesHelper.SetStoragePath("Site_Map", value);
            }
        }
    }
}
