using System;
using System.IO;

namespace FeedProducts.Common.Helper
{
    /// <summary>
    /// Helper class for file related method
    /// </summary>
    public static class FileHelper
    {
        public static string ReadFileData(string path)
        {
            return File.ReadAllText(Environment.CurrentDirectory + "\\" + path);
        }
    }
}
