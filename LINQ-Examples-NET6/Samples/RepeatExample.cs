namespace LINQ_Examples_NET6.Samples
{
    class RepeatExample
    {
        public void Sample1()
        {
            var result = Enumerable.Repeat(".Net", 4);
            //  result = IEnumerable<string> { ".Net", ".Net", ".Net", ".Net" }
        }
    }
}
