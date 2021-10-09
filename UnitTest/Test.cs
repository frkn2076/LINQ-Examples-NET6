using LINQ_Examples_NET6.Models;
using LINQ_Examples_NET6.Samples;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Aggregate_Sample1()
        {
            var sample = new AggregateExample();
            var actual = sample.Sample1();
            Assert.AreEqual(120, actual);
        }

        [Test]
        public void Aggregate_Sample2()
        {
            var sample = new AggregateExample();
            var actual = sample.Sample2();
            Assert.AreEqual(1200, actual);
        }

        [Test]
        public void Aggregate_Sample3()
        {
            var sample = new AggregateExample();
            var actual = sample.Sample3();
            Assert.AreEqual(600, actual);
        }

        [Test]
        public void All_Sample1()
        {
            var sample = new AllExample();
            var actual = sample.Sample1();
            Assert.IsTrue(actual);
        }

        [Test]
        public void Any_Sample1()
        {
            var sample = new AnyExample();
            var actual = sample.Sample1();
            Assert.IsTrue(actual);
        }

        [Test]
        public void Append_Sample1()
        {
            var sample = new AppendExample();
            var actual = sample.Sample1();
            var expected = new List<int> { 1, 2, 3, 4, 5, 10 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AsEnumerable_Sample1()
        {
            var sample = new AsEnumerableExample();
            var actual = sample.Sample1();
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Average_Sample1()
        {
            var sample = new AverageExample();
            var actual = sample.Sample1();
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Cast_Sample1()
        {
            var sample = new CastExample();
            var actual = sample.Sample1();
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Chunk_Sample1()
        {
            var sample = new ChunkExample();
            var actual = sample.Sample1();
            var expected = new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5 } };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Concat_Sample1()
        {
            var sample = new ConcatExample();
            var actual = sample.Sample1();
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Contains_Sample1()
        {
            var sample = new ContainsExample();
            var actual = sample.Sample1();
            Assert.IsTrue(actual);
        }

        [Test]
        public void Contains_Sample2()
        {
            var sample = new ContainsExample();
            var actual = sample.Sample2();
            Assert.IsTrue(actual);
        }

        [Test]
        public void Count_Sample1()
        {
            var sample = new CountExample();
            var actual = sample.Sample1();
            Assert.AreEqual(4, actual);
        }

        [Test]
        public void Count_Sample2()
        {
            var sample = new CountExample();
            var actual = sample.Sample2();
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void DefaultIfEmpty_Sample1()
        {
            var sample = new DefaultIfEmptyExample();
            var actual = sample.Sample1();
            var expected = new List<int> { 0 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DefaultIfEmpty_Sample2()
        {
            var sample = new DefaultIfEmptyExample();
            var actual = sample.Sample2();
            var expected = new List<int> { 5 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DistinctBy_Sample1()
        {
            var sample = new DistinctByExample();
            var actual = sample.Sample1();
            var expected = new List<Person> { new("Leonardo", "Dicaprio"), new("Tom", "Hanks") };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DistinctBy_Sample2()
        {
            var sample = new DistinctByExample();
            var actual = sample.Sample2();
            var expected = new List<Person> { new("Leonardo", "Dicaprio"), new("Tom", "Hanks") };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Distinct_Sample1()
        {
            var sample = new DistinctExample();
            var actual = sample.Sample1();
            var expected = new List<int> { 1, 2, 4, 5 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Distinct_Sample2()
        {
            var sample = new DistinctExample();
            var actual = sample.Sample2();
            var expected = new List<string> { "Red", "Blue", "Black" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ElementAt_Sample1()
        {
            var sample = new ElementAtExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Green", actual);
        }

        [Test]
        public void ElementAt_Sample2()
        {
            var sample = new ElementAtExample();
            var actual = sample.Sample2();
            Assert.AreEqual("Blue", actual);
        }

        [Test]
        public void ElementAtOrDefault_Sample1()
        {
            var sample = new ElementAtOrDefaultExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Green", actual);
        }

        [Test]
        public void ElementAtOrDefault_Sample2()
        {
            var sample = new ElementAtOrDefaultExample();
            var actual = sample.Sample2();
            Assert.IsNull(actual);
        }

        [Test]
        public void ElementAtOrDefault_Sample3()
        {
            var sample = new ElementAtOrDefaultExample();
            var actual = sample.Sample3();
            Assert.AreEqual("Blue", actual);
        }

        [Test]
        public void ElementAtOrDefault_Sample4()
        {
            var sample = new ElementAtOrDefaultExample();
            var actual = sample.Sample4();
            Assert.IsNull(actual);
        }

        [Test]
        public void Empty_Sample1()
        {
            var sample = new EmptyExample();
            var actual = sample.Sample1();
            var expected = Enumerable.Empty<int>();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExceptBy_Sample1()
        {
            var sample = new ExceptByExample();
            var actual = sample.Sample1();
            var expected = new List<Person>() { new("Leonardo", "Dicaprio"), new("TOM", "Sawyer") };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExceptBy_Sample2()
        {
            var sample = new ExceptByExample();
            var actual = sample.Sample2();
            var expected = new List<Person>() { new("Leonardo", "Dicaprio") };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Except_Sample1()
        {
            var sample = new ExceptExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Red", "Green" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Except_Sample2()
        {
            var sample = new ExceptExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Red", "Green" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void First_Sample1()
        {
            var sample = new FirstExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Red", actual);
        }

        [Test]
        public void First_Sample2()
        {
            var sample = new FirstExample();
            var actual = sample.Sample2();
            Assert.AreEqual("Green", actual);
        }

        [Test]
        public void First_Sample3()
        {
            var sample = new FirstExample();
            Assert.Throws<InvalidOperationException>(() => sample.Sample3());
        }

        [Test]
        public void FirstOrDefault_Sample1()
        {
            var sample = new FirstOrDefaultExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Red", actual);
        }

        [Test]
        public void FirstOrDefault_Sample2()
        {
            var sample = new FirstOrDefaultExample();
            var actual = sample.Sample2();
            Assert.IsNull(actual);
        }

        [Test]
        public void FirstOrDefault_Sample3()
        {
            var sample = new FirstOrDefaultExample();
            var actual = sample.Sample3();
            Assert.AreEqual("White", actual);
        }

        [Test]
        public void FirstOrDefault_Sample4()
        {
            var sample = new FirstOrDefaultExample();
            var actual = sample.Sample4();
            Assert.AreEqual("Green", actual);
        }

        [Test]
        public void FirstOrDefault_Sample5()
        {
            var sample = new FirstOrDefaultExample();
            var actual = sample.Sample5();
            Assert.IsNull(actual);
        }

        [Test]
        public void FirstOrDefault_Sample6()
        {
            var sample = new FirstOrDefaultExample();
            var actual = sample.Sample6();
            Assert.AreEqual("White", actual);
        }

        [Test]
        public void GroupBy_Sample1()
        {
            var sample = new GroupByExample();
            var actual = sample.Sample1();
            var actualAslist = actual.ToList();
            var expectedKey0 = new string[] { "Red" };
            var expectedKey1 = new string[] { "Green", "Black" };
            var expectedKey2 = new string[] { "Blue" };

            Assert.AreEqual(3, actualAslist[0].Key);
            Assert.AreEqual(expectedKey0, actualAslist[0]);
            Assert.AreEqual(5, actualAslist[1].Key);
            Assert.AreEqual(expectedKey1, actualAslist[1]);
            Assert.AreEqual(4, actualAslist[2].Key);
            Assert.AreEqual(expectedKey2, actualAslist[2]);
        }

        [Test]
        public void GroupBy_Sample2()
        {
            var sample = new GroupByExample();
            var actual = sample.Sample2();
            var actualAslist = actual.ToList();
            var expectedKey0 = new string[] { "R" };
            var expectedKey1 = new string[] { "G", "B" };
            var expectedKey2 = new string[] { "B" };

            Assert.AreEqual(3, actualAslist[0].Key);
            Assert.AreEqual(expectedKey0, actualAslist[0]);
            Assert.AreEqual(5, actualAslist[1].Key);
            Assert.AreEqual(expectedKey1, actualAslist[1]);
            Assert.AreEqual(4, actualAslist[2].Key);
            Assert.AreEqual(expectedKey2, actualAslist[2]);
        }

        [Test]
        public void GroupBy_Sample3()
        {
            var sample = new GroupByExample();
            var actual = sample.Sample3();
            var actualAslist = actual.ToList();
            var expectedKey0 = new string[] { "Red" };
            var expectedKey1 = new string[] { "Green" };
            var expectedKey2 = new string[] { "blue", "Black" };

            Assert.AreEqual("R", actualAslist[0].Key);
            Assert.AreEqual(expectedKey0, actualAslist[0]);
            Assert.AreEqual("G", actualAslist[1].Key);
            Assert.AreEqual(expectedKey1, actualAslist[1]);
            Assert.AreEqual("b", actualAslist[2].Key);
            Assert.AreEqual(expectedKey2, actualAslist[2]);
        }

        [Test]
        public void GroupBy_Sample4()
        {
            var sample = new GroupByExample();
            var actual = sample.Sample4();
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "R" };
            var expectedKey1 = new string[] { "G" };
            var expectedKey2 = new string[] { "b", "B" };

            Assert.AreEqual("R", actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.AreEqual("G", actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
            Assert.AreEqual("b", actualAsList[2].Key);
            Assert.AreEqual(expectedKey2, actualAsList[2]);
        }

        [Test]
        public void GroupJoin_Sample1()
        {
            var sample = new GroupJoinExample();
            var actual = sample.Sample1();
            var actualAsList = actual.ToList();
            var expectedKey0 = new List<string>() { "Daisy" };
            var expectedKey1 = new List<string>() { "Boots" };
            var expectedKey2 = new List<string>() { "Barley" };
            var expectedKey3 = new List<string>() { "Whiskers" };

            Assert.AreEqual("Magnus", actualAsList[0].Name);
            Assert.AreEqual(expectedKey0, actualAsList[0].Pets);
            Assert.AreEqual("Terry", actualAsList[1].Name);
            Assert.AreEqual(expectedKey1, actualAsList[1].Pets);
            Assert.AreEqual("terry", actualAsList[2].Name);
            Assert.AreEqual(expectedKey2, actualAsList[2].Pets);
            Assert.AreEqual("Charlotte", actualAsList[3].Name);
            Assert.AreEqual(expectedKey3, actualAsList[3].Pets);
        }

        [Test]
        public void GroupJoin_Sample2()
        {
            var sample = new GroupJoinExample();
            var actual = sample.Sample2();
            var actualAsList = actual.ToList();
            var expectedKey0 = new List<string>() { "Daisy" };
            var expectedKey1 = new List<string>() { "Barley", "Boots" };
            var expectedKey2 = new List<string>() { "Barley", "Boots" };
            var expectedKey3 = new List<string>() { "Whiskers" };

            Assert.AreEqual("Magnus", actualAsList[0].Name);
            Assert.AreEqual(expectedKey0, actualAsList[0].Pets);
            Assert.AreEqual("Terry", actualAsList[1].Name);
            Assert.AreEqual(expectedKey1, actualAsList[1].Pets);
            Assert.AreEqual("terry", actualAsList[2].Name);
            Assert.AreEqual(expectedKey2, actualAsList[2].Pets);
            Assert.AreEqual("Charlotte", actualAsList[3].Name);
            Assert.AreEqual(expectedKey3, actualAsList[3].Pets);
        }

        [Test]
        public void IntersectBy_Sample1()
        {
            var sample = new IntersectByExample();
            var actual = sample.Sample1();
            var expected = new List<string> { "Red" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IntersectBy_Sample2()
        {
            var sample = new IntersectByExample();
            var actual = sample.Sample2();
            var expected = new List<string> { "Red", "Blue" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Join_Sample1()
        {
            var sample = new JoinExample();
            var actual = sample.Sample1();
            var expected = new List<string> { "White" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Join_Sample2()
        {
            var sample = new JoinExample();
            var actual = sample.Sample2();
            var expected = new List<string> { "White", "Black" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Last_Sample1()
        {
            var sample = new LastExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Black", actual);
        }

        [Test]
        public void Last_Sample2()
        {
            var sample = new FirstOrDefaultExample();
            var actual = sample.Sample2();
            Assert.IsNull(actual);
        }

        [Test]
        public void LastOrDefault_Sample1()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Black", actual);
        }

        [Test]
        public void LastOrDefault_Sample2()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample2();
            Assert.IsNull(actual);
        }

        [Test]
        public void LastOrDefault_Sample3()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample3();
            Assert.AreEqual("Black", actual);
        }

        [Test]
        public void LastOrDefault_Sample4()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample4();
            Assert.AreEqual("White", actual);
        }

        [Test]
        public void LastOrDefault_Sample5()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample5();
            Assert.AreEqual("Blue", actual);
        }

        [Test]
        public void LastOrDefault_Sample6()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample6();
            Assert.IsNull(actual);
        }

        [Test]
        public void LastOrDefault_Sample7()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample7();
            Assert.AreEqual("Blue", actual);
        }

        [Test]
        public void LastOrDefault_Sample8()
        {
            var sample = new LastOrDefaultExample();
            var actual = sample.Sample8();
            Assert.AreEqual("White", actual);
        }

        [Test]
        public void LongCount_Sample1()
        {
            var sample = new LongCountExample();
            var actual = sample.Sample1();
            Assert.AreEqual(4, actual);
        }

        [Test]
        public void LongCount_Sample2()
        {
            var sample = new LongCountExample();
            var actual = sample.Sample2();
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void MaxBy_Sample1()
        {
            var sample = new MaxByExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Purple", actual);
        }

        [Test]
        public void MaxBy_Sample2()
        {
            var sample = new MaxByExample();
            var actual = sample.Sample2();
            Assert.AreEqual("pink", actual);
        }

        [Test]
        public void Max_Sample1()
        {
            var sample = new MaxExample();
            var actual = sample.Sample1();
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void Max_Sample2()
        {
            var sample = new MaxExample();
            var actual = sample.Sample2();
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void Max_Sample3()
        {
            var sample = new MaxExample();
            var actual = sample.Sample3();
            Assert.AreEqual("D1", actual);
        }

        [Test]
        public void Max_Sample4()
        {
            var sample = new MaxExample();
            var actual = sample.Sample4();
            Assert.AreEqual("d", actual);
        }

        [Test]
        public void MinBy_Sample1()
        {
            var sample = new MinByExample();
            var actual = sample.Sample1();
            Assert.AreEqual("Red", actual);
        }

        [Test]
        public void MinBy_Sample2()
        {
            var sample = new MinByExample();
            var actual = sample.Sample2();
            Assert.AreEqual("Blue", actual);
        }

        [Test]
        public void Min_Sample1()
        {
            var sample = new MinExample();
            var actual = sample.Sample1();
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Min_Sample2()
        {
            var sample = new MinExample();
            var actual = sample.Sample2();
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Min_Sample3()
        {
            var sample = new MinExample();
            var actual = sample.Sample3();
            Assert.AreEqual("a1", actual);
        }

        [Test]
        public void Min_Sample4()
        {
            var sample = new MinExample();
            var actual = sample.Sample4();
            Assert.AreEqual("A", actual);
        }

        [Test]
        public void OfType_Sample1()
        {
            var sample = new OfTypeExample();
            var actual = sample.Sample1();
            var expected = new List<string> { "White", "George" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrderByDescending_Sample1()
        {
            var sample = new OrderByDescendingExample();
            var actual = sample.Sample1();
            var expected = new List<Pet>() {
                new Pet("Whiskers", "Charlotte"),
                new Pet("Daisy", "Magnus"),
                new Pet("Boots", "Terry"),
                new Pet("Barley", "Terry")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrderByDescending_Sample2()
        {
            var sample = new OrderByDescendingExample();
            var actual = sample.Sample2();
            var expected = new List<Pet>() {
                new Pet("Whiskers", "Charlotte"),
                new Pet("Barley", "Terry"),
                new Pet("Boots", "Terry"),
                new Pet("Daisy", "Magnus")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrderBy_Sample1()
        {
            var sample = new OrderByExample();
            var actual = sample.Sample1();
            var expected = new List<Pet>() {
                new Pet("Barley", "Terry"),
                new Pet("Boots", "Terry"),
                new Pet("Daisy", "Magnus"),
                new Pet("Whiskers", "Charlotte")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrderBy_Sample2()
        {
            var sample = new OrderByExample();
            var actual = sample.Sample2();
            var expected = new List<Pet>() {
                new Pet("Boots", "Terry"),
                new Pet("Daisy", "Magnus"),
                new Pet("Barley", "Terry"),
                new Pet("Whiskers", "Charlotte")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Prepend_Sample1()
        {
            var sample = new PrependExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "White", "Red", "Green", "Blue", "Black" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Range_Sample1()
        {
            var sample = new RangeExample();
            var actual = sample.Sample1();
            var expected = new List<int>() { 2, 3, 4, 5, 6 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Repeat_Sample1()
        {
            var sample = new RepeatExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { ".Net", ".Net", ".Net", ".Net" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Reverse_Sample1()
        {
            var sample = new ReverseExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Black", "Blue", "Green", "Red" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Select_Sample1()
        {
            var sample = new SelectExample();
            var actual = sample.Sample1();
            var expected = new List<int>() { 3, 5, 4, 5 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Select_Sample2()
        {
            var sample = new SelectExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Red-0", "Green-1", "Blue-2", "Black-3" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SelectMany_Sample1()
        {
            var sample = new SelectManyExample();
            var actual = sample.Sample1();
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SelectMany_Sample2()
        {
            var sample = new SelectManyExample();
            var actual = sample.Sample2();
            var expected = new List<int>() { 0, 0, 0, 4, 5, 6, 14, 16, 18 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SelectMany_Sample3()
        {
            var sample = new SelectManyExample();
            var actual = sample.Sample3();
            var expected = new List<int>() { 7, 8, 9, 19, 20, 21, 31, 32, 33 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SelectMany_Sample4()
        {
            var sample = new SelectManyExample();
            var actual = sample.Sample4();
            var expected = new List<int>() { 6, 6, 6, 19, 20, 21, 38, 40, 42 };
            Assert.AreEqual(expected, actual);
        }
    }
}