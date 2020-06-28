using Solution.Core;

namespace Solution
{
    static class Program
    {
        private static readonly ILogger Logger = new Logger();
        private static readonly IApplicationStarter ApplicationStarter = new ApplicationStarter(Logger);
        private static readonly IApplicationFinisher ApplicationFinisher = new ApplicationFinisher(Logger);
        private static readonly IPersonValidator PersonValidator = new PersonValidator(Logger);
        private static readonly IPersonCreator PersonCreator = new PersonCreator(Logger);
        private static readonly StandardMessages StandardMessages = new StandardMessages(ApplicationStarter, ApplicationFinisher, Logger);
        private static readonly PersonDataCapture PersonDataCapture = new PersonDataCapture();

        static void Main(string[] args)
        {
            StandardMessages.StartApplication();

            Person person = new Person();

            StandardMessages.DisplayFirstNameRequestMessage();
            person = PersonDataCapture.CapturePersonFirstName(person);

            StandardMessages.DisplayLastNameRequestMessage();
            person = PersonDataCapture.CapturePersonLastName(person);

            bool isValidPerson = PersonValidator.Validate(person);

            if (!isValidPerson)
            {
                ApplicationFinisher.FinishApplication();
                return;
            }

            PersonCreator.Create(person);
            ApplicationFinisher.FinishApplication();
        }
    }
}