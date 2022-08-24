using FeedProducts.Common.Helper;
using FeedProducts.Interfaces;
using FeedProducts.Models;
using System;
using System.Collections.Generic;

namespace FeedProducts.FileReader
{
    /// <summary>
    /// Capterra Yaml reader
    /// </summary>
    public class CapterraYamlReader : IFileReader
    {
        /// <summary>
        /// Read file
        /// </summary>
        public void ReadFile(string path)
        {
            YamlHelper<Capterra> yamlHelper = new YamlHelper<Capterra>();
            List<Capterra> entries = yamlHelper.GetEntries(path);
            entries.ForEach(x => Console.WriteLine($"Name: {x.name}, Tags: {x.tags}, Twitter: {x.twitter}"));
            Console.ReadLine();
        }
    }
}
