using System;
using Solution.Core;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            IApplicationStarter applicationStarter = new ApplicationStarter(logger);
            IApplicationFinisher applicationFinisher = new ApplicationFinisher(logger);
            IPersonValidator personValidator = new PersonValidator(logger);
            IPersonCreator personCreator = new PersonCreator(logger);
            StandardMessages standardMessages = new StandardMessages(applicationStarter, applicationFinisher, logger);
            PersonDataCapture personDataCapture = new PersonDataCapture();

            standardMessages.StartApplication();

            Person person = new Person();

            standardMessages.DisplayFirstNameRequestMessage();
            person = personDataCapture.CapturePersonFirstName(person);

            standardMessages.DisplayLastNameRequestMessage();
            person = personDataCapture.CapturePersonLastName(person);

            bool isValidPerson = personValidator.Validate(person);

            if (!isValidPerson)
            {
                applicationFinisher.FinishApplication();
                return;
            }

            personCreator.Create(person);
            applicationFinisher.FinishApplication();
        }
    }
}