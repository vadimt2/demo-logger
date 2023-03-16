namespace Logger
{
    public class BlService : IBlService
    {
        private readonly ILogger<BlService> _logger;

        public BlService(IServiceProvider provider)
        {
            _logger = provider.GetRequiredService<ILogger<BlService>>();
        }

        public void Test()
        {
            _logger.LogError("Test");
        }
    }
}
