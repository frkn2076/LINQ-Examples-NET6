using LINQ_Examples_NET6.Samples;

namespace LINQ_Examples_NET6;
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

        var distinctExample = new DistinctExample();
        distinctExample.Sample1();
        distinctExample.Sample2();

        var distinctByExample = new DistinctByExample();
        distinctByExample.Sample1();
        distinctByExample.Sample2();

        var elementAtExample = new ElementAtExample();
        elementAtExample.Sample1();
        elementAtExample.Sample2();

        var elementAtOrDefaultExample = new ElementAtOrDefaultExample();
        elementAtOrDefaultExample.Sample1();
        elementAtOrDefaultExample.Sample2();

        var emptyExample = new EmptyExample();
        emptyExample.Sample1();

        var exceptExample = new ExceptExample();
        exceptExample.Sample1();
        exceptExample.Sample2();

        var exceptByExample = new ExceptByExample();
        exceptByExample.Sample1();
        exceptByExample.Sample2();

        var firstExample = new FirstExample();
        firstExample.Sample1();
        firstExample.Sample2();

        var firstOrDefaultExample = new FirstOrDefaultExample();
        firstOrDefaultExample.Sample1();
        firstOrDefaultExample.Sample2();
        firstOrDefaultExample.Sample3();
        firstOrDefaultExample.Sample4();

        var groupByExample = new GroupByExample();
        groupByExample.Sample1();
        groupByExample.Sample2();
        groupByExample.Sample3();
        groupByExample.Sample4();

        var groupJoinExample = new GroupJoinExample();
        groupJoinExample.Sample1();
        groupJoinExample.Sample2();

        var intersectExample = new IntersectExample();
        intersectExample.Sample1();
        intersectExample.Sample2();

        var intersectByExample = new IntersectByExample();
        intersectByExample.Sample1();
        intersectByExample.Sample2();

        var joinExample = new JoinExample();
        joinExample.Sample1();
        joinExample.Sample2();

        var lastExample = new LastExample();
        lastExample.Sample1();
        lastExample.Sample2();

        var lastOrDefaultExample = new LastOrDefaultExample();
        lastOrDefaultExample.Sample1();
        lastOrDefaultExample.Sample2();
        lastOrDefaultExample.Sample3();
        lastOrDefaultExample.Sample4();

        var longCountExample = new LongCountExample();
        longCountExample.Sample1();
        longCountExample.Sample2();

        var maxExample = new MaxExample();
        maxExample.Sample1();
        maxExample.Sample2();
        maxExample.Sample3();
        maxExample.Sample4();

        var maxByExample = new MaxByExample();
        maxByExample.Sample1();
        maxByExample.Sample2();

        var minExample = new MinExample();
        minExample.Sample1();
        minExample.Sample2();
        minExample.Sample3();
        minExample.Sample4();

        var minByExample = new MinByExample();
        minByExample.Sample1();
        minByExample.Sample2();

        var ofTypeExample = new OfTypeExample();
        ofTypeExample.Sample1();

        var orderByExample = new OrderByExample();
        orderByExample.Sample1();
        orderByExample.Sample2();

        var orderByDescendingExample = new OrderByDescendingExample();
        orderByDescendingExample.Sample1();
        orderByDescendingExample.Sample2();

        var prependExample = new PrependExample();
        prependExample.Sample1();

        var rangeExample = new RangeExample();
        rangeExample.Sample1();

        var repeatExample = new RepeatExample();
        repeatExample.Sample1();

        var reverseExample = new ReverseExample();
        reverseExample.Sample1();

        var selectExample = new SelectExample();
        selectExample.Sample1();
        selectExample.Sample2();

        var selectManyExample = new SelectManyExample();
        selectManyExample.Sample1();
        selectManyExample.Sample2();
        selectManyExample.Sample3();
        selectManyExample.Sample4();

        var sequenceEqualExample = new SequenceEqualExample();
        sequenceEqualExample.Sample1();
        sequenceEqualExample.Sample2();

        var singleExample = new SingleExample();
        singleExample.Sample1();
        singleExample.Sample2();

        var singleOrDefaultExample = new SingleOrDefaultExample();
        singleOrDefaultExample.Sample1();
        singleOrDefaultExample.Sample2();

        var skipExample = new SkipExample();
        skipExample.Sample1();

        var skipLastExample = new SkipLastExample();
        skipLastExample.Sample1();

        var skipWhileExample = new SkipWhileExample();
        skipWhileExample.Sample1();
        skipWhileExample.Sample2();

        var sumExample = new SumExample();
        sumExample.Sample1();
        sumExample.Sample2();

        var takeExample = new TakeExample();
        takeExample.Sample1();
        takeExample.Sample2();

        var takeLastExample = new TakeLastExample();
        takeLastExample.Sample1();

        var takeWhileExample = new TakeWhileExample();
        takeWhileExample.Sample1();
        takeWhileExample.Sample2();

        var thenByExample = new ThenByExample();
        thenByExample.Sample1();
        thenByExample.Sample2();

        var thenByDescendingExample = new ThenByDescendingExample();
        thenByDescendingExample.Sample1();
        thenByDescendingExample.Sample2();

        var toArray = new ToArrayExample();
        toArray.Sample1();

        var toDictionaryExample = new ToDictionaryExample();
        toDictionaryExample.Sample1();
        toDictionaryExample.Sample2();
        toDictionaryExample.Sample3();
        toDictionaryExample.Sample4();

    }
}