namespace LINQ_Examples_NET6.Samples;
public class RepeatExample
{
    public IEnumerable<string> Sample1()
    {
        var result = Enumerable.Repeat(".Net", 4);
        //  result = IEnumerable<string> { ".Net", ".Net", ".Net", ".Net" }
        return result;
    }
}