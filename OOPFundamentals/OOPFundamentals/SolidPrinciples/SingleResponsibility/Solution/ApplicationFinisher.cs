using System;
using Solution.Core;

namespace Solution
{
    public class ApplicationFinisher : IApplicationFinisher
    {
        private readonly ILogger _logger;

        public ApplicationFinisher(ILogger logger)
        {
            _logger = logger;
        }

        public void FinishApplication()
        {
            _logger.Log("Press any key to close...");
            Console.ReadKey();
        }
    }
}