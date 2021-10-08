using System.Collections;
namespace LINQ_Examples_NET6.Custome;
internal class CustomeItems : IEnumerable<string>
{
    private IEnumerable<string> items()
    {
        yield return "X";
        yield return "Y";
    }
    public IEnumerator<string> GetEnumerator() => items().GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
