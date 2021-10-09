using Newtonsoft.Json;

namespace UnitTest
{
    internal static class Helper
    {
        internal static bool DeepEqual(object? expected, object? actual)
        {
            if (expected is null ^ actual is null)
                return false;

            if (expected is null)
                return true;

            var aJSON = JsonConvert.SerializeObject(expected);
            var bJSON = JsonConvert.SerializeObject(actual);
            return aJSON.Equals(bJSON);
        }
    }
}
