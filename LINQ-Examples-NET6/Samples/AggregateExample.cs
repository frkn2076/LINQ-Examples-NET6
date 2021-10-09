namespace LINQ_Examples_NET6.Samples;
public class AggregateExample
{
    public int Sample1()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var result = numbers.Aggregate((acc, value) => acc * value);
        //  result = (((1 * 2) * 3) * 4) * 5
        return result;
    }

    public int Sample2()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var result = numbers.Aggregate(10, (acc, value) => acc * value);
        //  result = ((((10 * 1) * 2) * 3) * 4) * 5
        return result;
    }


    public int Sample3()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var result = numbers.Aggregate(10, (acc, value) => acc * value, res => res / 2);
        //  result = (((((10 * 1) * 2) * 3) * 4) * 5) / 2
        return result;
    }
}