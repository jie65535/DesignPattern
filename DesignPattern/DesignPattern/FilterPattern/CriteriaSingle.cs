using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (var people in persons)
            {
                if (people.MaritalStatus.Equals("SINGLE", StringComparison.OrdinalIgnoreCase))
                {
                    singlePersons.Add(people);
                }
            }
            return singlePersons;
        }
    }
}
