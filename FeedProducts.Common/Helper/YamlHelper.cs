using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using YamlDotNet.Serialization.NamingConventions;

namespace FeedProducts.Common.Helper
{
    /// <summary>
    /// Yaml helper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [ExcludeFromCodeCoverage]
    public class YamlHelper<T> : IYamlHelper<T>
    {
        public readonly IFileHelper _fileHelper;

        public YamlHelper(IFileHelper fileHelper)
        {
            _fileHelper = fileHelper;
        }

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

            return deserializer.Deserialize<List<T>>(_fileHelper.ReadFileData(path));
        }
    }
}
