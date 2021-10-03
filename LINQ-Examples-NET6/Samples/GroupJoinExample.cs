using LINQ_Examples_NET6.Models;

namespace LINQ_Examples_NET6.Samples;
class GroupJoinExample
{
    public void Sample1()
    {
        var barley = new Pet("Barley", "terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var people = new List<string> { "Magnus", "Terry", "terry", "Charlotte" };
        var pets = new List<Pet> { barley, boots, whiskers, daisy };

        var result = people.GroupJoin(pets, person => person, pet => pet.Owner, (person, petCollection) =>
                         new
                         {
                             OwnerName = person,
                             Pets = petCollection.Select(pet => pet.Name)
                         });

        //  result = IEnumerable<GroupJoinIterator>  { [
        //  { OwnerName = "Magnus", Pets = ["Daisy"] },
        //  { OwnerName = "Terry", Pets = ["Boots"] },
        //  { OwnerName = "terry", Pets = ["Barley"] },
        //  { OwnerName = "Charlotte", Pets = ["Whiskers"] }
        //  ] }

    }

    public void Sample2()
    {
        var barley = new Pet("Barley", "terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var people = new List<string> { "Magnus", "Terry", "terry", "Charlotte" };
        var pets = new List<Pet> { barley, boots, whiskers, daisy };

        var result = people.GroupJoin(pets, person => person, pet => pet.Owner, (person, petCollection) =>
                         new
                         {
                             OwnerName = person,
                             Pets = petCollection.Select(pet => pet.Name)
                         }, StringComparer.OrdinalIgnoreCase);

        //  result = IEnumerable<GroupJoinIterator>  { [
        //  { OwnerName = "Magnus", Pets = ["Daisy"] },
        //  { OwnerName = "Terry", Pets = ["Barley", "Boots"] },
        //  { OwnerName = "terry", Pets = ["Barley", "Boots"] },
        //  { OwnerName = "Charlotte", Pets = ["Whiskers"] }
        //  ] }

    }
}