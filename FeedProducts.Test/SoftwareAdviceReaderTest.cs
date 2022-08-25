using FeedProducts.Common.Helper;
using FeedProducts.Models;
using Moq;
using Newtonsoft.Json;
using Xunit;
using System.Collections.Generic;
using FeedProducts.FileReader;

namespace FeedProducts.Test
{
    public class SoftwareAdviceReaderTest
    {
        [Fact]
        public void ReadFile_Execute()
        {
            int methodCalled = 0;
            var fileHelper = new Mock<IFileHelper>();
            fileHelper.Setup(x => x.ReadFileData(It.IsAny<string>()))
                .Returns(JsonConvert.SerializeObject(new ProductsList()
                {
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                            Title = "title",
                            Categories = new List<string>() { "A"},
                            Twitter = "twitter"
                        }
                    }
                }))
                .Callback(() => methodCalled++);

            var f = new SoftwareAdviceReader(fileHelper.Object);
            f.ReadFile("path");
            Assert.True(methodCalled == 1);
        }
    }
}
