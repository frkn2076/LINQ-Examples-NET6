namespace LINQ_Examples_NET6.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name) => Name = name;

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
