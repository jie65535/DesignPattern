namespace DesignPattern.FilterPattern
{
    public class Person
    {
        public Person(string name, string gender, string maritalStatus)
        {
            Name = name;
            Gender = gender;
            MaritalStatus = maritalStatus;
        }

        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string MaritalStatus { get; private set; }

        public override string ToString()
        {
            return string.Format("[Name:{0}\tGender:{1},\tMaritalStatus:{2}\t]", Name, Gender, MaritalStatus);
        }
    }
}
