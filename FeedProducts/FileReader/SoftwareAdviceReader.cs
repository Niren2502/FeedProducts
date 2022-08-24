using FeedProducts.Common.Helper;
using FeedProducts.Interfaces;
using FeedProducts.Models;
using Newtonsoft.Json;
using System;

namespace FeedProducts.FileReader
{
    public class SoftwareAdviceReader : IFileReader
    {
        /// <summary>
        /// Read file
        /// </summary>
        public void ReadFile(string path)
        {
            Products products = JsonConvert.DeserializeObject<Products>(FileHelper.ReadFileData(path));

            products.products.ForEach(x => Console.WriteLine($"Name: {x.title}, Categories: {string.Join(", ", x.categories)}, Twitter: {x.twitter}"));
            Console.ReadLine();
        }
    }
}
