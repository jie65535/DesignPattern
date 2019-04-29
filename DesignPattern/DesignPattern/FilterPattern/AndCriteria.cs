using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public class AndCriteria : ICriteria
    {
        private readonly ICriteria _Criteria;
        private readonly ICriteria _OtherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _Criteria = criteria;
            _OtherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = _Criteria.MeetCriteria(persons);
            return _OtherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}
