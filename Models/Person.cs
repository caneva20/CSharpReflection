namespace CSharReflection.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public ICollection<Person> Dependants { get; set; }

        public Person()
        {

        }

        public Person(string name, int age, DateOnly dateOfBirth, ICollection<Person> dependants = null)
        {
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            Dependants = dependants ?? new List<Person>();
        }

        public void AddDependant(Person person)
        {
            Dependants.Add(person);
        }

        public bool RemoveDependant(Person person)
        {
            return Dependants.Remove(person);
        }

        private void Sit()
        {
            Console.WriteLine("??");
        }
    }
}
