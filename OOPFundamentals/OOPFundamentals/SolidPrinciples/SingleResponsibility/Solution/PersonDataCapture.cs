using System;

namespace Solution
{
    public class PersonDataCapture
    {
        public Person CapturePersonFirstName(Person person)
        {
            person.FirstName = Console.ReadLine();
            return person;
        }

        public Person CapturePersonLastName(Person person)
        {
            person.LastName = Console.ReadLine();
            return person;
        }
    }
}