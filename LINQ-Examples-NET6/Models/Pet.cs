namespace LINQ_Examples_NET6.Models
{
    class Pet
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public Pet(string name, string owner)
        {
            Name = name;
            Owner = owner;
        }
    }
}
