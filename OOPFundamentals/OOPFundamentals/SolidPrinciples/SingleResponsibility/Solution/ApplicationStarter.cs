using Solution.Core;

namespace Solution
{
    public class ApplicationStarter : IApplicationStarter
    {
        private readonly ILogger _logger;

        public ApplicationStarter(ILogger logger)
        {
            _logger = logger;
        }
        
        public void StartApplication()
        {
            _logger.Log("Welcome to my application!");
        }
    }
}