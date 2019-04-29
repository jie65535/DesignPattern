using System.Collections.Generic;

namespace DesignPattern.FilterPattern
{
    public interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}
