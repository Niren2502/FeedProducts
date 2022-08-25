using FeedProducts.Common.Helper;
using FeedProducts.FileReader;
using FeedProducts.Interfaces;
using FeedProducts.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;

namespace FeedProducts
{
    /// <summary>
    /// Program class
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class Program
    {
        public static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddScoped<IFileFactory, FileFactory>()
                .AddScoped<CapterraYamlReader>()
                .AddScoped<IFileReader, CapterraYamlReader>(s => s.GetService<CapterraYamlReader>())
                .AddScoped<SoftwareAdviceReader>()
                .AddScoped<IFileReader, SoftwareAdviceReader>(s => s.GetService<SoftwareAdviceReader>())
                .AddScoped<IYamlHelper<Capterra>, YamlHelper<Capterra>>()
                .AddScoped<IFileHelper, FileHelper>()
                .BuildServiceProvider();

            var service = serviceProvider.GetService<IFileFactory>();

            // Pass file path as argument
            if (args.Length > 0)
            {
                var fileObj = service.GetFileReader(args[0]);
                fileObj.ReadFile(args[0]);
            }
            else
            {
                Console.WriteLine("No file path supported");
            }
            Console.ReadLine();
        }
    }
}
