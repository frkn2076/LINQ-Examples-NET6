namespace LINQ_Examples_NET6.Samples;
public class SumExample
{
    public int Sample1()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Sum();
        //  result = 15
        return result;
    }

    public int Sample2()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Sum(x => x + 1);
        //  result = 20
        return result;
    }
}