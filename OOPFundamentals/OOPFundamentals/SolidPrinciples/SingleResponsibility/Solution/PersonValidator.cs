using Solution.Core;

namespace Solution
{
    public class PersonValidator : IPersonValidator
    {
        private readonly ILogger _logger;

        public PersonValidator(ILogger logger)
        {
            _logger = logger;
        }

        public bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                _logger.LogError("You didn't enter a valid first name!");
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                _logger.LogError("You didn't enter a valid last name!");
                return false;
            }

            return true;
        }
    }
}