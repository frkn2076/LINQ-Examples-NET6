using LINQ_Examples_NET6.Comparer;
using LINQ_Examples_NET6.Models;

namespace LINQ_Examples_NET6.Samples;
class OrderByDescendingExample
{
    public void Sample1()
    {
        var barley = new Pet("Barley", "Terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var pets = new List<Pet> { barley, boots, whiskers, daisy };
        var result = pets.OrderByDescending(x => x.Name);
        //  result = IEnumerable<Pet> { [
        //  { Name = "Whiskers", Owner = "Charlotte"},
        //  { Name = "Daisy", Owner = "Magnus"},
        //  { Name = "Boots", Owner = "Terry"},
        //  { Name = "Barley", Owner = "Terry"}
        //  ] }
    }

    public void Sample2()
    {
        var barley = new Pet("Barley", "Terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var pets = new List<Pet> { barley, boots, whiskers, daisy };
        var result = pets.OrderByDescending(x => x.Name, new LengthComparer());
        //  result = IEnumerable<Pet> { [
        //  { Name = "Whiskers", Owner = "Charlotte"},
        //  { Name = "Barley", Owner = "Terry"},
        //  { Name = "Boots", Owner = "Terry"}
        //  { Name = "Daisy", Owner = "Magnus"},
        //  ] }
    }
}