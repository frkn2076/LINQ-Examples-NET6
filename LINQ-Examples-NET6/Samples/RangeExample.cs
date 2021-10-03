namespace LINQ_Examples_NET6.Samples;
class RangeExample
{
    public void Sample1()
    {
        var result = Enumerable.Range(2, 5);
        //  result = IEnumerable<int> { 2, 3, 4, 5, 6}
    }
}