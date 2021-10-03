namespace LINQ_Examples_NET6.Samples;
class AverageExample
{
    public void Sample1()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var result = numbers.Average();
        //  result = (1 + 2 + 3 + 4 + 5) / 5
    }

    public void Sample2()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var result = numbers.Average(x => x * x);
        //  result = ((1 * 1) + (2 * 2) + (3 * 3) + (4 * 4) + (5 * 5)) / 5
    }
}