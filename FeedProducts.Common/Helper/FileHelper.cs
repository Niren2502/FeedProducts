using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace FeedProducts.Common.Helper
{
    /// <summary>
    /// Helper class for file related method
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FileHelper : IFileHelper
    {
        public string ReadFileData(string path)
        {
            return File.ReadAllText(Environment.CurrentDirectory + "\\" + path);
        }
    }
}
