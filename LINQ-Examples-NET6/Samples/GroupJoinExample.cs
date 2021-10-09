using LINQ_Examples_NET6.Models;

namespace LINQ_Examples_NET6.Samples;
public class GroupJoinExample
{
    public IEnumerable<Owner> Sample1()
    {
        var barley = new Pet("Barley", "terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var people = new List<string> { "Magnus", "Terry", "terry", "Charlotte" };
        var pets = new List<Pet> { barley, boots, whiskers, daisy };

        var result = people.GroupJoin(pets, person => person, pet => pet.Owner, (person, petCollection) 
            => new Owner(person, petCollection.Select(x => x.Name).ToList()));

        //  result = IEnumerable<GroupJoinIterator>  { [
        //  { OwnerName = "Magnus", Pets = ["Daisy"] },
        //  { OwnerName = "Terry", Pets = ["Boots"] },
        //  { OwnerName = "terry", Pets = ["Barley"] },
        //  { OwnerName = "Charlotte", Pets = ["Whiskers"] }
        //  ] }
        return result;
    }

    public IEnumerable<Owner> Sample2()
    {
        var barley = new Pet("Barley", "terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var people = new List<string> { "Magnus", "Terry", "terry", "Charlotte" };
        var pets = new List<Pet> { barley, boots, whiskers, daisy };

        var result = people.GroupJoin(pets, person => person, pet => pet.Owner, (person, petCollection) 
            => new Owner(person, petCollection.Select(x => x.Name).ToList()), StringComparer.OrdinalIgnoreCase);

        //  result = IEnumerable<GroupJoinIterator>  { [
        //  { OwnerName = "Magnus", Pets = ["Daisy"] },
        //  { OwnerName = "Terry", Pets = ["Barley", "Boots"] },
        //  { OwnerName = "terry", Pets = ["Barley", "Boots"] },
        //  { OwnerName = "Charlotte", Pets = ["Whiskers"] }
        //  ] }
        return result;
    }
}