using Xunit.Abstractions;

namespace Microsoft.Extensions.Logging.Xunit
{
    public class XunitLoggerProvider : ILoggerProvider
    {
        private readonly ITestOutputHelper testOutputHelper;

        public XunitLoggerProvider(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        public ILogger CreateLogger(string categoryName) =>
            new XunitLogger(testOutputHelper, categoryName);

        public void Dispose()
        {
        }
    }
}
