namespace FeedProducts.Interfaces
{
    /// <summary>
    /// File reader interface
    /// </summary>
    public interface IFileReader
    {
        /// <summary>
        /// Read file method
        /// </summary>
        /// <param name="path"></param>
        public void ReadFile(string path);
    }
}
