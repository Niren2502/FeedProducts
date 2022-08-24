using System.Collections.Generic;
using YamlDotNet.Serialization.NamingConventions;

namespace FeedProducts.Common.Helper
{
    /// <summary>
    /// Yaml helper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class YamlHelper<T>
    {
        /// <summary>
        /// Get deserialized entries for a specific type present in yaml
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<T> GetEntries(string path)
        {
            var deserializer = new YamlDotNet.Serialization.DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

            return deserializer.Deserialize<List<T>>(FileHelper.ReadFileData(path));
        }
    }
}
