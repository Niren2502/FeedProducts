using FeedProducts.Common.Helper;
using FeedProducts.FileReader;
using FeedProducts.Models;
using Moq;
using System;
using Xunit;

namespace FeedProducts.Test
{
    public class FileFactoryTest
    {
        [Fact]
        public void GetFileReader_ReturnYamlReader()
        {
            var svcProvider = new Mock<IServiceProvider>();
            var yamlHelper = new Mock<IYamlHelper<Capterra>>();
            var fileHelper = new Mock<IFileHelper>();
            svcProvider.Setup(x => x.GetService(typeof(CapterraYamlReader)))
                .Returns(new CapterraYamlReader(yamlHelper.Object));

            svcProvider.Setup(x => x.GetService(typeof(SoftwareAdviceReader)))
                .Returns(new SoftwareAdviceReader(fileHelper.Object));

            var f = new FileFactory(svcProvider.Object);
            var obj = f.GetFileReader("abc.yaml");
            Assert.IsType<CapterraYamlReader>(obj);
        }

        [Fact]
        public void GetFileReader_ReturnJsonReader()
        {
            var svcProvider = new Mock<IServiceProvider>();
            var yamlHelper = new Mock<IYamlHelper<Capterra>>();
            var fileHelper = new Mock<IFileHelper>();
            svcProvider.Setup(x => x.GetService(typeof(CapterraYamlReader)))
                .Returns(new CapterraYamlReader(yamlHelper.Object));

            svcProvider.Setup(x => x.GetService(typeof(SoftwareAdviceReader)))
                .Returns(new SoftwareAdviceReader(fileHelper.Object));

            var f = new FileFactory(svcProvider.Object);
            var obj = f.GetFileReader("abc.json");
            Assert.IsType<SoftwareAdviceReader>(obj);
        }

        [Fact]
        public void GetFileReader_InvalidFileType()
        {
            var svcProvider = new Mock<IServiceProvider>();
            var yamlHelper = new Mock<IYamlHelper<Capterra>>();
            var fileHelper = new Mock<IFileHelper>();
            svcProvider.Setup(x => x.GetService(typeof(CapterraYamlReader)))
                .Returns(new CapterraYamlReader(yamlHelper.Object));

            svcProvider.Setup(x => x.GetService(typeof(SoftwareAdviceReader)))
                .Returns(new SoftwareAdviceReader(fileHelper.Object));

            var f = new FileFactory(svcProvider.Object);
            Assert.Throws<ArgumentException>(() => f.GetFileReader("abc.csv"));
        }
    }
}
