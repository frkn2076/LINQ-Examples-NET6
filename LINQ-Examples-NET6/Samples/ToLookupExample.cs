namespace LINQ_Examples_NET6.Samples
{
    internal class ToLookupExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ToLookup(x => x.Length > 4);
            //  result = ILookup<bool, string> [ { Key: false, Items: [ "Red", "Blue" ] }, { Key: true, Items: [ "Green", "Black" ] } ]
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
            var result = colors.ToLookup(x => x.Substring(0,1), StringComparer.OrdinalIgnoreCase);
            //  result = ILookup<bool, string> [ { Key: "R", Items: [ "Red", "red" ] }, { Key: "G", Items: [ "Green" ] }, { Key: "B", Items: [ "Blue", "Black" ] } ]
        }

        public void Sample3()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ToLookup(x => x.Length > 4, res => res.Substring(0,3));
            //  result = ILookup<bool, string> [ { Key: false, Items: [ "Red", "Blu" ] }, { Key: true, Items: [ "Gre", "Bla" ] } ]
        }

        public void Sample4()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
            var result = colors.ToLookup(x => x.Substring(0, 1), res => res.Substring(0,3), StringComparer.OrdinalIgnoreCase);
            //  result = ILookup<bool, string> [ { Key: "R", Items: [ "Red", "red" ] }, { Key: "G", Items: [ "Gre" ] }, { Key: "B", Items: [ "Blu", "Bla" ] } ]
        }
    }
}
