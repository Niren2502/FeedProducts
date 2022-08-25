namespace FeedProducts.Interfaces
{
    public interface IFileFactory
    {
        public IFileReader GetFileReader(string path);
    }
}
