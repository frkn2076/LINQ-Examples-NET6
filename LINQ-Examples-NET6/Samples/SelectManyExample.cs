namespace LINQ_Examples_NET6.Samples;
class SelectManyExample
{
    public void Sample1()
    {
        var numbersOfNumbers = new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } };
        var result = numbersOfNumbers.SelectMany(x => x);
        //  result = IEnumerable<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }

    public void Sample2()
    {
        var numbersOfNumbers = new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } };
        var result = numbersOfNumbers.SelectMany((v, i) => v.Select(x => x * i));
        //  result = IEnumerable<int> { 0, 0, 0, 4, 5, 6, 14, 16, 18 };
    }

    public void Sample3()
    {
        var numbersOfNumbers = new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } };
        var result = numbersOfNumbers.SelectMany(x => x, (numbers, res) => res + numbers.Sum());
        //  result = IEnumerable<int> { 1 + (1+2+3), 2 + (1+2+3), 3 + (1+2+3), 4 + (4+5+6), 5 + (4+5+6), 6 + (4+5+6), 7 + (7+8+9), 8 + (7+8+9), 9 + (7+8+9) };
        //  result = IEnumerable<int> { 7, 8, 9, 19, 20, 21, 31, 32, 33 }
    }

    public void Sample4()
    {
        var numbersOfNumbers = new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } };
        var result = numbersOfNumbers.SelectMany((v, i) => v.Select(x => x * i), (numbers, res) => res + numbers.Sum());
        //  result = IEnumerable<int> { 1*0 + (1+2+3), 2*0 + (1+2+3), 3*0 + (1+2+3), 4*1 + (4+5+6), 5*1 + (4+5+6), 6*1 + (4+5+6), 7*2 + (7+8+9), 8*2 + (7+8+9), 9*2 + (7+8+9) };
        //  result = IEnumerable<int> { 6, 6, 6, 19, 20, 21, 38, 40, 42 }
    }
}