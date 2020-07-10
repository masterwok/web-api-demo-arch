using Demo.Data.Repositories.Contracts;
using Demo.Data.Services;
using Moq;
using NUnit.Framework;

namespace Demo.Data.Test
{
    public class HelloWorldServiceTest
    {
        private HelloWorldService _helloWorldService;
        private Mock<IStringRepository> _stringRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _stringRepositoryMock = new Mock<IStringRepository>();

            _helloWorldService = new HelloWorldService(_stringRepositoryMock.Object);
        }

        [Test]
        public void CreateWasCalledWithExpectedValue()
        {
            const string value = "hello";

            _helloWorldService.CreateHello(value);

            _stringRepositoryMock.Verify(c => c.Create(value), Times.Once);
        }
    }
}