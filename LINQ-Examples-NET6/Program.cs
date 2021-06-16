using LINQ_Examples_NET6.Samples;

namespace LINQ_Examples_NET6
{
    class Program
    {
        static void Main(string[] args)
        {
            var aggregateExample = new AggregateExample();
            aggregateExample.Sample1();
            aggregateExample.Sample2();
            aggregateExample.Sample3();

            var allExample = new AllExample();
            allExample.Sample1();

            var anyExample = new AnyExample();
            anyExample.Sample1();

            var appendExample = new AppendExample();
            appendExample.Sample1();

            var asEnumerableExample = new AsEnumerableExample();
            asEnumerableExample.Sample1();

            var averageExample = new AverageExample();
            averageExample.Sample1();
            averageExample.Sample2();

            var castExample = new CastExample();
            castExample.Sample1();

            var chunkExample = new ChunkExample();
            chunkExample.Sample1();

            var concatExample = new ConcatExample();
            concatExample.Sample1();

            var containsExample = new ContainsExample();
            containsExample.Sample1();
            containsExample.Sample2();

            var countExample = new CountExample();
            countExample.Sample1();
            countExample.Sample2();

            var defaultIfEmptyExample = new DefaultIfEmptyExample();
            defaultIfEmptyExample.Sample1();
            defaultIfEmptyExample.Sample2();

        }
    }
}
