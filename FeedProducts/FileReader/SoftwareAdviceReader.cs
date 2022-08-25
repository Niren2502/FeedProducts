using FeedProducts.Common.Helper;
using FeedProducts.Interfaces;
using FeedProducts.Models;
using Newtonsoft.Json;
using System;

namespace FeedProducts.FileReader
{
    /// <summary>
    /// Software advice reader
    /// </summary>
    public class SoftwareAdviceReader : IFileReader
    {
        private readonly IFileHelper _fileHelper;

        public SoftwareAdviceReader(IFileHelper fileHelper)
        {
            _fileHelper = fileHelper;
        }

        /// <summary>
        /// Read file
        /// </summary>
        public void ReadFile(string path)
        {
            ProductsList products = JsonConvert.DeserializeObject<ProductsList>(_fileHelper.ReadFileData(path));

            products.Products.ForEach(x => Console.WriteLine($"Name: {x.Title}, Categories: {string.Join(", ", x.Categories)}, Twitter: {x.Twitter}"));
        }
    }
}
