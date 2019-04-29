using System;
using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (var people in persons)
            {
                if (people.Gender.Equals("MALE", StringComparison.OrdinalIgnoreCase))
                {
                    malePersons.Add(people);
                }
            }
            return malePersons;
        }
    }
}
