using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Extensions.Logging.Xunit.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper testOutputHelper;
        private readonly LoggerFactory loggerFactory;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            this.loggerFactory = new LoggerFactory(new[] { new XunitLoggerProvider(testOutputHelper) });
        }

        [Fact]
        public void Test1()
        {
            var logger = loggerFactory.CreateLogger("Test1");
            logger.LogInformation("Hello World!");
            logger = loggerFactory.CreateLogger<UnitTest1>();
            logger.LogInformation("Hello World!");
        }
    }
}
