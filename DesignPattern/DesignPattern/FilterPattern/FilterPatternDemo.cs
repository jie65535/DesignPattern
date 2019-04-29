using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    class FilterPatternDemo : IDesignPatternDemo
    {
        public void Run()
        {
            List<Person> persons = new List<Person>
            {
                new Person("Robert",    "Male",     "Single"    ),
                new Person("John",      "Male",     "Married"   ),
                new Person("Laura",     "Female",   "Married"   ),
                new Person("Diana",     "Female",   "Single"    ),
                new Person("Mike",      "Male",     "Single"    ),
                new Person("Bobby",     "Male",     "Single"    ),
            };

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("\nPersons:");
            Console.WriteLine(string.Join("\n", persons));
            Console.WriteLine("\nMales:");
            Console.WriteLine(string.Join("\n", male.MeetCriteria(persons)));
            Console.WriteLine("\nFemales:");
            Console.WriteLine(string.Join("\n", female.MeetCriteria(persons)));
            Console.WriteLine("\nSingle Males:");
            Console.WriteLine(string.Join("\n", singleMale.MeetCriteria(persons)));
            Console.WriteLine("\nSingle Or Females:");
            Console.WriteLine(string.Join("\n", singleOrFemale.MeetCriteria(persons)));
        }
    }
}
