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
            var expected = new List<Person> 
            { 
                new("Leonardo", "Dicaprio"),
                new("Tom", "Hanks")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DistinctBy_Sample2()
        {
            var sample = new DistinctByExample();
            var actual = sample.Sample2();
            var expected = new List<Person> 
            { 
                new("Leonardo", "Dicaprio"),
                new("Tom", "Hanks")
            };
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
            var expected = new List<Person>() 
            { 
                new("Leonardo", "Dicaprio"),
                new("TOM", "Sawyer")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExceptBy_Sample2()
        {
            var sample = new ExceptByExample();
            var actual = sample.Sample2();
            var expected = new List<Person>() 
            { 
                new("Leonardo", "Dicaprio")
            };
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
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "Red" };
            var expectedKey1 = new string[] { "Green", "Black" };
            var expectedKey2 = new string[] { "Blue" };

            Assert.AreEqual(3, actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.AreEqual(5, actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
            Assert.AreEqual(4, actualAsList[2].Key);
            Assert.AreEqual(expectedKey2, actualAsList[2]);
        }

        [Test]
        public void GroupBy_Sample2()
        {
            var sample = new GroupByExample();
            var actual = sample.Sample2();
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "R" };
            var expectedKey1 = new string[] { "G", "B" };
            var expectedKey2 = new string[] { "B" };

            Assert.AreEqual(3, actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.AreEqual(5, actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
            Assert.AreEqual(4, actualAsList[2].Key);
            Assert.AreEqual(expectedKey2, actualAsList[2]);
        }

        [Test]
        public void GroupBy_Sample3()
        {
            var sample = new GroupByExample();
            var actual = sample.Sample3();
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "Red" };
            var expectedKey1 = new string[] { "Green" };
            var expectedKey2 = new string[] { "blue", "Black" };

            Assert.AreEqual("R", actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.AreEqual("G", actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
            Assert.AreEqual("b", actualAsList[2].Key);
            Assert.AreEqual(expectedKey2, actualAsList[2]);
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
                new("Whiskers", "Charlotte"),
                new("Daisy", "Magnus"),
                new("Boots", "Terry"),
                new("Barley", "Terry")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrderByDescending_Sample2()
        {
            var sample = new OrderByDescendingExample();
            var actual = sample.Sample2();
            var expected = new List<Pet>() {
                new("Whiskers", "Charlotte"),
                new("Barley", "Terry"),
                new("Boots", "Terry"),
                new("Daisy", "Magnus")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrderBy_Sample1()
        {
            var sample = new OrderByExample();
            var actual = sample.Sample1();
            var expected = new List<Pet>() {
                new("Barley", "Terry"),
                new("Boots", "Terry"),
                new("Daisy", "Magnus"),
                new("Whiskers", "Charlotte")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OrderBy_Sample2()
        {
            var sample = new OrderByExample();
            var actual = sample.Sample2();
            var expected = new List<Pet>() {
                new("Boots", "Terry"),
                new("Daisy", "Magnus"),
                new("Barley", "Terry"),
                new("Whiskers", "Charlotte")
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

        [Test]
        public void SequenceEqual_Sample1()
        {
            var sample = new SequenceEqualExample();
            var actual = sample.Sample1();
            Assert.IsTrue(actual);
        }

        [Test]
        public void SequenceEqual_Sample2()
        {
            var sample = new SequenceEqualExample();
            var actual = sample.Sample2();
            Assert.IsFalse(actual);
        }

        [Test]
        public void SequenceEqual_Sample3()
        {
            var sample = new SequenceEqualExample();
            var actual = sample.Sample3();
            Assert.IsTrue(actual);
        }

        [Test]
        public void Single_Sample1()
        {
            var sample = new SingleExample();
            Assert.Throws<InvalidOperationException>(() => sample.Sample1());
        }

        [Test]
        public void Single_Sample2()
        {
            var sample = new SingleExample();
            Assert.Throws<InvalidOperationException>(() => sample.Sample2());
        }

        [Test]
        public void Single_Sample3()
        {
            var sample = new SingleExample();
            var actual = sample.Sample3();
            Assert.AreEqual("Blue", actual);
        }

        [Test]
        public void Single_Sample4()
        {
            var sample = new SingleExample();
            Assert.Throws<InvalidOperationException>(() => sample.Sample4());
        }

        [Test]
        public void Single_Sample5()
        {
            var sample = new SingleExample();
            Assert.Throws<InvalidOperationException>(() => sample.Sample5());
        }

        [Test]
        public void Single_Sample6()
        {
            var sample = new SingleExample();
            var actual = sample.Sample6();
            Assert.AreEqual("Red", actual);
        }

        [Test]
        public void SingleOrDefault_Sample1()
        {
            var sample = new SingleOrDefaultExample();
            Assert.Throws<InvalidOperationException>(() => sample.Sample1());
        }

        [Test]
        public void SingleOrDefault_Sample2()
        {
            var sample = new SingleOrDefaultExample();
            var actual = sample.Sample2();
            Assert.IsNull(actual);
        }

        [Test]
        public void SingleOrDefault_Sample3()
        {
            var sample = new SingleOrDefaultExample();
            var actual = sample.Sample3();
            Assert.AreEqual("Blue", actual);
        }

        [Test]
        public void SingleOrDefault_Sample4()
        {
            var sample = new SingleOrDefaultExample();
            Assert.Throws<InvalidOperationException>(() => sample.Sample4());
        }

        [Test]
        public void SingleOrDefault_Sample5()
        {
            var sample = new SingleOrDefaultExample();
            var actual = sample.Sample5();
            Assert.IsNull(actual);
        }

        [Test]
        public void SingleOrDefault_Sample6()
        {
            var sample = new SingleOrDefaultExample();
            var actual = sample.Sample6();
            Assert.AreEqual("Red", actual);
        }


        [Test]
        public void Skip_Sample1()
        {
            var sample = new SkipExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Blue", "Black", "White" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void SkipLast_Sample6()
        {
            var sample = new SkipLastExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Red", "Green", "Blue" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void SkipWhile_Sample1()
        {
            var sample = new SkipWhileExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Green", "Blue", "Black", "White" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void SkipWhile_Sample2()
        {
            var sample = new SkipWhileExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Blue", "Black", "White" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Sum_Sample1()
        {
            var sample = new SumExample();
            var actual = sample.Sample1();
            Assert.AreEqual(15, actual);
        }


        [Test]
        public void Sum_Sample2()
        {
            var sample = new SumExample();
            var actual = sample.Sample2();
            Assert.AreEqual(20, actual);
        }


        [Test]
        public void Take_Sample1()
        {
            var sample = new TakeExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Red", "Green" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Take_Sample2()
        {
            var sample = new TakeExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Green", "Blue", "Black" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TakeLast_Sample1()
        {
            var sample = new TakeLastExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Black", "White" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TakeWhile_Sample1()
        {
            var sample = new TakeWhileExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Green", "Blue" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TakeWhile_Sample2()
        {
            var sample = new TakeWhileExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Red", "Green", "Blue" };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ThenByDescending_Sample1()
        {
            var sample = new ThenByDescendingExample();
            var actual = sample.Sample1();
            var expected = new List<Person>() 
            {
                new("Leonardo", "Dicaprio"),
                new("Tom", "Sawyer"),
                new("Tom", "Hiddlestone"),
                new("Tom", "Hanks")
            };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ThenByDescending_Sample2()
        {
            var sample = new ThenByDescendingExample();
            var actual = sample.Sample2();
            var expected = new List<Person>()
            {
                new("Leonardo", "Dicaprio"),
                new("Tom", "Hiddlestone"),
                new("Tom", "Sawyer"),
                new("Tom", "Hanks")
            };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ThenBy_Sample1()
        {
            var sample = new ThenByExample();
            var actual = sample.Sample1();
            var expected = new List<Person>()
            {
                new("Leonardo", "Dicaprio"),
                new("Tom", "Hanks"),
                new("Tom", "Hiddlestone"),
                new("Tom", "Sawyer")
            };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ThenBy_Sample2()
        {
            var sample = new ThenByExample();
            var actual = sample.Sample2();
            var expected = new List<Person>()
            {
                new("Leonardo", "Dicaprio"),
                new("Tom", "Hanks"),
                new("Tom", "Sawyer"),
                new("Tom", "Hiddlestone")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToArray_Sample1()
        {
            var sample = new ToArrayExample();
            var actual = sample.Sample1();
            var expected = new string[] { "Red", "Green", "Blue", "Black" };
            Assert.IsInstanceOf<string[]>(expected);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToDictionary_Sample1()
        {
            var sample = new ToDictionaryExample();
            var actual = sample.Sample1();
            var expected = new Dictionary<string, string>()
            {
                { "Red", "Red" },
                { "Gre", "Green" },
                { "Blu", "Blue" },
                { "Bla", "Black" },
                { "red", "red" }
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToDictionary_Sample2()
        {
            var sample = new ToDictionaryExample();
            Assert.Throws<ArgumentException>(() => sample.Sample2());
        }

        [Test]
        public void ToDictionary_Sample3()
        {
            var sample = new ToDictionaryExample();
            var actual = sample.Sample3();
            var expected = new Dictionary<string, int>()
            {
                { "Red", 3 },
                { "Green", 5 },
                { "Blue", 4 },
                { "Black", 5 },
                { "red", 3 }
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToDictionary_Sample4()
        {
            var sample = new ToDictionaryExample();
            Assert.Throws<ArgumentException>(() => sample.Sample4());
        }

        [Test]
        public void ToHashSet_Sample1()
        {
            var sample = new ToHashSetExample();
            var actual = sample.Sample1();
            var expected = new HashSet<string> { "Red", "Green", "Blue", "Black", "red" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToHashSet_Sample2()
        {
            var sample = new ToHashSetExample();
            var actual = sample.Sample2();
            var expected = new HashSet<string> { "Red", "Green", "Blue", "Black" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToList_Sample1()
        {
            var sample = new ToListExample();
            var actual = sample.Sample1();
            var expected = new List<string> { "Red", "Green", "Blue", "Black" };
            Assert.IsInstanceOf<List<string>>(expected);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToLookup_Sample1()
        {
            var sample = new ToLookupExample();
            var actual = sample.Sample1();
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "Red", "Blue" };
            var expectedKey1 = new string[] { "Green", "Black" };

            Assert.IsFalse(actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.IsTrue(actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
        }

        [Test]
        public void ToLookup_Sample2()
        {
            var sample = new ToLookupExample();
            var actual = sample.Sample2();
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "Red", "red" };
            var expectedKey1 = new string[] { "Green" };
            var expectedKey2 = new string[] { "Blue", "Black" };

            Assert.AreEqual("R", actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.AreEqual("G", actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
            Assert.AreEqual("B", actualAsList[2].Key);
            Assert.AreEqual(expectedKey2, actualAsList[2]);
        }

        [Test]
        public void ToLookup_Sample3()
        {
            var sample = new ToLookupExample();
            var actual = sample.Sample3();
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "Red", "Blu" };
            var expectedKey1 = new string[] { "Gre", "Bla" };

            Assert.IsFalse(actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.IsTrue(actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
        }

        [Test]
        public void ToLookup_Sample4()
        {
            var sample = new ToLookupExample();
            var actual = sample.Sample4();
            var actualAsList = actual.ToList();
            var expectedKey0 = new string[] { "Red", "red" };
            var expectedKey1 = new string[] { "Gre" };
            var expectedKey2 = new string[] { "Blu", "Bla" };

            Assert.AreEqual("R", actualAsList[0].Key);
            Assert.AreEqual(expectedKey0, actualAsList[0]);
            Assert.AreEqual("G", actualAsList[1].Key);
            Assert.AreEqual(expectedKey1, actualAsList[1]);
            Assert.AreEqual("B", actualAsList[2].Key);
            Assert.AreEqual(expectedKey2, actualAsList[2]);
        }

        [Test]
        public void TryGetNonEnumeratedCount_Sample1()
        {
            var sample = new TryGetNonEnumeratedCountExample();
            var actual = sample.Sample1();
            Assert.IsTrue(actual.Item1);
            Assert.AreEqual(4, actual.Item2);
        }

        [Test]
        public void TryGetNonEnumeratedCount_Sample2()
        {
            var sample = new TryGetNonEnumeratedCountExample();
            var actual = sample.Sample2();
            Assert.IsFalse(actual.Item1);
            Assert.Zero(actual.Item2);
        }

        [Test]
        public void UnionBy_Sample1()
        {
            var sample = new UnionByExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Red", "Green", "Blue", "Purple", "White", "blue" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UnionBy_Sample2()
        {
            var sample = new UnionByExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Red", "Green", "Blue", "Purple", "White" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Union_Sample1()
        {
            var sample = new UnionExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Red", "Green", "Blue", "Black", "Purple", "White", "blue" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Union_Sample2()
        {
            var sample = new UnionExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Red", "Green", "Blue", "Black", "Purple", "White" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Where_Sample1()
        {
            var sample = new WhereExample();
            var actual = sample.Sample1();
            var expected = new List<string>() { "Green", "Black" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Where_Sample2()
        {
            var sample = new WhereExample();
            var actual = sample.Sample2();
            var expected = new List<string>() { "Red", "Green" };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_Sample1()
        {
            var sample = new ZipExample();
            var actual = sample.Sample1();
            var expected = new List<(string, string)>()
            {
                ("Red", "Purple"),
                ("Green", "White"),
                ("Blue", "Blue"),
                ("Black", "Red")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_Sample2()
        {
            var sample = new ZipExample();
            var actual = sample.Sample2();
            var expected = new List<(string, string, string)>()
            {
                ("Red", "Purple", "Yellow"),
                ("Green", "White", "Brown"),
                ("Blue", "Blue", "White"),
                ("Black", "Red", "Gray")
            };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Zip_Sample3()
        {
            var sample = new ZipExample();
            var actual = sample.Sample3();
            var expected = new List<string>()
            {
                "Red:Purple",
                "Green:White",
                "Blue:Blue", "Black:Red"
            };
            Assert.AreEqual(expected, actual);
        }
    }
}