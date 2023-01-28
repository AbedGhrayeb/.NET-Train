namespace BinarySearch
{
    public static class HelperMethods
    {
        public static IEnumerable<int> GenerateRandomIntArray(int length)
        {
            var random = new Random();
            for (int i = 0; i < length; i++)
                yield return random.Next();
        }
    }
}
