using Solution.Core;

namespace Solution
{
    public class PersonCreator : IPersonCreator
    {
        private readonly ILogger _logger;

        public PersonCreator(ILogger logger)
        {
            _logger = logger;
        }

        public void Create(Person person)
        {
            _logger.LogInfo($"Your username is {person.FirstName.Substring(0, 1)}{person.LastName}");
        }
    }
}