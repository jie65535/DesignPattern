using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (var people in persons)
            {
                if (people.Gender.Equals("FEMALE", StringComparison.OrdinalIgnoreCase))
                {
                    femalePersons.Add(people);
                }
            }
            return femalePersons;
        }
    }
}
