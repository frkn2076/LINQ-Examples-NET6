namespace LINQ_Examples_NET6.Samples;
public class AppendExample
{
    public IEnumerable<int> Sample1()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var result = numbers.Append(10);
        //  result = IEnumerable<int> { 1, 2, 3, 4, 5, 10 }
        return result;
    }
}