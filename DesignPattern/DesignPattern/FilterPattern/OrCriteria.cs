using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.FilterPattern
{
    public class OrCriteria : ICriteria
    {
        private readonly ICriteria _Criteria;
        private readonly ICriteria _OtherCriteria;


        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _Criteria = criteria;
            _OtherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = _Criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = _OtherCriteria.MeetCriteria(persons);
            return firstCriteriaItems.Union(otherCriteriaItems).ToList();
        }
    }
}
