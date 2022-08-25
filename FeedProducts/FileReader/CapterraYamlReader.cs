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
        private readonly IYamlHelper<Capterra> _yamlHelper;

        public CapterraYamlReader(IYamlHelper<Capterra> yamlHelper)
        {
            _yamlHelper = yamlHelper;
        }

        /// <summary>
        /// Read file
        /// </summary>
        public void ReadFile(string path)
        {
            List<Capterra> entries = _yamlHelper.GetEntries(path);
            entries.ForEach(x => Console.WriteLine($"Name: {x.Name}, Tags: {x.Tags}, Twitter: {x.Twitter}"));
        }
    }
}
