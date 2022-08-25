using System.Collections.Generic;

namespace FeedProducts.Common.Helper
{
    public interface IYamlHelper<T>
    {
        /// <summary>
        /// Get deserialized entries for a specific type present in yaml
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<T> GetEntries(string path);

    }
}
