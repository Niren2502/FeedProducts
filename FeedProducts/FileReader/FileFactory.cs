using FeedProducts.Interfaces;
using System;
using System.IO;

namespace FeedProducts.FileReader
{
    public class FileFactory : IFileFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public FileFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        ///  get file reader object
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IFileReader GetFileReader(string path)
        {
            var extension = Path.GetExtension(path);

            if (extension.Equals(".yaml"))
            {
                return (IFileReader)_serviceProvider.GetService(typeof(CapterraYamlReader));
            }
            else if (extension.Equals(".json"))
            {
                return (IFileReader)_serviceProvider.GetService(typeof(SoftwareAdviceReader));
            }
            else
            {
                throw new ArgumentException("File type not supported");
            }
        }
    }
}
