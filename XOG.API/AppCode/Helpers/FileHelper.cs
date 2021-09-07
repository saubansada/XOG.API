using System;
using System.IO;
using System.Text;
using XOG.Util;

namespace XOG.AppCode.Helpers
{
    public static class FilesHelper
    {
        public static string ReadFile(String FilePath)
        {
            using (var fileStream = new FileStream(FilePath.MapPath(), FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        public static Boolean WriteFile(String FilePath, String data)
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }

                using (StreamWriter writer = new StreamWriter(FilePath.MapPath(), false))
                {
                    writer.Write(data);

                    return true;
                }
            }
            catch (Exception)
            {

                ErrorLogger.LogError("Error while writing a file in FileHelper");

                return false;
            }
        }
    }

}