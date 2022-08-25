using FeedProducts.Common.Helper;
using FeedProducts.FileReader;
using FeedProducts.Models;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace FeedProducts.Test
{
    public class CapterraYamlReaderTest
    {
        [Fact]
        public void ReadFile_Execute()
        {
            int methodCalled = 0;
            var yamlHelper = new Mock<IYamlHelper<Capterra>>();
            yamlHelper.Setup(x => x.GetEntries(It.IsAny<string>()))
                .Returns(new List<Capterra>() { 
                    new Capterra()
                    {
                        Name = "ABC",
                        Tags = "tags",
                        Twitter = "twitter"
                    }
                })
                .Callback( () => methodCalled++);

            var f = new CapterraYamlReader(yamlHelper.Object);
            f.ReadFile("path");
            Assert.True(methodCalled == 1);
        }
    }
}
