using Solution.Core;

namespace Solution
{
    public class StandardMessages
    {
        private readonly IApplicationStarter _applicationStarter;
        private readonly IApplicationFinisher _applicationFinisher;
        private readonly ILogger _logger;

        public StandardMessages(IApplicationStarter applicationStarter, IApplicationFinisher applicationFinisher, ILogger logger)
        {
            _applicationStarter = applicationStarter;
            _applicationFinisher = applicationFinisher;
            _logger = logger;
        }

        public void StartApplication()
        {
            _applicationStarter.StartApplication();
        }

        public void FinishApplication()
        {
            _applicationFinisher.FinishApplication();
        }

        public void DisplayFirstNameRequestMessage()
        {
            _logger.Log("What's your first name: ");
        }
        
        public void DisplayLastNameRequestMessage()
        {
            _logger.Log("What's your last name: ");
        }
    }
}