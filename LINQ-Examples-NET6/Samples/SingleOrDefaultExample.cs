namespace LINQ_Examples_NET6.Samples
{
    class SingleOrDefaultExample
    {
        public void Sample1()
        {
            var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
            try
            {
                var result1 = colors1.SingleOrDefault();
            }
            catch (Exception)
            {
                // ex = "Sequence contains more than one element"
            }

            var colors2 = new List<string>();
            var result2 = colors2.SingleOrDefault();
            //  result2 = null

            var colors3 = new List<string>() { "Blue" };
            var result3 = colors3.SingleOrDefault();
            //  result3 = "Blue"
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            try
            {
                var result1 = colors.SingleOrDefault(x => x.Length > 3);
            }
            catch (Exception)
            {
                // ex = "Sequence contains more than one element"
            }

            var result2 = colors.SingleOrDefault(x => x.Length > 7);
            // result2 = null 

            var result3 = colors.SingleOrDefault(x => x.Length == 3);
            //  result3 = "Red"
        }
    }
}
